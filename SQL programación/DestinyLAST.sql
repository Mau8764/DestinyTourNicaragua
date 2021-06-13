USE Destiny
GO


-- Procedimiento almacenado para insertar clientes en su respectiva tabla.
CREATE PROCEDURE SP_InsertarClientePersona
@Cedula varchar(20),
@Correo_Electronico nvarchar(50),
@Nombre VARCHAR(50),
@Sexo BIT,
@Edad Int,
@Telefono NVARCHARf(8)
AS
BEGIN
INSERT INTO Persona(Cedula,Nombre,Sexo,Edad,Telefono) VALUES (@Cedula,@Nombre,@Sexo,@Edad,@Telefono)

INSERT INTO Cliente (Cedula, Correo_Electronico) Values(@Cedula, @Correo_Electronico)

END
GO

EXEC	[dbo].[SP_InsertarClientePersona]
		'201-190390-0008L',
		'griseldalopez@gmail.com',
		'Griselda Alexandra Lopez',
		1,
		29,
		'5501-3920'
GO

EXEC	[dbo].[SP_InsertarClientePersona]
		'001-081170-006H',
		'brenda_madrigal@yahoo.com',
		'Brenda Madrigal',
		1,
		49,
		'8519-5876'
GO

EXEC	[dbo].[SP_InsertarClientePersona]
		'001-081197-0008K',
		'solorzanojulia@yahoo.es',
		'Julia Solorzano',
		1,
		22,
		'8871-1547'
GO

EXEC	[dbo].[SP_InsertarClientePersona]
		'401-131090-0002C',
		'l_ortega22@gmail.com',
		'Luis Carlos Ortega',
		0,
		29,
		'8985-1040'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		' 001-150298-1000K',
		'mari56rmorales@gmail.com',
		'Maritza del Socorro Rivas Hernandez',
		1,
		21,
		'8263-5456'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'402-200895-0000C',
		'Carlo79*hernandez@gmail.com',
		'Roberto Carlos Hernandez',
		0,
		24,
		'5525-5699'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-130286-0003U',
		'anap_002@gmail.com',
		'Ana Gabriela Putoy Ruiz',
		1,
		39,
		'7895-6622'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-060683-2224D',
		'srrr1@gmail.com',
		'Scarleth Raquel Ruiz Rojas',
		1,
		36,
		'8990-5423'

EXEC	[dbo].[SP_InsertarClientePersona]
		'001-060673-2224D',
		'albamm@gmail.com',
		'Alba Martha Martinez Canda',
		1,
		46,
		'8990-5423'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-201182-0061D',
		'trochal_2@gmail.com',
		'Juan Antonio Trocha Lopez',
		0,
		37,
		'8665-3010'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-030488-0052D',
		'neto_sanchez*2@hotmail.es',
		'Ernesto David Sanchez',
		0,
		31,
		'7588-1223'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'568-300192-1000M',
		'jlcg34@yahoo.com',
		'Jose Luis Cortez Gonzales',
		0,
		27,
		'8898-3214'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'401-190899-0008X',
		 'alexlli12@hotmail.com',
		'Gemalli Alexandra Rodriguez',
		1,
		20,
		'8299-6355'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-080397-0024M',
		 'chamorroitzayana@outlook.com',
		'Eneyda Itzayana Chamorro Garcia',
		1,
		22,
		'7545-6887'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-100985-0006J',
		 'oniceortiz@yahoo.es',
		'Onice del carmen Chavarria Ortiz',
		1,
		34,
		'5425-8100'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'402-170289-0000M',
		 'anitarodrig@gmail.com',
		'Ana Heyling Rodriguez',
		1,
		30,
		'5876-8022'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-280495-0059C',
		 'eliborgemartin@hotmail.com',
		'Maricela Elizabeth Borge Martin',
		1,
		25,
		'8995-4727'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'402-141199-1003E',
		 'palacios_canda@hotmail.com',
		'Milton Eliezer Canda Palacios',
		0,
		20,
		'5814-5478'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-110987-0083U',
		 'emmuñoz447@outlook.com',
		'Emilio Isaac Muñoz Alvarez',
		0,
		32,
		'8852-1364'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'007-171297-1000W',
		 'hazielgomezu@hotmail.com',
		'Mateo Haziel Diaz Gomez',
		0,
		22,
		'8794-8562'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'041-070191-0003L',
		 'luisxamora@gmail.com',
		'Luis Manuel Urbina Zamora',
		0,
		28,
		'8691-4327'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'281-061171-0001R',
		 'alejandro_miguel@gmail.com',
		'Kevin Alejandro Roa',
		0,
		48,
		'8516-4239'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-031086-0052D',
		 'julimonte@hotmail.com',
		'Briana Julissa Cordobas Fargas',
		1,
		33,
		'8833-4970'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-201982-0061Q',
		 'jeanmarrostran@hotmail.com',
		'Jean Carlos Martinez Rostran',
		0,
		37,
		'8856-3871'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'161-021092-0011G',
		 'padillamartinez@yahoo.com',
		'Maria Graciela Padilla Martinez',
		1,
		27,
		'5587-9632'
GO
---------------------------------------------------Clientes que rentan vehiculo-----------------------------------------
EXEC	[dbo].[SP_InsertarClientePersona]
		'081-150462-0001J',
		 'caballeroester@yahoo.com',
		'Esther Gomez Caballero',
		1,
		57,
		'8896-5417'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-181070-0006Y',
		 'markantony_cabrera@gmail.com',
		'Marcos Antonio Cabrera',
		0,
		49,
		'5964-8732'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'441-040767-0005J',
		 'alejandroruiz@gmail.com',
		'Alejandro Marti Ruiz',
		0,
		52,
		'7868-5321'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'281-141161-0007N',
		 'hidalgoparra@outlook.com',
		'Adrián Hidalgo Parra',
		0,
		58,
		'8278-1899'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-260672-0003Y',
		 'chepehernandez@yahoo.es',
		'José Vazquez Hernandez',
		0,
		47,
		'777-5002'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-240582-0001M',
		 'sarinuñez@hotmail.com',
		'Sara Gonzalez Nuñez',
		1,
		37,
		'8956-3274'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'441-011070-0006Y',
		 'guerrero_navarro@gmail.com',
		'Noelia Guerrero Navarro',
		1,
		49,
		'7895-1234'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-110761-0052D',
		 'adrianamuñoz@outlook.com',
		'Adriana Muñoz Carrasco',
		1,
		58,
		'8412-6549'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-050269-2224D',
		 'alexnieto@gmail.com',
		'Alexandra Garcia Nieto',
		1,
		50,
		'5841-2697'
GO
EXEC	[dbo].[SP_InsertarClientePersona]
		'001-160671-0008X',
		 'lozanomendez@hotmail.com',
		'Alejandro Lozano Mendez',
		0,
		48,
		'7842-1563'
GO
	
--Consulta: Datos de los clientes 
SELECT Persona.Cedula, Persona.Nombre, IIF(Persona.Sexo=0,'M','F') as Sexo, 
Edad,Telefono,Correo_Electronico 
FROM Persona INNER JOIN Cliente ON Persona.Cedula = Cliente.Cedula
GO


--Procedimiento para eliminar cliente
CREATE  PROCEDURE  SP_EliminarClientePersona
@Cedula varchar(20)
AS
DELETE FROM Cliente WHERE Cedula = @Cedula
GO 

EXEC SP_EliminarClientePersona  '201-190390-008G'
GO
----------------------------------------------------------------------------------------
--Procedimiento para eliminar persona
CREATE  PROCEDURE  SP_EliminarPersona
@Cedula varchar(20)
AS
DELETE FROM Persona WHERE Cedula = @Cedula
GO 

EXEC SP_EliminarPersona  '201-190390-0008L'
EXEC SP_EliminarPersona  	'001-081170-006H'
EXEC SP_EliminarPersona  '001-081197-0008K'
EXEC SP_EliminarPersona  '401-131090-0002C'
EXEC SP_EliminarPersona  ' 001-150298-1000K'
EXEC SP_EliminarPersona  '402-200895-0000C'
EXEC SP_EliminarPersona  '001-130286-0003U'
EXEC SP_EliminarPersona  '001-060683-2224D'
EXEC SP_EliminarPersona  '001-060673-2224D'
GO
SELECT * FROM persona
	
SELECT Persona.Cedula, Persona.Nombre, IIF(Persona.Sexo=0,'F','M') as Sexo, 
Edad,Telefono,Correo_Electronico 
FROM Persona INNER JOIN Cliente ON Persona.Cedula = Cliente.Cedula

GO
----------------------------------------------------------------------------


--Procedimiento para Insertar Tour 
CREATE PROCEDURE SP_InsertarTour
@NombreTour VARCHAR(50),
@Hora_Salida TIME,
@Hora_Regreso TIME,
@Fecha_Tour DATE,
@Tipo_Tour BIT,
@Nombre_Institucion NVARCHAR(50)
AS
BEGIN

INSERT INTO Tour_Nacional (NombreTour,Hora_Salida,Hora_Regreso,Fecha_Tour,Tipo_Tour,Nombre_Institucion) 
VALUES (@NombreTour, @Hora_Salida,@Hora_Regreso,@Fecha_Tour,@Tipo_Tour,@Nombre_Institucion)

END
GO
-- Ejemplo de Insertar Tour
EXEC SP_InsertarTour 'Macizo de Peñas Blancas','05:00','20:00','2019-07-14', 0,null  --adultos 32 niños 30--
EXEC SP_InsertarTour 'Flor de Caña y Cerro Negro','05:00','20:00','2019-07-14', 1,'Universidad Americana' --33 dolares-
EXEC SP_InsertarTour 'Ometepe','04:00','20:00','2019-07-21', 0,null 
EXEC SP_InsertarTour 'Treecasa','05:00','20:00','2019-07-21', 0,null 
GO

-----------------Consulta tour privados y publicos-----------------------------------------
SELECT IdTour,CONVERT(char(5),Hora_Salida) as Hora_Salida, CONVERT(char(5),Hora_Regreso) as Hora_Regreso,Fecha_Tour,NombreTour,IIF(Tipo_Tour=0,'Tour Publico','Tour Privado') as TipoTour, IIF(Nombre_Institucion IS NULL,'',Nombre_Institucion) as 'Nombre_Institucion'
FROM Tour_Nacional
GO

--------------------------Procedimiento para insertar Lugar
CREATE PROCEDURE SP_InsertarLugar(
@Nombre_Lugar NVARCHAR(100))
AS
BEGIN
	INSERT INTO Lugares(Nombre_Lugar) VALUES (@Nombre_Lugar)
END
GO
-- Ejemplo de Insertar Lugar
EXEC SP_InsertarLugar 'Reserva Macizo de Peñas Blancas'
EXEC SP_InsertarLugar 'Cascada Arcoiris'
EXEC SP_InsertarLugar 'Santuario de Arboles Gigantes'
EXEC SP_InsertarLugar  'Sendero El Sonoro'
EXEC SP_InsertarLugar  'Reserva Flor de Caña'
EXEC SP_InsertarLugar  'Caseron en Leon'
EXEC SP_InsertarLugar  ' Volcan Cerro Negro'
EXEC SP_InsertarLugar  'Quesillos Nagarote'
EXEC SP_InsertarLugar  'Quesillos Acacia'
EXEC SP_InsertarLugar  'San jorge'
EXEC SP_InsertarLugar  'Isla de Ometepe'
EXEC SP_InsertarLugar  'Punta Jesus Maria'
EXEC SP_InsertarLugar  'Charco Verde'
EXEC SP_InsertarLugar  'Mariposario'
EXEC SP_InsertarLugar  'Ojo de Agua'
EXEC SP_InsertarLugar  'Cascada San Ramon'
EXEC SP_InsertarLugar  'Hotel Finca Santo Domingo'
EXEC SP_InsertarLugar  'Bahia de San Juan del Sur'
EXEC SP_InsertarLugar  'Mirador El Cristo'
EXEC SP_InsertarLugar  'Hotel Treecasa'



GO
--Change identity number  
DBCC CHECKIDENT ('Lugares', RESEED, 9);  
GO  

select * from Lugares


------------Procedimiento para asignar lugares a un tour----------------
GO
CREATE PROCEDURE SP_InsertaTourLugar(
@IdTour INT,
@Id_Lugar INT)
AS
BEGIN
  INSERT INTO Lugar_Tour(IdTour,Id_Lugar) VALUES (@IdTour,@Id_Lugar)

END
GO
EXEC  SP_InsertaTourLugar 1,1
EXEC  SP_InsertaTourLugar 1,2
EXEC  SP_InsertaTourLugar 1,3
EXEC  SP_InsertaTourLugar 1,4
EXEC  SP_InsertaTourLugar 2,5
EXEC  SP_InsertaTourLugar 2,6
EXEC  SP_InsertaTourLugar 2,7
EXEC  SP_InsertaTourLugar 2,8
EXEC  SP_InsertaTourLugar 2,9
EXEC  SP_InsertaTourLugar 3,10
EXEC  SP_InsertaTourLugar 3,11
EXEC  SP_InsertaTourLugar 3,12
EXEC  SP_InsertaTourLugar 3,13
EXEC  SP_InsertaTourLugar 3,14
EXEC  SP_InsertaTourLugar 3,15
EXEC  SP_InsertaTourLugar 3,16
EXEC  SP_InsertaTourLugar 3,17
EXEC  SP_InsertaTourLugar 4,18
EXEC  SP_InsertaTourLugar 4,19
EXEC  SP_InsertaTourLugar 4,20




GO


SELECT TN.IdTour , CONVERT(char(5),Hora_Salida) as Hora_Salida,CONVERT(char(5),Hora_Regreso) as Hora_Regreso,Fecha_Tour, NombreTour,IIF(Tipo_Tour=0,'Tour Publico','Tour Privado') as Tipo_Tour,Nombre_Institucion,Nombre_Lugar
FROM Tour_Nacional AS TN INNER JOIN Lugar_Tour AS LT ON TN.IdTour = LT.IdTour
INNER JOIN Lugares AS L ON LT.Id_Lugar = L.Id_Lugar

-----CONSULTA INFORMACION DEL TOUR CON SUS RESPECTIVOS LUGARES A VISITAR------------------------------
select MAX(TN.NombreTour) AS 'Nombre del Tour', MAX(TN.Fecha_Tour) as Fecha_Tour, MAX(CONVERT(char(5),Hora_Salida)) as Hora_Salida,MAX(CONVERT(char(5),Hora_Regreso)) as Hora_Regreso,MAX(IIF(Tipo_Tour=0,'Tour Publico','Tour Privado')) as Tipo_Tour,MAX(Nombre_Institucion) AS Institucion, COUNT(*) AS 'Cantidad de Lugares a visitar'
    ,STUFF((
        select ', ' + [Nombre_Lugar]
        from Lugar_Tour AS t1 INNER JOIN Lugares ON t1.Id_Lugar = Lugares.Id_Lugar
        where t1.IdTour = t.IdTour
        for xml path(''), type
    ).value('.', 'varchar(max)'), 1, 1, '') AS Lugares
from Lugar_Tour AS t INNER JOIN Tour_Nacional as TN ON t.IdTour = TN.IdTour
INNER JOIN Lugares AS L ON t.Id_Lugar = L.Id_Lugar
group by t.IdTour
--------------------------------------------------------------------------------------------------------------
SELECT * FROM Lugares 

SELECT *
FROM Tour_Nacional AS TN INNER JOIN Lugar_Tour AS LT ON TN.IdTour = LT.IdTour
INNER JOIN Lugares AS L ON LT.Id_Lugar = L.Id_Lugar


GO


---------------------Procedimiento para Insertar Idioma--------------------------
CREATE PROCEDURE SP_InsertarIdioma(
	@NombreIdioma NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO Idioma (Nombre_Idioma) VALUES (@NombreIdioma)
END
GO
-- Ejemplo de Insertar idioma
EXEC SP_InsertarIdioma 'Inglés'
GO

-- Procedimiento para Insertar ChoferCoster
CREATE PROCEDURE SP_InsertaChofer(
@Fecha DATETIME,
@Cedula VARCHAR(16),
@Nombre VARCHAR(50),
@CantidadCoster INT,
@Capacidad INT
)
AS
BEGIN
	INSERT INTO ChoferCoster (Fecha,CedulaChofer,NombreChofer,CantidadCoster,Capacidad) VALUES (@Fecha,@Cedula,@Nombre,@CantidadCoster,@Capacidad)
END
GO
-- Ejemplo de procedimiento para insertar Chofer
EXEC SP_InsertaChofer '','','',0,20
GO

-- Procedimiento para Insertar Hotel
CREATE PROCEDURE SP_InsertaHotel(
@Fecha_Ingreso DATETIME,
@Edad_Persona INT,
@Fecha_Salida DATETIME,
@Cantidad_Persona INT,
@Fecha_Reserva DATETIME,
@Tipo_Habitacion NVARCHAR(50),
@Numero_Habitacion INT,
@Regimen NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO Hotel (Fecha_Ingreso,Edad_Persona,Fecha_Salida,
	Cantidad_Persona,Fecha_Reserva,Tipo_Habitacion,Numero_Habitacion,Regimen) VALUES (
	@Fecha_Ingreso,@Edad_Persona,@Fecha_Salida,@Cantidad_Persona,@Fecha_Reserva,
	@Tipo_Habitacion,@Numero_Habitacion,@Regimen)
END
GO
-- Ejemplo de inserción de hotel

-- Procedimiento para Insertar Renta de vehiculo
CREATE PROCEDURE SP_InsertaRentaVehiculo(
@Cantidad_dia INT,
@Tipo_carro NVARCHAR(20),
@Fecha_renta DATETIME,
@Fecha_devolucion DATETIME,
@Placa NVARCHAR(20)
)
AS
BEGIN
	INSERT INTO Renta_Vehiculo	(Cantidad_dia,Tipo_carro,Fecha_renta,Fecha_devolucion,Placa) values (@Cantidad_dia,@Tipo_carro,@Fecha_renta,@Fecha_devolucion,@Placa )
END
GO

-- Procedimiento para insertar boleto aereo
CREATE PROCEDURE SP_InsertaBoletoAereo(
@Destino NVARCHAR(50),
@Fecha_Ida DATETIME,
@Tarifa FLOAT,
@Fecha_Regreso DATETIME,
@Linea_Aerea NVARCHAR(50),
@Cabina_Avion NVARCHAR(30)
)
AS
BEGIN
	INSERT INTO Boleto_Aereo (Destino,Fecha_Ida,Tarifa,Fecha_Regreso,Linea_Aerea,Cabina_Avion) VALUES 
	(@Destino,@Fecha_Ida,@Tarifa,@Fecha_Regreso,@Linea_Aerea,@Cabina_Avion)
END
GO

-- Procedimiento para insertar Hotel
CREATE PROCEDURE SP_InsertaHotel(
@Fecha_Ingreso DATETIME,
@Edad_Persona INT,
@Fecha_Salida DATETIME,
@Cantidad_Persona INT,
@Fecha_Reserva DATETIME,
@Tipo_Habitacion NVARCHAR(50),
@Numero_Habitacion INT,
@Regimen NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO Hotel (Fecha_Ingreso,Edad_Persona,Fecha_Salida,Cantidad_Persona,Fecha_Reserva,Tipo_Habitacion,Numero_Habitacion,Regimen)
	VALUES (@Fecha_Ingreso,@Edad_Persona,@Fecha_Salida,@Cantidad_Persona,@Fecha_Reserva,@Tipo_Habitacion,@Numero_Habitacion,@Regimen)
END
GO

-- Procedimiento para insertar Renta Vehiculo
CREATE PROCEDURE SP_InsertaRentaVehiculo(
@Cantidad_dia INT,
@Tipo_Carro NVARCHAR(20),
@Fecha_renta DATETIME,
@Fecha_devolucion DATETIME,
@Placa NVARCHAR(20)
)
AS
BEGIN
	INSERT INTO Renta_Vehiculo (Cantidad_dia,Tipo_Carro,Fecha_renta,Fecha_devolucion,Placa)
	VALUES (@Cantidad_dia,@Tipo_Carro,@Fecha_renta,@Fecha_devolucion,@Placa)
END
GO

-- Procedimiento para insertar Seguro viaje
CREATE PROCEDURE SP_InsertaSeguroViaje(
@Pasaporte NVARCHAR(50),
@Destino NVARCHAR(100),
@Fecha_Ida DATETIME,
@Fecha_Regreso DATETIME,
@ContactoEmergencia NVARCHAR(100),
@TelefonoEmergencia NVARCHAR(15)
)
AS
BEGIN
	INSERT INTO Seguro_Viaje (Pasaporte,Destino,Fecha_Ida,Fecha_Regreso,ContactoEmergencia,TelefonoEmergencia)
	VALUES (@Pasaporte,@Destino,@Fecha_Ida,@Fecha_Regreso,@ContactoEmergencia,@TelefonoEmergencia)
END
GO

-- Procedimiento para insertar Paquete Nacional

-- Procedimiento para insertar Guia de Tour
CREATE PROCEDURE SP_InsertaGuiaDeTour(
@IdTour Integer,
@Id_Guia Integer
)
AS
BEGIN
	INSERT INTO GuiaDeTour (IdTour,Id_Guia) VALUES (@IdTour,@Id_Guia)
END
GO

-- Procedimiento para insertar Guia
CREATE PROCEDURE SP_InsertaGuia(
@Nombre_Guia NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO Guia (Nombre_Guia) VALUES (@Nombre_Guia)
END
GO

-- Procedimiento para insertar Hospedaje
CREATE PROCEDURE SP_InsertaHospedaje(
@Nombre_Turista NVARCHAR(50),
@Numero_Habitacion INT,
@Categoria CHAR(50),
@Nombre_Hospedaje NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO Hospedaje (Nombre_Turista,Numero_Habitacion,Categoria,Nombre_Hospedaje) VALUES
	(@Nombre_Turista,@Numero_Habitacion,@Categoria,@Nombre_Hospedaje)
END
GO

-- Procedimiento para insertar Comida
CREATE PROCEDURE SP_InsertaComida(
@Tipo_Comida NVARCHAR(50),
@Cantidad_Plato INT,
@Nombre_Plato NVARCHAR(50)
)
AS
BEGIN
	INSERT INTO Comida (Tipo_Comida,Cantidad_Plato,Nombre_Plato) VALUES
	(@Tipo_Comida,@Cantidad_Plato,@Nombre_Plato)
END
GO

-- Procedimiento para insertar Actividad 
CREATE PROCEDURE SP_InsertaActividad(
@Descripcion NVARCHAR(100)
)
AS
BEGIN
	INSERT INTO Actividad (Descripcion) VALUES (@Descripcion)
END
GO

-- Procedimiento para insertar Forma_Pago
CREATE PROCEDURE SP_InsertaFormaPago(
@Tipo_Pago NVARCHAR(50),
@Cantidad_Depositada INT
)
AS
BEGIN
	INSERT INTO Forma_Pago (Tipo_Pago,Cantidad_Depositada) VALUES
	(@Tipo_Pago,@Cantidad_Depositada)
END
GO

-- Procedimiento para insertar Acompañante
CREATE PROCEDURE SP_InsertaAcompanante(
@Nombre_acompañante NVARCHAR(50),
@Cedula VARCHAR(20)
)
AS
BEGIN
	INSERT INTO Acompañante (Nombre_acompañante,Cedula) VALUES (@Nombre_acompañante,@Cedula)
END
GO

-- Procedimiento para insertar Reservacion_FormaPago
CREATE PROCEDURE SP_InsertaReservacionFormaPago(
@Id_reservacion INT,
@Id_FormaPago INT
)
AS
BEGIN
	INSERT INTO Reservacion_FormaPago (Id_reservacion,Id_FormaPago) VALUES (@Id_reservacion,@Id_FormaPago)
END
GO

-- Procedimiento para insertar Reservacion
CREATE PROCEDURE SP_InsertaReservacion(
@FechaReservacion DATETIME,
@Pago NUMERIC(18,3),
@Cedula VARCHAR(20),
@IdChoferCoster INT
)
AS
BEGIN
	INSERT INTO Reservacion (FechaReservacion,Pago,Cedula,IdChoferCoster) VALUES
	(@FechaReservacion,@Pago,@Cedula,@IdChoferCoster)
END
GO

-- Procedimiento para insertar Servicios de Reservacion
CREATE PROCEDURE SP_InsertaServiciosDeReservacion(
@Id_reservacion INT,
@FechaRealizacionServicio DATETIME,
@Id_servicio INT
)
AS
BEGIN
	INSERT INTO ServiciosDeReservacion (Id_reservacion,FechaRealizacionServicio,Id_servicio) VALUES
	(@Id_reservacion,@FechaRealizacionServicio,@Id_servicio)
END
GO

-- Procedimiento para insertar Tipo de Servicio
CREATE PROCEDURE SP_InsertaTipoServicio(
@Nombre_Servicio NVARCHAR(50),
@IdPaqueteEuropa INT,
@IdSeguroViaje INT,
@IdPaqueteNacional INT,
@IdRentaVehiculo INT,
@IdTour INT,
@IdServicioHotel INT,
@IdBoleto INT
)
AS
BEGIN
	INSERT INTO Tipo_servicio (Nombre_Servicio,IdPaqueteEuropa,IdSeguroViaje,IdPaqueteNacional,IdRentaVehiculo,IdTour,IdServicioHotel,IdBoleto)
	VALUES (@Nombre_Servicio,@IdPaqueteEuropa,@IdSeguroViaje,@IdPaqueteNacional,@IdRentaVehiculo,@IdTour,@IdServicioHotel,@IdBoleto)
END
GO


/******/
