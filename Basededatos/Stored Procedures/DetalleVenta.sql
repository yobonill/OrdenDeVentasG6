
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

