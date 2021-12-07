create table  usuarios(
	users_id int primary key identity,
	first_name varchar(150) not null, 
	last_name varchar(150) not null,
	email varchar(50) not null, 
	username varchar(30) not null, 
	user_psswd varchar(50) not null, 
)

create table respuesta(
	answer_id int primary key identity, 
	descripcion varchar(500) not null, 
	fecha date not null, 
	users_id int not null, 
	quest_id int not null,
	foreign key (users_id) references usuarios(users_id),
	foreign key (quest_id) references pregunta(quest_id)
)

create table pregunta(
	quest_id int primary key identity, 
	titulo varchar(150) not null,
	descripcion varchar(500) not null,
	fecha date not null, 
	estado bit not null,
	users_id int not null, 
	
	foreign key (users_id) references usuarios(users_id)
)


