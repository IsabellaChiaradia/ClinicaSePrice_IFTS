DROP SCHEMA IF EXISTS clinica_se_price;
CREATE SCHEMA clinica_se_price;
USE clinica_se_price;

-- Creación de la tabla Paciente
DROP TABLE IF EXISTS paciente;
CREATE TABLE paciente (
    id_paciente INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(20) NOT NULL,
    apellido VARCHAR(20) NOT NULL,
    nro_documento VARCHAR(20) NOT NULL,
	fecha_nac DATE NOT NULL,
	email VARCHAR(45),
	telefono VARCHAR(20) NOT NULL,
	domicilio VARCHAR(45) NOT NULL,
	obra_social VARCHAR(20)
);

-- Creación de la tabla especialidad
DROP TABLE IF EXISTS especialidad;
CREATE TABLE especialidad (
    id_especialidad INT AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL
);

-- Creación de la tabla medico
DROP TABLE IF EXISTS medico;
CREATE TABLE medico (
    id_medico INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    nro_documento VARCHAR(20) NOT NULL,
    duracion_turno INT NOT NULL,
    id_especialidad INT,
	telefono VARCHAR(20) NOT NULL,
	domicilio VARCHAR(50),
	email VARCHAR(45),
    FOREIGN KEY (id_especialidad) REFERENCES especialidad(id_especialidad)
);

-- Creación de la tabla Horario_atencion
DROP TABLE IF EXISTS horario_atencion;
CREATE TABLE horario_atencion (
    id INT AUTO_INCREMENT PRIMARY KEY,
    dia INT NOT NULL,
    hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL,
    id_medico INT,
    FOREIGN KEY (id_medico) REFERENCES medico(id_medico)
);

-- Creacion de la tabla practica
DROP TABLE IF EXISTS practica;
CREATE TABLE practica (
    id_practica INT AUTO_INCREMENT PRIMARY KEY,
    codigo VARCHAR(50) NOT NULL,
	costo DECIMAL NOT NULL,
	descripcion VARCHAR(30) 
);

-- Creación de la tabla Turno
DROP TABLE IF EXISTS turno;
CREATE TABLE turno (
    id_turno INT AUTO_INCREMENT PRIMARY KEY,
    fecha_atencion DATE NOT NULL,
    fecha_baja DATE,
    acreditado BOOLEAN NOT NULL,
    hora_inicio TIME NOT NULL,
    hora_fin TIME NOT NULL,
    id_paciente INT,
    id_medico INT,
	id_practica INT,
    FOREIGN KEY (id_paciente) REFERENCES paciente(id_paciente),
    FOREIGN KEY (id_medico) REFERENCES medico(id_medico),
	FOREIGN KEY (id_practica) REFERENCES practica(id_practica)
);

-- Creacion de la tabla insumo
DROP TABLE IF EXISTS insumo;
CREATE TABLE insumo (
    id_insumo INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
	cantidad INT NOT NULL
);

-- Creacion de la tabla practica_insumo
DROP TABLE IF EXISTS practica_insumo;
CREATE TABLE practica_insumo (
    id_practica INT,
    id_insumo INT,
    cantidad INT,
    PRIMARY KEY (id_practica, id_insumo),
    FOREIGN KEY (id_practica) REFERENCES practica(id_practica),
    FOREIGN KEY (id_insumo) REFERENCES insumo(id_insumo)
);

-- Insertar pacientes
INSERT INTO paciente (nombre, apellido, nro_documento, email, telefono, fecha_nac, domicilio, obra_social) VALUES
('Juan', 'Perez', '30123456', 'juan.perez@gmail.com', '2641234567', '1985-01-15', 'Av. Libertador 1234', 'OSDE'),
('Maria', 'Gonzalez', '27234567', 'maria.gonzalez@outlook.com', '2642345678', '1990-03-22', 'Calle Falsa 456', 'Swiss Medical'),
('Carlos', 'Ramirez', '28123456', 'carlos.ramirez@gmail.com', '2643456789', '1982-07-30', 'Calle Siempre Viva 789', 'Medicus'),
('Ana', 'Lopez', '29234567', 'ana.lopez@outlook.com', '2644567890', '1995-11-10', 'Calle San Martin 1011', 'Galeno'),
('Lucia', 'Martinez', '30345678', 'lucia.martinez@gmail.com', '2645678901', '1988-06-05', 'Av. Rawson 1213', 'OMINT'),
('Pedro', 'Fernandez', '31345678', 'pedro.fernandez@outlook.com', '2646789012', '1979-04-12', 'Calle Mendoza 1415', 'OSDE'),
('Laura', 'Gutierrez', '32345678', 'laura.gutierrez@gmail.com', '2647890123', '1983-08-25', 'Calle Rioja 1617', 'Swiss Medical'),
('Diego', 'Alvarez', '33345678', 'diego.alvarez@outlook.com', '2648901234', '1992-02-19', 'Calle Tucuman 1819', 'Medicus'),
('Sofia', 'Romero', '34345678', 'sofia.romero@gmail.com', '2649012345', '1987-09-15', 'Av. Urquiza 2021', 'Galeno'),
('Javier', 'Dominguez', '35345678', 'javier.dominguez@outlook.com', '2649123456', '1991-12-31', 'Calle Sarmiento 2223', 'OMINT');

-- Insertar especialidades
INSERT INTO especialidad (tipo) VALUES 
('Pediatria'),
('Cardiologia'),
('Odontologia'),
('Kinesiologia'),
('Bioquimica');

-- Insertar doctores
INSERT INTO medico (nombre, apellido, nro_documento, duracion_turno, id_especialidad, telefono, domicilio, email) VALUES
('Alejandro', 'Gomez', '27123456', 30, 1, '2641234567', 'Av. Libertador 123', 'alejandro.gomez@gmail.com'),                -- Asignado a la especialidad de Pediatria
('Beatriz', 'Fernandez', '28123456', 30, 1, '2642345678', 'Calle Rivadavia 456', 'beatriz.fernandez@outlook.com'),         -- Asignado a la especialidad de Pediatria
('Carlos', 'Martinez', '29123456', 30, 2, '2643456789', 'Av. José Ignacio de la Roza 789', 'carlos.martinez@gmail.com'),   -- Asignado a la especialidad de Cardiología
('Daniela', 'Lopez', '30123456', 30, 3, '2644567890', 'Calle General Acha 1011', 'daniela.lopez@outlook.com'),             -- Asignado a la especialidad de Odontologia
('Esteban', 'Ramirez', '31123456', 30, 4, '2645678901', 'Av. Rawson 1213', 'esteban.ramirez@gmail.com'),                   -- Asignado a la especialidad de Kinesiologia
('Fernanda', 'Gonzalez', '32123456', 30, 5, '2646789012', 'Calle Mendoza 1415', 'fernanda.gonzalez@outlook.com');          -- Asignado a la especialidad de Bioquimica

-- Insertar horarios de atención para los médicos
INSERT INTO horario_atencion (dia, hora_inicio, hora_fin, id_medico) VALUES 
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

INSERT INTO turno (fecha_atencion, hora_inicio, hora_fin, id_paciente, id_medico, acreditado)
VALUES ('2024-05-17', '11:00:00', '11:30:00', 1, 1, 0);




