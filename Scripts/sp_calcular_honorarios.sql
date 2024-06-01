-- sp_calcula_honorarios: calcula los honorarios de un médico, recibiendo el id del medico y el día como parametros de input.
-- El día debe ser en el formato AAAA-MM-DD
delimiter // 
drop procedure if exists sp_calcula_honorarios//
 create procedure sp_calcula_honorarios(in i_dia varchar(50),in i_id_medico int, out rta int)
 begin
set rta = (SELECT sum(costoFinal) 
FROM turno tu 
INNER JOIN medico me on me.idMedico = tu.id_medico
WHERE tu.fechaAtencion = i_dia AND me.idMedico = i_id_medico AND tu.acreditado = 1);
end //