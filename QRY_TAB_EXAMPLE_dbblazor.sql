USE dbblazor
GO

/****** Object:  Table [dbo].[Registrados]    Script Date: 4/8/2022 19:32:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DatosPersonales](
	[IdDato] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [varchar](200) NULL,
	[Apellidos] [varchar](200) NULL,
	[NombresCompletos] [varchar](400) NULL,
	[Identificacion] [varchar](20) NULL,
	[email] [varchar](400) NULL,
	[FechaNacimiento] datetime NULL,
	[FechaNacimientoConsulta] varchar(15) NULL,
	IdGenero int NULL,
	IdPais int NULL,
	IdEstadoCivil int NULL,
	LicenciaConducir bit,
	MovilidadPropia bit,
	Discapacidad bit,
	FechaRegistro datetime,
	UsuarioRegistro varchar(400),
	FechaModificacion datetime,
	UsuarioModificacion varchar(400),
	Estado varchar(25),
PRIMARY KEY CLUSTERED 
(
	[IdDato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Registrados]    Script Date: 4/8/2022 19:32:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DatosContacto](
	[IdDatoContacto] [int] IDENTITY(1,1) NOT NULL,
	[IdDato] [int] NOT NULL,
	Celular [varchar](15) NULL,
	Telefono varchar(15) NULL,
	EmailSecundario [varchar](400) NULL,
	IdPais int NULL,
	ProvinciaEstado [varchar](400) NULL,
	Ciudad [varchar](400) NULL,
	Direccion [varchar](400) NULL,
	Facebook [varchar](400) NULL,
	Twiter [varchar](400) NULL,
	Instagram [varchar](400) NULL,
	Linkedin [varchar](400) NULL,
	FechaRegistro datetime,
	UsuarioRegistro varchar(400),
	FechaModificacion datetime,
	UsuarioModificacion varchar(400),
	Estado varchar(25),
PRIMARY KEY CLUSTERED 
(
	[IdDatoContacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Registrados]    Script Date: 4/8/2022 19:32:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DatosEducacion](
	[IdDatoEducacion] [int] IDENTITY(1,1) NOT NULL,
	[IdDato] [int] NOT NULL,
	TituloCarrera [varchar](max) NULL,
	Institucion [varchar](max) NULL,
	IdTipoEstudio int,
	IdEstadoEstudio int,
	AreaEstudio [varchar](max) NULL,
	IdPais int,
	MesInicio int,
	AnioInicio int,
	MesFin int,
	AnioFin int,

	FechaRegistro datetime,
	UsuarioRegistro varchar(400),
	FechaModificacion datetime,
	UsuarioModificacion varchar(400),
	Estado varchar(25),

PRIMARY KEY CLUSTERED 
(
	[IdDatoEducacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Registrados]    Script Date: 4/8/2022 19:32:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DatosIdioma](
	[IdDatoIdioma] [int] IDENTITY(1,1) NOT NULL,
	[IdDato] [int] NOT NULL,

	IdIdioma int,
	IdNivelEscrito int,
	IdNivelHablado int,

	FechaRegistro datetime,
	UsuarioRegistro varchar(400),
	FechaModificacion datetime,
	UsuarioModificacion varchar(400),
	Estado varchar(25),

PRIMARY KEY CLUSTERED 
(
	[IdDatoIdioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[Registrados]    Script Date: 4/8/2022 19:32:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DatosLaboral](
	[IdDatoLaboral] [int] IDENTITY(1,1) NOT NULL,
	[IdDato] [int] NOT NULL,
	Empresa [varchar](max) NULL,
	IdActividadEmpresa int,
	Puesto [varchar](max) NULL,
	IdNivelExperiencia int,
	IodAreaDelPuesto int,
	IdPais int,

	MesInicio int,
	AnioInicio int,
	MesFin int,
	AnioFin int,
	Presente bit,
	ExperienciaEnVentas bit,

	FechaRegistro datetime,
	UsuarioRegistro varchar(400),
	FechaModificacion datetime,
	UsuarioModificacion varchar(400),
	Estado varchar(25),

PRIMARY KEY CLUSTERED 
(
	[IdDatoLaboral] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO