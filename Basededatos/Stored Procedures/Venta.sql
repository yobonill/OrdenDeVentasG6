
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

