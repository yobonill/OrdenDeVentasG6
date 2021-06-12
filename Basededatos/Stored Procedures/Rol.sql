
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

