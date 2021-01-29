USE CLINIC;
DROP PROCEDURE IF EXISTS getMostPerformedTestsDuringSpecifiedTime;
DELIMITER $
CREATE PROCEDURE getMostPerformedTestsDuringSpecifiedTime 
	(IN startdate_param DATE, IN enddate_param DATE)

BEGIN

DECLARE total_tests_for_range INT;
SELECT 
	COUNT(*) 
FROM 
	Patient_Visit_has_Lab_Tests 
WHERE 
	test_date >= startdate_param AND 
	test_date <= enddate_param into total_tests_for_range;
    
SELECT 
	Lab_Tests_test_code AS 'Test Code', 
	test_type AS 'Test Name', 
	COUNT(*) AS 'Qualified Tests Performed At Least Twice', 
    total_tests_for_range AS 'Total Tests Performed In Date Range',
    CONCAT((ROUND((COUNT(*) / total_tests_for_range * 100), 1)), '%') AS 'Percentage of Qualified Tests of Total Tests in Range', 
    SUM(CASE WHEN test_result = 'normal' THEN 1 ELSE 0 END) AS 'Normal Results of Qualified Tests', 
    SUM(CASE WHEN test_result = 'abnormal' THEN 1 ELSE 0 END) AS 'Abnormal Results of Qualified Tests',
    CONCAT((ROUND((SUM(CASE WHEN TIMESTAMPDIFF(YEAR, dob, test_date) >= 18 AND 
		TIMESTAMPDIFF(YEAR, dob, test_date) <=29 THEN 1 ELSE 0 END) / COUNT(*) * 100), 1)), '%') AS 
		'Percentage of Those 18-29 Years Accounting for Qualified Tests', 
    CONCAT((ROUND((SUM(CASE WHEN TIMESTAMPDIFF(YEAR, dob, test_date) >= 30 AND 
		TIMESTAMPDIFF(YEAR, dob, test_date) <=39 THEN 1 ELSE 0 END) / COUNT(*) * 100), 1)), '%') AS 
		'Percentage of Those 30-39 Years Accounting for Qualified Tests'
FROM 
	Patient_Visit_has_Lab_Tests,
	Lab_Tests,
    Patient_Visit,
    Appointment,
    Clinic_Person
WHERE 
	Lab_Tests_test_code = test_code AND
	Patient_visit_Appointment_ID = Appointment_ID AND
    Appointment_ID = Appointment.ID AND
    Patient_Clinic_Person_ID = Clinic_Person.ID AND
	test_date >= startdate_param AND 
	test_date <= enddate_param
GROUP BY 
	test_code
HAVING 
	count(*) >= 2
ORDER BY 
	count(*) DESC, test_code DESC;	

END $
DELIMITER ;


CALL getMostPerformedTestsDuringSpecifiedTime("2020-10-27", "2020-10-27");
