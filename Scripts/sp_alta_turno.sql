CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_alta_turno`(
    IN i_fecha_atencion DATE,
    IN i_hora_inicio TIME,
    IN i_hora_fin TIME,
    IN i_costo_final DECIMAL(10, 2),
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
        INSERT INTO turno (fechaAtencion, horaInicio, horaFin, costoFinal, id_paciente, id_medico, id_practica)
        VALUES (i_fecha_atencion, i_hora_inicio, i_hora_fin, i_costo_final, i_id_paciente, i_id_medico, i_id_practica);

        SET rta = idTurno; -- devuelve el ID del turno insertado
    ELSE
        SET rta = -1; -- indica que ya existe un turno con esos datos
    END IF;
END