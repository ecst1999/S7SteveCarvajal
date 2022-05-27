-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema s7_tutorias
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema s7_tutorias
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `s7_tutorias` DEFAULT CHARACTER SET utf8 ;
USE `s7_tutorias` ;

-- -----------------------------------------------------
-- Table `s7_tutorias`.`tutores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `s7_tutorias`.`tutores` (
  `tut_id` INT NOT NULL AUTO_INCREMENT,
  `tut_nombres` VARCHAR(255) NULL,
  `tut_estado` TINYINT(1) NULL,
  PRIMARY KEY (`tut_id`),
  UNIQUE INDEX `tut_id_UNIQUE` (`tut_id` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `s7_tutorias`.`estudiantes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `s7_tutorias`.`estudiantes` (
  `est_id` INT NOT NULL AUTO_INCREMENT,
  `est_nombres` VARCHAR(255) NULL,
  `est_estado` TINYINT(1) NULL,
  PRIMARY KEY (`est_id`),
  UNIQUE INDEX `est_id_UNIQUE` (`est_id` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `s7_tutorias`.`tutorias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `s7_tutorias`.`tutorias` (
  `tuto_id` INT NOT NULL AUTO_INCREMENT,
  `tuto_materia` VARCHAR(100) NULL,
  `tuto_horarios` VARCHAR(45) NULL,
  `est_id` INT NULL,
  `tuto_observaciones` LONGTEXT NULL,
  `tuto_actividades_adicionales` LONGTEXT NULL,
  PRIMARY KEY (`tuto_id`),
  INDEX `fk_estudiantes_tutorias_idx` (`est_id` ASC) VISIBLE,
  CONSTRAINT `fk_estudiantes_tutorias`
    FOREIGN KEY (`est_id`)
    REFERENCES `s7_tutorias`.`estudiantes` (`est_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `s7_tutorias`.`tutores_estudiantes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `s7_tutorias`.`tutores_estudiantes` (
  `tut_id` INT NOT NULL,
  `est_id` INT NOT NULL,
  PRIMARY KEY (`tut_id`, `est_id`),
  INDEX `fk_tutores_has_estudiantes_estudiantes1_idx` (`est_id` ASC) VISIBLE,
  INDEX `fk_tutores_has_estudiantes_tutores1_idx` (`tut_id` ASC) VISIBLE,
  CONSTRAINT `fk_tutores_has_estudiantes_tutores1`
    FOREIGN KEY (`tut_id`)
    REFERENCES `s7_tutorias`.`tutores` (`tut_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tutores_has_estudiantes_estudiantes1`
    FOREIGN KEY (`est_id`)
    REFERENCES `s7_tutorias`.`estudiantes` (`est_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

#Tutores
INSERT INTO `s7_tutorias`.`tutores` (`tut_nombres`, `tut_estado`) VALUES ('Daniel Enriquez', '1');
INSERT INTO `s7_tutorias`.`tutores` (`tut_nombres`, `tut_estado`) VALUES ('Hernesto Zabala', '1');

#Estudiantes
INSERT INTO `s7_tutorias`.`estudiantes` (`est_nombres`, `est_estado`) VALUES ('Marcelo Perez', '1');
INSERT INTO `s7_tutorias`.`estudiantes` (`est_nombres`, `est_estado`) VALUES ('Juan Zambiza', '1');
INSERT INTO `s7_tutorias`.`estudiantes` (`est_nombres`, `est_estado`) VALUES ('Elvis Camacho', '1');
INSERT INTO `s7_tutorias`.`estudiantes` (`est_nombres`, `est_estado`) VALUES ('Daniela Montero', '1');
INSERT INTO `s7_tutorias`.`estudiantes` (`est_nombres`, `est_estado`) VALUES ('Carolina Echeverria', '1');
INSERT INTO `s7_tutorias`.`estudiantes` (`est_nombres`, `est_estado`) VALUES ('Mercedes Quintana', '1');

# Tutores Estudiantes
INSERT INTO `s7_tutorias`.`tutores_estudiantes` (`tut_id`, `est_id`) VALUES ('1', '1');
INSERT INTO `s7_tutorias`.`tutores_estudiantes` (`tut_id`, `est_id`) VALUES ('1', '2');
INSERT INTO `s7_tutorias`.`tutores_estudiantes` (`tut_id`, `est_id`) VALUES ('1', '3');
INSERT INTO `s7_tutorias`.`tutores_estudiantes` (`tut_id`, `est_id`) VALUES ('2', '4');
INSERT INTO `s7_tutorias`.`tutores_estudiantes` (`tut_id`, `est_id`) VALUES ('2', '5');
INSERT INTO `s7_tutorias`.`tutores_estudiantes` (`tut_id`, `est_id`) VALUES ('2', '6');

# Tutorias
INSERT INTO `s7_tutorias`.`tutorias` (`tuto_materia`, `tuto_horarios`, `est_id`, `tuto_observaciones`, `tuto_actividades_adicionales`) VALUES ('Matemática', 'Lunes 14:00 - 15:00', '1', 'Presenta inconvenientes al hacer fracciones', 'Realizar 20 ejercicios del libro con respecto fracciones.');
INSERT INTO `s7_tutorias`.`tutorias` (`tuto_materia`, `tuto_horarios`, `est_id`, `tuto_observaciones`, `tuto_actividades_adicionales`) VALUES ('Lenguaje', 'Martes 15:00 - 16:00', '2', 'Presenta inconvenientes con la redacción de textos científicos', 'Realizar un ensayo de 15 páginas.');


