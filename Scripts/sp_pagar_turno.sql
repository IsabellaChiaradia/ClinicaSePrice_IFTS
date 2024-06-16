DELIMITER //

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