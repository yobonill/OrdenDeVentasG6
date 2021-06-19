

USE [OrdenVentasDB]
GO

/****** Object:  StoredProcedure [dbo].[proc_articuloLoadByPrimaryKey] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_articuloLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_articuloLoadByPrimaryKey];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_articuloLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_articuloLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_articuloLoadAll] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_articuloLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_articuloLoadAll];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_articuloLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_articuloLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_articuloUpdate] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_articuloUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_articuloUpdate];
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



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_articuloUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_articuloUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_articuloInsert] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_articuloInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_articuloInsert];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_articuloInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_articuloInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_articuloDelete] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_articuloDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_articuloDelete];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_articuloDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_articuloDelete Error on Creation'
GO 

