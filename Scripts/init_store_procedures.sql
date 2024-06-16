/*_________________SP ALTA PACIENTE____________________________*/

delimiter // 
 drop procedure if exists sp_alta_paciente//
 create procedure sp_alta_paciente(in i_nombre varchar(50),in i_apellido varchar(50), in i_n_documento varchar(15), in i_correo varchar(50), in i_fecha_nac date, in i_n_telefono  varchar(15), in i_domicilio varchar(50), in i_obra_social varchar(20), out rta int)
 begin
     declare id int default 0;
	 declare existe int default 0;
     declare contador int default 0;
    
     set contador = (select count(*) from paciente);
     if contador = 0 then
		set id = 1001; /* consideramos a este numero como el primer numero de paciente*/
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo id de paciente almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set id = (select max(IDPaciente) + 1 from paciente);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el paciente
		------------------------------------------------------- */	
		set existe = (select count(*) from paciente p where p.email = i_correo or p.nDocumento = i_n_documento);
     end if;
	 
	  if existe = 0 then	 
		 insert into paciente values(id,i_nombre,i_apellido,i_n_documento,i_correo,i_fecha_nac,i_n_telefono,i_domicilio,i_obra_social);
		 set rta  = id; -- esto devuelve el id del paciente
	  else
		 set rta = existe; -- si devuelve 1 ya existe
      end if;		 
     end //
	 
	/*_________________SP ALTA TURNO____________________________*/
	
drop procedure if exists sp_alta_turno//
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_alta_turno`(
    IN i_fecha_atencion DATE,
    IN i_hora_inicio TIME,
    IN i_hora_fin TIME,
    IN i_id_paciente INT,
    IN i_id_medico INT,
    IN i_id_practica INT,
    OUT rta INT
)
BEGIN
    DECLARE idTurno INT DEFAULT 0;
    DECLARE idExistente INT DEFAULT 0;
    
    DECLARE contador INT DEFAULT 0;
    SET contador = (SELECT COUNT(*) FROM turno);
    
    IF contador = 0 THEN
        SET idTurno = 2001; -- consideramos este número como el primer número de turno
    ELSE
        SET idTurno = (SELECT MAX(idTurno) + 1 FROM turno);
        SET idExistente = (SELECT COUNT(*) FROM turno t WHERE t.id_paciente = i_id_paciente AND t.fechaAtencion = i_fecha_atencion AND t.horaInicio = i_hora_inicio);
    END IF;

    IF idExistente = 0 THEN
        INSERT INTO turno (fechaAtencion, horaInicio, horaFin, id_paciente, id_medico, id_practica)
        VALUES (i_fecha_atencion, i_hora_inicio, i_hora_fin, i_id_paciente, i_id_medico, i_id_practica);

        SET rta = idTurno; -- devuelve el ID del turno insertado
    ELSE
        SET rta = -1; -- indica que ya existe un turno con esos datos
    END IF;
END

	
	/*_________________SP CONSULTA PACIENTE____________________________*/
	
DROP PROCEDURE IF EXISTS sp_consulta_paciente//
CREATE PROCEDURE sp_consulta_paciente (
    IN i_n_documento VARCHAR(20)
)
BEGIN
    SELECT *
    FROM 
        paciente p
    WHERE 
        p.nDocumento = i_n_documento;
END //
	
	/*_________________SP CONSULTA TURNO____________________________*/
	
	/*Trae los datos importantes de un turno filtrando por dni del paciente y fecha actual*/

DROP PROCEDURE IF EXISTS sp_consulta_turno//
CREATE PROCEDURE sp_consulta_turno (
    IN p_dni VARCHAR(20)
)
BEGIN
    SELECT 
		CONCAT(p.nombre, ' ', p.apellido) AS paciente,
        p.obraSocial,
        t.fechaAtencion,
        t.fechaBaja,
        t.acreditado,
        t.horaInicio,
        t.horaFin,
        t.costoFinal,
        CONCAT(m.nombre, ' ', m.apellido) AS medico,
        pr.descripcion AS practica_descripcion
    FROM 
        turno t
    JOIN 
        paciente p ON t.id_paciente = p.idPaciente
    JOIN 
        medico m ON t.id_medico = m.idMedico
    JOIN 
        practica pr ON t.id_practica = pr.idPractica
    WHERE 
        p.nDocumento = p_dni
        AND t.fechaAtencion = CURDATE();
END //
	
	/*_________________SP CONSULTA TURNOS POSIBLES X ESPECIALIDAD____________________________*/
	
DROP PROCEDURE IF EXISTS sp_consulta_turnos_posibles_x_especialidad//
CREATE PROCEDURE sp_consulta_turnos_posibles_x_especialidad(
    IN i_fecha_desde DATE,
    IN i_fecha_hasta DATE,
    IN i_id_especialidad INT
)
BEGIN
    DECLARE v_id_medico INT;
    DECLARE v_done INT DEFAULT FALSE;
    DECLARE cur_medicos CURSOR FOR SELECT m.idMedico FROM medico m WHERE m.id_especialidad = i_id_especialidad;
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET v_done = TRUE;

    -- Borrar la tabla temporal si existe
    DROP TEMPORARY TABLE IF EXISTS Temp_All_Turnos;

    -- Crear tabla temporal para almacenar todos los turnos
    CREATE TEMPORARY TABLE Temp_All_Turnos (
        dia INT,
        fecha DATE,
        hora_inicio TIME,
        hora_fin TIME,
        id_medico INT,
        nombre_completo VARCHAR(100),
        idTurno INT
    );

    -- Abrir el cursor para iterar sobre los médicos
    OPEN cur_medicos;

    medico_loop: LOOP
        -- Obtener el id del médico
        FETCH cur_medicos INTO v_id_medico;

        -- Salir del bucle si no hay más médicos
        IF v_done THEN
            LEAVE medico_loop;
        END IF;

        -- Llamar al procedimiento existente para obtener los turnos del médico
        CALL sp_consulta_turnos_posibles_x_medico(i_fecha_desde, i_fecha_hasta, v_id_medico, false);

        -- Insertar los turnos del médico actual en la tabla temporal general
        INSERT INTO Temp_All_Turnos (dia, fecha, hora_inicio, hora_fin, id_medico, nombre_completo, idTurno)
        SELECT dia, fecha, hora_inicio, hora_fin, id_medico, nombre_completo, idTurno
        FROM Temp_Turnos_Disponibles_Y_Ocupados;
    END LOOP;

    -- Cerrar el cursor
    CLOSE cur_medicos;

    -- Mostrar todos los turnos combinados
    SELECT * FROM Temp_All_Turnos ORDER BY fecha, hora_inicio;

END //
	
	/*_________________SP CONSULTA TURNOS POSIBLES X MEDICO____________________________*/
	
DROP PROCEDURE IF EXISTS sp_consulta_turnos_posibles_x_medico//
CREATE PROCEDURE sp_consulta_turnos_posibles_x_medico(
	IN i_fecha_desde DATE,
    IN i_fecha_hasta DATE,
    IN i_id_medico INT,
    IN i_show_results BOOLEAN
)
BEGIN
    DECLARE v_dia_semana INT;
    DECLARE v_inicio TIME;
    DECLARE v_inicioAux TIME;
    DECLARE v_fin TIME;
    DECLARE v_duracion_turno INT;
    DECLARE v_inicio_periodo DATE;
    
    DECLARE cur_horarios CURSOR FOR SELECT ha.dia, ha.horaInicio, ha.horaFin FROM horario_atencion ha WHERE ha.id_medico = i_id_medico;
    
    SET v_inicio_periodo = i_fecha_desde;
    
    SELECT m.duracionTurno 
    INTO v_duracion_turno
    FROM medico m
    WHERE m.idMedico = i_id_medico;
    
    -- Borrar los registros de la tabla Temp_Turnos_Posibles si existe
    DROP TEMPORARY TABLE IF EXISTS Temp_Turnos_Posibles;
    
    -- Crear tabla Temp_Turnos_Posibles
    CREATE TEMPORARY TABLE Temp_Turnos_Posibles (
		dia INT,
        fecha DATE,
        hora_inicio TIME,
        hora_fin TIME,
        id_medico INT
    );
    
    -- Borrar los registros de la tabla Temp_Turnos_Disponibles_Y_Ocupados si existe
    DROP TEMPORARY TABLE IF EXISTS Temp_Turnos_Disponibles_Y_Ocupados;
    
    -- Crear tabla Temp_Turnos_Disponibles_Y_Ocupados
    CREATE TEMPORARY TABLE Temp_Turnos_Disponibles_Y_Ocupados (
		dia INT,
        fecha DATE,
        hora_inicio TIME,
        hora_fin TIME,
        id_medico INT,
        nombre_completo VARCHAR(100), 
        idTurno INT
    );

    -- Abrir el cursor
    OPEN cur_horarios;

    -- Iterar sobre los horarios de atención
    horario_loop: BEGIN
        -- Iniciar el manejo de excepciones
        DECLARE CONTINUE HANDLER FOR NOT FOUND SET v_dia_semana = NULL;

        -- Lógica de la iteración
        LOOP
            -- Obtener los detalles del horario de atención
            FETCH cur_horarios INTO v_dia_semana, v_inicio, v_fin;

            -- Salir del bucle si no hay más filas
            IF (v_dia_semana IS NULL) THEN
                LEAVE horario_loop;
            END IF;

            -- Insertar los turnos dentro del horario de atención
			WHILE v_inicio_periodo <= i_fecha_hasta DO
				IF (v_dia_semana = DAYOFWEEK(v_inicio_periodo)) THEN
					SET v_inicioAux = v_inicio;
					WHILE v_inicioAux < v_fin DO
						INSERT INTO Temp_Turnos_Posibles (dia, fecha, hora_inicio, hora_fin, id_medico)
						VALUES (v_dia_semana, v_inicio_periodo, v_inicioAux, ADDTIME(v_inicioAux, SEC_TO_TIME(v_duracion_turno * 60)), i_id_medico);
						
						SET v_inicioAux = ADDTIME(v_inicioAux, SEC_TO_TIME(v_duracion_turno * 60));
					END WHILE;
				END IF;
				 SET v_inicio_periodo = DATE_ADD(v_inicio_periodo, INTERVAL 1 DAY);
			END WHILE;
			SET v_inicio_periodo = i_fecha_desde;	 -- lo tengo que reiniciar para el proximo registro del loop
        END LOOP;
    END;

    -- Cerrar el cursor
    CLOSE cur_horarios;

    -- Mostrar los turnos generados
    INSERT INTO Temp_Turnos_Disponibles_Y_Ocupados (dia, fecha, hora_inicio, hora_fin, id_medico, nombre_completo, idTurno)
		SELECT ttp.dia, ttp.fecha, ttp.hora_inicio, ttp.hora_fin, ttp.id_medico, CONCAT(m.nombre, ' ', m.apellido) as nombre_completo, t.idTurno
		FROM Temp_Turnos_Posibles ttp
		LEFT JOIN (SELECT * 
				   FROM turno tu 
				   WHERE tu.fechaBaja IS NULL
					 AND tu.fechaAtencion BETWEEN i_fecha_desde AND i_fecha_hasta) t
			ON t.id_medico = ttp.id_medico
			AND t.horaInicio = ttp.hora_inicio
			AND t.fechaAtencion = ttp.fecha
		INNER JOIN medico m ON m.idMedico = ttp.id_medico
		ORDER BY ttp.fecha, ttp.hora_inicio;

	IF i_show_results THEN
        SELECT * FROM Temp_Turnos_Disponibles_Y_Ocupados;
    END IF;
   
END //
	
	/*_________________SP INGRESO LOGIN____________________________*/

DROP PROCEDURE IF EXISTS sp_ingreso_login//
CREATE PROCEDURE sp_ingreso_login(in correo varchar(20),in psw varchar(15))
BEGIN
  SELECT nombre, apellido, nomRol
	FROM usuario u INNER JOIN rol r ON u.id_rol = r.idRol
		WHERE email = correo AND psw = contrasenia /* se compara con los parametros */
			AND isActivo = 1; /* el usuario debe estar activo */
END //

/*______________________________SP PAGAR TURNO_________________*/

DROP PROCEDURE IF EXISTS sp_pagar_turno //
CREATE PROCEDURE sp_pagar_turno (
    IN i_idTurno INT,
    IN i_costoFinal DECIMAL,
    OUT o_result INT
)
BEGIN
    DECLARE v_idPractica INT;
    DECLARE v_acreditado BOOLEAN;

    -- Obtener el estado actual de acreditado y el id_practica del turno
    SELECT acreditado, id_practica INTO v_acreditado, v_idPractica
    FROM turno
    WHERE idTurno = i_idTurno;

    -- Verificar si el turno ya está acreditado
    IF v_acreditado = TRUE THEN
        SET o_result = 0;
    ELSE
        -- Actualizar el costoFinal del turno y poner acreditado en true
        UPDATE turno
        SET costoFinal = i_costoFinal,
            acreditado = TRUE
        WHERE idTurno = i_idTurno;

        -- Actualizar el stock de insumos
        UPDATE insumo i
        JOIN practica_insumo pi ON i.idInsumo = pi.id_insumo
        SET i.cantidad = i.cantidad - pi.cantidad
        WHERE pi.id_practica = v_idPractica;

        SET o_result = 1;
    END IF;
END //

DELIMITER ;