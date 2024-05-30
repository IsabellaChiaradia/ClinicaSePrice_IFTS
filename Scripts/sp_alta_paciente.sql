delimiter // 
 drop procedure if exists sp_alta_paciente//
 create procedure sp_alta_paciente(in i_nombre varchar(50),in i_apellido varchar(50), in i_n_documento varchar(15), in i_correo varchar(50), in i_fecha_nac varchar(15), in i_n_telefono  varchar(15), in i_domicilio varchar(50), in i_obra_social varchar(20), out rta int)
 begin
     declare id int default 0;
	 declare existe int default 0;
     declare contador int default 0;
    
     set contador = (select count(*) from paciente);
     if contador = 0 then
		set id = 1001; /* consideramos a este numero como el primer numero de paciente*/
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo id de paciente almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set id = (select max(IDPaciente) + 1 from paciente);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el paciente
		------------------------------------------------------- */	
		set existe = (select count(*) from paciente p where p.email = i_correo or p.nDocumento = i_n_documento);
     end if;
	 
	  if existe = 0 then	 
		 insert into paciente values(id,i_nombre,i_apellido,i_n_documento,i_correo,i_fecha_nac,i_n_telefono,i_domicilio,i_obra_social);
		 set rta  = id; -- esto devuelve el id del paciente
	  else
		 set rta = existe; -- si devuelve 1 ya existe
      end if;		 
     end //