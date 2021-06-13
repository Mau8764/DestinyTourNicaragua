/*
Created		14/5/19
Modified		18/7/19
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/

/*Creacion de base de datos*/
CREATE DATABASE Destiny
GO
USE Destiny
GO
/*Creación de tablas*/
Create table [ChoferCoster]
(
	[IdChoferCoster] Integer NOT NULL IDENTITY(1,1),UNIQUE ([IdChoferCoster]), /*Modificado*/
	[Fecha] Date NOT NULL,
	[CedulaChofer] Varchar(16) NOT NULL,
	[NombreChofer] Varchar(50) NOT NULL,
	[CantidadCoster] Integer NOT NULL,
	[Capacidad] Integer NOT NULL,
	Primary Key ([IdChoferCoster])
) 
go

Create table [Reservacion]
(
	[Id_reservacion] Integer IDENTITY(1,1) NOT NULL, /*Modificado*/
	[FechaReservacion] Datetime NOT NULL,
	[Pago] money NOT NULL,/**/
	[Cedula] Varchar(20) NOT NULL,
	[IdChoferCoster] Integer NOT NULL,
	Primary Key ([Id_reservacion]),
	FOREIGN KEY (IdChoferCoster) REFERENCES ChoferCoster(IdChoferCoster) /*Modificado*/
) 
go

Create table [Tour_Nacional]
(
	[IdTour] Integer NOT NULL IDENTITY(1,1), /*Modificado*/
	[Hora_Salida] TIME NOT NULL, /*Modificado*/
	[Hora_Regreso] TIME NOT NULL, /*Modificado*/
	[Fecha_Tour] Date NOT NULL, /*Modificado*/
	[NombreTour] Varchar(50) NOT NULL,
	[Tipo_Tour] varchar(8) NOT NULL, /*Modificado*/
	[Nombre_Institucion] Nvarchar(50) NULL /*Modificado*/
	Primary Key ([IdTour])
) 
go

Create table [Guia]
(
	[Id_Guia] Integer NOT NULL IDENTITY(1,1),/*Modificado*/
	[Nombre_Guia] Nvarchar(50) NOT NULL,
	Primary Key ([Id_Guia])
) 
go

Create table [Cliente]
(
	[Correo_Electronico] Nvarchar(50) NOT NULL,
	[Cedula] Varchar(20) NOT NULL,
	Primary Key ([Cedula])
) 
go

Create table [Hospedaje]
(
	[Id_hospedaje] INT IDENTITY(1,1) NOT NULL, /*Modificado*/
	[Nombre_Turista] Nvarchar(50) NOT NULL,
	[Numero_Habitacion] Integer NOT NULL,
	[Categoria] Char(50) NOT NULL,
	[Nombre_Hospedaje] Nvarchar(50) NOT NULL,
	Primary Key ([Id_hospedaje])
) 
go

Create table [Actividad]
(
	[Id_Act] INT IDENTITY(1,1) NOT NULL, /*Modificado*/
	[Descripcion] Nvarchar(100) NOT NULL
	Primary Key ([Id_Act])
) 
go

Create table [Persona]
(
	[Cedula] Varchar(20) NOT NULL,
	[Nombre] Char(50) NOT NULL,
	[Sexo] Char(10) NOT NULL,
	[Edad] Char(50) NOT NULL,
	[Telefono] Integer NOT NULL,
	Primary Key ([Cedula])
) 
go

Create table [Paquete_Europa]
(
	[IdPaqueteEuropa] Integer NOT NULL,
	Primary Key ([IdPaqueteEuropa])
) 
go

Create table [Boleto_Aereo]
(
	[IdBoleto] Integer NOT NULL IDENTITY(1,1), UNIQUE ([IdBoleto]),/*Modificado*/
	[Destino] Nvarchar(50) NOT NULL,
	[Fecha_Ida] Date NOT NULL,
	[Tarifa] Float NOT NULL,
	[Fecha_Regreso] Date NOT NULL,
	[Linea_Aerea] Nvarchar(50) NOT NULL,
	[Cabina_Avion] Nvarchar(30) NOT NULL,
	Primary Key ([IdBoleto])
) 
go

Create table [Paquete_Nacional]
(
	[IdPaqueteNacional] Integer NOT NULL IDENTITY(1,1), /*Modificado*/
	Primary Key ([IdPaqueteNacional])
) 
go

Create table [Hotel]
(
	[IdServicioHotel] Integer NOT NULL,/*Modificado*/
	[Fecha_Ingreso] Date NOT NULL,
	[Edad_Persona] Integer NOT NULL,
	[Fecha_Salida] Date NOT NULL,
	[Cantidad_Persona] Integer NOT NULL,
	[Fecha_Reserva] Date NOT NULL,
	[Tipo_Habitacion] Nvarchar(50) NOT NULL,
	[Numero_Habitacion] Integer NOT NULL,
	[Regimen] Nvarchar(50) NOT NULL,
	Primary Key ([IdServicioHotel])
) 
go

Create table [Seguro_Viaje]
(
	[IdSeguroViaje] Integer NOT NULL IDENTITY(1,1),/*Modificado*/
	[Pasaporte] Nvarchar(50) NOT NULL,
	[Destino] Nvarchar(100) NOT NULL,
	[Fecha_Ida] Date NOT NULL,
	[Fecha_Regreso] Date NOT NULL,
	[ContactoEmergencia] Nvarchar(100) NOT NULL,
	[TelefonoEmergencia] Nvarchar(15) NOT NULL,
	Primary Key ([IdSeguroViaje])
) 
go

Create table [Renta_Vehiculo]
(
	[IdRentaVehiculo] Integer NOT NULL IDENTITY(1,1), /*Modificado*/
	[Cantidad_dia] Integer NOT NULL,
	[Tipo_carro] nvarchar(10) NOT NULL,
	[Fecha_renta] Date NOT NULL,
	[Fecha_devolucion] Date NOT NULL,
	[Placa] Nvarchar(20) NOT NULL,
	Primary Key ([IdRentaVehiculo])
) 
go

Create table [Comida]
(
	[id_comida] Integer NOT NULL IDENTITY(1,1), /*Modificado*/
	[Tipo_Comida] Nvarchar(50) NOT NULL,
	[Cantidad_Plato] Integer NOT NULL,
	[Nombre_Plato] Nvarchar(50) NOT NULL,
	Primary Key ([id_comida])
) 
go

Create table [Beneficio_Incluido]
(
	[id_beneficio] Integer NOT NULL IDENTITY(1,1), /*Modificado*/
	[Nombre_beneficio] Nvarchar(50) NOT NULL,
	[id_comida] Integer NULL FOREIGN KEY REFERENCES Comida(id_comida), /*Modificado*/
	[Id_Act] INT NULL FOREIGN KEY REFERENCES Actividad(Id_Act), /*Modificado*/
	[IdTour] Integer NOT NULL FOREIGN KEY REFERENCES Tour_Nacional(IdTour),/*Modificado*/
	[Id_hospedaje] INT NULL FOREIGN KEY REFERENCES Hospedaje(Id_hospedaje), /*Modificado*/
	Primary Key ([id_beneficio])
) 
go

Create table [Acompanante]
(
	[id_acompanante] Integer IDENTITY(1,1) NOT NULL, /*Modificado*/
	[Nombre_acompañante] Nvarchar(50) NOT NULL,
	[Cedula] Varchar(20) NOT NULL FOREIGN KEY REFERENCES Cliente(Cedula),/*Modificado*/
	Primary Key ([id_acompanante])
) 
go

Create table [Tipo_servicio]
(
	[Id_servicio] Integer IDENTITY(1,1) NOT NULL, /*Modificado*/
	[Nombre_Servicio] Nvarchar(50) NOT NULL,
	[IdPaqueteEuropa] Integer NULL FOREIGN KEY REFERENCES Paquete_Europa(IdPaqueteEuropa), /*Modificado*/
	[IdSeguroViaje] Integer NULL FOREIGN KEY REFERENCES Seguro_Viaje(IdSeguroViaje), /*Modificado*/
	[IdPaqueteNacional] Integer NULL FOREIGN KEY REFERENCES Paquete_Nacional(IdPaqueteNacional), /*Modificado*/
	[IdRentaVehiculo] Integer NULL FOREIGN KEY REFERENCES Renta_Vehiculo(IdRentaVehiculo), /*Modificado*/
	[IdTour] Integer NULL FOREIGN KEY REFERENCES Tour_Nacional(IdTour), /*Modificado*/
	[IdServicioHotel] Integer NULL FOREIGN KEY REFERENCES Hotel(IdServicioHotel), /*Modificado*/
	[IdBoleto] Integer NULL FOREIGN KEY REFERENCES Boleto_Aereo(IdBoleto), /*Modificado*/
	Primary Key ([Id_servicio])
) 
go

Create table [Forma_Pago]
(
	[Id_FormaPago] Integer IDENTITY(1,1) NOT NULL, /*Modificado*/
	[Tipo_Pago] Nvarchar(50) NOT NULL,
	[Cantidad_Depositada] float NOT NULL,
	Primary Key ([Id_FormaPago])
) 
go

Create table [Idioma]
(
	[Id_Idioma] Integer NOT NULL IDENTITY(1,1), /*Modificado*/
	[Nombre_Idioma] Nvarchar(50) NOT NULL,
	Primary Key ([Id_Idioma])
) 
go

Create table [Idioma_Manejado]
(
	[Id_Idioma] Integer NOT NULL FOREIGN KEY REFERENCES Idioma(Id_Idioma), /*Modificado*/
	[Id_Guia] Integer NOT NULL FOREIGN KEY REFERENCES Guia(Id_Guia) /*Modificado*/
) 
go

Create table [Reservacion_FormaPago]
(
	[Id_reservacion] Integer NOT NULL FOREIGN KEY REFERENCES Reservacion(Id_reservacion), /*Modificado*/
	[Id_FormaPago] Integer NOT NULL FOREIGN KEY REFERENCES Forma_Pago(Id_FormaPago) /*Modificado*/
) 
go

Create table [Lugares]
(
	[Id_Lugar] Integer NOT NULL IDENTITY(1,1), /*Modificado*/
	[Nombre_Lugar] Nvarchar(100) NOT NULL,
Primary Key ([Id_Lugar])
) 
go

Create table [Lugar_Tour]
(
	[IdTour] Integer NOT NULL FOREIGN KEY REFERENCES Tour_Nacional(IdTour), /*Modificado*/
	[Id_Lugar] Integer NOT NULL FOREIGN KEY REFERENCES Lugares(Id_Lugar) /*Modificado*/
) 
go

Create table [ServiciosDeReservacion]
(
	[Id_reservacion] Integer NOT NULL FOREIGN KEY REFERENCES Reservacion(Id_reservacion), /*Modificado*/
	[FechaRealizacionServicio] Date NOT NULL,
	[Id_servicio] Integer NOT NULL FOREIGN KEY REFERENCES Tipo_servicio(Id_servicio), /*Modificado*/
	Primary Key ([Id_reservacion],[Id_servicio])
) 
go

Create table [GuiaDeTour]
(
	[IdTour] Integer NOT NULL FOREIGN KEY REFERENCES Tour_Nacional(IdTour), /*Modificado*/
	[Id_Guia] Integer NOT NULL FOREIGN KEY REFERENCES Guia(Id_Guia), /*Modificado*/
Primary Key ([IdTour],[Id_Guia])
) 
go


Set quoted_identifier on
go


Set quoted_identifier off
go
