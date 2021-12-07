--Usuarios INSERTS

insert into usuarios(first_name, last_name, email, username, user_psswd) 
VALUES ('Chris','Contreras','1@gmail.com','chris','1234'), ('Sofi','Clara','2@gmail.com','sofi','1234'), ('salmon','dorado','3@gmail.com','salmon','1234')

---Preguntas INSERTS

insert into pregunta(titulo, descripcion, fecha, estado, users_id) VALUES ('Que es la programacion?', 
'La programación es el proceso utilizado para idear y ordenar las acciones necesarias para realizar un proyecto. 
En la actualidad, la noción de programación se encuentra muy asociada a la creación de aplicaciones de informática y videojuegos.', '2021-10-2', 1, 3)
insert into pregunta(titulo, descripcion, fecha, estado, users_id) VALUES ('Que es un perro?', 
'Jam[as he visto un perro en mi vida, alguien peude explicarme que es un perro, como se ven y como tratarlos. Gracias. ', '2021-11-14', 1, 2)
insert into pregunta(titulo, descripcion, fecha, estado, users_id) VALUES ('Si nosotros contamos ovejas para dormir, ¿qué cuentan los ovejas?', 
'Tengo esta duda existencial, no puedo dormir pensando que si las ovejas tienen problamas al dormir, contaran humanos?', '2020-1-2', 1, 1)
insert into pregunta(titulo, descripcion, fecha, estado, users_id) VALUES ('Donde queda el Banco Credomatic mas cercano a La Gloria', 
'Hola!, debo hacer una transaccion en el banco Credomatic donde puedo hacerla que quede cerca de La Gloria?', '2021-12-2', 1, 2)
insert into pregunta(titulo, descripcion, fecha, estado, users_id) VALUES ('Porque usar C#?', 
'Hola!, estoy entrabndo en el mundo de la programacion y quisiera saber porque usar el lenguaj C# y es que hay demasiados lenguajes y quiero saber por donde empezar', '2021-12-6', 1, 1)

-- Respuestas INSERTS

insert into respuesta(descripcion, fecha, users_id, quest_id) VALUES ('La programación es el proceso utilizado para idear y ordenar las acciones necesarias para realizar un proyecto. 
En la actualidad, la noción de programación se encuentra muy asociada a la creación de aplicaciones de informática y videojuegos.', '2021-10-3', 1, 1), 
('No se que es la programacion googlealo. Espero haberte ayudado', '2021-10-4', 2, 1), ('Un perro es un animal. Comunmente se le conoce por el nombre perro. Saludos.', '2021-11-15', 3, 2),
('Que es un oveja?', '2020-1-3', 3, 3), ('El banco mas cercano a la La Gloria es el que esta en el centro comercial San Luis', '2021-12-3', 1, 4), 
(' C# es un lenguaje diseñado por Microsoft para generar programas sobre la plataforma .NET. Es fruto de una evolución que partió con 
el nacimiento de C, que era un lenguaje en el que se trabajaba con programación estructurada, 
luego apareció C++ que ya permitía la programación orientada a objetos, y por último la evolución dio lugar a C#.', '2021-12-7', 2, 5)