

--login procedure

create or alter proc usuarios_login
@username varchar(50), @password varchar(50)
as
select users_id, first_name, last_name, email
from usuarios where username = @username  and user_psswd = @password
go

insert usuarios(first_name, last_name, email, username, user_psswd) VALUES ('Chris', 'Contreras', '1@gmail.com', 'chris', '1234')




create or alter proc usuario_getOne
@id int
as
	select u.first_name, u.last_name, u.email from usuarios u 
	where  u.users_id=@id
go

create or alter proc usuarios_list_all
as
select * from usuarios
go


create or alter proc pregunta_list_all
as
select p.titulo as 'Titulo', p.descripcion as 'Descrición', p.fecha as 'Fecha de publicación', 
	case p.estado
		when 1 then 'Abierta'
		when 0 then 'Cerrada'
		else 'Sin especificar'
	end as 'Estado de Pregunta'
from pregunta p
order by p.fecha desc
go



create or alter proc Mipregunta_list_all
@user_id int
as
	select u.username as 'Usuario', p.titulo as 'Titulo', p.descripcion as 'Descripcion', p.fecha as 'Fecha', p.estado as 'Estadode la pregunta' 
	from usuarios u inner join pregunta p ON u.users_id = p.users_id where u.users_id = @user_id
	order by p.fecha desc
go