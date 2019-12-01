USE
[master]
/****** Object:  Database [PuntoVentaDB]    Script Date: 11/2/2019 4:20:32 PM ******/
CREATE DATABASE [PuntoVentaDB]

USE [PuntoVentaDB]
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[IDArticulo] [int] IDENTITY(1,1) NOT NULL,
	[IDCategoria] [int] NOT NULL,
	[IDPresentacion] [int] NOT NULL,
	[Codigo_Articulo] [varchar](20) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Imagen] [image] NULL,
	[Estatus] [int] NOT NULL,
 CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
(
	[IDArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[IDCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Estatus] [int] NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[IDCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IDCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Sexo] [varchar](6) NOT NULL,
	[Fecha_Nacimineto] [date] NULL,
	[Tipo_Documento] [varchar](50) NOT NULL,
	[Num_Documeto] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Email] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuentaPorCobrar]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaPorCobrar](
	[IDCxC] [int] IDENTITY(1,1) NOT NULL,
	[IDCliente] [int] NOT NULL,
	[IDFactura] [int] NOT NULL,
	[Documento] [varchar](50) NULL,
	[Monto] [numeric](18, 2) NULL,
	[Observacion] [varchar](100) NULL,
	[Fecha_A_Cobrar] [date] NULL,
	[Tipo] [varchar](10) NULL,
 CONSTRAINT [PK_CuntaXcobrar] PRIMARY KEY CLUSTERED 
(
	[IDCxC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Menu]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[IDMenu] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Activa] [int] NULL,
 CONSTRAINT [PK_IDMenu] PRIMARY KEY CLUSTERED 
(
	[IDMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Presentacion]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Presentacion](
	[IDPresentacion] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Estatus] [int] NOT NULL,
 CONSTRAINT [PK_Presentacion] PRIMARY KEY CLUSTERED 
(
	[IDPresentacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IDProveedor] [int] IDENTITY(1,1) NOT NULL,
	[razon_social] [varchar](50) NULL,
	[Sector_Comercial] [varchar](50) NOT NULL,
	[Identificacion] [numeric](18, 0) NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [numeric](18, 0) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IDProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubMenu]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubMenu](
	[IDSubMenu] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[IDMenu] [int] NOT NULL,
	[Activa] [int] NULL,
	[imagen] [varchar](250) NULL,
 CONSTRAINT [PK_SubMenu] PRIMARY KEY CLUSTERED 
(
	[IDMenu] ASC,
	[IDSubMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trabajador]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trabajador](
	[IDTrabajador] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Sexo] [varchar](10) NOT NULL,
	[Fecha_Nacimiento] [date] NOT NULL,
	[Cedula] [varchar](15) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [numeric](18, 0) NOT NULL,
	[Email] [varchar](20) NULL,
	[Salario] [numeric](14, 2) NOT NULL,
	[Usuario] [varchar](10) NULL,
	[Password] [varchar](10) NULL,
	[Rango] [varchar](20) NULL,
	[Cargo] [varchar](50) NOT NULL,
	[Estatus] [int] NOT NULL,
 CONSTRAINT [PK_Trabajador] PRIMARY KEY CLUSTERED 
(
	[IDTrabajador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



CREATE TABLE [dbo].[Privilegio](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](10) NOT NULL,
	[Clave] [varchar](10) NOT NULL,
	[rango] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Articulo] ADD  CONSTRAINT [DF_Articulo_Estatus]  DEFAULT ((1)) FOR [Estatus]
GO
ALTER TABLE [dbo].[Trabajador] ADD  CONSTRAINT [DF_Trabajador_Estatus]  DEFAULT ((1)) FOR [Estatus]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_Articulo_Categoria] FOREIGN KEY([IDCategoria])
REFERENCES [dbo].[Categoria] ([IDCategoria])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_Articulo_Categoria]
GO
ALTER TABLE [dbo].[Articulo]  WITH CHECK ADD  CONSTRAINT [FK_Articulo_Presentacion] FOREIGN KEY([IDPresentacion])
REFERENCES [dbo].[Presentacion] ([IDPresentacion])
GO
ALTER TABLE [dbo].[Articulo] CHECK CONSTRAINT [FK_Articulo_Presentacion]
GO
ALTER TABLE [dbo].[CuentaPorCobrar]  WITH CHECK ADD  CONSTRAINT [FK_CuentaPorCobrar_Clientes] FOREIGN KEY([IDCliente])
REFERENCES [dbo].[Cliente] ([IDCliente])
GO
ALTER TABLE [dbo].[CuentaPorCobrar] CHECK CONSTRAINT [FK_CuentaPorCobrar_Clientes]
GO


/****** Object:  StoredProcedure [dbo].[proc_ArticuloDelete]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ArticuloDelete]
(
	@IDArticulo numeric(12,0)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	Update [dbo].[Articulo] set Estatus =0
	WHERE
		([IDArticulo] = @IDArticulo)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ArticuloInsert]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ArticuloInsert]
(
	@Codigo_Articulo varchar(20) = NULL, 
	@Nombre varchar(50) = NULL, 
	@Imagen image = NULL, 
	@IDCategoria int = NULL, 
	@IDPresentacion int = NULL,
	@descripcion varchar(100)=null,
	@Estatus int =null
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	INSERT
	INTO [Articulo]
	(
		[IDCategoria], 
		[IDPresentacion],
		[Codigo_Articulo],
		[Nombre], 
		[Descripcion],
		[Imagen], 
		[Estatus]
	)
	
	VALUES
	(
		@IDCategoria, 
		@IDPresentacion,
		@Codigo_Articulo,
		@Nombre, 
		@descripcion,
		@Imagen, 
		@Estatus
	)


	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ArticuloLoadAll]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ArticuloLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		a.IDArticulo,
		a.Codigo_Articulo, 
		a.Nombre, 
		[Imagen], 
		c.Nombre as Categoria, 
		p.Nombre as Presentacion,
		a.Descripcion
	FROM [dbo].[Articulo] a,Categoria c,Presentacion p 
	where a.IDCategoria = c.IDCategoria 
	and a.IDPresentacion = p.IDPresentacion
	and a.Estatus = 1;

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ArticuloLoadById]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ArticuloLoadById]
(
	@Codigo_Articulo varchar(20)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		a.IDArticulo,
		a.Codigo_Articulo, 
		a.Nombre, 
		[Imagen], 
		c.Nombre as Categoria, 
		p.Nombre as Presentacion,
		a.Descripcion
	FROM [dbo].[Articulo] a,Categoria c,Presentacion p
	WHERE
		a.Codigo_Articulo like @Codigo_Articulo+'%' 
		and a.IDCategoria = c.IDCategoria 
		and a.IDPresentacion = p.IDPresentacion 
		and a.Estatus = 1

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ArticuloUpdate]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ArticuloUpdate]
(
	@IDArticulo int, 
	@IDCategoria int = NULL, 
	@IDPresentacion int = NULL,
	@Codigo_Articulo varchar(10) = NULL, 
	@Nombre varchar(50) = NULL, 
	@Imagen image = NULL, 
	@Descripcion varchar(100) = null,
	@Estatus int =null
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	UPDATE [Articulo]
	SET
		[IDCategoria] = @IDCategoria, 
		[IDPresentacion] = @IDPresentacion,
		[Codigo_Articulo] = @Codigo_Articulo, 
		[Nombre] = @Nombre, 
		[Imagen] = @Imagen, 
		[Descripcion] =@Descripcion,
		[Estatus] = @Estatus
	WHERE
		([IDArticulo] = @IDArticulo)

	SET @Err = @@Error


	RETURN @Err
END

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_CategoriaDelete]
(
	@IDCategoria numeric(12,0)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[Categoria]
	WHERE
		([IDCategoria] = @IDCategoria)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_CategoriaInsert]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_CategoriaInsert]
(
	@IDCategoria numeric(12,0), 
	@Nombre varchar(50), 
	@Descripcion varchar(100)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Categoria]
	(
		[IDCategoria], 
		[Nombre], 
		[Descripcion]
	)
	
	VALUES
	(
		@IDCategoria, 
		@Nombre, 
		@Descripcion
	)


	SET @Err = @@Error



	

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_CategoriaLoadAll]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_CategoriaLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDCategoria], 
		[Nombre], 
		[Descripcion]
	FROM [dbo].[Categoria]

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_CategoriaLoadById]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_CategoriaLoadById]
(
	@IDCategoria int	
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDCategoria], 
		[Nombre], 
		[Descripcion]
	FROM [dbo].[Categoria]
	WHERE
		([IDCategoria] = @IDCategoria) 

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_CategoriaUpdate]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_CategoriaUpdate]
(
	@IDCategoria numeric(12,0), 
	@Nombre varchar(50), 
	@Descripcion varchar(100)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [Categoria]
	SET
		[Nombre] = @Nombre, 
		[Descripcion] = @Descripcion
	WHERE
		([IDCategoria] = @IDCategoria)

	SET @Err = @@Error


	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ClienteDelete]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ClienteDelete]
(
	@IDCliente numeric(12,0)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[Cliente]
	WHERE
		([IDCliente] = @IDCliente)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ClienteInsert]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ClienteInsert]
(
	@IDCliente numeric(12,0) = NULL OUTPUT, 
	@Nombre varchar(20), 
	@Apellido varchar(50), 
	@Sexo varchar(6) = NULL, 
	@FechaNacimineto date = NULL, 
	@TipoDocumento varchar(50), 
	@NumDocumeto varchar(50), 
	@Telefono numeric(18,0) = NULL, 
	@Direccion varchar(100) = NULL, 
	@Email varchar(20) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Cliente]
	(
		[Nombre], 
		[Apellido], 
		[Sexo], 
		[Fecha_Nacimineto], 
		[Tipo_Documento], 
		[Num_Documeto], 
		[Telefono], 
		[Direccion], 
		[Email]
	)
	
	VALUES
	(
		@Nombre, 
		@Apellido, 
		@Sexo, 
		@FechaNacimineto, 
		@TipoDocumento, 
		@NumDocumeto, 
		@Telefono, 
		@Direccion, 
		@Email
	)


	SET @Err = @@Error

		
	SELECT @IDCliente = SCOPE_IDENTITY()

	

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ClienteLoadAll]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ClienteLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDCliente], 
		[Nombre], 
		[Apellido], 
		[Sexo], 
		[Fecha_Nacimineto], 
		[Tipo_Documento], 
		[Num_Documeto], 
		[Telefono], 
		[Direccion], 
		[Email]
	FROM [dbo].[Cliente]

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ClienteLoadById]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ClienteLoadById]
(
	@IDCliente numeric(12,0)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDCliente], 
		[Nombre], 
		[Apellido], 
		[Sexo], 
		[Fecha_Nacimineto], 
		[Tipo_Documento], 
		[Num_Documeto], 
		[Telefono], 
		[Direccion], 
		[Email]
	FROM [dbo].[Cliente]
	WHERE
		([IDCliente] = @IDCliente)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ClienteUpdate]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ClienteUpdate]
(
	@IDCliente numeric(12,0), 
	@Nombre varchar(20), 
	@Apellido varchar(50), 
	@Sexo varchar(6) = NULL, 
	@FechaNacimineto date = NULL, 
	@TipoDocumento varchar(50), 
	@NumDocumeto varchar(50), 
	@Telefono numeric(18,0) = NULL, 
	@Direccion varchar(100) = NULL, 
	@Email varchar(20) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [Cliente]
	SET
		[Nombre] = @Nombre, 
		[Apellido] = @Apellido, 
		[Sexo] = @Sexo, 
		[Fecha_Nacimineto] = @FechaNacimineto, 
		[Tipo_Documento] = @TipoDocumento, 
		[Num_Documeto] = @NumDocumeto, 
		[Telefono] = @Telefono, 
		[Direccion] = @Direccion, 
		[Email] = @Email
	WHERE
		([IDCliente] = @IDCliente)

	SET @Err = @@Error


	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_MenuDelete]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_MenuDelete]
(
	@IDMenu int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[Menu]
	WHERE
		([IDMenu] = @IDMenu)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_MenuInsert]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_MenuInsert]
(
	@IDMenu int, 
	@Nombre varchar(100), 
	@Activa int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Menu]
	(
		[IDMenu], 
		[Nombre], 
		[Activa]
	)
	
	VALUES
	(
		@IDMenu, 
		@Nombre, 
		@Activa
	)


	SET @Err = @@Error



	

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_MenuLoadAll]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_MenuLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDMenu], 
		[Nombre], 
		[Activa]
	FROM [dbo].[Menu]

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_MenuLoadById]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_MenuLoadById]
(
	@IDMenu int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDMenu], 
		[Nombre], 
		[Activa]
	FROM [dbo].[Menu]
	WHERE
		([IDMenu] = @IDMenu)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_MenuUpdate]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_MenuUpdate]
(
	@IDMenu int, 
	@Nombre varchar(100), 
	@Activa int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [Menu]
	SET
		[Nombre] = @Nombre, 
		[Activa] = @Activa
	WHERE
		([IDMenu] = @IDMenu)

	SET @Err = @@Error


	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_PresentacionDelete]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_PresentacionDelete]
(
	@IDPresentacion int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[Presentacion]
	WHERE
		([IDPresentacion] = @IDPresentacion)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_PresentacionInsert]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_PresentacionInsert]
(
	@Nombre varchar(50), 
	@Descripcion varchar(100)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Presentacion]
	(
		[Nombre], 
		[Descripcion]
	)
	
	VALUES
	(
		@Nombre, 
		@Descripcion
	)


	SET @Err = @@Error



	

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_PresentacionLoadAll]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_PresentacionLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDPresentacion], 
		[Nombre], 
		[Descripcion]
	FROM [dbo].[Presentacion]

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_PresentacionLoadById]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_PresentacionLoadById]
(
	@IDPresentacion numeric(12,0)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDPresentacion], 
		[Nombre], 
		[Descripcion]
	FROM [dbo].[Presentacion]
	WHERE
		([IDPresentacion] = @IDPresentacion)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_PresentacionUpdate]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_PresentacionUpdate]
(
	@IDPresentacion int, 
	@Nombre varchar(50), 
	@Descripcion varchar(100)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [Presentacion]
	SET
		[Nombre] = @Nombre, 
		[Descripcion] = @Descripcion
	WHERE
		([IDPresentacion] = @IDPresentacion)

	SET @Err = @@Error


	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ProveedorDelete]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ProveedorDelete]
(
	@IDProveedor numeric(12,0)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[Proveedor]
	WHERE
		([IDProveedor] = @IDProveedor)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ProveedorInsert]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ProveedorInsert]
(
	@IDProveedor numeric(12,0), 
	@SectorComercial varchar(50), 
	@Identificacion numeric(18,0) = NULL, 
	@Direccion varchar(100), 
	@Telefono numeric(18,0) = NULL, 
	@Email varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Proveedor]
	(
		[IDProveedor], 
		[Sector_Comercial], 
		[Identificacion], 
		[Direccion], 
		[Telefono], 
		[Email]
	)
	
	VALUES
	(
		@IDProveedor, 
		@SectorComercial, 
		@Identificacion, 
		@Direccion, 
		@Telefono, 
		@Email
	)


	SET @Err = @@Error



	

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ProveedorLoadAll]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ProveedorLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDProveedor], 
		[Sector_Comercial], 
		[Identificacion], 
		[Direccion], 
		[Telefono], 
		[Email]
	FROM [dbo].[Proveedor]

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ProveedorLoadById]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ProveedorLoadById]
(
	@IDProveedor numeric(12,0)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDProveedor], 
		[Sector_Comercial], 
		[Identificacion], 
		[Direccion], 
		[Telefono], 
		[Email]
	FROM [dbo].[Proveedor]
	WHERE
		([IDProveedor] = @IDProveedor)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ProveedorUpdate]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_ProveedorUpdate]
(
	@IDProveedor numeric(12,0), 
	@SectorComercial varchar(50), 
	@Identificacion numeric(18,0) = NULL, 
	@Direccion varchar(100), 
	@Telefono numeric(18,0) = NULL, 
	@Email varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [Proveedor]
	SET
		[Sector_Comercial] = @SectorComercial, 
		[Identificacion] = @Identificacion, 
		[Direccion] = @Direccion, 
		[Telefono] = @Telefono, 
		[Email] = @Email
	WHERE
		([IDProveedor] = @IDProveedor)

	SET @Err = @@Error


	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SubMenuDelete]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_SubMenuDelete]
(
	@IDSubMenu int, 
	@IDMenu int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[SubMenu]
	WHERE
		([IDMenu] = @IDMenu) AND 
		([IDSubMenu] = @IDSubMenu)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SubMenuInsert]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_SubMenuInsert]
(
	@IDSubMenu int, 
	@Nombre varchar(100), 
	@IDMenu int, 
	@Activa int = NULL, 
	@Imagen varchar(250) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [SubMenu]
	(
		[IDSubMenu], 
		[Nombre], 
		[IDMenu], 
		[Activa], 
		[imagen]
	)
	
	VALUES
	(
		@IDSubMenu, 
		@Nombre, 
		@IDMenu, 
		@Activa, 
		@Imagen
	)


	SET @Err = @@Error



	

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SubMenuLoadAll]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_SubMenuLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDSubMenu], 
		[Nombre], 
		[IDMenu], 
		[Activa], 
		[imagen]
	FROM [dbo].[SubMenu]

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SubMenuLoadById]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_SubMenuLoadById]
(
	@IDMenu int, 
	@IDSubMenu int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDSubMenu], 
		[Nombre], 
		[IDMenu], 
		[Activa], 
		[imagen]
	FROM [dbo].[SubMenu]
	WHERE
		([IDMenu] = @IDMenu) AND 
		([IDSubMenu] = @IDSubMenu)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_SubMenuUpdate]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_SubMenuUpdate]
(
	@IDSubMenu int, 
	@Nombre varchar(100), 
	@IDMenu int, 
	@Activa int = NULL, 
	@Imagen varchar(250) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [SubMenu]
	SET
		[Nombre] = @Nombre, 
		[Activa] = @Activa, 
		[imagen] = @Imagen
	WHERE
		([IDMenu] = @IDMenu) AND 
		([IDSubMenu] = @IDSubMenu)

	SET @Err = @@Error


	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_TrabajadorDelete]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_TrabajadorDelete]
(
	@IDTrabajador numeric(12,0)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	Update
	[dbo].[Trabajador] set Estatus=0
	WHERE
		([IDTrabajador] = @IDTrabajador)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_TrabajadorInsert]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_TrabajadorInsert]
(
	@Nombre varchar(50) = NULL, 
	@Apellido varchar(50) = NULL, 
	@Sexo varchar(10) = NULL, 
	@FechaNacimiento date = NULL, 
	@Cedula varchar(15) = NULL, 
	@Direccion varchar(50) = NULL, 
	@Telefono numeric(18,0) = NULL, 
	@Email varchar(20) = NULL, 
	@Salario numeric(14,2) = NULL, 
	@Usuario varchar(10), 
	@Password varchar(10), 
	@Rango varchar(10),
	@Cargo varchar(50) = NULL, 
	@Estatus int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	INSERT
	INTO [Trabajador]
	(
		[Nombre], 
		[Apellido], 
		[Sexo], 
		[Fecha_Nacimiento], 
		[Cedula], 
		[Direccion], 
		[Telefono], 
		[Email], 
		[Salario], 
		[Usuario], 
		[Password],
		[Rango], 
		[Cargo], 
		[Estatus]
	)
	
	VALUES
	(
		@Nombre, 
		@Apellido, 
		@Sexo, 
		@FechaNacimiento, 
		@Cedula, 
		@Direccion, 
		@Telefono, 
		@Email, 
		@Salario, 
		@Usuario, 
		@Password, 
		@Rango,
		@Cargo, 
		@Estatus
	)

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_TrabajadorLoadAll]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_TrabajadorLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDTrabajador],
		[Nombre], 
		[Apellido], 
		[Sexo], 
		[Fecha_Nacimiento], 
		[Cedula], 
		[Direccion], 
		[Telefono], 
		[Email], 
		[Salario],
		[Cargo],
		[Usuario], 
		[Password],
		[Rango]
		
	FROM [dbo].[Trabajador] where Estatus = 1

	SET @Err = @@Error

	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_TrabajadorLoadById]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_TrabajadorLoadById]
(
	@Nombre varchar(50)
)
AS
BEGIN

SET NOCOUNT ON
	DECLARE @Err int
	
	SELECT
		[IDTrabajador],
		[Nombre], 
		[Apellido], 
		[Sexo], 
		[Fecha_Nacimiento], 
		[Cedula], 
		[Direccion], 
		[Telefono], 
		[Email], 
		[Salario],
		[Cargo],
		[Usuario], 
		[Password],
		[Rango]
	FROM [dbo].[Trabajador]
	WHERE
		Nombre like @Nombre+'%' and Estatus = 1

 	SET @Err = @@Error

	RETURN @Err
END



GO
/****** Object:  StoredProcedure [dbo].[proc_TrabajadorUpdate]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_TrabajadorUpdate]
(
	@IDTrabajador int, 
	@Nombre varchar(50) = NULL, 
	@Apellido varchar(50) = NULL, 
	@Sexo varchar(10) = NULL, 
	@FechaNacimiento date = NULL, 
	@Cedula varchar(15) = NULL, 
	@Direccion varchar(50) = NULL, 
	@Telefono numeric(18,0) = NULL, 
	@Email varchar(20) = NULL, 
	@Salario numeric(14,2) = NULL, 
	@Rango varchar(10) = NULL, 
	@Usuario varchar(10), 
	@Password varchar(10), 
	@Cargo varchar(50) = NULL, 
	@Estatus int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [Trabajador]
	SET
		[Nombre] = @Nombre, 
		[Apellido] = @Apellido, 
		[Sexo] = @Sexo, 
		[Fecha_Nacimiento] = @FechaNacimiento, 
		[Cedula] = @Cedula, 
		[Direccion] = @Direccion, 
		[Telefono] = @Telefono, 
		[Email] = @Email, 
		[Salario] = @Salario, 
		[Rango] = @Rango, 
		[Usuario] = @Usuario, 
		[Password] = @Password, 
		[Cargo] = @Cargo, 
		[Estatus] = @Estatus
	WHERE
		([IDTrabajador] = @IDTrabajador)

	SET @Err = @@Error


	RETURN @Err
END

GO
/****** Object:  StoredProcedure [dbo].[proc_UsuarioDelete]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[proc_UsuarioDelete]
(	
	@ID int
)
as
begin
	Delete Usuario where ID = @ID;
end

GO
/****** Object:  StoredProcedure [dbo].[proc_UsuarioInsert]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[proc_UsuarioInsert]
(	
	@nombre varchar(10),
	@clave varchar(10),
	@rango varchar(10)
)
as
begin
	insert into Usuario (Nombre,Clave,rango) 
	values(@nombre,@clave,@rango);
end

GO
/****** Object:  StoredProcedure [dbo].[proc_UsuarioLoadAll]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[proc_UsuarioLoadAll]
as
begin
	Select * from Usuario;
end
GO
/****** Object:  StoredProcedure [dbo].[proc_UsuarioUpdate]    Script Date: 11/2/2019 4:20:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[proc_UsuarioUpdate]
(	
	@ID int,
	@nombre varchar(10),
	@clave varchar(10),
	@rango varchar(10)
)
as
begin
	Update Usuario set Nombre =@nombre ,Clave = @clave, rango = @rango
		where ID = @ID;
end

GO
/****** Object:  StoredProcedure [dbo].[proc_ValidarUsuario]    Script Date: 11/7/2019 9:53:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_ValidarUsuario]
(
 	@Usuario varchar(10),
 	@Password varchar(10)
)
 as
 begin
	select Usuario, Password,Rango 
	from Trabajador
	where Usuario = @Usuario
		and Password = @Password
		and Estatus = 1
	
 end

GO



/*||||||||||||||||||||||||||||||||||||||||||||************LUIS BILL************||||||||||||||||||||||||||||||||||||||||||||||||||||**/

USE [PuntoVentaDB]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaMostrarDetalle]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaMostrarDetalle]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaLoadAll]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaLoadAll]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaInsert]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaInsert]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaGenerarId]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaGenerarId]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaDisminuirstock]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaDisminuirstock]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarFechaAnulado]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaBuscarFechaAnulado]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarFecha]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaBuscarFecha]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarClienteNombre]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaBuscarClienteNombre]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarClienteDocumento]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaBuscarClienteDocumento]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarArticuloNombre]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaBuscarArticuloNombre]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarArticuloId]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaBuscarArticuloId]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarArticuloCodigo]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaBuscarArticuloCodigo]
GO
/****** Object:  StoredProcedure [dbo].[proc_VentaAnular]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_VentaAnular]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoUpdate]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoUpdate]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoMostrarDetalle]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoMostrarDetalle]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoLoadAll]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoLoadAll]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoInsert]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoInsert]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoGenerarId]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoGenerarId]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoDelete]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoDelete]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarProveedorRnc]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoBuscarProveedorRnc]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarProveedorRazon]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoBuscarProveedorRazon]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarFecha]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoBuscarFecha]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarArticuloNombre]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoBuscarArticuloNombre]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarArticuloId]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoBuscarArticuloId]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarArticuloCodigo]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoBuscarArticuloCodigo]
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoAnular]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_IngresoAnular]
GO
/****** Object:  StoredProcedure [dbo].[proc_Detalle_VentaLoadAll]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_Detalle_VentaLoadAll]
GO
/****** Object:  StoredProcedure [dbo].[proc_Detalle_VentaInsert]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_Detalle_VentaInsert]
GO
/****** Object:  StoredProcedure [dbo].[proc_Detalle_IngresoLoadAll]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_Detalle_IngresoLoadAll]
GO
/****** Object:  StoredProcedure [dbo].[proc_Detalle_IngresoInsert]    Script Date: 12/11/2019 14:34:50 ******/
DROP PROCEDURE [dbo].[proc_Detalle_IngresoInsert]
GO
ALTER TABLE [dbo].[Venta] DROP CONSTRAINT [FK_Venta_Trabajador]
GO
ALTER TABLE [dbo].[Venta] DROP CONSTRAINT [FK_Venta_Clientes]
GO
ALTER TABLE [dbo].[Ingreso] DROP CONSTRAINT [FK_Ingreso_Trabajador]
GO
ALTER TABLE [dbo].[Ingreso] DROP CONSTRAINT [FK_Ingreso_Provedor]
GO
ALTER TABLE [dbo].[Detalle_Venta] DROP CONSTRAINT [FK_Detalle_Venta_Venta]
GO
ALTER TABLE [dbo].[Detalle_Venta] DROP CONSTRAINT [FK_Detalle_Venta_Ingreso]
GO
ALTER TABLE [dbo].[Detalle_Ingreso] DROP CONSTRAINT [FK_Detalle_Ingreso_Ingreso]
GO
ALTER TABLE [dbo].[Detalle_Ingreso] DROP CONSTRAINT [FK_Detalle_Ingreso_Articulo]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 12/11/2019 14:34:50 ******/
DROP TABLE [dbo].[Venta]
GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 12/11/2019 14:34:50 ******/
DROP TABLE [dbo].[Ingreso]
GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 12/11/2019 14:34:50 ******/
DROP TABLE [dbo].[Detalle_Venta]
GO
/****** Object:  Table [dbo].[Detalle_Ingreso]    Script Date: 12/11/2019 14:34:50 ******/
DROP TABLE [dbo].[Detalle_Ingreso]
GO
/****** Object:  Table [dbo].[Detalle_Ingreso]    Script Date: 12/11/2019 14:34:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Ingreso](
	[IDDetalle_Ingreso] [int] IDENTITY(1,1) NOT NULL,
	[IDIngreso] [int] NOT NULL,
	[IDArticulo] [int] NOT NULL,
	[Precio_compra] [numeric](18, 2) NULL,
	[Precio_Venta] [numeric](18, 2) NULL,
	[Stock_Inicial] [numeric](18, 0) NULL,
	[Stock_Actual] [numeric](18, 0) NULL,
	[Fecha_produccion] [date] NULL,
	[Fecha_vencimiento] [date] NULL,
 CONSTRAINT [PK_Detalle_Ingreso] PRIMARY KEY CLUSTERED 
(
	[IDDetalle_Ingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Detalle_Venta]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Venta](
	[IDDetalle_Venta] [int] IDENTITY(1,1) NOT NULL,
	[IDDetalle_Ingreso] [int] NOT NULL,
	[IDVenta] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio_Venta] [numeric](18, 2) NOT NULL,
	[Descuento] [numeric](18, 2) NOT NULL,
 CONSTRAINT [PK_Detalle] PRIMARY KEY CLUSTERED 
(
	[IDDetalle_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ingreso](
	[IDIngreso] [int] NOT NULL,
	[IDTrabajador] [int] NOT NULL,
	[IDProveedor] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Tipo_Pago] [varchar](20) NOT NULL,
	[Num_Comprobante] [varchar](20) NULL,
	[IGV] [numeric](18, 0) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Ingreso] PRIMARY KEY CLUSTERED 
(
	[IDIngreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[IDVenta] [int] NOT NULL,
	[IDCliente] [int] NOT NULL,
	[IDTrabajador] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[Tipo_Pago] [varchar](50) NOT NULL,
	[No_Comprobante] [varchar](50) NULL,
	[No_CreFiscal] [varchar](50) NULL,
	[IGV] [numeric](11, 2) NULL,
	[No_AutTarjeta] [varchar](30) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[IDVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Detalle_Ingreso] ON 

INSERT [dbo].[Detalle_Ingreso] ([IDDetalle_Ingreso], [IDIngreso], [IDArticulo], [Precio_compra], [Precio_Venta], [Stock_Inicial], [Stock_Actual], [Fecha_produccion], [Fecha_vencimiento]) VALUES (5, 1, 2, CAST(100.00 AS Numeric(18, 2)), CAST(200.00 AS Numeric(18, 2)), CAST(10 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2019-11-11' AS Date), CAST(N'2019-11-11' AS Date))
INSERT [dbo].[Detalle_Ingreso] ([IDDetalle_Ingreso], [IDIngreso], [IDArticulo], [Precio_compra], [Precio_Venta], [Stock_Inicial], [Stock_Actual], [Fecha_produccion], [Fecha_vencimiento]) VALUES (6, 1, 1, CAST(200.00 AS Numeric(18, 2)), CAST(400.00 AS Numeric(18, 2)), CAST(15 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), CAST(N'2019-11-11' AS Date), CAST(N'2019-11-11' AS Date))
SET IDENTITY_INSERT [dbo].[Detalle_Ingreso] OFF
SET IDENTITY_INSERT [dbo].[Detalle_Venta] ON 

INSERT [dbo].[Detalle_Venta] ([IDDetalle_Venta], [IDDetalle_Ingreso], [IDVenta], [Cantidad], [Precio_Venta], [Descuento]) VALUES (4, 5, 1, 1, CAST(200.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)))
INSERT [dbo].[Detalle_Venta] ([IDDetalle_Venta], [IDDetalle_Ingreso], [IDVenta], [Cantidad], [Precio_Venta], [Descuento]) VALUES (5, 6, 1, 3, CAST(400.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)))
INSERT [dbo].[Detalle_Venta] ([IDDetalle_Venta], [IDDetalle_Ingreso], [IDVenta], [Cantidad], [Precio_Venta], [Descuento]) VALUES (6, 5, 2, 4, CAST(200.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)))
INSERT [dbo].[Detalle_Venta] ([IDDetalle_Venta], [IDDetalle_Ingreso], [IDVenta], [Cantidad], [Precio_Venta], [Descuento]) VALUES (7, 6, 2, 7, CAST(400.00 AS Numeric(18, 2)), CAST(0.00 AS Numeric(18, 2)))
SET IDENTITY_INSERT [dbo].[Detalle_Venta] OFF
INSERT [dbo].[Ingreso] ([IDIngreso], [IDTrabajador], [IDProveedor], [Fecha], [Tipo_Pago], [Num_Comprobante], [IGV], [Estado]) VALUES (1, 1, 4, CAST(N'2019-11-11 14:24:46.240' AS DateTime), N'Efectivo', N'-', CAST(18 AS Numeric(18, 0)), 1)
INSERT [dbo].[Venta] ([IDVenta], [IDCliente], [IDTrabajador], [fecha], [Tipo_Pago], [No_Comprobante], [No_CreFiscal], [IGV], [No_AutTarjeta], [Estado]) VALUES (1, 3, 1, CAST(N'2019-11-11 14:26:20.163' AS DateTime), N'Efectivo', N'', N'', CAST(18.00 AS Numeric(11, 2)), N'', 1)
INSERT [dbo].[Venta] ([IDVenta], [IDCliente], [IDTrabajador], [fecha], [Tipo_Pago], [No_Comprobante], [No_CreFiscal], [IGV], [No_AutTarjeta], [Estado]) VALUES (2, 3, 1, CAST(N'2019-11-11 15:04:19.003' AS DateTime), N'Efectivo', N'', N'', CAST(18.00 AS Numeric(11, 2)), N'', 1)
ALTER TABLE [dbo].[Detalle_Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Ingreso_Articulo] FOREIGN KEY([IDArticulo])
REFERENCES [dbo].[Articulo] ([IDArticulo])
GO
ALTER TABLE [dbo].[Detalle_Ingreso] CHECK CONSTRAINT [FK_Detalle_Ingreso_Articulo]
GO
ALTER TABLE [dbo].[Detalle_Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Ingreso_Ingreso] FOREIGN KEY([IDIngreso])
REFERENCES [dbo].[Ingreso] ([IDIngreso])
GO
ALTER TABLE [dbo].[Detalle_Ingreso] CHECK CONSTRAINT [FK_Detalle_Ingreso_Ingreso]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Venta_Ingreso] FOREIGN KEY([IDDetalle_Ingreso])
REFERENCES [dbo].[Detalle_Ingreso] ([IDDetalle_Ingreso])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_Detalle_Venta_Ingreso]
GO
ALTER TABLE [dbo].[Detalle_Venta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Venta_Venta] FOREIGN KEY([IDVenta])
REFERENCES [dbo].[Venta] ([IDVenta])
GO
ALTER TABLE [dbo].[Detalle_Venta] CHECK CONSTRAINT [FK_Detalle_Venta_Venta]
GO
ALTER TABLE [dbo].[Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_Provedor] FOREIGN KEY([IDProveedor])
REFERENCES [dbo].[Proveedor] ([IDProveedor])
GO
ALTER TABLE [dbo].[Ingreso] CHECK CONSTRAINT [FK_Ingreso_Provedor]
GO
ALTER TABLE [dbo].[Ingreso]  WITH CHECK ADD  CONSTRAINT [FK_Ingreso_Trabajador] FOREIGN KEY([IDTrabajador])
REFERENCES [dbo].[Trabajador] ([IDTrabajador])
GO
ALTER TABLE [dbo].[Ingreso] CHECK CONSTRAINT [FK_Ingreso_Trabajador]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Clientes] FOREIGN KEY([IDCliente])
REFERENCES [dbo].[Cliente] ([IDCliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Clientes]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Trabajador] FOREIGN KEY([IDTrabajador])
REFERENCES [dbo].[Trabajador] ([IDTrabajador])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Trabajador]
GO
/****** Object:  StoredProcedure [dbo].[proc_Detalle_IngresoInsert]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_Detalle_IngresoInsert]
(
	@IDDetalleIngreso int = NULL OUTPUT, 
	@IDIngreso int, 
	@IDArticulo int, 
	@PrecioCompra numeric(18,2) = NULL, 
	@PrecioVenta numeric(18,2) = NULL, 
	@StockInicial numeric(18,0) = NULL, 
	@StockActual numeric(18,0) = NULL, 
	@FechaProduccion date = NULL, 
	@FechaVencimiento date = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Detalle_Ingreso]
	(
		[IDIngreso], 
		[IDArticulo], 
		[Precio_compra], 
		[Precio_Venta], 
		[Stock_Inicial], 
		[Stock_Actual], 
		[Fecha_produccion], 
		[Fecha_vencimiento]
	)
	
	VALUES
	(
		@IDIngreso, 
		@IDArticulo, 
		@PrecioCompra, 
		@PrecioVenta, 
		@StockInicial, 
		@StockActual, 
		@FechaProduccion, 
		@FechaVencimiento
	)


	SET @Err = @@Error

		
	SELECT @IDDetalleIngreso = SCOPE_IDENTITY()

	

	RETURN @Err
END



GO
/****** Object:  StoredProcedure [dbo].[proc_Detalle_IngresoLoadAll]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_Detalle_IngresoLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDDetalle_Ingreso], 
		[IDIngreso], 
		[IDArticulo], 
		[Precio_compra], 
		[Precio_Venta], 
		[Stock_Inicial], 
		[Stock_Actual], 
		[Fecha_produccion], 
		[Fecha_vencimiento]
	FROM [dbo].[Detalle_Ingreso]

	SET @Err = @@Error

	RETURN @Err
END



GO
/****** Object:  StoredProcedure [dbo].[proc_Detalle_VentaInsert]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_Detalle_VentaInsert]
(
	
	@IDDetalleIngreso int, 
	@IDVenta int, 
	@Cantidad int, 
	@PrecioVenta numeric(18,2), 
	@Descuento numeric(18,2)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Detalle_Venta]
	(
		[IDDetalle_Ingreso], 
		[IDVenta], 
		[Cantidad], 
		[Precio_Venta], 
		[Descuento]
	)
	
	VALUES
	(
		@IDDetalleIngreso, 
		@IDVenta, 
		@Cantidad, 
		@PrecioVenta, 
		@Descuento
	)


	SET @Err = @@Error

		


	

	RETURN @Err
END



GO
/****** Object:  StoredProcedure [dbo].[proc_Detalle_VentaLoadAll]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_Detalle_VentaLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[IDDetalle_Venta], 
		[IDDetalle_Ingreso], 
		[IDVenta], 
		[Cantidad], 
		[Precio_Venta], 
		[Descuento]
	FROM [dbo].[Detalle_Venta]

	SET @Err = @@Error

	RETURN @Err
END



GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoAnular]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_IngresoAnular]
@idingreso int
as
update ingreso set estado = 0
WHERE idingreso = @idingreso



GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarArticuloCodigo]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_IngresoBuscarArticuloCodigo]
@textobuscar varchar (50)
as
SELECT dbo.articulo.idarticulo, dbo.articulo.Codigo_Articulo, dbo.articulo.nombre,
dbo.articulo.descripcion, dbo.articulo.imagen, dbo.articulo.idcategoria, 
dbo.categoria.nombre AS Categoria, dbo.articulo.idpresentacion,
dbo.presentacion.nombre AS Presentacion
FROM dbo.articulo INNER JOIN dbo.categoria 
ON dbo.articulo.idcategoria = dbo.categoria.idcategoria 
INNER JOIN dbo.presentacion 
ON dbo.articulo.idpresentacion = dbo.presentacion.idpresentacion
where dbo.articulo.Codigo_Articulo like @textobuscar + '%'
order by dbo.articulo.idarticulo desc



GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarArticuloId]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_IngresoBuscarArticuloId]
@textobuscar varchar (50)
as
SELECT dbo.articulo.idarticulo, dbo.articulo.Codigo_Articulo, dbo.articulo.nombre,
dbo.articulo.descripcion, dbo.articulo.imagen, dbo.articulo.idcategoria, 
dbo.categoria.nombre AS Categoria, dbo.articulo.idpresentacion,
dbo.presentacion.nombre AS Presentacion
FROM dbo.articulo INNER JOIN dbo.categoria 
ON dbo.articulo.idcategoria = dbo.categoria.idcategoria 
INNER JOIN dbo.presentacion 
ON dbo.articulo.idpresentacion = dbo.presentacion.idpresentacion
where dbo.articulo.IDArticulo like @textobuscar + '%'
order by dbo.articulo.idarticulo desc



GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarArticuloNombre]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_IngresoBuscarArticuloNombre]
@textobuscar varchar (50)
as
SELECT dbo.articulo.idarticulo, dbo.articulo.Codigo_Articulo, dbo.articulo.nombre,
dbo.articulo.descripcion, dbo.articulo.imagen, dbo.articulo.idcategoria, 
dbo.categoria.nombre AS Categoria, dbo.articulo.idpresentacion,
dbo.presentacion.nombre AS Presentacion
FROM dbo.articulo INNER JOIN dbo.categoria 
ON dbo.articulo.idcategoria = dbo.categoria.idcategoria 
INNER JOIN dbo.presentacion 
ON dbo.articulo.idpresentacion = dbo.presentacion.idpresentacion
where dbo.articulo.nombre like @textobuscar + '%'
order by dbo.articulo.idarticulo desc



GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarFecha]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_IngresoBuscarFecha]
@textobuscar varchar (50),
@textobuscar2 varchar (50)
as
select i.idingreso, (t.apellido +' '+t.nombre) as Trabajador,
p.razon_social as proveedor, i.fecha,i.tipo_pago,
i.num_comprobante,i.estado, SUM(d.precio_compra*d.stock_inicial) as Total
from detalle_ingreso d inner join ingreso i
on d.idingreso = i.idingreso
inner join proveedor p
on i.idproveedor = p.idproveedor
inner join trabajador t
on i.idtrabajador = t.idtrabajador
group by 
i.idingreso, t.apellido +' '+t.nombre,
p.razon_social, i.fecha,i.tipo_pago,
i.num_comprobante,i.estado
having CONVERT(date, i.Fecha, 103) >= @textobuscar and CONVERT(date, i.Fecha, 103) <=@textobuscar2
GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarProveedorRazon]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_IngresoBuscarProveedorRazon]
@textobuscar varchar(50)
as
select * from proveedor
where razon_social like @textobuscar + '%'


GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoBuscarProveedorRnc]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_IngresoBuscarProveedorRnc]
@textobuscar varchar (50)
as
select * from proveedor
where Identificacion like @textobuscar + '%'


GO

/****** Object:  StoredProcedure [dbo].[proc_IngresoGenerarId]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_IngresoGenerarId]
as
select isnull(max(idingreso),0) + 1 as idingreso from ingreso

GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoInsert]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_IngresoInsert]
(
	@IDIngreso int , 
	@IDTrabajador int, 
	@IDProveedor int, 
	@Fecha datetime, 
	@TipoPago varchar(20), 
	@NumComprobante varchar(20) = NULL, 
	@Igv numeric(18,0) = NULL, 
	@Estado int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Ingreso]
	(
		[IDIngreso],
		[IDTrabajador], 
		[IDProveedor], 
		[Fecha], 
		[Tipo_Pago], 
		[Num_Comprobante], 
		[IGV], 
		[Estado]
	)
	
	VALUES
	(
		@IDIngreso,
		@IDTrabajador, 
		@IDProveedor, 
		@Fecha, 
		@TipoPago, 
		@NumComprobante, 
		@Igv, 
		@Estado
	)


	SET @Err = @@Error

		
	SELECT @IDIngreso = SCOPE_IDENTITY()

	

	RETURN @Err
END



GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoLoadAll]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_IngresoLoadAll]
as
select top 100 i.idingreso, (t.apellido +' '+t.nombre) as Trabajador,
p.razon_social as proveedor, i.fecha,i.tipo_pago,
i.num_comprobante,i.estado, SUM(d.precio_compra*d.stock_inicial) as Total
from detalle_ingreso d inner join ingreso i
on d.idingreso = i.idingreso
inner join proveedor p
on i.idproveedor = p.idproveedor
inner join trabajador t
on i.idtrabajador = t.idtrabajador
group by 
i.idingreso, t.apellido +' '+t.nombre,
p.razon_social, i.fecha,i.tipo_pago,
i.num_comprobante,i.estado
order by idingreso desc



GO
/****** Object:  StoredProcedure [dbo].[proc_IngresoMostrarDetalle]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_IngresoMostrarDetalle]
@textobuscar int
as
select d.idarticulo,a.nombre as Articulo, d.precio_compra,
d.precio_venta, d.stock_inicial, d.fecha_produccion,
d.fecha_vencimiento, (d.stock_inicial*d.precio_compra) as Subtotal
from detalle_ingreso d inner join articulo a
on d.idarticulo = a.idarticulo 
where d.idingreso = @textobuscar
GO

/****** Object:  StoredProcedure [dbo].[proc_VentaAnular]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_VentaAnular]
@idventa int
as
update Venta set estado = 0
WHERE IDVenta = @idventa




GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarArticuloCodigo]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_VentaBuscarArticuloCodigo]
@textobuscar varchar (50)
as
select d.iddetalle_ingreso,a.Codigo_Articulo,a.nombre,
c.nombre as Categoria, p.nombre as Presentacion,
d.stock_actual,d.precio_compra,d.precio_venta,
d.fecha_vencimiento
from articulo a inner join categoria c
on a.idcategoria = c.idcategoria
inner join presentacion p
on a.idpresentacion = p.idpresentacion
inner join detalle_ingreso d
on a.idarticulo = d.idarticulo
inner join ingreso i
on d.idingreso = i.idingreso
where a.Codigo_Articulo = @textobuscar
and d.stock_actual > 0
and i.estado <> 0



GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarArticuloId]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_VentaBuscarArticuloId]
@textobuscar varchar (50)
as
select d.iddetalle_ingreso,a.Codigo_Articulo,a.nombre,
c.nombre as Categoria, p.nombre as Presentacion,
d.stock_actual,d.precio_compra,d.precio_venta,
d.fecha_vencimiento
from articulo a inner join categoria c
on a.idcategoria = c.idcategoria
inner join presentacion p
on a.idpresentacion = p.idpresentacion
inner join detalle_ingreso d
on a.idarticulo = d.idarticulo
inner join ingreso i
on d.idingreso = i.idingreso
where a.IDArticulo = @textobuscar
and d.stock_actual > 0
and i.estado <> 0



GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarArticuloNombre]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_VentaBuscarArticuloNombre]
@textobuscar varchar (50)
as
select d.iddetalle_ingreso,a.Codigo_Articulo,a.nombre,
c.nombre as Categoria, p.nombre as Presentacion,
d.stock_actual,d.precio_compra,d.precio_venta,
d.fecha_vencimiento
from articulo a inner join categoria c
on a.idcategoria = c.idcategoria
inner join presentacion p
on a.idpresentacion = p.idpresentacion
inner join detalle_ingreso d
on a.idarticulo = d.idarticulo
inner join ingreso i
on d.idingreso = i.idingreso
where a.Nombre like @textobuscar + '%'
and d.stock_actual > 0
and i.estado <> 0




GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarClienteDocumento]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[proc_VentaBuscarClienteDocumento]
@textobuscar varchar(50)
as
select * from cliente
where Num_Documento like @textobuscar + '%'


GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarClienteNombre]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[proc_VentaBuscarClienteNombre]
@textobuscar varchar(50)
as
select * from cliente
where Nombre like @textobuscar + '%'


GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarFecha]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_VentaBuscarFecha]
@textobuscar varchar (50),
@textobuscar2 varchar (50)
as
select v.idventa,
(t.apellido+' '+t.nombre) as Trabajador,
(c.apellido+' '+c.nombre) as Cliente,
v.fecha,v.Tipo_Pago,v.No_Comprobante,v.No_CreFiscal,v.No_AutTarjeta,
SUM((d.cantidad*d.precio_venta)-d.descuento) as Total
from detalle_venta d inner join venta v
on d.idventa = v.idventa
inner join cliente c
on v.idcliente = c.idcliente
inner join trabajador t
on v.idtrabajador = t.idtrabajador 
group by v.idventa,
(t.apellido+' '+t.nombre),
(c.apellido+' '+c.nombre),
v.fecha,v.Tipo_Pago,v.No_Comprobante,v.No_CreFiscal,v.No_AutTarjeta
having CONVERT(date, v.Fecha, 103) >= @textobuscar and CONVERT(date, v.Fecha, 103) <=@textobuscar2



GO
/****** Object:  StoredProcedure [dbo].[proc_VentaBuscarFechaAnulado]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_VentaBuscarFechaAnulado]
@textobuscar varchar (50),
@textobuscar2 varchar (50)
as
select v.idventa,
(t.apellido+' '+t.nombre) as Trabajador,
(c.apellido+' '+c.nombre) as Cliente,
v.fecha,v.Tipo_Pago,v.No_Comprobante,v.No_CreFiscal,v.No_AutTarjeta,
SUM((d.cantidad*d.precio_venta)-d.descuento) as Total
from detalle_venta d inner join venta v
on d.idventa = v.idventa
inner join cliente c
on v.idcliente = c.idcliente
inner join trabajador t
on v.idtrabajador = t.idtrabajador 
group by v.idventa,
(t.apellido+' '+t.nombre),
(c.apellido+' '+c.nombre),
v.fecha,v.Tipo_Pago,v.No_Comprobante,v.No_CreFiscal,v.No_AutTarjeta,v.estado
having v.fecha >= @textobuscar and v.fecha <=@textobuscar2 and v.estado = 0


GO
/****** Object:  StoredProcedure [dbo].[proc_VentaDisminuirstock]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Disminuis el stock despues de una venta
create proc [dbo].[proc_VentaDisminuirstock]
@iddetalle_ingreso int,
@cantidad int
as update detalle_ingreso set stock_actual = stock_actual - @cantidad
where iddetalle_ingreso = @iddetalle_ingreso


GO
/****** Object:  StoredProcedure [dbo].[proc_VentaGenerarId]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_VentaGenerarId]
as
select isnull(max(IDVenta),0) + 1 as idventa from venta

GO
/****** Object:  StoredProcedure [dbo].[proc_VentaInsert]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proc_VentaInsert]
(
	@IDVenta int , 
	@IDCliente int, 
	@IDTrabajador int, 
	@Fecha datetime, 
	@TipoPago varchar(50), 
	@NoComprobante varchar(50) = NULL, 
	@NoCreFiscal varchar(50) = NULL, 
	@Igv numeric(11,2) = NULL, 
	@NoAutTarjeta varchar(30) = NULL, 
	@Estado int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Venta]
	(	
		[IDVenta],
		[IDCliente], 
		[IDTrabajador], 
		[fecha], 
		[Tipo_Pago], 
		[No_Comprobante], 
		[No_CreFiscal], 
		[IGV], 
		[No_AutTarjeta], 
		[estado]
	)
	
	VALUES
	(
	    @IDVenta,
		@IDCliente, 
		@IDTrabajador, 
		@Fecha, 
		@TipoPago, 
		@NoComprobante, 
		@NoCreFiscal, 
		@Igv, 
		@NoAutTarjeta, 
		@Estado
	)


	SET @Err = @@Error

		
	SELECT @IDVenta = SCOPE_IDENTITY()

	

	RETURN @Err
END



GO
/****** Object:  StoredProcedure [dbo].[proc_VentaLoadAll]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_VentaLoadAll]
as
select top 100 v.idventa,
(t.apellido+' '+t.nombre) as Trabajador,
(c.apellido+' '+c.nombre) as Cliente,
v.fecha,v.Tipo_Pago,v.No_comprobante, v.No_CreFiscal,
SUM((d.cantidad*d.precio_venta)-d.descuento) as Total
from detalle_venta d inner join venta v
on d.idventa = v.idventa
inner join cliente c
on v.idcliente = c.idcliente
inner join trabajador t
on v.idtrabajador = t.idtrabajador 
group by v.idventa,
(t.apellido+' '+t.nombre),
(c.apellido+' '+c.nombre),
v.fecha,v.Tipo_Pago,v.No_comprobante, v.No_CreFiscal
order by v.idventa desc




GO
/****** Object:  StoredProcedure [dbo].[proc_VentaMostrarDetalle]    Script Date: 12/11/2019 14:34:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_VentaMostrarDetalle]
@textobuscar int
as
select d.iddetalle_ingreso, a.nombre as Articulo,
d.cantidad, d.precio_venta, d.descuento,
((d.precio_venta*d.cantidad) - d.descuento) as Subtotal
from detalle_venta d inner join detalle_ingreso di
on d.iddetalle_ingreso = di.iddetalle_ingreso
inner join articulo a
on di.idarticulo = a.idarticulo
where d.idventa = @textobuscar
GO


/***||||||||||||||||||||||||||||||||||||*******END LUIS BILL**************||||||||||||||||||||||||||||||||||||****************/
