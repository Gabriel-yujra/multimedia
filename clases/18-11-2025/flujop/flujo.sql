-- phpMyAdmin SQL Dump
-- version 4.3.11
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 17-11-2025 a las 21:00:36
-- Versión del servidor: 5.6.24
-- Versión de PHP: 5.6.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `wflujo`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `flujo`
--

CREATE TABLE IF NOT EXISTS `flujo` (
  `codflujo` varchar(5) DEFAULT NULL,
  `codproceso` varchar(5) DEFAULT NULL,
  `cod_procesosiguiente` varchar(5) DEFAULT NULL,
  `rol` varchar(15) DEFAULT NULL,
  `pantalla` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `flujo`
--

INSERT INTO `flujo` (`codflujo`, `codproceso`, `cod_procesosiguiente`, `rol`, `pantalla`) VALUES
('F1', 'P1', 'P2', 'estudiante', 'inicio'),
('F1', 'P2', 'P3', 'estudiante', 'listado'),
('F1', 'P3', 'P4', 'estudiante', 'mencion'),
('F1', 'P4', NULL, 'kardex', 'fin'),
('F1', 'P5', 'P6', 'kardex', 'inicio'),
('F1', 'P6', 'P8', 'kardex', 'inicio'),
('F1', 'P7', 'P8', 'kardex', 'inicio'),
('F1', 'P7', 'P8', 'estudiante', 'inicio');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
