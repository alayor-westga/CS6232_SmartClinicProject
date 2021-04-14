USE [cs6232-g1];
DROP PROCEDURE IF EXISTS getMostPerformedTestsDuringDates;
DROP FUNCTION IF EXISTS getLabTestResultTypeCount;
DROP FUNCTION IF EXISTS getLabTestCountByPatientAgeRange;
GO
CREATE FUNCTION getLabTestResultTypeCount(@LabTestCodeParam VARCHAR(45), @IsNormal BIT)
RETURNS INT
BEGIN
    DECLARE @LabTestCount INT;

    IF  @LabTestCodeParam IS NULL OR @IsNormal IS NULL
        -- Adding this hack as throwing errors is not allowed in functions.
        RETURN CAST('You must specify both the @LabTestCodeParam and the @IsNormal.' AS INT);
    
    SELECT @LabTestCount = COUNT(*)
    FROM LabTestResults 
    WHERE lab_test_code = @LabTestCodeParam
    AND is_normal = @IsNormal;
            
    RETURN @LabTestCount;
END
GO
CREATE FUNCTION getLabTestCountByPatientAgeRange(@LabTestCodeParam VARCHAR(45), @StartAge INT, @EndAge INT, @InsideRange BIT)
RETURNS INT
AS
BEGIN
    DECLARE @LabTestCount INT;
    
    IF  @LabTestCodeParam IS NULL OR @StartAge IS NULL OR @EndAge IS NULL
        RETURN CAST('You must specify the @LabTestCodeParam, @StartAge, and @EndAge.' AS INT);

    IF  @StartAge > @EndAge 
        RETURN CAST('@EndAge must be greater or equal than @StartAge.' AS INT);
    
    SELECT @LabTestCount = COUNT(r.lab_test_code)
    FROM LabTestResults r
        INNER JOIN Appointments a ON (a.appointment_id = r.appointment_id)
        INNER JOIN Patients p ON (p.patient_id = a.patient_id)
        INNER JOIN ClinicPersons c ON (p.clinic_person_id = c.clinic_person_id)
    WHERE lab_test_code = @LabTestCodeParam
    AND (@InsideRange = 1 AND CAST(DATEDIFF(DAY, c.date_of_birth, r.date_performed) / 365.25 AS INT) BETWEEN @StartAge AND @EndAge
        OR @InsideRange = 0 AND CAST(DATEDIFF(DAY, c.date_of_birth, r.date_performed) / 365.25 AS INT) NOT BETWEEN @StartAge AND @EndAge);
            
    RETURN @LabTestCount;
END
GO
CREATE PROCEDURE getMostPerformedTestsDuringDates @StartDate DATE, @EndDate DATE
AS
SET NOCOUNT ON;
    DECLARE @AllTestsCount INT;

    IF  @StartDate IS NULL OR @EndDate IS NULL
        THROW 70001, 'You must specify a @StartDate and @EndDate.', 1;

    IF  @StartDate > @EndDate 
        THROW 70001, '@EndDate must be greater or equal than @StartDate.', 1;
    
    SELECT @AllTestsCount = COUNT(lab_test_code)
    FROM LabTestResults
    WHERE date_performed BETWEEN @StartDate AND @EndDate;
    
    SELECT 
        t.lab_test_code,
        t.name,
        COUNT(t.lab_test_code) AS tests_count,
        @AllTestsCount as all_tests_count,
        FORMAT(CAST(COUNT(t.lab_test_code) AS DECIMAL) / @AllTestsCount, 'P') AS test_count_percentage,
        [dbo].getLabTestResultTypeCount(t.lab_test_code, 1) AS normal_results_count,
        [dbo].getLabTestResultTypeCount(t.lab_test_code, 0) AS abnormal_results_count,
        FORMAT([dbo].getLabTestCountByPatientAgeRange(t.lab_test_code, 18, 29, 1) / CAST(COUNT(t.lab_test_code) AS DECIMAL), 'P') AS tests_on_18_29_percent,
        FORMAT([dbo].getLabTestCountByPatientAgeRange(t.lab_test_code, 30, 39, 1) / CAST(COUNT(t.lab_test_code) AS DECIMAL), 'P') AS tests_on_30_39_percent,
        FORMAT([dbo].getLabTestCountByPatientAgeRange(t.lab_test_code, 18, 39, 0) / CAST(COUNT(t.lab_test_code) AS DECIMAL), 'P') AS tests_on_not_18_39_percent
    FROM LabTestResults r
        INNER JOIN LabTests t ON (t.lab_test_code = r.lab_test_code)
    WHERE r.date_performed BETWEEN @StartDate AND @EndDate
    GROUP BY t.lab_test_code, t.name
    HAVING COUNT(t.lab_test_code) > 1
    ORDER BY tests_count DESC, t.lab_test_code DESC;
GO