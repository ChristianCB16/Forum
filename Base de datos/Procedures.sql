

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
select p.quest_id, u.username as 'Username',p.titulo as 'Titulo', p.descripcion as 'Descrición', p.fecha as 'Fecha de publicación', 
	case p.estado
		when 1 then 'Abierta'
		when 0 then 'Cerrada'
		else 'Sin especificar'
	end as 'Estado de Pregunta'
from pregunta p inner join usuarios u on p.users_id = u.users_id
order by p.fecha desc
go


select * from pregunta

create or alter proc Mipregunta_list_all
@user_id int
as
	select u.username as 'Usuario', p.titulo as 'Titulo', p.descripcion as 'Descripcion', p.fecha as 'Fecha', p.estado as 'Estadode la pregunta' 
	from usuarios u inner join pregunta p ON u.users_id = p.users_id where u.users_id = @user_id
	order by p.fecha desc
go

--create
create or alter proc usuario_crear
@firstname varchar(150),
@lastname varchar(150),
@username varchar(150),
@email varchar(50),
@psswd varchar(50)
as 
insert into usuarios(first_name, last_name,username,email,user_psswd)
values(@firstname, @lastname, @username,@email, @psswd);
go 

select * from usuarios


create proc usuario_existe
@valor varchar(100),
@existe bit output
as
if exists (select first_name from usuarios where first_name = ltrim(rtrim(@valor)))
	begin
		set @existe=1
	end
else
	begin
		set @existe=0
	end
go


Create proc verRespuestasId
@answer_id int
as
select r.answer_id, r.descripcion, r.fecha, u.username from pregunta p inner join respuesta r ON p.quest_id = r.quest_id inner join usuarios u ON r.users_id = u.users_id
where p.quest_id = @answer_id
order by r.fecha desc









create or alter proc pregunta_list_all
as
select p.quest_id, p.titulo as 'Titulo', p.descripcion as 'Descrición', p.fecha as 'Fecha de publicación', 
	case p.estado
		when 1 then 'Abierta'
		when 0 then 'Cerrada'
		else 'Sin especificar'
	end as 'Estado de Pregunta'
from pregunta p
order by p.fecha desc
go

create proc usuario_existe
@username varchar(100),
@id int output
as
select u.users_id from usuarios u	
go

create or alter proc Mipregunta_list_all
@username varchar(150)
as
	select u.username as 'Usuario', p.titulo as 'Titulo', p.descripcion as 'Descripcion', p.fecha as 'Fecha', p.estado as 'Estadode la pregunta' 
	from usuarios u inner join pregunta p ON u.users_id = p.users_id where u.username = @username
	order by p.fecha desc
go

create or alter proc cerrar_pregunta
@id int
as
	update pregunta 
	set estado = 0
	where pregunta.quest_id = @id
go


create or alter proc Mipregunta_list_all
@username varchar(150)
as
	select p.quest_id,u.username as 'Usuario', p.titulo as 'Titulo', p.descripcion as 'Descripcion', p.fecha as 'Fecha', case p.estado
		when 1 then 'Abierta'
		when 0 then 'Cerrada'
		else 'Sin especificar'
	end as 'Estado de Pregunta' 
	from usuarios u inner join pregunta p ON u.users_id = p.users_id where u.username = @username
	order by p.fecha desc
go


create or alter proc crear_pregunta
@titulo varchar(150),
@descripcion varchar(500),
@fecha date,
@estado bit,
@username varchar(150)
as 
Declare @id int
select @id = u.users_id from usuarios u  where username = @username
insert into pregunta(titulo, descripcion, fecha, estado, users_id)
values(@titulo, @descripcion, @fecha, @estado, @id);
go




select * from respuesta

create or alter proc crear_respuesta
@descripcion varchar(500),
@fecha date,
@username varchar(150),
@quest_id int 
as 
Declare @id int
select @id = u.users_id from usuarios u  where username = @username
insert into respuesta(descripcion, fecha, users_id, quest_id)
values(@descripcion, @fecha, @id, @quest_id)
go

create or alter proc pregunta_list_all
as
select p.quest_id, u.username as 'Username',p.titulo as 'Titulo', p.descripcion as 'Descrición', p.fecha as 'Fecha de publicación', 
	case p.estado
		when 1 then 'Abierta'
		when 0 then 'Cerrada'
		else 'Sin especificar'
	end as 'Estado de Pregunta'
from pregunta p inner join usuarios u on p.users_id = u.users_id
order by p.fecha desc
go

create or alter proc respuesta_posible
@id int,
@existe bit output
as
declare @valor bit
select @valor=estado from pregunta where quest_id = @id
if @valor = 1
	begin
		set @existe=1
	end
else
	begin
		set @existe=0
	end
go





















