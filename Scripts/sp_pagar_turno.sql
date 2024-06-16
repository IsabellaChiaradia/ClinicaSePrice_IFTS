DELIMITER //

DROP PROCEDURE IF EXISTS sp_pagar_turno //
CREATE PROCEDURE sp_pagar_turno (
    IN i_idTurno INT,
    IN i_costoFinal DECIMAL
)
BEGIN
    DECLARE v_idPractica INT;
    
    -- Obtener el id_practica del turno
    SELECT id_practica INTO v_idPractica
    FROM turno
    WHERE idTurno = i_idTurno;

    -- Actualizar el costoFinal del turno
    UPDATE turno
    SET costoFinal = i_costoFinal,
        acreditado = true
    WHERE idTurno = i_idTurno;

    -- Actualizar el stock de insumos
    UPDATE insumo i
    JOIN practica_insumo pi ON i.idInsumo = pi.id_insumo
    SET i.cantidad = i.cantidad - pi.cantidad
    WHERE pi.id_practica = v_idPractica;

END //

DELIMITER ;
