USE [master]
GO
/****** Object:  Database [dbHotel]    Script Date: 15/05/2023 16:56:05 ******/
CREATE DATABASE [dbHotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbHotel', FILENAME = N'E:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbHotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbHotel_log', FILENAME = N'E:\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\dbHotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [dbHotel] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbHotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbHotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbHotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbHotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbHotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbHotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbHotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbHotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbHotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbHotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbHotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbHotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbHotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbHotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbHotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbHotel] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dbHotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbHotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbHotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbHotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbHotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbHotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbHotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbHotel] SET RECOVERY FULL 
GO
ALTER DATABASE [dbHotel] SET  MULTI_USER 
GO
ALTER DATABASE [dbHotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbHotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbHotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbHotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbHotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbHotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbHotel', N'ON'
GO
ALTER DATABASE [dbHotel] SET QUERY_STORE = ON
GO
ALTER DATABASE [dbHotel] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [dbHotel]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dni] [bigint] NULL,
	[telefono] [bigint] NULL,
	[correo] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mascota]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mascota](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[tipo] [varchar](50) NULL,
	[edad] [int] NULL,
 CONSTRAINT [PK_Mascota] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero_habitacion] [int] NULL,
	[tipo_habitacion] [varchar](50) NULL,
	[tematica] [varchar](50) NULL,
	[paquete] [varchar](50) NULL,
	[precio] [float] NULL,
	[fecha_ingreso] [datetime] NULL,
	[fecha_salida] [datetime] NULL,
	[fecha_facturacion] [datetime] NULL,
	[id_cliente] [int] NULL,
	[id_mascota] [int] NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NULL,
	[contrasena] [varchar](50) NULL,
	[estado] [varchar](50) NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dni] [bigint] NULL,
	[correo] [varchar](50) NULL,
	[telefono] [bigint] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono], [correo]) VALUES (1, N'Alvaro', N'Lamg', 12345678, 987654321, N'alamg@hym.com')
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono], [correo]) VALUES (2, N'Sthepen', N'Espinoza', 12345679, 4654651, N'sadsadsa@gmail.com')
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono], [correo]) VALUES (3, N'Juan Carlos', N'Bodoque', 12345680, 987654323, N'jbodoque@gmail.com')
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono], [correo]) VALUES (4, N'Diego', N'Espinoza', 123456789, 4654651, N'sadsadsa@gmail.com')
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono], [correo]) VALUES (5, N'Nombre', N'Apellido', 7895461, 987654321, N'abc@abc.com')
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono], [correo]) VALUES (6, N'Alvaro', N'Lamg', 78456542, 987654321, N'alvaro@upc.edu.pe')
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono], [correo]) VALUES (7, N'Alvaro', N'Lamg', 78464651, 987546421, N'alvaro@ufjasf.com')
INSERT [dbo].[Cliente] ([id], [nombre], [apellido], [dni], [telefono], [correo]) VALUES (8, N'Ken', N'Aguirre', 71456874, 902131321, N'asdasda@dsada.com')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Mascota] ON 

INSERT [dbo].[Mascota] ([id], [nombre], [tipo], [edad]) VALUES (1, N'Pecky', N'Gato ', 6)
INSERT [dbo].[Mascota] ([id], [nombre], [tipo], [edad]) VALUES (2, N'Fido', N'Perro ', 14)
INSERT [dbo].[Mascota] ([id], [nombre], [tipo], [edad]) VALUES (4, N'Maxi', N'Perror Shiba', 8)
SET IDENTITY_INSERT [dbo].[Mascota] OFF
GO
SET IDENTITY_INSERT [dbo].[Servicio] ON 

INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (1, 402, N'Clasico', N'Clasico', N'Intermedio', 300, CAST(N'2021-11-10T00:00:00.000' AS DateTime), CAST(N'2021-11-12T00:00:00.000' AS DateTime), CAST(N'2021-11-13T20:38:30.910' AS DateTime), 1, 1)
INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (2, 304, N'Personalizado', N'Nave espacial', N'Completo', 450, CAST(N'2021-10-29T00:00:00.000' AS DateTime), CAST(N'2021-11-02T00:00:00.000' AS DateTime), CAST(N'2021-11-13T21:53:09.017' AS DateTime), 2, NULL)
INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (3, 106, N'Personalizado', N'Campamento', N'Basico', 350, CAST(N'2021-09-12T00:00:00.000' AS DateTime), CAST(N'2021-10-10T00:00:00.000' AS DateTime), CAST(N'2021-11-13T21:53:03.277' AS DateTime), 1, NULL)
INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (4, 303, N'Personalizado', N'Mina', N'Completo', 450, CAST(N'2021-11-10T00:00:00.000' AS DateTime), CAST(N'2021-11-23T00:00:00.000' AS DateTime), CAST(N'2021-11-12T15:29:44.963' AS DateTime), 3, 2)
INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (6, 103, N'Personalizado', N'Puente', N'Completo', 450, CAST(N'2021-11-13T00:00:00.000' AS DateTime), CAST(N'2021-12-02T00:00:00.000' AS DateTime), CAST(N'2021-11-13T22:27:36.613' AS DateTime), 2, NULL)
INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (7, 108, N'Personalizado', N'Puente', N'Intermedio', 400, CAST(N'2022-11-13T00:00:00.000' AS DateTime), CAST(N'2022-12-02T00:00:00.000' AS DateTime), CAST(N'2021-11-13T21:42:29.017' AS DateTime), 2, NULL)
INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (9, 102, N'Clasico', N'Clasico', N'Completo', 350, CAST(N'2021-01-01T00:00:00.000' AS DateTime), CAST(N'2021-02-02T00:00:00.000' AS DateTime), CAST(N'2021-11-13T21:43:57.243' AS DateTime), 2, NULL)
INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (10, 123, N'Clasico', N'Clasico', N'Basico', 250, CAST(N'2023-04-16T00:00:00.000' AS DateTime), CAST(N'2023-04-18T00:00:00.000' AS DateTime), CAST(N'2023-04-16T15:07:26.587' AS DateTime), 5, 2)
INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (12, 112, N'Clasico', N'Clasico', N'Intermedio', 300, CAST(N'2023-05-12T00:00:00.000' AS DateTime), CAST(N'2023-05-15T00:00:00.000' AS DateTime), CAST(N'2023-05-01T19:58:19.777' AS DateTime), 7, NULL)
INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (13, 112, N'Clasico', N'Clasico', N'Intermedio', 300, CAST(N'2023-05-13T00:00:00.000' AS DateTime), CAST(N'2023-05-15T00:00:00.000' AS DateTime), CAST(N'2023-05-01T19:59:19.900' AS DateTime), 7, 2)
INSERT [dbo].[Servicio] ([id], [numero_habitacion], [tipo_habitacion], [tematica], [paquete], [precio], [fecha_ingreso], [fecha_salida], [fecha_facturacion], [id_cliente], [id_mascota]) VALUES (14, 108, N'Personalizado', N'Puente', N'Intermedio', 400, CAST(N'2022-11-13T00:00:00.000' AS DateTime), CAST(N'2022-12-02T00:00:00.000' AS DateTime), CAST(N'2023-05-01T20:00:13.183' AS DateTime), 2, NULL)
SET IDENTITY_INSERT [dbo].[Servicio] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id], [usuario], [contrasena], [estado], [nombre], [apellido], [dni], [correo], [telefono]) VALUES (1, N'alamg', N'alamg123', N'Recepcionista', N'Alvaro', N'Lamg', 12345678, N'alamg@hym.com', 987654321)
INSERT [dbo].[Usuario] ([id], [usuario], [contrasena], [estado], [nombre], [apellido], [dni], [correo], [telefono]) VALUES (2, N'sespinoza', N'sespinoza123', N'Administrador', N'Sthepen', N'Espinoza', 12345679, N'sespinoza@hym.com', 987654322)
INSERT [dbo].[Usuario] ([id], [usuario], [contrasena], [estado], [nombre], [apellido], [dni], [correo], [telefono]) VALUES (3, N'gespinoza', N'gespinoza123', N'Inactivo', N'Gabriel', N'Espinoza', 12345680, N'gespinoza@hym.com', 987654323)
INSERT [dbo].[Usuario] ([id], [usuario], [contrasena], [estado], [nombre], [apellido], [dni], [correo], [telefono]) VALUES (6, N'mchaucas', N'mchaucas123', N'Administrador', N'Manuel', N'Chaucas', 12345682, N'mchaucas@hym.com', 987654325)
INSERT [dbo].[Usuario] ([id], [usuario], [contrasena], [estado], [nombre], [apellido], [dni], [correo], [telefono]) VALUES (7, N'ggarcia', N'ggarcia123', N'Recepcionista', N'Gianella', N'Garcia', 12345681, N'ggarcia@hym.com', 987654324)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_Cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_Cliente]
GO
ALTER TABLE [dbo].[Servicio]  WITH CHECK ADD  CONSTRAINT [FK_Servicio_Mascota] FOREIGN KEY([id_mascota])
REFERENCES [dbo].[Mascota] ([id])
GO
ALTER TABLE [dbo].[Servicio] CHECK CONSTRAINT [FK_Servicio_Mascota]
GO
/****** Object:  StoredProcedure [dbo].[Buscar_Servicios_en_Rango_Mes]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[Buscar_Servicios_en_Rango_Mes]
@mes1 datetime,
@mes2 datetime
as
Select numero_habitacion,paquete,fecha_ingreso,fecha_salida,fecha_facturacion from Servicio
where fecha_facturacion>=@mes1 and fecha_facturacion<=@mes2
GO
/****** Object:  StoredProcedure [dbo].[BuscarPorUsuarioContrasena_Usuario]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--SELECT * from Usuario WHERE usuario like '{0}' and contrasena like '{1}' 
CREATE PROC [dbo].[BuscarPorUsuarioContrasena_Usuario]
@usuario varchar(50),
@contrasena varchar(50)
as
SELECT * FROM Usuario WHERE usuario like @usuario and contrasena like @contrasena
GO
/****** Object:  StoredProcedure [dbo].[ConsultarTipoMascota]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ConsultarTipoMascota]
@tipo varchar(50)
as
select * from Mascota where tipo = @tipo
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Cliente]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Eliminar_Cliente]
@id int
as
DELETE from Cliente WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Mascota]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Eliminar_Mascota]
@id int
as
DELETE from Mascota WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Producto]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Eliminar_Producto]
@id int
as
delete from Producto
where id=@id;
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Servicio]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Eliminar_Servicio]
@id int
as
DELETE from Servicio WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Usuario]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--DELETE from Usuario WHERE id={0}
CREATE PROC [dbo].[Eliminar_Usuario]
@id int
as
DELETE from Usuario WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Cliente]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insertar_Cliente]
@nombre varchar(50),
@apellido varchar(50),
@dni bigint,
@telefono bigint,
@correo varchar(50)
as
IF NOT EXISTS(SELECT * FROM Cliente WHERE dni = @dni)
	BEGIN
	INSERT INTO Cliente(nombre, apellido, dni, telefono, correo) VALUES(@nombre, @apellido, @dni, @telefono, @correo)
	END
ELSE
	BEGIN
	UPDATE Cliente SET
	nombre = @nombre,
	apellido = @apellido,
	telefono = @telefono,
	correo = @correo
	WHERE dni = @dni
	END
SELECT id FROM Cliente WHERE dni = @dni
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Mascota]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Insertar_Mascota]
@nombre varchar(50),
@tipo varchar(50),
@edad int
as
IF NOT EXISTS(SELECT * FROM Mascota WHERE nombre = @nombre and tipo = @tipo)
	BEGIN
	INSERT INTO Mascota(nombre, tipo, edad) VALUES(@nombre, @tipo, @edad)
	END
ELSE
	BEGIN
	UPDATE Mascota SET
	edad = @edad
	WHERE nombre = @nombre and tipo = @tipo
	END
SELECT id FROM Mascota WHERE nombre = @nombre and tipo = @tipo
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Producto]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insertar_Producto]
@codigo varchar(50),
@descripcion varchar(50),
@marca varchar(50),
@fecha date,
@tipo varchar(50),
@paravender bit,
@cantidad int
as
insert into Producto(codigo,descripcion,marca,fecha,tipo,paravender,cantidad) 
values (@codigo,@descripcion,@marca,@fecha,@tipo,@paravender,@cantidad)
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Servicio]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Insertar_Servicio]
@numero_habitacion int,
@tipo_habitacion varchar(50),
@tematica varchar(50),
@paquete varchar(50),
@precio float,
@fecha_ingreso datetime,
@fecha_salida datetime,
@fecha_facturacion datetime,
@id_cliente int,
@id_mascota int
as
BEGIN
DECLARE @id int
INSERT INTO Servicio(numero_habitacion, tipo_habitacion, tematica, paquete, precio, fecha_ingreso, fecha_salida, fecha_facturacion, id_cliente, id_mascota) 
VALUES(@numero_habitacion, @tipo_habitacion, @tematica, @paquete, @precio, @fecha_ingreso, @fecha_salida, @fecha_facturacion, @id_cliente, @id_mascota)
SET @id = SCOPE_IDENTITY()
SELECT @id AS id
END
GO
/****** Object:  StoredProcedure [dbo].[Insertar_Usuario]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--INSERT INTO Usuario(usuario, contrasena, estado, nombre, apellido, dni, correo, telefono) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')
CREATE PROC [dbo].[Insertar_Usuario]
@usuario varchar(50),
@contrasena varchar(50),
@estado varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@dni bigint,
@correo varchar(50),
@telefono bigint
as
INSERT INTO Usuario(usuario, contrasena, estado, nombre, apellido, dni, correo, telefono) VALUES(@usuario, @contrasena, @estado, @nombre, @apellido, @dni, @correo, @telefono)
GO
/****** Object:  StoredProcedure [dbo].[IntervaloFechas]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[IntervaloFechas]
@fecha1 datetime,
@fecha2 datetime
as
Select * from Servicio where fecha_ingreso > @fecha1 and fecha_ingreso < @fecha2
GO
/****** Object:  StoredProcedure [dbo].[Modificar_Cliente]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Modificar_Cliente]
@id int,
@nombre varchar(50),
@apellido varchar(50),
@dni bigint,
@telefono bigint,
@correo varchar(50)
as
UPDATE Cliente SET
nombre = @nombre,
apellido = @apellido,
dni = @dni,
telefono = @telefono,
correo = @correo
WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[Modificar_Mascota]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Modificar_Mascota]
@id int,
@nombre varchar(50),
@tipo varchar(50),
@edad int
as
UPDATE Mascota SET
nombre = @nombre,
tipo = @tipo,
edad = @edad
WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[Modificar_Producto]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Modificar_Producto]
@id int,
@codigo varchar(50),
@descripcion varchar(50),
@marca varchar(50),
@fecha date,
@tipo varchar(50),
@paravender bit,
@cantidad int
as
update Producto set 
codigo=@codigo,
descripcion=@descripcion,
marca=@marca,
fecha=@fecha,
tipo=@tipo,
paravender=@paravender,
cantidad=@cantidad
where id=@id;
GO
/****** Object:  StoredProcedure [dbo].[Modificar_Servicio]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Modificar_Servicio]
@id int,
@numero_habitacion int,
@tipo_habitacion varchar(50),
@tematica varchar(50),
@paquete varchar(50),
@precio float,
@fecha_ingreso datetime,
@fecha_salida datetime,
@fecha_facturacion datetime,
@id_cliente int,
@id_mascota int
as
UPDATE Servicio SET
numero_habitacion = @numero_habitacion,
tipo_habitacion = @tipo_habitacion,
tematica = @tematica,
paquete = @paquete,
precio = @precio,
fecha_ingreso = @fecha_ingreso,
fecha_salida = @fecha_salida,
fecha_facturacion = @fecha_facturacion,
id_cliente = @id_cliente,
id_mascota = @id_mascota
WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[Modificar_Usuario]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--UPDATE Usuario SET usuario='{0}', contrasena='{1}', estado='{2}', nombre='{3}', apellido='{4}', dni='{5}', correo='{6}', telefono='{7}' where id={8}
CREATE PROC [dbo].[Modificar_Usuario]
@id int,
@usuario varchar(50),
@contrasena varchar(50),
@estado varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@dni bigint,
@correo varchar(50),
@telefono bigint
as
UPDATE Usuario SET
usuario = @usuario,
contrasena = @contrasena,
estado = @estado,
nombre = @nombre,
apellido = @apellido,
dni = @dni,
correo = @correo,
telefono = @telefono
WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[Mostrar]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Mostrar]
as
select * from Producto;
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Cliente]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Mostrar_Cliente]
as
SELECT * FROM Cliente
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Mascota]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Mostrar_Mascota]
as
SELECT * FROM Mascota
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Producto]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Mostrar_Producto]
@marca varchar(50)
as
select * from Producto
where marca=@marca;
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Servicio]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Mostrar_Servicio]
as
SELECT * FROM Servicio
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Usuario]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--SELECT * from Usuario
CREATE PROC [dbo].[Mostrar_Usuario]
as
SELECT * FROM Usuario
GO
/****** Object:  StoredProcedure [dbo].[Mostrar_Venta]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Mostrar_Venta]
as
SELECT
Servicio.id as 'id_servicio',
Servicio.numero_habitacion as 'numero_habitacion_servicio',
Servicio.tipo_habitacion as 'tipo_habitacion_servicio',
Servicio.tematica as 'tematica_servicio',
Servicio.paquete as 'paquete_servicio',
Servicio.precio as 'precio_servicio',
Servicio.fecha_ingreso as 'fecha_ingreso_servicio',
Servicio.fecha_salida as 'fecha_salida_servicio',
Servicio.fecha_facturacion as 'fecha_facturacion_servicio',
Servicio.id_cliente,
Cliente.nombre as 'nombre_cliente',
Cliente.apellido as 'apellido_cliente',
Cliente.dni as 'dni_cliente',
Cliente.telefono as 'telefono_cliente',
Cliente.correo as 'correo_cliente',
Servicio.id_mascota,
Mascota.nombre as 'nombre_mascota',
Mascota.tipo as 'tipo_mascota',
Mascota.edad as 'edad_mascota'
FROM Servicio INNER JOIN Cliente ON (Servicio.id_cliente = Cliente.id) LEFT JOIN Mascota ON (Servicio.id_mascota = Mascota.id)
GO
/****** Object:  StoredProcedure [dbo].[ReestablecerContrasena_Usuario]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ReestablecerContrasena_Usuario]
@usuario varchar(50),
@contrasena varchar(50),
@dni bigint,
@correo varchar(50),
@telefono bigint
as
DECLARE @RESULTADO varchar(50)
IF EXISTS(SELECT * FROM Usuario WHERE usuario like @usuario and dni = @dni and correo = @correo and telefono = @telefono)
BEGIN
UPDATE Usuario SET contrasena = @contrasena WHERE usuario like @usuario and dni = @dni and correo = @correo and telefono = @telefono
SET @resultado = 'Contraseña reestablecida satisfactoriamente.'
END
ELSE
BEGIN
SET @resultado = 'Datos ingresados incorrectos.'
END
SELECT @resultado
GO
/****** Object:  StoredProcedure [dbo].[TipoHabitacion]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TipoHabitacion]
@tipo varchar(50)
as
select * from Servicio where tipo_habitacion = @tipo
GO
/****** Object:  StoredProcedure [dbo].[TipoTematica]    Script Date: 15/05/2023 16:56:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TipoTematica]
@tematica varchar(50)
as
select * from Servicio where tematica = @tematica
GO
USE [master]
GO
ALTER DATABASE [dbHotel] SET  READ_WRITE 
GO
