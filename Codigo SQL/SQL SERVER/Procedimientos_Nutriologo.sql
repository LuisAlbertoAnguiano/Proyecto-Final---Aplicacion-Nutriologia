-- Procedimientos de BD_Nutriologo

-- Procedimientos para la tabla Usuario
-- Agregar Usuario
CREATE PROCEDURE sp_AgregarUsuario
@ID SMALLINT,
@Nombre VARCHAR(30),
@Contraseña VARCHAR(MAX)
AS
BEGIN
	INSERT INTO Usuario VALUES (@ID, @Nombre, @Contraseña)
END

-- Procedimientos para la tabla Paciente

CREATE PROCEDURE sp_RegistrarPaciente
@#Paciente SMALLINT,
@Nombre VARCHAR(30),
@ApePaterno VARCHAR(20),
@ApeMaterno VARCHAR(20),
@Sexo VARCHAR(9),
@FechaNacimiento SMALLDATETIME,
@#Contacto VARCHAR(13),
@Email VARCHAR(MAX),
@Usuario_R SMALLINT,
@Usuario_M SMALLINT,
@Estado SMALLINT
AS
BEGIN
    INSERT INTO Paciente VALUES(@#Paciente, @Nombre, @ApePaterno, @ApeMaterno, @Sexo, @FechaNacimiento, 
	@#Contacto, @Email, @Usuario_R, @Usuario_M, @Estado)
END

CREATE PROCEDURE sp_ActualizarPaciente
@#Paciente SMALLINT,
@Nombre VARCHAR(30),
@ApePaterno VARCHAR(20),
@ApeMaterno VARCHAR(20),
@Sexo VARCHAR(9),
@FechaNacimiento SMALLDATETIME,
@#Contacto VARCHAR(13),
@Email VARCHAR(MAX),
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE Paciente SET NombrePaciente=@Nombre, ApellidoPaterno = @ApePaterno,ApellidoMaterno = @ApeMaterno, 
	Sexo=@Sexo, FechaNacimiento=@FechaNacimiento, #Contacto=@#Contacto, Email=@Email, Usuario_M=@Usuario_M 
	WHERE #Paciente=@#Paciente
END

CREATE PROCEDURE sp_EliminarPaciente
@#Paciente SMALLINT,
@Usuario_M SMALLINT,
@Estado SMALLINT
AS
BEGIN
    UPDATE Paciente SET Usuario_M=@Usuario_M, Estado=@Estado 
	WHERE #Paciente=@#Paciente
END

-- Procedimientos para la tabla CategoriaFisica

CREATE PROCEDURE sp_RegistrarC_Fisica
@Id SMALLINT,
@Nombre VARCHAR(MAX),
@Usuario_R SMALLINT,
@Usuario_M SMALLINT
AS
BEGIN
    INSERT INTO CategoriaFisica VALUES(@Id, @Nombre, @Usuario_R, @Usuario_M)
END

CREATE PROCEDURE sp_ActualizarC_Fisica
@Id SMALLINT,
@Nombre VARCHAR(MAX),
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE CategoriaFisica SET NombreCategoria=@Nombre, Usuario_M=@Usuario_M
	WHERE IdCategoria=@Id
END

CREATE PROCEDURE sp_EliminarC_Fisica
@Id SMALLINT
AS
BEGIN
    DELETE FROM CategoriaFisica WHERE IdCategoria=@Id
END

--Procedimientos para la tabla Alimentos

CREATE PROCEDURE sp_RegistrarAlimento
@Id SMALLINT,
@Nombre VARCHAR(MAX),
@Usuario_R SMALLINT,
@Usuario_M SMALLINT
AS
BEGIN
    INSERT INTO Alimentos VALUES(@Id, @Nombre, @Usuario_R, @Usuario_M)
END

CREATE PROCEDURE sp_ActualizarAlimento
@Id SMALLINT,
@Nombre VARCHAR(MAX),
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE Alimentos SET NombreAlimento=@Nombre, Usuario_M=@Usuario_M
	WHERE IdAlimento=@Id
END

CREATE PROCEDURE sp_EliminarAlimento
@Id SMALLINT
AS
BEGIN
    DELETE FROM Alimentos WHERE IdAlimento=@Id
END

-- Procedimientos para la tabla Dietas

CREATE PROCEDURE sp_RegistrarDieta
@Id SMALLINT,
@Nombre VARCHAR(MAX),
@Usuario_R SMALLINT,
@Usuario_M SMALLINT
AS
BEGIN
    INSERT INTO Dietas VALUES(@Id, @Nombre, @Usuario_R, @Usuario_M)
END

CREATE PROCEDURE sp_ActualizarDieta
@Id SMALLINT,
@Nombre VARCHAR(MAX),
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE Dietas SET NombreDieta=@Nombre, Usuario_M=@Usuario_M
	WHERE IdDieta=@Id
END

CREATE PROCEDURE sp_EliminarDieta
@Id SMALLINT
AS
BEGIN
    DELETE FROM Dietas WHERE IdDieta=@Id
END

-- Procedimientos para la tabla Sistemas

CREATE PROCEDURE sp_RegistrarSistema
@Id SMALLINT,
@Nombre VARCHAR(MAX),
@Usuario_R SMALLINT,
@Usuario_M SMALLINT
AS
BEGIN
    INSERT INTO Sistemas VALUES(@Id, @Nombre, @Usuario_R, @Usuario_M)
END

CREATE PROCEDURE sp_ActualizarSistema
@Id SMALLINT,
@Nombre VARCHAR(MAX),
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE Sistemas SET NombreSistema=@Nombre, Usuario_M=@Usuario_M
	WHERE IdSistema=@Id
END

CREATE PROCEDURE sp_EliminarSistema
@Id SMALLINT
AS
BEGIN
    DELETE FROM Sistemas WHERE IdSistema=@Id
END

--Procedimientos para la tabla Act_Fisica

CREATE PROCEDURE sp_RegistrarAct_Fisica
@#Paciente SMALLINT,
@IdCategoria SMALLINT,
@Descripcion VARCHAR(MAX),
@Frecuencia VARCHAR(MAX),
@Usuario_R SMALLINT,
@Usuario_M SMALLINT
AS
BEGIN
    INSERT INTO Act_Fisica VALUES(@#Paciente, @IdCategoria, @Descripcion, @Frecuencia, @Usuario_R, @Usuario_M)
END

CREATE PROCEDURE sp_ActualizarAct_Fisica
@#Paciente SMALLINT,
@IdCategoria SMALLINT,
@Descripcion VARCHAR(MAX),
@Frecuencia VARCHAR(MAX),
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE Act_Fisica SET IdCategoria=@IdCategoria, Descripcion=@Descripcion, Frecuencia=@Frecuencia, 
	Usuario_M=@Usuario_M WHERE #Paciente=@#Paciente
END

CREATE PROCEDURE sp_EliminarAct_Fisica
@#Paciente SMALLINT
AS
BEGIN
    DELETE FROM Act_Fisica WHERE #Paciente=@#Paciente
END

--Procedimientos para la tabla Cita
CREATE PROCEDURE sp_RegistrarCita
@#Paciente SMALLINT,
@#Cita SMALLINT,
@FechaCita SMALLDATETIME,
@Usuario_R SMALLINT,
@Usuario_M SMALLINT
AS
BEGIN
    INSERT INTO Cita VALUES(@#Paciente, @#Cita, @FechaCita, @Usuario_R, @Usuario_M)
END

CREATE PROCEDURE sp_ActualizarCita
@#Paciente SMALLINT,
@#Cita SMALLINT,
@FechaCita SMALLDATETIME,
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE Cita SET FechaCita=@FechaCita, Usuario_M=@Usuario_M
	WHERE #Paciente=@#Paciente AND #Cita=@#Cita
END

CREATE PROCEDURE sp_EliminarCita
@#Paciente SMALLINT,
@#Cita SMALLINT
AS
BEGIN
    DELETE FROM Cita WHERE #Paciente=@#Paciente AND #Cita=@#Cita
END

CREATE PROCEDURE sp_EliminarCita_Total
@#Paciente SMALLINT
AS
BEGIN
    DELETE FROM Cita WHERE #Paciente=@#Paciente
END

-- Procedimientos para la tabla Revision

CREATE PROCEDURE sp_RegistrarRevision
@#Paciente SMALLINT,
@#Revision SMALLINT,
@Peso DECIMAL(5,2),
@Estatura DECIMAL(5,2),
@Cintura DECIMAL(5,2),
@Cadera DECIMAL(5,2),
@IMC DECIMAL(5,2),
@ICC DECIMAL(5,2),
@Usuario_R SMALLINT,
@Usuario_M SMALLINT
AS
BEGIN
    INSERT INTO Revision VALUES(@#Paciente, @#Revision, @Peso, 
	@Estatura, @Cintura,@Cadera, @IMC, @ICC, @Usuario_R, @Usuario_M)
END

CREATE PROCEDURE sp_ActualizarRevision
@#Paciente SMALLINT,
@#Revision SMALLINT,
@Peso DECIMAL(5,2),
@Estatura DECIMAL(5,2),
@Cintura DECIMAL(5,2),
@Cadera DECIMAL(5,2),
@IMC DECIMAL(5,2),
@ICC DECIMAL(5,2),
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE Revision SET Peso=@Peso, Estatura=@Estatura, Cintura=@Cintura, Cadera=@Cadera, IMC=@IMC, 
	ICC=@ICC, Usuario_M=@Usuario_M WHERE #Paciente=@#Paciente AND #Revision=@#Revision
END

CREATE PROCEDURE sp_EliminarRevision
@#Paciente SMALLINT,
@#Revision SMALLINT
AS
BEGIN
    DELETE FROM Revision WHERE #Paciente=@#Paciente AND #Revision=@#Revision
END

CREATE PROCEDURE sp_EliminarRevision_Total
@#Paciente SMALLINT
AS
BEGIN
    DELETE FROM Revision WHERE #Paciente=@#Paciente
END

-- Procedimientos para la tabla Diag_Clinico

CREATE PROCEDURE sp_RegistrarDiag_Clinico
@#Paciente SMALLINT,
@#Diagnostico SMALLINT,
@Enfermedad VARCHAR(MAX),
@Ant_F VARCHAR(MAX),
@Alergia VARCHAR(MAX),
@SintomasD VARCHAR(MAX),
@Signos VARCHAR(MAX),
@Med_Sup VARCHAR(MAX),
@Usuario_R SMALLINT,
@Usuario_M SMALLINT
AS
BEGIN
    INSERT INTO Diag_Clinico VALUES(@#Paciente, @#Diagnostico, @Enfermedad, @Ant_F, @Alergia, 
	@SintomasD, @Signos, @Med_Sup, @Usuario_R, @Usuario_M)
END

CREATE PROCEDURE sp_ActualizarDiag_Clinico
@#Paciente SMALLINT,
@#Diagnostico SMALLINT,
@Enfermedad VARCHAR(MAX),
@Ant_F VARCHAR(MAX),
@Alergia VARCHAR(MAX),
@SintomasD VARCHAR(MAX),
@Signos VARCHAR(MAX),
@Med_Sup VARCHAR(MAX),
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE Diag_Clinico SET Enfermedad=@Enfermedad, AntecedenteFamiliar=@Ant_F, Alergia=@Alergia, 
	SintomasDigestivos=@SintomasD, Signos=@Signos, Medicamentos_Suplementos=@Med_Sup, 
	Usuario_M=@Usuario_M WHERE #Paciente=@#Paciente AND #Diagnostico=@#Diagnostico
END

CREATE PROCEDURE sp_EliminarDiag_Clinico
@#Paciente SMALLINT,
@#Diagnostico SMALLINT
AS
BEGIN
    DELETE FROM Diag_Clinico WHERE #Paciente=@#Paciente AND #Diagnostico=@#Diagnostico
END

CREATE PROCEDURE sp_EliminarDiag_Clinico_Total
@#Paciente SMALLINT
AS
BEGIN
    DELETE FROM Diag_Clinico WHERE #Paciente=@#Paciente
END

-- Procedimientos para la tabla Frec_Alimentaria

CREATE PROCEDURE sp_RegistrarFrec_Alimentaria
@#Paciente SMALLINT,
@IdAlimento SMALLINT,
@Frec_D VARCHAR(30),
@Frec_S VARCHAR(30),
@Especificaciones VARCHAR(30),
@Usuario_R SMALLINT,
@Usuario_M SMALLINT
AS
BEGIN
    INSERT INTO Frec_Alimentaria 
	VALUES(@#Paciente, @IdAlimento, @Frec_D, @Frec_S, @Especificaciones, @Usuario_R, @Usuario_M)
END

CREATE PROCEDURE sp_ActualizarFrec_Alimentaria
@#Paciente SMALLINT,
@IdAlimento SMALLINT,
@Frec_D VARCHAR(30),
@Frec_S VARCHAR(30),
@Especificaciones VARCHAR(30),
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE Frec_Alimentaria SET Frec_Semana=@Frec_D, Frec_Dia=@Frec_S, Especificaciones=@Especificaciones, 
	Usuario_M = @Usuario_M	WHERE #Paciente=@#Paciente AND IdAlimento=@IdAlimento
END

CREATE PROCEDURE sp_EliminarFrec_Alimentaria
@#Paciente SMALLINT,
@IdAlimento SMALLINT
AS
BEGIN
    DELETE FROM Frec_Alimentaria WHERE #Paciente=@#Paciente AND IdAlimento=@IdAlimento
END

CREATE PROCEDURE sp_EliminarFrec_Alimentaria_Total
@#Paciente SMALLINT
AS
BEGIN
    DELETE FROM Frec_Alimentaria WHERE #Paciente=@#Paciente
END

-- Procedimientos para la tabla DietaPaciente

CREATE PROCEDURE sp_RegistrarDieta_Paciente
@#Paciente SMALLINT,
@IdDieta SMALLINT,
@IdSistema SMALLINT,
@KCal DECIMAL(6,2),
@HC DECIMAL(5,2),
@Proteinas DECIMAL(5,2),
@Lipidos DECIMAL(5,2),
@Notas VARCHAR(MAX),
@Usuario_R SMALLINT,
@Usuario_M SMALLINT
AS
BEGIN
    INSERT INTO DietaPaciente VALUES(@#Paciente, @IdDieta, @IdSistema, @KCal, @HC, @Proteinas, @Lipidos, 
	@Notas, @Usuario_R, @Usuario_M)
END

CREATE PROCEDURE sp_ActualizarDieta_Paciente
@#Paciente SMALLINT,
@IdDieta SMALLINT,
@IdSistema SMALLINT,
@KCal DECIMAL(6,2),
@HC DECIMAL(5,2),
@Proteinas DECIMAL(5,2),
@Lipidos DECIMAL(5,2),
@Notas VARCHAR(MAX),
@Usuario_M SMALLINT
AS
BEGIN
    UPDATE DietaPaciente SET IdDieta=@IdDieta, IdSistema=@IdSistema, KCal=@KCal, HC=@HC, 
	Proteinas=@Proteinas, Lipidos=@Lipidos, Notas=@Notas, Usuario_M = @Usuario_M 
	WHERE #Paciente=@#Paciente
END

CREATE PROCEDURE sp_EliminarDieta_Paciente
@#Paciente SMALLINT
AS
BEGIN
    DELETE FROM DietaPaciente WHERE #Paciente=@#Paciente
END

--Creacion de Vistas
--Vista Categorias Fisicas
CREATE VIEW View_MostrarCategoriaFisica
AS
	SELECT IdCategoria AS 'ID', NombreCategoria AS 'Nombre'
	FROM CategoriaFisica

--Vista Alimentos
CREATE VIEW View_MostrarAlimentos
AS
	SELECT IdAlimento AS 'ID', NombreAlimento AS 'Nombre'
	FROM Alimentos

--Vista Dietas
CREATE VIEW View_MostrarDietas
AS
	SELECT IdDieta AS 'ID', NombreDieta AS 'Nombre'
	FROM Dietas

--Vista Sistemas
CREATE VIEW View_MostrarSistemas
AS
	SELECT IdSistema AS 'ID', NombreSistema AS 'Nombre'
	FROM Sistemas

SELECT * FROM View_MostrarAlimentos

-- Vista de la tabla Pacientes
CREATE VIEW View_MostrarPacientes
AS
	SELECT #Paciente, NombrePaciente AS 'Nombre', ApellidoPaterno AS 'Apellido paterno',
	ApellidoMaterno AS 'Apellido materno', Sexo, CONVERT (VARCHAR(10), FechaNacimiento, 103) AS 'Fecha de nacimiento',
	#Contacto, Email AS 'Correo Electronico'
	FROM Paciente
	WHERE Estado = 1

SELECT * FROM View_MostrarPacientes

--Vista de Actividad fisica
Create View View_ActividadFisica
AS
    SELECT P.NombrePaciente + ' ' + P.ApellidoPaterno + ' ' + P.ApellidoMaterno AS Paciente, CA.IdCategoria AS 'ID Categoria', CA.NombreCategoria AS 'Categoria Fisica', AF.Descripcion, AF.Frecuencia
	FROM Paciente AS P, Act_Fisica AS AF, CategoriaFisica AS CA
	WHERE P.#Paciente=AF.#Paciente AND AF.IdCategoria=CA.IdCategoria

SELECT * FROM View_ActividadFisica

--Vista de Citas
CREATE VIEW View_Citas
AS
    SELECT P.NombrePaciente + ' ' + P.ApellidoPaterno + ' ' + P.ApellidoMaterno AS Paciente, C.#Cita, CONVERT (VARCHAR(10), C.FechaCita, 103) AS 'Fecha de la cita'
	--SUBSTRING (CONVERT (VARCHAR, C.HoraInicial,108),1,5) AS 'Hora inicial', 
	--SUBSTRING (CONVERT (VARCHAR, C.HoraFinal,108),1,5) AS 'Hora final'
	FROM Cita AS C, Paciente AS P
	WHERE P.#Paciente=C.#Paciente

SELECT * FROM View_Citas

-- Procedimientos de consultas

-- Consultar la actividad fisica de un paciente

CREATE PROCEDURE sp_Consultar_Actividad_Fisica
@#Paciente SMALLINT
AS
BEGIN
    SELECT P.NombrePaciente + ' ' + P.ApellidoPaterno + ' ' + P.ApellidoMaterno AS Paciente, CA.IdCategoria AS 'ID Categoria', CA.NombreCategoria AS 'Categoria Fisica', AF.Descripcion, AF.Frecuencia
	FROM Paciente AS P, Act_Fisica AS AF, CategoriaFisica AS CA
	WHERE P.#Paciente=@#Paciente AND P.#Paciente=AF.#Paciente AND AF.IdCategoria=CA.IdCategoria AND P.Estado = 1
END

EXECUTE sp_Consultar_Actividad_Fisica 1

--Consultar citas del paciente

CREATE PROCEDURE sp_Consultar_Citas
@#Paciente SMALLINT
AS
BEGIN
    SELECT P.NombrePaciente + ' ' + P.ApellidoPaterno + ' ' + P.ApellidoMaterno AS Paciente, C.#Cita, CONVERT (VARCHAR(10), C.FechaCita, 103) AS 'Fecha de la cita'
	--SUBSTRING (CONVERT (VARCHAR, C.HoraInicial,108),1,5) AS 'Hora inicial', 
	--SUBSTRING (CONVERT (VARCHAR, C.HoraFinal,108),1,5) AS 'Hora final'
	FROM Cita AS C, Paciente AS P
	WHERE P.#Paciente=@#Paciente AND P.#Paciente=C.#Paciente AND P.Estado = 1
END

EXECUTE sp_Consultar_Citas 1

-- Consultar Revision del paciente

CREATE PROCEDURE sp_Consultar_Revision
@#Paciente SMALLINT
AS
BEGIN
    SELECT P.NombrePaciente + ' ' + P.ApellidoPaterno + ' ' + P.ApellidoMaterno AS Paciente, R.#Revision, 
	R.Peso, R.Estatura, R.Cintura, R.Cadera, R.IMC, R.ICC
	FROM Paciente AS P, Revision AS R
	WHERE P.#Paciente=@#Paciente AND P.#Paciente=R.#Paciente AND P.Estado = 1
END

EXECUTE sp_Consultar_Revision 1

-- Consultar Diagnostico Clinico del paciente

CREATE PROCEDURE sp_Consultar_Diagnostico_Clinico
@#Paciente SMALLINT
AS
BEGIN
    SELECT P.NombrePaciente + ' ' + P.ApellidoPaterno + ' ' + P.ApellidoMaterno AS Paciente, DC.#Diagnostico, DC.Enfermedad, DC.AntecedenteFamiliar, DC.Alergia, 
	DC.SintomasDigestivos, DC.Signos, DC.Medicamentos_Suplementos
	FROM Paciente AS P, Diag_Clinico AS DC
	WHERE P.#Paciente=@#Paciente AND P.#Paciente=DC.#Paciente AND P.Estado = 1
END

EXECUTE sp_Consultar_Diagnostico_Clinico 1

--Consultar la frecuencia alimentaria del paciente

CREATE PROCEDURE sp_Consultar_Frecuencia_Alimentaria
@#Paciente SMALLINT
AS
BEGIN
    SELECT FA.IdAlimento, A.NombreAlimento AS Alimento, FA.Frec_Semana AS 'Frecuencia Semanal', FA.Frec_Dia AS 'Frecuencia Diaria', FA.Especificaciones
    FROM Frec_Alimentaria AS FA, Alimentos AS A, Paciente AS P
    WHERE FA.#Paciente=@#Paciente AND FA.IdAlimento=A.IdAlimento AND P.Estado = 1
END

EXECUTE sp_Consultar_Frecuencia_Alimentaria 6


-- Consultar la dieta del paciente

CREATE PROCEDURE sp_Consultar_Dieta_Paciente
@#Paciente SMALLINT
AS
BEGIN
    SELECT P.NombrePaciente + ' ' + P.ApellidoPaterno + ' ' + P.ApellidoMaterno AS Paciente, D.IdDieta, S.IdSistema, DP.KCal, DP.HC AS 'Hidratos de Carbono', 
	DP.Proteinas, DP.Lipidos
	FROM Paciente AS P, DietaPaciente AS DP, Dietas AS D, Sistemas AS S
	WHERE P.#Paciente=@#Paciente AND @#Paciente=DP.#Paciente AND DP.IdDieta=D.IdDieta AND DP.IdSistema=S.IdSistema AND P.Estado = 1
END

EXECUTE sp_Consultar_Dieta_Paciente 1

SELECT NombrePaciente + ' ' + ApellidoPaterno + ' ' + ApellidoMaterno AS Paciente FROM Paciente WHERE #Paciente = 1


