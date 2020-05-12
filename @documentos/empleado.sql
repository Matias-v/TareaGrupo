CREATE TABLE `empleado` (
  `cedula` int(11) NOT NULL primary key,
  `primer_nombre` varchar(20) NOT NULL,
  `segundo_nombre` varchar(20) DEFAULT NULL,
  `primer_apellido` varchar(20) NOT NULL,
  `segundo_apellido` varchar(20) DEFAULT NULL,
  `tipo` varchar(20) not null,
  `sueldoMens` int(10) not null,
  `telefono` int(15) not null,
  `direccion` varchar(25) not null
);

INSERT INTO `empleado` (`cedula`, `primer_nombre`, `segundo_nombre`, `primer_apellido`, `segundo_apellido`,`tipo`,`sueldoMens`,`telefono`,`direccion`) VALUES
(5422312, 'Pedro', 'Jose', 'Pedrosa', 'Joseosa','Operario',25000,094232121,'Av Bolivia 2122'),
(4212312, 'Maria', 'Jose', 'Gonzales', 'Pedrosa','Operario',25000,092311231,'Av Rivera 4421'),
(1233421, 'Mario', 'Alvaro', 'Lopes', 'Martinez','Administrativo',40000,099231112,'Av Italia 4111'),
(1123223, 'Hector', 'Matep', 'Gonzalez', NULL,'Gerente',35000,098343656,'Cno Carrasco 6643'),
(1124567, 'Richard', NULL, 'pias', NULL,'Administrativo',54000,097655342,'Av Rivera 4331'),
(2342345, 'Ricardo', NULL, 'Fort', NULL,'Operario',26000,098784787,'Av Bolivia 4321');