-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Clinic
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Clinic
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Clinic` DEFAULT CHARACTER SET utf8 ;
USE `Clinic` ;

-- -----------------------------------------------------
-- Table `Clinic`.`Clinic_Person`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Clinic_Person` (
  `ID` INT(6) NOT NULL,
  `lname` VARCHAR(45) NOT NULL,
  `fname` VARCHAR(45) NOT NULL,
  `dob` DATE NOT NULL,
  `ssn` CHAR(11) NULL,
  `gender` VARCHAR(6) NOT NULL,
  `address1` VARCHAR(45) NOT NULL,
  `address2` VARCHAR(45) NULL,
  `city` VARCHAR(45) NOT NULL,
  `state` CHAR(2) NOT NULL,
  `zip` VARCHAR(10) NOT NULL,
  `phone` CHAR(12) NOT NULL,
  UNIQUE INDEX `ssn_UNIQUE` (`ssn` ASC) VISIBLE,
  PRIMARY KEY (`ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Clinic`.`Patient`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Patient` (
  `Clinic_Person_ID` INT(6) NOT NULL,
  `ID` CHAR(6) NOT NULL,
  UNIQUE INDEX `ID_UNIQUE` (`ID` ASC) VISIBLE,
  PRIMARY KEY (`Clinic_Person_ID`),
  INDEX `fk_Patient_Clinic_Person_ID_idx` (`Clinic_Person_ID` ASC) VISIBLE,
  CONSTRAINT `fk_Patient_Clinic_Person1`
    FOREIGN KEY (`Clinic_Person_ID`)
    REFERENCES `Clinic`.`Clinic_Person` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Clinic`.`Doctor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Doctor` (
  `Clinic_Person_ID` INT(6) NOT NULL,
  `ID` CHAR(6) NOT NULL,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE,
  UNIQUE INDEX `ID_UNIQUE` (`ID` ASC) VISIBLE,
  PRIMARY KEY (`Clinic_Person_ID`),
  INDEX `fk_Doctor_Clinic_Person_ID_idx` (`Clinic_Person_ID` ASC) VISIBLE,
  CONSTRAINT `fk_Doctor_Clinic_Person1`
    FOREIGN KEY (`Clinic_Person_ID`)
    REFERENCES `Clinic`.`Clinic_Person` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Clinic`.`Administrator`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Administrator` (
  `Clinic_Person_ID` INT(6) NOT NULL,
  `ID` CHAR(6) NOT NULL,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE,
  UNIQUE INDEX `ID_UNIQUE` (`ID` ASC) VISIBLE,
  PRIMARY KEY (`Clinic_Person_ID`),
  INDEX `fk_Administrator_ClinicPerson1_idx` (`Clinic_Person_ID` ASC) VISIBLE,
  CONSTRAINT `fk_Administrator_Clinic_Person1`
    FOREIGN KEY (`Clinic_Person_ID`)
    REFERENCES `Clinic`.`Clinic_Person` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Clinic`.`Nurse`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Nurse` (
  `Clinic_Person_ID` INT(6) NOT NULL,
  `ID` CHAR(6) NOT NULL,
  `username` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Clinic_Person_ID`),
  INDEX `fk_Nurse_Clinic_Person1_idx` (`Clinic_Person_ID` ASC) VISIBLE,
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE,
  UNIQUE INDEX `ID_UNIQUE` (`ID` ASC) VISIBLE,
  CONSTRAINT `fk_Nurse_Clinic_Person1`
    FOREIGN KEY (`Clinic_Person_ID`)
    REFERENCES `Clinic`.`Clinic_Person` (`ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Clinic`.`Appointment`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Appointment` (
  `Patient_Clinic_Person_ID` INT(6) NOT NULL,
  `appt_date` DATE NOT NULL,
  `appt_time` TIME NOT NULL,
  `reason` VARCHAR(100) NOT NULL,
  `Doctor_Clinic_Person_ID` INT(6) NOT NULL,
  INDEX `fk_Appointment_Doctor1_idx` (`Doctor_Clinic_Person_ID` ASC) VISIBLE,
  INDEX `fk_Appointment_Patient1_idx` (`Patient_Clinic_Person_ID` ASC) VISIBLE,
  PRIMARY KEY (`Patient_Clinic_Person_ID`, `appt_date`, `appt_time`),
  CONSTRAINT `fk_Appointment_Doctor1`
    FOREIGN KEY (`Doctor_Clinic_Person_ID`)
    REFERENCES `Clinic`.`Doctor` (`Clinic_Person_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Appointment_Patient1`
    FOREIGN KEY (`Patient_Clinic_Person_ID`)
    REFERENCES `Clinic`.`Patient` (`Clinic_Person_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Clinic`.`Patient_Visit`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Patient_Visit` (
  `Appointment_Patient_Clinic_Person_ID` INT(6) NOT NULL,
  `Appointment_appt_date` DATE NOT NULL,
  `Appointment_appt_time` TIME NOT NULL,
  `weight` INT NOT NULL,
  `bp_sys` INT NOT NULL,
  `bp_dia` INT NOT NULL,
  `temp` DECIMAL(4,1) NOT NULL,
  `pulse` INT NOT NULL,
  `symptoms` TINYTEXT NOT NULL,
  `initial_diagnosis` VARCHAR(100) NOT NULL,
  `final_diagnosis` VARCHAR(100) NULL,
  `Nurse_Clinic_Person_ID` INT(6) NOT NULL,
  INDEX `fk_Patient_visit_Nurse1_idx` (`Nurse_Clinic_Person_ID` ASC) VISIBLE,
  PRIMARY KEY (`Appointment_Patient_Clinic_Person_ID`, `Appointment_appt_date`, `Appointment_appt_time`),
  CONSTRAINT `fk_Patient_visit_Nurse1`
    FOREIGN KEY (`Nurse_Clinic_Person_ID`)
    REFERENCES `Clinic`.`Nurse` (`Clinic_Person_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Patient_Visit_Appointment1`
    FOREIGN KEY (`Appointment_Patient_Clinic_Person_ID` , `Appointment_appt_date` , `Appointment_appt_time`)
    REFERENCES `Clinic`.`Appointment` (`Patient_Clinic_Person_ID` , `appt_date` , `appt_time`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Clinic`.`Lab_Tests`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Lab_Tests` (
  `test_code` VARCHAR(10) NOT NULL,
  `test_type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`test_code`),
  UNIQUE INDEX `test_type_UNIQUE` (`test_type` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Clinic`.`Specialty`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Specialty` (
  `specialty` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`specialty`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Clinic`.`Doctor_has_Specialty`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Doctor_has_Specialty` (
  `Doctor_Clinic_Person_ID` INT(6) NOT NULL,
  `Specialty_specialty` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Doctor_Clinic_Person_ID`, `Specialty_specialty`),
  INDEX `fk_Doctor_has_Specialty_Specialty1_idx` (`Specialty_specialty` ASC) VISIBLE,
  INDEX `fk_Doctor_has_Specialty_Doctor1_idx` (`Doctor_Clinic_Person_ID` ASC) VISIBLE,
  CONSTRAINT `fk_Doctor_has_Specialty_Doctor1`
    FOREIGN KEY (`Doctor_Clinic_Person_ID`)
    REFERENCES `Clinic`.`Doctor` (`Clinic_Person_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Doctor_has_Specialty_Specialty1`
    FOREIGN KEY (`Specialty_specialty`)
    REFERENCES `Clinic`.`Specialty` (`specialty`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Clinic`.`Patient_Visit_has_Lab_Tests`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Clinic`.`Patient_Visit_has_Lab_Tests` (
  `Patient_Visit_Appointment_Patient_Clinic_Person_ID` INT(6) NOT NULL,
  `Patient_Visit_Appointment_appt_date` DATE NOT NULL,
  `Patient_Visit_Appointment_appt_time` TIME NOT NULL,
  `Lab_Tests_test_code` VARCHAR(10) NOT NULL,
  `test_date` DATE NULL,
  `test_result` VARCHAR(10) NULL,
  PRIMARY KEY (`Patient_Visit_Appointment_Patient_Clinic_Person_ID`, `Patient_Visit_Appointment_appt_date`, `Patient_Visit_Appointment_appt_time`, `Lab_Tests_test_code`),
  INDEX `fk_Patient_Visit_has_Lab_Tests_Lab_Tests1_idx` (`Lab_Tests_test_code` ASC) VISIBLE,
  INDEX `fk_Patient_Visit_has_Lab_Tests_Patient_Visit1_idx` (`Patient_Visit_Appointment_Patient_Clinic_Person_ID` ASC, `Patient_Visit_Appointment_appt_date` ASC, `Patient_Visit_Appointment_appt_time` ASC) VISIBLE,
  CONSTRAINT `fk_Patient_Visit_has_Lab_Tests_Patient_Visit1`
    FOREIGN KEY (`Patient_Visit_Appointment_Patient_Clinic_Person_ID` , `Patient_Visit_Appointment_appt_date` , `Patient_Visit_Appointment_appt_time`)
    REFERENCES `Clinic`.`Patient_Visit` (`Appointment_Patient_Clinic_Person_ID` , `Appointment_appt_date` , `Appointment_appt_time`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Patient_Visit_has_Lab_Tests_Lab_Tests1`
    FOREIGN KEY (`Lab_Tests_test_code`)
    REFERENCES `Clinic`.`Lab_Tests` (`test_code`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
