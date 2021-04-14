USE [cs6232-g1];
GO
CREATE PROCEDURE getMostPerformedTestsDuringDates @StartDate DATE, @EndDate DATE
AS
SET NOCOUNT ON;
        DECLARE @AllTestsCount INT;
        
		/* IF (@StartDate IS NULL OR @EndDate IS NULL)
		BEGIN
			THROW 51000, 'You must specify a @StartDate and @EndDate.', 1; 
		END
		IF (@StartDate > @EndDate)
		BEGIN
			THROW 51000, '@EndDate must be greater or equal than @StartDate.', 1; 
		END */
        
		SELECT @AllTestsCount = COUNT(lab_test_code)
        FROM LabTestResults
		WHERE date_performed BETWEEN @StartDate AND @EndDate;
        
		SELECT 
			t.lab_test_code,
			t.name,
			COUNT(t.lab_test_code) AS tests_count,
            @AllTestsCount,
            COUNT(t.lab_test_code) / @AllTestsCount AS test_count_percentage,
            getLabTestResultTypeCount(r.lab_test_code, 'normal') AS normal_results_count,
            getLabTestResultTypeCount(r.lab_test_code, 'abnormal') AS abnormal_results_count,
            getLabTestCountByPatientAgeRange(r.lab_test_code, 18, 29) / COUNT(t.lab_test_code) AS tests_on_18_29_pecent,
            getLabTestCountByPatientAgeRange(r.lab_test_code, 30, 39) / COUNT(t.lab_test_code) AS tests_on_30_39_pecent
        FROM LabTestResults r
			INNER JOIN LabTests t ON (t.lab_test_code = r.lab_test_code)
		WHERE r.date_performed BETWEEN @StartDate AND @EndDate
		GROUP BY t.lab_test_code, t.name
        HAVING COUNT(t.lab_test_code) > 1
        ORDER BY tests_count DESC, t.lab_test_code DESC;
        
GO