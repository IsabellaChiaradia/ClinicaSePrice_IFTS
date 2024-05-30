--Trae los datos importantes de un turno filtrando por dni del paciente y fecha actual

DELIMITER //
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

DELIMITER ;