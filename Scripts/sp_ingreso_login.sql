DELIMITER //
DROP PROCEDURE IF EXISTS sp_ingreso_login//
CREATE PROCEDURE sp_ingreso_login(in correo varchar(20),in psw varchar(15))
BEGIN
  SELECT nombre, apellido, nomRol
	FROM usuario u INNER JOIN rol r ON u.id_rol = r.idRol
		WHERE email = correo AND psw = contrasenia /* se compara con los parametros */
			AND isActivo = 1; /* el usuario debe estar activo */
END //

DELIMITER ;