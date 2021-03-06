USE [master]
GO
/****** Object:  Database [CooKINGDataBase]    Script Date: 27.1.2018. 20:31:31 ******/
CREATE DATABASE [CooKINGDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CooKINGDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CooKINGDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CooKINGDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CooKINGDataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CooKINGDataBase] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CooKINGDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CooKINGDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CooKINGDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CooKINGDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CooKINGDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CooKINGDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CooKINGDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [CooKINGDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CooKINGDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CooKINGDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CooKINGDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CooKINGDataBase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CooKINGDataBase] SET QUERY_STORE = OFF
GO
USE [CooKINGDataBase]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CooKINGDataBase]
GO
/****** Object:  Table [dbo].[Fotografija]    Script Date: 27.1.2018. 20:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fotografija](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Lokacija] [nvarchar](max) NOT NULL,
	[ReceptId] [int] NOT NULL,
 CONSTRAINT [PK_Fotografija] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Korak]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korak](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BrojKoraka] [int] NOT NULL,
	[OpisKoraka] [nvarchar](3000) NOT NULL,
	[Naputak] [nvarchar](200) NULL,
	[VrijemeIzvodenja] [int] NULL,
	[ReceptId] [int] NOT NULL,
 CONSTRAINT [PK_Korak] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Namirnica]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Namirnica](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[Mjera] [int] NOT NULL,
	[Opca] [bit] NOT NULL,
	[Vrsta] [int] NOT NULL,
 CONSTRAINT [PK_Namirnica] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recept]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recept](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](100) NOT NULL,
	[VrstaJela] [int] NOT NULL,
	[PodvrstaJela] [int] NOT NULL,
	[BrojServiranja] [int] NOT NULL,
	[VrijemeKuhanja] [int] NOT NULL,
	[Tezina] [int] NOT NULL,
	[PotrebnoKuhanje] [bit] NOT NULL,
	[Biljeska] [nvarchar](3000) NULL,
	[Savijet] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Recept] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sastavnica]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sastavnica](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReceptId] [int] NOT NULL,
	[NamirnicaId] [int] NOT NULL,
	[Kolicina] [decimal](6, 1) NOT NULL,
 CONSTRAINT [PK_Sastavnica] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Fotografija]  WITH CHECK ADD  CONSTRAINT [FK_Fotografija_Recept] FOREIGN KEY([ReceptId])
REFERENCES [dbo].[Recept] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Fotografija] CHECK CONSTRAINT [FK_Fotografija_Recept]
GO
ALTER TABLE [dbo].[Korak]  WITH CHECK ADD  CONSTRAINT [FK_Korak_Recept] FOREIGN KEY([ReceptId])
REFERENCES [dbo].[Recept] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Korak] CHECK CONSTRAINT [FK_Korak_Recept]
GO
ALTER TABLE [dbo].[Sastavnica]  WITH CHECK ADD  CONSTRAINT [FK_Sastavnica_Namirnica] FOREIGN KEY([NamirnicaId])
REFERENCES [dbo].[Namirnica] ([Id])
GO
ALTER TABLE [dbo].[Sastavnica] CHECK CONSTRAINT [FK_Sastavnica_Namirnica]
GO
ALTER TABLE [dbo].[Sastavnica]  WITH CHECK ADD  CONSTRAINT [FK_Sastavnica_Sastavnica] FOREIGN KEY([ReceptId])
REFERENCES [dbo].[Recept] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sastavnica] CHECK CONSTRAINT [FK_Sastavnica_Sastavnica]
GO
/****** Object:  StoredProcedure [dbo].[spDohvatiIDReceptaFalse]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDohvatiIDReceptaFalse] 
	@Min int, @Max int, @Vrijeme int
AS
BEGIN
	
	SET NOCOUNT ON;

    select Id from Recept where (Tezina between @Min and @Max) and (VrijemeKuhanja<=@Vrijeme or @Vrijeme=0)
END
GO
/****** Object:  StoredProcedure [dbo].[spDohvatiIDReceptaTrue]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spDohvatiIDReceptaTrue]
	@Min int, @Max int, @Vrijeme int, @Vrsta int, @Podvrsta int
AS
BEGIN
	
	SET NOCOUNT ON;

    select Id from Recept where (VrstaJela=@Vrsta)and(PodvrstaJela=@Podvrsta)and(Tezina between @Min and @Max) and (VrijemeKuhanja<=@Vrijeme or @Vrijeme=0)
END
GO
/****** Object:  StoredProcedure [dbo].[spDohvatiSveFotografijePoReceptu]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDohvatiSveFotografijePoReceptu]
	@ReceptId int
AS
BEGIN
	
	SET NOCOUNT ON;

	select * from Fotografija where ReceptId=@ReceptId;
END
GO
/****** Object:  StoredProcedure [dbo].[spDohvatiSveKorakePoReceptu]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDohvatiSveKorakePoReceptu]
	@ReceptId int
AS
BEGIN
	
	SET NOCOUNT ON;

	select * from Korak where ReceptId=@ReceptId;
END
GO
/****** Object:  StoredProcedure [dbo].[SpDohvatiSveNamirnice]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SpDohvatiSveNamirnice]
AS
BEGIN
	SET NOCOUNT ON;

    select * from dbo.Namirnica;
END
GO
/****** Object:  StoredProcedure [dbo].[spDohvatiSveNamirnicePoReceptu]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDohvatiSveNamirnicePoReceptu]
	@ReceptId int
AS
BEGIN
	
	SET NOCOUNT ON;

    select * from Namirnica where id in(select NamirnicaId from Sastavnica where ReceptId=@ReceptId);
END
GO
/****** Object:  StoredProcedure [dbo].[spDohvatiSveSastavnice]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDohvatiSveSastavnice] 
	
AS
BEGIN
	
	SET NOCOUNT ON;

    select * from dbo.Sastavnica;
END
GO
/****** Object:  StoredProcedure [dbo].[spFotografija_Insert]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spFotografija_Insert]
	@Lokacija nvarchar(MAX),
	@ReceptId int
AS
BEGIN
	
	SET NOCOUNT ON;

	insert into dbo.Fotografija(Lokacija,ReceptId) values (@Lokacija,@ReceptId);
END
GO
/****** Object:  StoredProcedure [dbo].[spKorak_Insert]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spKorak_Insert] 
	@BrojKoraka int,
	@OpisKoraka nvarchar(3000),
	@Naputak nvarchar(200),
	@VrijemeIzvodenja int,
	@ReceptId int
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.Korak(BrojKoraka,OpisKoraka,Naputak,VrijemeIzvodenja,ReceptId)values(@BrojKoraka,@OpisKoraka,@Naputak,@VrijemeIzvodenja,@ReceptId);
END
GO
/****** Object:  StoredProcedure [dbo].[spNamirnica_Delete]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spNamirnica_Delete] 
	@Naziv nvarchar(50)
	
AS
BEGIN
	SET NOCOUNT ON;

    delete from dbo.Namirnica where Naziv=@Naziv;
END
GO
/****** Object:  StoredProcedure [dbo].[spNamirnica_Insert]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spNamirnica_Insert]
	@Naziv nvarchar(50),
	@Mjera int,
	@Opca bit,
	@Vrsta int
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Namirnica(Naziv,Mjera,Opca,Vrsta) values (@Naziv, @Mjera, @Opca, @Vrsta);
	
END
GO
/****** Object:  StoredProcedure [dbo].[spRecept_Delete]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spRecept_Delete]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;
	delete from dbo.Recept where Id=@Id;
END
GO
/****** Object:  StoredProcedure [dbo].[spRecept_Insert]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spRecept_Insert]
	@Naziv nvarchar(100),
	@VrstaJela int,
	@PodvrstaJela int,
	@BrojServiranja int,
	@VrijemeKuhanja int,
	@KuharskoUmijece int,
	@PotrebnoKuhanje bit,
	@Savijet nvarchar(3000),
	@Id int=0 output
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.Recept(Naziv,VrstaJela,PodvrstaJela,BrojServiranja,VrijemeKuhanja,Tezina,PotrebnoKuhanje,Savijet)
	values (@Naziv,@VrstaJela,@PodvrstaJela,@BrojServiranja,@VrijemeKuhanja,@KuharskoUmijece,@PotrebnoKuhanje,@Savijet);

	select @Id=SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[spSastavnica_Insert]    Script Date: 27.1.2018. 20:31:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spSastavnica_Insert]
	@ReceptId int, 
	@NamirnicaId int,
	@Kolicina decimal(6,1)
AS
BEGIN
	SET NOCOUNT ON;

	insert into Sastavnica(ReceptId,NamirnicaId,Kolicina) values (@ReceptId,@NamirnicaId,@Kolicina);
END
GO
USE [master]
GO
ALTER DATABASE [CooKINGDataBase] SET  READ_WRITE 
GO
