DELIMITER //

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

        
        DROP TEMPORARY TABLE IF EXISTS Temp_Turnos_Posibles;
        DROP TEMPORARY TABLE IF EXISTS Temp_Turnos_Disponibles_Y_Ocupados;

        -- Llamar al procedimiento existente para obtener los turnos del médico
        CALL sp_consulta_turnos_posibles_x_medico(i_fecha_desde, i_fecha_hasta, v_id_medico);

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

DELIMITER ;

call sp_consulta_turnos_posibles_x_especialidad('2024-06-03', '2024-06-07',1);