

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