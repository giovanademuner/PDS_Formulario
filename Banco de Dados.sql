CREATE DATABASE app_contato_bd;
USE app_contato_bd;

CREATE TABLE contato(
 id_con INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
 nome_con VARCHAR(100) NOT NULL,
 data_nasc_con DATE NOT NULL,
 sexo_con VARCHAR(30) NOT NULL,
 email_con VARCHAR(30) NOT NULL,
 telefone_con VARCHAR(30) NOT NULL
 );
 insert into Contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (1, 'Hendrik', '2023-01-13', 'Male', 'hhalfhide0@abc.net.au', '818-482-3164');
insert into Contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (2, 'Carroll', '2022-05-23', 'Female', 'cfick1@princeton.edu', '284-413-4410');
insert into Contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (3, 'Rodrick', '2023-02-06', 'Male', 'rstrachan2@foxnews.com', '374-941-8828');
insert into Contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (4, 'Thedric', '2022-11-07', 'Male', 'tblaxlande3@g.co', '586-955-0716');
insert into Contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (5, 'Elonore', '2022-04-07', 'Female', 'equarlis4@discovery.com', '478-132-1102');
insert into Contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (6, 'Cosetta', '2022-05-09', 'Female', 'cstoves5@ezinearticles.com', '408-131-3740');
insert into Contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (7, 'Warde', '2022-11-23', 'Male', 'whankard6@merriam-webster.com', '723-585-4813');
insert into Contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (8, 'Arte', '2022-08-13', 'Male', 'aabbyss7@who.int', '715-571-7367');
insert into Contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (9, 'Ardra', '2023-02-16', 'Female', 'acockburn8@unc.edu', '319-931-6221');
insert into Contato (id_con, nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values (10, 'Ludovico', '2022-11-30', 'Male', 'lgagie9@xing.com', '940-424-8784');

select * from contato;