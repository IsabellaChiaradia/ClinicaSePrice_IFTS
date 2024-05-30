-- Trae los datos del paciente filtrando por numero de documento 
--IN dni
DELIMITER //
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

DELIMITER ;