
create table  usuarios(
	users_id int primary key identity,
	first_name varchar(150) not null, 
	last_name varchar(150) not null,
	email varchar(50) not null, 
	username varchar(30) not null, 
	user_psswd varchar(50) not null, 
)
