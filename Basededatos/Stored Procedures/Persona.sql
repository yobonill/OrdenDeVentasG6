
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

