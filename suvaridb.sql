USE [SuvariSrv]
GO
/****** Object:  Table [dbo].[MagazaTanim]    Script Date: 05/06/2013 11:27:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MagazaTanim](
	[RecordId] [int] IDENTITY(1,1) NOT NULL,
	[BolgeKodu] [nvarchar](5) NOT NULL,
	[MagazaKodu] [nvarchar](5) NOT NULL,
	[MagazaKisaKodu] [nvarchar](5) NOT NULL,
	[MagazaAdi] [nvarchar](100) NOT NULL,
	[MagazaTipi] [nvarchar](5) NOT NULL,
	[MagazaLokasyonTipi] [nvarchar](5) NOT NULL,
	[MagazaAlan] [decimal](5, 2) NOT NULL,
	[MagazaIli] [nvarchar](50) NOT NULL,
	[IlBolgesi] [nvarchar](50) NOT NULL,
	[MagazaAdres] [nvarchar](500) NOT NULL,
	[MagazaYetkilisiAdi] [nvarchar](50) NOT NULL,
	[MagazaYetkilisiUnvani] [nvarchar](50) NOT NULL,
	[MagazaSabitHatNo] [nvarchar](50) NOT NULL,
	[MagazaGSMNo] [nvarchar](50) NOT NULL,
	[MagazaMail] [nvarchar](50) NOT NULL,
	[MagazaYetkilisiKisiselGSMNo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MagazaTanim] PRIMARY KEY CLUSTERED 
(
	[RecordId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
