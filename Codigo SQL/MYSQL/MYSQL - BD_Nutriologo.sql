--Codigo MySQL
CREATE DATABASE BD_Nutriologo;

USE BD_Nutriologo;

-- Creacion de las tablas
CREATE TABLE 'Usuario'(
'ID_Usuario' SMALLINT PRIMARY KEY,
'Nombre' VARCHAR(30) NOT NULL,
'Contraseña' VARCHAR(MAX) NOT NULL);

CREATE TABLE 'Paciente'(
'#Paciente' SMALLINT PRIMARY KEY,
'NombrePaciente' VARCHAR(30) NOT NULL,
'ApellidoPaterno' VARCHAR(20) NOT NULL,
'ApellidoMaterno' VARCHAR(20) NOT NULL,
'Sexo' VARCHAR(9) NOT NULL,
'FechaNacimiento' SMALLDATETIME NOT NULL,
'#Contacto' VARCHAR(13) NOT NULL,
'Email' VARCHAR(MAX) NOT NULL,
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'),
'Estado' SMALLINT NOT NULL);

CREATE TABLE 'CategoriaFisica'(
'IdCategoria' SMALLINT PRIMARY KEY,
'NombreCategoria' VARCHAR(MAX) NOT NULL,
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'));

CREATE TABLE 'Alimentos'(
'IdAlimento' SMALLINT PRIMARY KEY,
'NombreAlimento' VARCHAR(MAX) NOT NULL,
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'));

CREATE TABLE 'Dietas'(
'IdDieta' SMALLINT PRIMARY KEY,
'NombreDieta' VARCHAR(MAX) NOT NULL,
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'));

CREATE TABLE 'Sistemas'(
'IdSistema' SMALLINT PRIMARY KEY,
'NombreSistema' VARCHAR(MAX) NOT NULL,
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'));

CREATE TABLE 'Act_Fisica'(
'#Paciente' SMALLINT REFERENCES 'Paciente'('#Paciente'),
'IdCategoria' SMALLINT REFERENCES 'CategoriaFisica'('IdCategoria'),
'Descripcion' VARCHAR(MAX) NOT NULL,
'Frecuencia' VARCHAR(MAX) NOT NULL,
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'),
PRIMARY KEY ('#Paciente', 'IdCategoria'));

CREATE TABLE 'Cita'(
'#Paciente' SMALLINT REFERENCES 'Paciente'('#Paciente'),
'#Cita' SMALLINT,
'FechaCita' SMALLDATETIME,
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'),
PRIMARY KEY ('#Paciente', '#Cita'));

CREATE TABLE 'Revision'(
'#Paciente' SMALLINT REFERENCES 'Paciente'('#Paciente'),
'#Revision' SMALLINT NOT NULL,
'Peso' DECIMAL(5,2),
'Estatura' DECIMAL(5,2),
'Cintura' DECIMAL(5,2),
'Cadera' DECIMAL(5,2),
'IMC' DECIMAL(5,2),
'ICC' DECIMAL(5,2),
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'),
PRIMARY KEY ('#Paciente', '#Revision'));

CREATE TABLE 'Diag_Clinico'(
'#Paciente' SMALLINT REFERENCES 'Paciente'('#Paciente'),
'#Diagnostico' SMALLINT,
'Enfermedad' VARCHAR(MAX),
'AntecedenteFamiliar' VARCHAR(MAX),
'Alergia' VARCHAR(MAX),
'SintomasDigestivos' VARCHAR(MAX),
'Signos' VARCHAR(MAX),
'Medicamentos_Suplementos' VARCHAR(MAX),
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'),
PRIMARY KEY ('#Paciente', '#Diagnostico'));

CREATE TABLE 'Frec_Alimentaria'(
'#Paciente' SMALLINT REFERENCES 'Paciente'('#Paciente'),
'IdAlimento' SMALLINT REFERENCES 'Alimentos'('IdAlimento'),
'Frec_Semana' VARCHAR(30),
'Frec_Dia' VARCHAR(30),
'Especificaciones' VARCHAR(30),
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'),
PRIMARY KEY ('#Paciente', 'IdAlimento'));

CREATE TABLE 'DietaPaciente'(
'#Paciente' SMALLINT REFERENCES 'Paciente'('#Paciente'),
'IdDieta' SMALLINT REFERENCES 'Dietas'('IdDieta'),
'IdSistema' SMALLINT FOREIGN KEY REFERENCES 'Sistemas'('IdSistema'),
'KCal' DECIMAL(6,2) NOT NULL,
'HC' DECIMAL(5,2) NOT NULL,
'Proteinas' DECIMAL(5,2) NOT NULL,
'Lipidos' DECIMAL(5,2) NOT NULL,
'Notas' VARCHAR(MAX),
'Usuario_R' SMALLINT REFERENCES 'Usuario'('ID_Usuario') NOT NULL,
'Usuario_M' SMALLINT REFERENCES 'Usuario'('ID_Usuario'),
PRIMARY KEY ('#Paciente', 'IdDieta'));