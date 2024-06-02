DROP SCHEMA IF EXISTS clinica;
CREATE SCHEMA clinica;
USE clinica;

-- Creación de la tabla Paciente
DROP TABLE IF EXISTS paciente;
CREATE TABLE paciente (
    idPaciente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(20) NOT NULL,
    apellido VARCHAR(20) NOT NULL,
    nDocumento VARCHAR(20) NOT NULL,
	email VARCHAR(45),
    fechaNac DATE NOT NULL,
	telefono VARCHAR(20) NOT NULL,
	domicilio VARCHAR(45) NOT NULL,
	obraSocial VARCHAR(20)
);

-- Creación de la tabla Especialidad
DROP TABLE IF EXISTS especialidad;
CREATE TABLE especialidad (
    idEspecialidad INT AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL
);

-- Creación de la tabla Medico
DROP TABLE IF EXISTS medico;
CREATE TABLE medico (
    idMedico INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    nDocumento VARCHAR(20) NOT NULL,
    duracionTurno INT NOT NULL,
    id_especialidad INT,
	telefono VARCHAR(20) NOT NULL,
	domicilio VARCHAR(50),
	email VARCHAR(45),
    FOREIGN KEY (id_especialidad) REFERENCES especialidad(idEspecialidad)
);

-- Creación de la tabla Horario_atencion
DROP TABLE IF EXISTS horario_atencion;
CREATE TABLE horario_atencion (
    id INT AUTO_INCREMENT PRIMARY KEY,
    dia INT NOT NULL,
    horaInicio TIME NOT NULL,
    horaFin TIME NOT NULL,
    id_medico INT,
    FOREIGN KEY (id_medico) REFERENCES Medico(idMedico)
);

-- Creacion de la tabla practica
DROP TABLE IF EXISTS practica;
CREATE TABLE practica (
    idPractica INT AUTO_INCREMENT PRIMARY KEY,
    codigo VARCHAR(50) NOT NULL,
	costo DECIMAL NOT NULL,
	descripcion VARCHAR(30),
	id_especialidad INT,
	FOREIGN KEY (id_especialidad) REFERENCES especialidad(idEspecialidad)
);

-- Creación de la tabla Turno
DROP TABLE IF EXISTS turno;
CREATE TABLE turno (
    idTurno INT AUTO_INCREMENT PRIMARY KEY,
    fechaAtencion DATE NOT NULL,
    fechaBaja DATE,
    acreditado BOOLEAN NOT NULL,
    horaInicio TIME NOT NULL,
    horaFin TIME NOT NULL,
	costoFinal DECIMAL,
    id_paciente INT,
    id_medico INT,
	id_practica INT,
    FOREIGN KEY (id_paciente) REFERENCES paciente(idPaciente),
    FOREIGN KEY (id_medico) REFERENCES medico(idMedico),
	FOREIGN KEY (id_practica) REFERENCES practica(idPractica)
);

-- Creacion de la tabla insumo
DROP TABLE IF EXISTS insumo;
CREATE TABLE insumo (
    idInsumo INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
	cantidad INT NOT NULL
);

-- Creacion de la tabla practica_insumo
DROP TABLE IF EXISTS practica_insumo;
CREATE TABLE practica_insumo (
    id_practica INT,
    id_insumo INT,
	id_especialidad INT,
    cantidad INT,
    PRIMARY KEY (id_practica, id_insumo),
    FOREIGN KEY (id_practica) REFERENCES practica(idPractica),
    FOREIGN KEY (id_insumo) REFERENCES insumo(idInsumo)
);

-- Creacion de la tabla rol
DROP TABLE IF EXISTS rol;
CREATE TABLE rol (
  idRol int(11) NOT NULL,
  nomRol varchar(30) NOT NULL,
  PRIMARY KEY (idRol)
);

-- Creacion de la tabla usuario
DROP TABLE IF EXISTS usuario;
CREATE TABLE usuario (
  idUsuario int(11) NOT NULL AUTO_INCREMENT,
  nombre varchar(50) DEFAULT NULL,
  apellido varchar(50) DEFAULT NULL,
  id_rol int(11) DEFAULT NULL,
  email varchar(50) DEFAULT NULL,
  contrasenia varchar(50) DEFAULT NULL,
  isActivo tinyint(1) DEFAULT NULL,
  PRIMARY KEY (idUsuario),
  FOREIGN KEY (id_rol) REFERENCES rol(idRol)
) ;


-- Insertar pacientes
INSERT INTO paciente (idPaciente, nombre, apellido, nDocumento, email, telefono, fechaNac, domicilio, obraSocial) VALUES
(1001,'Juan', 'Perez', '30123456', 'juan.perez@gmail.com', '2641234567', '1985-01-15', 'Av. Libertador 1234', 'OSDE'),
(1002,'Maria', 'Gonzalez', '27234567', 'maria.gonzalez@outlook.com', '2642345678', '1990-03-22', 'Calle Falsa 456', 'Swiss Medical'),
(1003,'Carlos', 'Ramirez', '28123456', 'carlos.ramirez@gmail.com', '2643456789', '1982-07-30', 'Calle Siempre Viva 789', 'Medicus'),
(1004,'Ana', 'Lopez', '29234567', 'ana.lopez@outlook.com', '2644567890', '1995-11-10', 'Calle San Martin 1011', 'Galeno'),
(1005,'Lucia', 'Martinez', '30345678', 'lucia.martinez@gmail.com', '2645678901', '1988-06-05', 'Av. Rawson 1213', 'OMINT'),
(1006,'Pedro', 'Fernandez', '31345678', 'pedro.fernandez@outlook.com', '2646789012', '1979-04-12', 'Calle Mendoza 1415', 'OSDE'),
(1007,'Laura', 'Gutierrez', '32345678', 'laura.gutierrez@gmail.com', '2647890123', '1983-08-25', 'Calle Rioja 1617', 'Swiss Medical'),
(1008,'Diego', 'Alvarez', '33345678', 'diego.alvarez@outlook.com', '2648901234', '1992-02-19', 'Calle Tucuman 1819', 'Medicus'),
(1009,'Sofia', 'Romero', '34345678', 'sofia.romero@gmail.com', '2649012345', '1987-09-15', 'Av. Urquiza 2021', 'Galeno'),
(1010,'Javier', 'Dominguez', '35345678', 'javier.dominguez@outlook.com', '2649123456', '1991-12-31', 'Calle Sarmiento 2223', 'OMINT'),
(1011,'Emiliano', 'Vargas', '41641790', 'emi.vargas@outlook.com', '2641524158', '1996-11-25', 'Calle Rawson 120 sur', 'OMINT');

-- Insertar especialidades
INSERT INTO especialidad (tipo) VALUES
('Kinesiología'),
('Pediatría'),
('Odontología'),
('Cardiología'),
('Traumatología'),
('Bioquímica');

-- Insertar doctores
INSERT INTO medico (nombre, apellido, nDocumento, duracionTurno, id_especialidad, telefono, domicilio, email) VALUES
('Alejandro', 'Gomez', '27123456', 30, 1, '2641234567', 'Av. Libertador 123', 'alejandro.gomez@gmail.com'),                -- Asignado a la especialidad de Pediatria
('Beatriz', 'Fernandez', '28123456', 30, 1, '2642345678', 'Calle Rivadavia 456', 'beatriz.fernandez@outlook.com'),         -- Asignado a la especialidad de Pediatria
('Carlos', 'Martinez', '29123456', 30, 2, '2643456789', 'Av. José Ignacio de la Roza 789', 'carlos.martinez@gmail.com'),   -- Asignado a la especialidad de Cardiología
('Daniela', 'Lopez', '30123456', 30, 3, '2644567890', 'Calle General Acha 1011', 'daniela.lopez@outlook.com'),             -- Asignado a la especialidad de Odontologia
('Esteban', 'Ramirez', '31123456', 30, 4, '2645678901', 'Av. Rawson 1213', 'esteban.ramirez@gmail.com'),                   -- Asignado a la especialidad de Kinesiologia
('Fernanda', 'Gonzalez', '32123456', 30, 5, '2646789012', 'Calle Mendoza 1415', 'fernanda.gonzalez@outlook.com');          -- Asignado a la especialidad de Bioquimica

-- Insertar horarios de atención
INSERT INTO Horario_atencion (dia, horaInicio, horaFin, id_medico) VALUES 
(2, '09:00:00', '12:00:00', 1),    -- Lunes de 9am a 12pm
(4, '10:30:00', '13:00:00', 1),    -- Miércoles de 10:30am a 1pm
(3, '07:00:00', '12:00:00', 2),    -- Martes de 7am a 12pm
(5, '08:00:00', '12:30:00', 2),     -- Jueves de 08:00am a 12:30pm
(2, '08:00:00', '12:00:00', 3),    -- Lunes de 8am a 12pm
(2, '15:00:00', '18:00:00', 3),     -- Lunes de 15pm a 18pm
(4, '08:00:00', '12:00:00', 3),    -- Miercoles de 8am a 12pm
(4, '15:00:00', '18:00:00', 3),     -- Miercoles de 15pm a 18pm
(6, '08:00:00', '12:00:00', 3),    -- Viernes de 8am a 12pm
(6, '15:00:00', '18:00:00', 3),     -- Viernes de 15pm a 18pm
(3, '08:00:00', '12:00:00', 4),    -- Martes de 8am a 12pm
(5, '14:30:00', '18:00:00', 4),    -- Jueves de 2:30pm a 6pm
(5, '08:00:00', '12:00:00', 4),    -- Jueves de 8am a 12pm
(6, '15:00:00', '19:00:00', 4),    -- Viernes de 3pm a 7pm
(2, '09:00:00', '12:00:00', 5),    -- Lunes de 9am a 12pm
(3, '08:30:00', '12:30:00', 5),    -- Martes de 8:30am a 12:30pm
(3, '15:00:00', '18:00:00', 5),    -- Martes de 3pm a 6pm
(5, '08:00:00', '12:30:00', 5),    -- Jueves de 8am a 12:30pm
(6, '14:30:00', '18:00:00', 5),    -- Viernes de 2:30pm a 6pm
(2, '08:30:00', '12:30:00', 6),    -- Lunes de 8:30am a 12:30pm
(3, '15:00:00', '18:30:00', 6),    -- Martes de 3pm a 6:30pm
(4, '08:00:00', '13:00:00', 6),    -- Miércoles de 8am a 1pm
(4, '14:30:00', '18:30:00', 6),    -- Miércoles de 2:30pm a 6:30pm
(3, '14:30:00', '18:00:00', 6);    -- Martes de 2:30pm a 6pm


-- Insertar insumos
INSERT INTO insumo (nombre, cantidad) VALUES
('Guantes', 500),
('Jeringas', 1000),
('Algodón', 200),
('Gasas', 300),
('Mascarillas', 600),
('Analgésicos', 400),
('Antibióticos', 300),
('Electrodos', 150),
('Tensiómetros', 50),
('Tiras Reactivas', 800);

-- Insertar prácticas
INSERT INTO practica (codigo, costo, descripcion, id_especialidad) VALUES
-- Kinesiología
('101', 3500.00, 'Rehabilitación', 1),
('102', 4000.00, 'Terapia Física', 1),
('103', 3700.00, 'Consulta Inicial', 1),
('104', 4200.00, 'Electroterapia', 1),
('105', 3900.00, 'Masoterapia', 1),

-- Pediatría
('201', 2500.00, 'Consulta', 2),
('202', 3000.00, 'Control de Crecimiento', 2),
('203', 3200.00, 'Vacunación', 2),
('204', 2800.00, 'Consulta de Emergencia', 2),
('205', 3500.00, 'Chequeo General', 2),

-- Odontología
('301', 4500.00, 'Consulta Dental', 3),
('302', 5000.00, 'Extracción', 3),
('303', 6000.00, 'Limpieza', 3),
('304', 7000.00, 'Tratamiento de Caries', 3),
('305', 7500.00, 'Colocación de Corona', 3),

-- Cardiología
('401', 5000.00, 'Consulta Cardiológica', 4),
('402', 15000.00, 'Ecocardiograma', 4),
('403', 7000.00, 'Electrocardiograma', 4),
('404', 8000.00, 'Prueba de Esfuerzo', 4),
('405', 10000.00, 'Monitoreo Holter', 4),

-- Traumatología
('501', 5500.00, 'Consulta Traumatológica', 5),
('502', 7000.00, 'Radiografía', 5),
('503', 6500.00, 'Yeso', 5),
('504', 8000.00, 'Reducción de Fractura', 5),
('505', 9000.00, 'Artroscopía', 5),

-- Bioquímica
('601', 4000.00, 'Análisis de Sangre', 6),
('602', 6000.00, 'Perfil Lipídico', 6),
('603', 5000.00, 'Análisis de Orina', 6),
('604', 7000.00, 'Pruebas de Función Hepática', 6),
('605', 7500.00, 'Test de Glucosa', 6);

-- Insertar turnos para los pacientes registrados
INSERT INTO Turno (fechaAtencion, horaInicio, horaFin, id_paciente, id_medico, acreditado, id_practica)
VALUES ('2024-05-17', '11:00:00', '11:30:00', 1001, 1, 0, 1),
 ('2024-05-17', '11:00:00', '11:30:00', 1011, 1, 0, 2),
 ('2024-05-17', '11:00:00', '11:30:00', 1011, 1, 0, 5);

-- Relacionar prácticas con insumos y sus cantidades
INSERT INTO practica_insumo (id_practica, id_insumo, id_especialidad, cantidad) VALUES
-- Kinesiología
(1, 1, 1, 1),    -- Guantes
(1, 3, 1, 1),    -- Algodón
(1, 4, 1, 2),    -- Gasas

(2, 1, 1, 1),    -- Guantes
(2, 3, 1, 1),    -- Algodón
(2, 4, 1, 2),    -- Gasas

(3, 1, 1, 1),    -- Guantes
(3, 3, 1, 1),    -- Algodón

(4, 1, 1, 1),    -- Guantes
(4, 3, 1, 1),    -- Algodón

(5, 1, 1, 1),    -- Guantes
(5, 3, 1, 1),    -- Algodón

-- Pediatría
(6, 1, 2, 2),    -- Guantes
(6, 3, 2, 1),    -- Algodón
(6, 6, 2, 1),    -- Analgésicos

(7, 1, 2, 1),    -- Guantes
(7, 3, 2, 1),    -- Algodón
(7, 7, 2, 1),    -- Antibióticos

(8, 1, 2, 1),    -- Guantes
(8, 3, 2, 1),    -- Algodón

(9, 1, 2, 1),    -- Guantes
(9, 3, 2, 1),    -- Algodón

(10, 1, 2, 1),   -- Guantes
(10, 3, 2, 1),   -- Algodón

-- Odontología
(11, 1, 3, 2),   -- Guantes
(11, 3, 3, 1),   -- Algodón
(11, 4, 3, 1),   -- Gasas

(12, 1, 3, 3),   -- Guantes
(12, 3, 3, 1),   -- Algodón
(12, 4, 3, 2),   -- Gasas

(13, 1, 3, 2),   -- Guantes
(13, 3, 3, 1),   -- Algodón

(14, 1, 3, 3),   -- Guantes
(14, 3, 3, 1),   -- Algodón
(14, 4, 3, 1),   -- Gasas

(15, 1, 3, 3),   -- Guantes
(15, 3, 3, 1),   -- Algodón

-- Cardiología
(16, 1, 4, 2),   -- Guantes
(16, 8, 4, 2),   -- Electrodos
(16, 9, 4, 1),   -- Tensiómetros

(17, 1, 4, 3),   -- Guantes
(17, 8, 4, 4),   -- Electrodos
(17, 9, 4, 1),   -- Tensiómetros

(18, 1, 4, 2),   -- Guantes
(18, 8, 4, 1),   -- Electrodos

(19, 1, 4, 2),   -- Guantes
(19, 8, 4, 2),   -- Electrodos
(19, 9, 4, 1),   -- Tensiómetros

(20, 1, 4, 2),   -- Guantes
(20, 8, 4, 2),   -- Electrodos

-- Traumatología
(21, 1, 5, 2),   -- Guantes
(21, 4, 5, 2),   -- Gasas
(21, 6, 5, 1),   -- Analgésicos

(22, 1, 5, 2),   -- Guantes
(22, 4, 5, 1),   -- Gasas
(22, 6, 5, 1),   -- Analgésicos

(23, 1, 5, 2),   -- Guantes
(23, 4, 5, 2),   -- Gasas

(24, 1, 5, 2),   -- Guantes
(24, 4, 5, 2),   -- Gasas
(24, 6, 5, 1),   -- Analgésicos

(25, 1, 5, 2),   -- Guantes
(25, 4, 5, 1),   -- Gasas

-- Bioquímica
(26, 1, 6, 1),   -- Guantes
(26, 2, 6, 1),   -- Jeringas
(26, 10, 6, 10), -- Tiras Reactivas

(27, 1, 6, 1),   -- Guantes
(27, 2, 6, 1),   -- Jeringas
(27, 10, 6, 5), -- Tiras Reactivas

(28, 1, 6, 1),   -- Guantes
(28, 5, 6, 1),   -- Mascarilla
(28, 10, 6, 8), -- Tiras Reactivas

(29, 1, 6, 1),   -- Guantes
(29, 5, 6, 1),   -- Mascarilla
(29, 10, 6, 7), -- Tiras Reactivas

(30, 1, 6, 1),   -- Guantes
(30, 5, 6, 1),   -- Mascarilla
(30, 10, 6, 4); -- Tiras Reactivas;


INSERT INTO rol (idRol, nomRol) VALUES
(1, 'Administrador');

INSERT INTO usuario (idUsuario, nombre, apellido, id_rol, email, contrasenia, isActivo) VALUES 
(1, 'Delfina', 'Brea', 1, 'admin@admin', '1234', 1);

