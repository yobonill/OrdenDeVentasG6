

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


USE [OrdenVentasDB]
GO

/****** Object:  StoredProcedure [dbo].[proc_categoriaLoadByPrimaryKey] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_categoriaLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_categoriaLoadByPrimaryKey];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_categoriaLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_categoriaLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_categoriaLoadAll] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_categoriaLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_categoriaLoadAll];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_categoriaLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_categoriaLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_categoriaUpdate] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_categoriaUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_categoriaUpdate];
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



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_categoriaUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_categoriaUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_categoriaInsert] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_categoriaInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_categoriaInsert];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_categoriaInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_categoriaInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_categoriaDelete] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_categoriaDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_categoriaDelete];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_categoriaDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_categoriaDelete Error on Creation'
GO 


USE [OrdenVentasDB]
GO

/****** Object:  StoredProcedure [dbo].[proc_detalle_ventaLoadByPrimaryKey] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_detalle_ventaLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_detalle_ventaLoadByPrimaryKey];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_detalle_ventaLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_detalle_ventaLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_detalle_ventaLoadAll] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_detalle_ventaLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_detalle_ventaLoadAll];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_detalle_ventaLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_detalle_ventaLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_detalle_ventaUpdate] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_detalle_ventaUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_detalle_ventaUpdate];
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



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_detalle_ventaUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_detalle_ventaUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_detalle_ventaInsert] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_detalle_ventaInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_detalle_ventaInsert];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_detalle_ventaInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_detalle_ventaInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_detalle_ventaDelete] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_detalle_ventaDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_detalle_ventaDelete];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_detalle_ventaDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_detalle_ventaDelete Error on Creation'
GO 


USE [OrdenVentasDB]
GO

/****** Object:  StoredProcedure [dbo].[proc_personaLoadByPrimaryKey] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_personaLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_personaLoadByPrimaryKey];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_personaLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_personaLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_personaLoadAll] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_personaLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_personaLoadAll];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_personaLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_personaLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_personaUpdate] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_personaUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_personaUpdate];
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



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_personaUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_personaUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_personaInsert] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_personaInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_personaInsert];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_personaInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_personaInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_personaDelete] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_personaDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_personaDelete];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_personaDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_personaDelete Error on Creation'
GO 


USE [OrdenVentasDB]
GO

/****** Object:  StoredProcedure [dbo].[proc_rolLoadByPrimaryKey] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_rolLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_rolLoadByPrimaryKey];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_rolLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_rolLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_rolLoadAll] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_rolLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_rolLoadAll];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_rolLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_rolLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_rolUpdate] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_rolUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_rolUpdate];
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



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_rolUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_rolUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_rolInsert] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_rolInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_rolInsert];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_rolInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_rolInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_rolDelete] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_rolDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_rolDelete];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_rolDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_rolDelete Error on Creation'
GO 


USE [OrdenVentasDB]
GO

/****** Object:  StoredProcedure [dbo].[proc_usuarioLoadByPrimaryKey] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_usuarioLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_usuarioLoadByPrimaryKey];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_usuarioLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_usuarioLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_usuarioLoadAll] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_usuarioLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_usuarioLoadAll];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_usuarioLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_usuarioLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_usuarioUpdate] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_usuarioUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_usuarioUpdate];
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



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_usuarioUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_usuarioUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_usuarioInsert] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_usuarioInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_usuarioInsert];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_usuarioInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_usuarioInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_usuarioDelete] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_usuarioDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_usuarioDelete];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_usuarioDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_usuarioDelete Error on Creation'
GO 


USE [OrdenVentasDB]
GO

/****** Object:  StoredProcedure [dbo].[proc_ventaLoadByPrimaryKey] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_ventaLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_ventaLoadByPrimaryKey];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ventaLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_ventaLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_ventaLoadAll] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_ventaLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_ventaLoadAll];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ventaLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_ventaLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_ventaUpdate] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_ventaUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_ventaUpdate];
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



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ventaUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_ventaUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_ventaInsert] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_ventaInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_ventaInsert];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ventaInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_ventaInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_ventaDelete] Script Date: 1/6/2021 3:15:25 p. m. ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_ventaDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_ventaDelete];
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


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_ventaDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_ventaDelete Error on Creation'
GO 

