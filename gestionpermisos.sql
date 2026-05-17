-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 18-05-2026 a las 00:01:47
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `gestionpermisos`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contribuyente`
--

CREATE TABLE `contribuyente` (
  `rut` varchar(12) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `nacionalidad` varchar(30) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `comuna` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `contribuyente`
--

INSERT INTO `contribuyente` (`rut`, `nombre`, `apellido`, `nacionalidad`, `direccion`, `comuna`) VALUES
('1-1', 'Allan', 'Brown', 'chileno', 'Direccion Temporal', 'Comuna Temporal'),
('12.333.444-5', 'Antonio Gabriel', 'Rivas Toledo', 'Chileno', 'Pulpica Alto 433', 'Monte Patria'),
('17.355.194-0', 'Priscila ', 'Padilla Gomez', 'Chilena', 'El Peral S/N', 'Monte Patria'),
('18.263.018-7', 'Josafat', 'Rojas', 'Chileno', 'Arturo Fernandez 1165', 'Iquique');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `Id` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(255) NOT NULL,
  `Rol` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`Id`, `Username`, `PasswordHash`, `Rol`) VALUES
(1, 'admin', '$2a$11$3x.EXNNSG7FQ8ceNNpk4w.b/GMT76yKOMmHzicEuLJkwMjpBcEtS6', 'admin'),
(2, 'Josafat Rojas', '$2a$11$X6wAP2RORz50Oa5/wMhts.LA.ygjz9BWOcCW2SztLVQGfG8z9DfZy', 'usuario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehiculo`
--

CREATE TABLE `vehiculo` (
  `patente` varchar(8) NOT NULL,
  `marca` varchar(30) NOT NULL,
  `modelo` varchar(30) NOT NULL,
  `color` varchar(20) DEFAULT NULL,
  `anio` int(11) DEFAULT NULL,
  `rut_contribuyente` varchar(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `vehiculo`
--

INSERT INTO `vehiculo` (`patente`, `marca`, `modelo`, `color`, `anio`, `rut_contribuyente`) VALUES
('CCBB10', 'Hyundai', 'Carretero', 'Fucsia', 2000, '1-1'),
('CGPF-75', 'Ford', 'Ecosport XLT PLUS 1.6', 'Gris', 2010, '18.263.018-7'),
('CRRP-25', 'Mazda', 'Rx8', 'Negro', 1996, '17.355.194-0'),
('FFPP-54', 'Ford', 'Mustang', 'Rojo', 1992, '18.263.018-7'),
('VPZR-15', 'Kia', 'Sportage', 'Azul Marino', 2020, '12.333.444-5');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `contribuyente`
--
ALTER TABLE `contribuyente`
  ADD PRIMARY KEY (`rut`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indices de la tabla `vehiculo`
--
ALTER TABLE `vehiculo`
  ADD PRIMARY KEY (`patente`),
  ADD KEY `fk_propietario` (`rut_contribuyente`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `vehiculo`
--
ALTER TABLE `vehiculo`
  ADD CONSTRAINT `fk_propietario` FOREIGN KEY (`rut_contribuyente`) REFERENCES `contribuyente` (`rut`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
