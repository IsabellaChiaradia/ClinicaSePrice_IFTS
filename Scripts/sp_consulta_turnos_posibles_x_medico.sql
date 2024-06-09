DELIMITER //
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

DELIMITER ;

call sp_consulta_turnos_posibles_x_medico('2024-06-03', '2024-06-07', 2, true);
