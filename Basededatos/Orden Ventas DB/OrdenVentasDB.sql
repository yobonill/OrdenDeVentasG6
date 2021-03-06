USE [master]
GO
/****** Object:  Database [OrdenVentasDB]    Script Date: 06/01/2021 15:53:10 ******/
CREATE DATABASE [OrdenVentasDB] ON  PRIMARY 
( NAME = N'OrdenVentasDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OrdenVentasDB.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OrdenVentasDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\OrdenVentasDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OrdenVentasDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OrdenVentasDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OrdenVentasDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [OrdenVentasDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [OrdenVentasDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [OrdenVentasDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [OrdenVentasDB] SET ARITHABORT OFF
GO
ALTER DATABASE [OrdenVentasDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [OrdenVentasDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [OrdenVentasDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [OrdenVentasDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [OrdenVentasDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [OrdenVentasDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [OrdenVentasDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [OrdenVentasDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [OrdenVentasDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [OrdenVentasDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [OrdenVentasDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [OrdenVentasDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [OrdenVentasDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [OrdenVentasDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [OrdenVentasDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [OrdenVentasDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [OrdenVentasDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [OrdenVentasDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [OrdenVentasDB] SET  READ_WRITE
GO
ALTER DATABASE [OrdenVentasDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [OrdenVentasDB] SET  MULTI_USER
GO
ALTER DATABASE [OrdenVentasDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [OrdenVentasDB] SET DB_CHAINING OFF
GO
USE [OrdenVentasDB]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[persona](
	[idpersona] [int] IDENTITY(1,1) NOT NULL,
	[tipo_persona] [varchar](20) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[tipo_documento] [varchar](20) NULL,
	[num_documento] [varchar](20) NULL,
	[direccion] [varchar](70) NULL,
	[telefono] [varchar](20) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [PK_IDPERSONA] PRIMARY KEY CLUSTERED 
(
	[idpersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[idcategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](256) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_IDCATEGORIA] PRIMARY KEY CLUSTERED 
(
	[idcategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_NOMBRE] UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[rol]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[rol](
	[idrol] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[descripcion] [varchar](100) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_IDROL] PRIMARY KEY CLUSTERED 
(
	[idrol] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[idrol] [int] NOT NULL,
	[usuario] [varchar](25) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[num_documento] [varchar](20) NULL,
	[direccion] [varchar](70) NULL,
	[telefono] [varchar](20) NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_IDUSUARIO] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[articulo]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[articulo](
	[idarticulo] [int] IDENTITY(1,1) NOT NULL,
	[idcategoria] [int] NOT NULL,
	[codigo] [varchar](50) NULL,
	[nombre] [varchar](100) NOT NULL,
	[precio_venta] [decimal](11, 2) NOT NULL,
	[stock] [int] NOT NULL,
	[descripcion] [varchar](256) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_IDARTICULO] PRIMARY KEY CLUSTERED 
(
	[idarticulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_NOMBRE_ARTICULO] UNIQUE NONCLUSTERED 
(
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[proc_rolUpdate]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_rolUpdate]
(
	@Idrol int, 
	@Nombre varchar(30), 
	@Descripcion varchar(100) = NULL, 
	@Estado bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [rol]
	SET
		[nombre] = @Nombre, 
		[descripcion] = @Descripcion, 
		[estado] = @Estado
	WHERE
		([idrol] = @Idrol)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_rolLoadByPrimaryKey]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_rolLoadByPrimaryKey]
(
	@Idrol int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idrol], 
		[nombre], 
		[descripcion], 
		[estado]
	FROM [dbo].[rol]
	WHERE
		([idrol] = @Idrol)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_rolLoadAll]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_rolLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idrol], 
		[nombre], 
		[descripcion], 
		[estado]
	FROM [dbo].[rol]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_rolInsert]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_rolInsert]
(
	@Idrol int = NULL OUTPUT, 
	@Nombre varchar(30), 
	@Descripcion varchar(100) = NULL, 
	@Estado bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [rol]
	(
		[nombre], 
		[descripcion], 
		[estado]
	)
	
	VALUES
	(
		@Nombre, 
		@Descripcion, 
		@Estado
	)


	SET @Err = @@Error

		
	SELECT @Idrol = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_rolDelete]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_rolDelete]
(
	@Idrol int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[rol]
	WHERE
		([idrol] = @Idrol)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_personaUpdate]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_personaUpdate]
(
	@Idpersona int, 
	@TipoPersona varchar(20), 
	@Nombre varchar(100), 
	@TipoDocumento varchar(20) = NULL, 
	@NumDocumento varchar(20) = NULL, 
	@Direccion varchar(70) = NULL, 
	@Telefono varchar(20) = NULL, 
	@Email varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [persona]
	SET
		[tipo_persona] = @TipoPersona, 
		[nombre] = @Nombre, 
		[tipo_documento] = @TipoDocumento, 
		[num_documento] = @NumDocumento, 
		[direccion] = @Direccion, 
		[telefono] = @Telefono, 
		[email] = @Email
	WHERE
		([idpersona] = @Idpersona)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_personaLoadByPrimaryKey]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_personaLoadByPrimaryKey]
(
	@Idpersona int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idpersona], 
		[tipo_persona], 
		[nombre], 
		[tipo_documento], 
		[num_documento], 
		[direccion], 
		[telefono], 
		[email]
	FROM [dbo].[persona]
	WHERE
		([idpersona] = @Idpersona)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_personaLoadAll]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_personaLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idpersona], 
		[tipo_persona], 
		[nombre], 
		[tipo_documento], 
		[num_documento], 
		[direccion], 
		[telefono], 
		[email]
	FROM [dbo].[persona]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_personaInsert]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_personaInsert]
(
	@Idpersona int = NULL OUTPUT, 
	@TipoPersona varchar(20), 
	@Nombre varchar(100), 
	@TipoDocumento varchar(20) = NULL, 
	@NumDocumento varchar(20) = NULL, 
	@Direccion varchar(70) = NULL, 
	@Telefono varchar(20) = NULL, 
	@Email varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [persona]
	(
		[tipo_persona], 
		[nombre], 
		[tipo_documento], 
		[num_documento], 
		[direccion], 
		[telefono], 
		[email]
	)
	
	VALUES
	(
		@TipoPersona, 
		@Nombre, 
		@TipoDocumento, 
		@NumDocumento, 
		@Direccion, 
		@Telefono, 
		@Email
	)


	SET @Err = @@Error

		
	SELECT @Idpersona = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_personaDelete]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_personaDelete]
(
	@Idpersona int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[persona]
	WHERE
		([idpersona] = @Idpersona)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_categoriaUpdate]    Script Date: 06/01/2021 15:53:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_categoriaUpdate]
(
	@Idcategoria int, 
	@Nombre varchar(50), 
	@Descripcion varchar(256) = NULL, 
	@Estado bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [categoria]
	SET
		[nombre] = @Nombre, 
		[descripcion] = @Descripcion, 
		[estado] = @Estado
	WHERE
		([idcategoria] = @Idcategoria)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_categoriaLoadByPrimaryKey]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_categoriaLoadByPrimaryKey]
(
	@Idcategoria int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idcategoria], 
		[nombre], 
		[descripcion], 
		[estado]
	FROM [dbo].[categoria]
	WHERE
		([idcategoria] = @Idcategoria)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_categoriaLoadAll]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_categoriaLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idcategoria], 
		[nombre], 
		[descripcion], 
		[estado]
	FROM [dbo].[categoria]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_categoriaInsert]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_categoriaInsert]
(
	@Idcategoria int = NULL OUTPUT, 
	@Nombre varchar(50), 
	@Descripcion varchar(256) = NULL, 
	@Estado bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [categoria]
	(
		[nombre], 
		[descripcion], 
		[estado]
	)
	
	VALUES
	(
		@Nombre, 
		@Descripcion, 
		@Estado
	)


	SET @Err = @@Error

		
	SELECT @Idcategoria = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_categoriaDelete]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_categoriaDelete]
(
	@Idcategoria int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[categoria]
	WHERE
		([idcategoria] = @Idcategoria)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_articuloUpdate]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_articuloUpdate]
(
	@Idarticulo int, 
	@Idcategoria int, 
	@Codigo varchar(50) = NULL, 
	@Nombre varchar(100), 
	@PrecioVenta decimal(11,2), 
	@Stock int, 
	@Descripcion varchar(256) = NULL, 
	@Estado bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [articulo]
	SET
		[idcategoria] = @Idcategoria, 
		[codigo] = @Codigo, 
		[nombre] = @Nombre, 
		[precio_venta] = @PrecioVenta, 
		[stock] = @Stock, 
		[descripcion] = @Descripcion, 
		[estado] = @Estado
	WHERE
		([idarticulo] = @Idarticulo)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_articuloLoadByPrimaryKey]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_articuloLoadByPrimaryKey]
(
	@Idarticulo int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idarticulo], 
		[idcategoria], 
		[codigo], 
		[nombre], 
		[precio_venta], 
		[stock], 
		[descripcion], 
		[estado]
	FROM [dbo].[articulo]
	WHERE
		([idarticulo] = @Idarticulo)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_articuloLoadAll]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_articuloLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idarticulo], 
		[idcategoria], 
		[codigo], 
		[nombre], 
		[precio_venta], 
		[stock], 
		[descripcion], 
		[estado]
	FROM [dbo].[articulo]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_articuloInsert]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_articuloInsert]
(
	@Idarticulo int = NULL OUTPUT, 
	@Idcategoria int, 
	@Codigo varchar(50) = NULL, 
	@Nombre varchar(100), 
	@PrecioVenta decimal(11,2), 
	@Stock int, 
	@Descripcion varchar(256) = NULL, 
	@Estado bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [articulo]
	(
		[idcategoria], 
		[codigo], 
		[nombre], 
		[precio_venta], 
		[stock], 
		[descripcion], 
		[estado]
	)
	
	VALUES
	(
		@Idcategoria, 
		@Codigo, 
		@Nombre, 
		@PrecioVenta, 
		@Stock, 
		@Descripcion, 
		@Estado
	)


	SET @Err = @@Error

		
	SELECT @Idarticulo = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_articuloDelete]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_articuloDelete]
(
	@Idarticulo int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[articulo]
	WHERE
		([idarticulo] = @Idarticulo)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  Table [dbo].[venta]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[venta](
	[idventa] [int] IDENTITY(1,1) NOT NULL,
	[idcliente] [int] NOT NULL,
	[idusuario] [int] NOT NULL,
	[tipo_comprobante] [varchar](20) NOT NULL,
	[serie_comprobante] [varchar](7) NULL,
	[num_comprobante] [varchar](10) NOT NULL,
	[fecha_hora] [datetime] NOT NULL,
	[impuesto] [decimal](4, 2) NOT NULL,
	[total] [decimal](11, 2) NOT NULL,
	[estado] [varchar](20) NOT NULL,
 CONSTRAINT [PK_IDVENTA] PRIMARY KEY CLUSTERED 
(
	[idventa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[proc_usuarioUpdate]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_usuarioUpdate]
(
	@Idusuario int, 
	@Idrol int, 
	@Usuario varchar(100), 
	@Password varbinary(1), 
	@NumDocumento varchar(20) = NULL, 
	@Direccion varchar(70) = NULL, 
	@Telefono varchar(20) = NULL, 
	@Email varchar(50), 
	@Estado bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [usuario]
	SET
		[idrol] = @Idrol, 
		[usuario] = @Usuario, 
		[password] = @Password, 
		[num_documento] = @NumDocumento, 
		[direccion] = @Direccion, 
		[telefono] = @Telefono, 
		[email] = @Email, 
		[estado] = @Estado
	WHERE
		([idusuario] = @Idusuario)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_usuarioLoadByPrimaryKey]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_usuarioLoadByPrimaryKey]
(
	@Idusuario int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idusuario], 
		[idrol], 
		[usuario], 
		[password], 
		[num_documento], 
		[direccion], 
		[telefono], 
		[email], 
		[estado]
	FROM [dbo].[usuario]
	WHERE
		([idusuario] = @Idusuario)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_usuarioLoadAll]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_usuarioLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idusuario], 
		[idrol], 
		[usuario], 
		[password], 
		[num_documento], 
		[direccion], 
		[telefono], 
		[email], 
		[estado]
	FROM [dbo].[usuario]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_usuarioInsert]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_usuarioInsert]
(
	@Idusuario int = NULL OUTPUT, 
	@Idrol int, 
	@Usuario varchar(100), 
	@Password varbinary(1), 
	@NumDocumento varchar(20) = NULL, 
	@Direccion varchar(70) = NULL, 
	@Telefono varchar(20) = NULL, 
	@Email varchar(50), 
	@Estado bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [usuario]
	(
		[idrol], 
		[usuario], 
		[password], 
		[num_documento], 
		[direccion], 
		[telefono], 
		[email], 
		[estado]
	)
	
	VALUES
	(
		@Idrol, 
		@Usuario, 
		@Password, 
		@NumDocumento, 
		@Direccion, 
		@Telefono, 
		@Email, 
		@Estado
	)


	SET @Err = @@Error

		
	SELECT @Idusuario = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ValidarUsuario]    Script Date: 6/4/2021 1:05:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_ValidarUsuario]
(
   @usuario varchar(25),
   @clave varchar(25)
)
as
begin
   select usuario,password
   from usuario
   where usuario=@usuario 
     and password = @clave
end
GO
/****** Object:  StoredProcedure [dbo].[proc_usuarioDelete]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_usuarioDelete]
(
	@Idusuario int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[usuario]
	WHERE
		([idusuario] = @Idusuario)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ventaUpdate]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ventaUpdate]
(
	@Idventa int, 
	@Idcliente int, 
	@Idusuario int, 
	@TipoComprobante varchar(20), 
	@SerieComprobante varchar(7) = NULL, 
	@NumComprobante varchar(10), 
	@FechaHora datetime, 
	@Impuesto decimal(4,2), 
	@Total decimal(11,2), 
	@Estado varchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [venta]
	SET
		[idcliente] = @Idcliente, 
		[idusuario] = @Idusuario, 
		[tipo_comprobante] = @TipoComprobante, 
		[serie_comprobante] = @SerieComprobante, 
		[num_comprobante] = @NumComprobante, 
		[fecha_hora] = @FechaHora, 
		[impuesto] = @Impuesto, 
		[total] = @Total, 
		[estado] = @Estado
	WHERE
		([idventa] = @Idventa)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ventaLoadByPrimaryKey]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ventaLoadByPrimaryKey]
(
	@Idventa int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idventa], 
		[idcliente], 
		[idusuario], 
		[tipo_comprobante], 
		[serie_comprobante], 
		[num_comprobante], 
		[fecha_hora], 
		[impuesto], 
		[total], 
		[estado]
	FROM [dbo].[venta]
	WHERE
		([idventa] = @Idventa)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ventaLoadAll]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ventaLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[idventa], 
		[idcliente], 
		[idusuario], 
		[tipo_comprobante], 
		[serie_comprobante], 
		[num_comprobante], 
		[fecha_hora], 
		[impuesto], 
		[total], 
		[estado]
	FROM [dbo].[venta]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ventaInsert]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ventaInsert]
(
	@Idventa int = NULL OUTPUT, 
	@Idcliente int, 
	@Idusuario int, 
	@TipoComprobante varchar(20), 
	@SerieComprobante varchar(7) = NULL, 
	@NumComprobante varchar(10), 
	@FechaHora datetime, 
	@Impuesto decimal(4,2), 
	@Total decimal(11,2), 
	@Estado varchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [venta]
	(
		[idcliente], 
		[idusuario], 
		[tipo_comprobante], 
		[serie_comprobante], 
		[num_comprobante], 
		[fecha_hora], 
		[impuesto], 
		[total], 
		[estado]
	)
	
	VALUES
	(
		@Idcliente, 
		@Idusuario, 
		@TipoComprobante, 
		@SerieComprobante, 
		@NumComprobante, 
		@FechaHora, 
		@Impuesto, 
		@Total, 
		@Estado
	)


	SET @Err = @@Error

		
	SELECT @Idventa = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ventaDelete]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ventaDelete]
(
	@Idventa int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[venta]
	WHERE
		([idventa] = @Idventa)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[iddetalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[idventa] [int] NOT NULL,
	[idarticulo] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio] [decimal](11, 2) NOT NULL,
	[descuento] [decimal](11, 2) NOT NULL,
 CONSTRAINT [PK_ID] PRIMARY KEY CLUSTERED 
(
	[iddetalle_venta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[proc_detalle_ventaUpdate]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_detalle_ventaUpdate]
(
	@IddetalleVenta int, 
	@Idventa int, 
	@Idarticulo int, 
	@Cantidad int, 
	@Precio decimal(11,2), 
	@Descuento decimal(11,2)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [detalle_venta]
	SET
		[idventa] = @Idventa, 
		[idarticulo] = @Idarticulo, 
		[cantidad] = @Cantidad, 
		[precio] = @Precio, 
		[descuento] = @Descuento
	WHERE
		([iddetalle_venta] = @IddetalleVenta)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_detalle_ventaLoadByPrimaryKey]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_detalle_ventaLoadByPrimaryKey]
(
	@IddetalleVenta int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[iddetalle_venta], 
		[idventa], 
		[idarticulo], 
		[cantidad], 
		[precio], 
		[descuento]
	FROM [dbo].[detalle_venta]
	WHERE
		([iddetalle_venta] = @IddetalleVenta)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_detalle_ventaLoadAll]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_detalle_ventaLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[iddetalle_venta], 
		[idventa], 
		[idarticulo], 
		[cantidad], 
		[precio], 
		[descuento]
	FROM [dbo].[detalle_venta]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_detalle_ventaInsert]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_detalle_ventaInsert]
(
	@IddetalleVenta int = NULL OUTPUT, 
	@Idventa int, 
	@Idarticulo int, 
	@Cantidad int, 
	@Precio decimal(11,2), 
	@Descuento decimal(11,2)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [detalle_venta]
	(
		[idventa], 
		[idarticulo], 
		[cantidad], 
		[precio], 
		[descuento]
	)
	
	VALUES
	(
		@Idventa, 
		@Idarticulo, 
		@Cantidad, 
		@Precio, 
		@Descuento
	)


	SET @Err = @@Error

		
	SELECT @IddetalleVenta = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_detalle_ventaDelete]    Script Date: 06/01/2021 15:53:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_detalle_ventaDelete]
(
	@IddetalleVenta int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[detalle_venta]
	WHERE
		([iddetalle_venta] = @IddetalleVenta)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  Default [DF__categoria__estad__00551192]    Script Date: 06/01/2021 15:53:11 ******/
ALTER TABLE [dbo].[categoria] ADD  DEFAULT ((1)) FOR [estado]
GO
/****** Object:  Default [DF__rol__estado__09DE7BCC]    Script Date: 06/01/2021 15:53:11 ******/
ALTER TABLE [dbo].[rol] ADD  DEFAULT ((1)) FOR [estado]
GO
/****** Object:  Default [DF__usuario__estado__0CBAE877]    Script Date: 06/01/2021 15:53:11 ******/
ALTER TABLE [dbo].[usuario] ADD  DEFAULT ((1)) FOR [estado]
GO
/****** Object:  Default [DF__articulo__estado__0425A276]    Script Date: 06/01/2021 15:53:11 ******/
ALTER TABLE [dbo].[articulo] ADD  DEFAULT ((1)) FOR [estado]
GO
/****** Object:  ForeignKey [FK_IDROL]    Script Date: 06/01/2021 15:53:11 ******/
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_IDROL] FOREIGN KEY([idrol])
REFERENCES [dbo].[rol] ([idrol])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_IDROL]
GO
/****** Object:  ForeignKey [FK_IDCATEGORIA]    Script Date: 06/01/2021 15:53:11 ******/
ALTER TABLE [dbo].[articulo]  WITH CHECK ADD  CONSTRAINT [FK_IDCATEGORIA] FOREIGN KEY([idcategoria])
REFERENCES [dbo].[categoria] ([idcategoria])
GO
ALTER TABLE [dbo].[articulo] CHECK CONSTRAINT [FK_IDCATEGORIA]
GO
/****** Object:  ForeignKey [FK_IDCLIENTE]    Script Date: 06/01/2021 15:53:12 ******/
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_IDCLIENTE] FOREIGN KEY([idcliente])
REFERENCES [dbo].[persona] ([idpersona])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_IDCLIENTE]
GO
/****** Object:  ForeignKey [FK_IDUSUARIO]    Script Date: 06/01/2021 15:53:12 ******/
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_IDUSUARIO] FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_IDUSUARIO]
GO
/****** Object:  ForeignKey [FK_IDARTICULO]    Script Date: 06/01/2021 15:53:12 ******/
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_IDARTICULO] FOREIGN KEY([idarticulo])
REFERENCES [dbo].[articulo] ([idarticulo])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_IDARTICULO]
GO
/****** Object:  ForeignKey [FK_IDVENTA]    Script Date: 06/01/2021 15:53:12 ******/
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_IDVENTA] FOREIGN KEY([idventa])
REFERENCES [dbo].[venta] ([idventa])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_IDVENTA]
GO

INSERT INTO rol (nombre, descripcion, estado) 
VALUES ('admin','administrador de sistema',1)

INSERT INTO usuario (idrol,usuario,password,email,estado) 
VALUES (1,'admin','admin','admin@gmail.com',1)
SELECT * FROM rol
SELECT * FROM usuario

use [BD_P1MENUDINAMICO]

Select * from usuario_t
INSERT INTO usuario_t (usuario, clave) VALUES ('yorki', 'yorki')