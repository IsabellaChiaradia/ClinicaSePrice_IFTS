DELIMITER //
DROP PROCEDURE IF EXISTS sp_consulta_turnos_posibles_x_medico//
CREATE PROCEDURE sp_consulta_turnos_posibles_x_medico(
	IN i_fecha_desde DATE,
    IN i_fecha_hasta DATE,
    IN i_id_medico INT
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
    -- Borrar los registros de la tabla de turnos temporal si existe
    DROP TEMPORARY TABLE IF EXISTS Temp_Turnos;
    
    -- Crear tabla de turnos temporal
    CREATE TEMPORARY TABLE Temp_Turnos (
		dia INT,
        fecha DATE,
        hora_inicio TIME,
        hora_fin TIME,
        id_medico INT
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
						INSERT INTO Temp_Turnos (dia, fecha, hora_inicio, hora_fin, id_medico)
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
    SELECT pt.*, t.idTurno
    FROM Temp_Turnos pt  -- posibles turnos
    LEFT JOIN (SELECT * 
				FROM turno tu 
                WHERE tu.fechaBaja IS NULL
					AND tu.fechaAtencion BETWEEN i_fecha_desde AND i_fecha_hasta) t
		ON t.id_medico = pt.id_medico
        AND t.horaInicio = pt.hora_inicio
        AND pt.fecha = t.fechaAtencion
	ORDER BY pt.fecha, pt.hora_inicio;
        
    
END //

DELIMITER ;

call sp_consulta_turnos_posibles_x_medico('2024-06-03', '2024-06-07',1);
