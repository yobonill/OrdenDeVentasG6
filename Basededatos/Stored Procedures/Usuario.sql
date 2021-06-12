
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

