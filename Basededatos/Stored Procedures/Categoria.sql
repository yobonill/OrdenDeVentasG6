
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

