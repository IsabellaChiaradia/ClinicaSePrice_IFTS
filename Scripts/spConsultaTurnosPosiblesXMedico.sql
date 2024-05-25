DELIMITER //

CREATE PROCEDURE ObtenerTurnosEnHorario(
	IN fechaDesde DATE,
    IN fechaHasta DATE,
    IN medicoId INT
)
BEGIN
    DECLARE dia_semana INT;
    DECLARE inicio TIME;
    DECLARE inicioAux TIME;
    DECLARE fin TIME;
    DECLARE duracion_turno INT;
    DECLARE inicioPeriodo DATE;
    
    

    DECLARE cur_horarios CURSOR FOR SELECT ha.dia, ha.horaInicio, ha.horaFin FROM Horario_atencion ha WHERE ha.idMedico = medicoId;
    
    SET inicioPeriodo = fechaDesde;
    
    SELECT duracionTurno 
    INTO duracion_turno
    FROM medico
    WHERE medico.id = medicoId;
    -- Borrar los registros de la tabla de turnos temporal si existe
    DROP TEMPORARY TABLE IF EXISTS Temp_Turnos;
    
    -- Crear tabla de turnos temporal
    CREATE TEMPORARY TABLE Temp_Turnos (
		dia INT,
        fecha DATE,
        horaInicio TIME,
        horaFin TIME,
        idMedico INT
    );

    -- Abrir el cursor
    OPEN cur_horarios;

    -- Iterar sobre los horarios de atención
    horario_loop: BEGIN
        -- Iniciar el manejo de excepciones
        DECLARE CONTINUE HANDLER FOR NOT FOUND SET dia_semana = NULL;

        -- Lógica de la iteración
        LOOP
            -- Obtener los detalles del horario de atención
            FETCH cur_horarios INTO dia_semana, inicio, fin;

            -- Salir del bucle si no hay más filas
            IF (dia_semana IS NULL) THEN
                LEAVE horario_loop;
            END IF;

            -- Insertar los turnos dentro del horario de atención
			WHILE inicioPeriodo <= fechaHasta DO
				IF (dia_semana = DAYOFWEEK(inicioPeriodo)) THEN
					SET inicioAux = inicio;
					WHILE inicioAux < fin DO
						INSERT INTO Temp_Turnos (dia, fecha, horaInicio, horaFin, idMedico)
						VALUES (dia_semana, inicioPeriodo, inicioAux, ADDTIME(inicioAux, SEC_TO_TIME(duracion_turno * 60)), medicoId);
						
						SET inicioAux = ADDTIME(inicioAux, SEC_TO_TIME(duracion_turno * 60));
					END WHILE;
				END IF;
				 SET inicioPeriodo = DATE_ADD(inicioPeriodo, INTERVAL 1 DAY);
			END WHILE;
			SET inicioPeriodo = fechaDesde;	 -- lo tengo que reiniciar para el proximo registro del loop
        END LOOP;
    END;

    -- Cerrar el cursor
    CLOSE cur_horarios;

    -- Mostrar los turnos generados
    SELECT * 
    FROM Temp_Turnos pt  -- posibles turnos
    LEFT JOIN (SELECT * FROM turno tu WHERE tu.fechaAtencion BETWEEN fechaDesde AND fechaHasta) t
		ON t.idMedico = pt.idMedico
        AND t.horaInicio = pt.horaInicio
        AND pt.fecha = t.fechaAtencion
	ORDER BY pt.fecha, pt.horaInicio;
        
    
END //

DELIMITER ;

call ObtenerTurnosEnHorario('2024-07-08', '2024-07-20',2);