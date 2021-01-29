USE clinic_management;
DROP PROCEDURE IF EXISTS getMostPerformedTestsDuringDates;
DROP FUNCTION IF EXISTS getLabTestResultTypeCount;
DROP FUNCTION IF EXISTS getLabTestCountByPatientAgeRange;
DELIMITER $

CREATE FUNCTION getLabTestResultTypeCount(lab_test_code_param VARCHAR(25), result_type VARCHAR(45))
RETURNS INT
READS SQL DATA
BEGIN
		DECLARE lab_test_count INT;

		IF  lab_test_code_param IS NULL OR result_type IS NULL  THEN
			SIGNAL SQLSTATE 'HY000'
			SET MESSAGE_TEXT = 'You must specify both the lab_test_code_param and the result_type.', MYSQL_ERRNO = 1108;
		END IF;
        
		SELECT COUNT(*) INTO lab_test_count
		FROM lab_test_results 
		WHERE lab_test_code = lab_test_code_param
		AND result = result_type;
                
		RETURN lab_test_count;
END$

CREATE FUNCTION getLabTestCountByPatientAgeRange(lab_test_code_param VARCHAR(25), start_age INT, end_age INT)
RETURNS INT
READS SQL DATA
BEGIN
		DECLARE lab_test_count INT;
        
		IF  lab_test_code_param IS NULL OR start_age IS NULL OR end_age IS NULL  THEN
			SIGNAL SQLSTATE 'HY000'
			SET MESSAGE_TEXT = 'You must specify the lab_test_code_param, start_age, and end_age.', MYSQL_ERRNO = 1108;
		END IF;
		IF start_age > end_age THEN
			SIGNAL SQLSTATE 'HY000'
			SET MESSAGE_TEXT = 'end_age must be greater or equal than start_age.', MYSQL_ERRNO = 1108;
		END IF;
        
		SELECT COUNT(lab_test_code) INTO lab_test_count
		FROM lab_test_results
			INNER JOIN patients USING (patient_id)
			INNER JOIN personal_information USING (personal_information_id)
		WHERE lab_test_code = lab_test_code_param
		AND TRUNCATE(DATEDIFF(lab_test_date, personal_information.date_of_birth) / 365.25, 0) BETWEEN start_age AND end_age;
                
		RETURN lab_test_count;
END$

CREATE PROCEDURE getMostPerformedTestsDuringDates(IN startdate DATE, IN endate DATE)
BEGIN
        DECLARE all_tests_count INT;
        
		IF startdate IS NULL OR endate IS NULL  THEN
			SIGNAL SQLSTATE 'HY000'
			SET MESSAGE_TEXT = 'You must specify a startdate and endate.', MYSQL_ERRNO = 1108;
		END IF;
		IF startdate > endate THEN
			SIGNAL SQLSTATE 'HY000'
			SET MESSAGE_TEXT = 'endate must be greater or equal than startdate.', MYSQL_ERRNO = 1108;
		END IF;
        
		SELECT COUNT(lab_test_code) INTO all_tests_count
        FROM lab_test_results
		WHERE lab_test_date BETWEEN startdate AND endate;
        
		SELECT 
			t.lab_test_code,
			t.name,
			COUNT(t.lab_test_code) AS tests_count,
            all_tests_count,
            COUNT(t.lab_test_code) / all_tests_count AS test_count_percentage,
            getLabTestResultTypeCount(r.lab_test_code, 'normal') AS normal_results_count,
            getLabTestResultTypeCount(r.lab_test_code, 'abnormal') AS abnormal_results_count,
            getLabTestCountByPatientAgeRange(r.lab_test_code, 18, 29) / COUNT(t.lab_test_code) AS tests_on_18_29_pecent,
            getLabTestCountByPatientAgeRange(r.lab_test_code, 30, 39) / COUNT(t.lab_test_code) AS tests_on_30_39_pecent
        FROM lab_test_results r
			INNER JOIN lab_tests t USING (lab_test_code)
		WHERE r.lab_test_date BETWEEN startdate AND endate
		GROUP BY t.lab_test_code, t.name
        HAVING tests_count > 1
        ORDER BY tests_count DESC, t.lab_test_code DESC;
        
END$
DELIMITER ;