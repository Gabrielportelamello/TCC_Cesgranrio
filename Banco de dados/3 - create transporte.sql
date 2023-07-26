USE [tailandia]
GO

/****** Object:  Table [dbo].[SEMEAR_TRANSPORTE]    Script Date: 25/07/2023 20:54:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SEMEAR_TRANSPORTE](
	[CNPJ] [varchar](20) NULL,
	[Endereco] [varchar](max) NULL,
	[Telefones] [varchar](50) NULL,
	[Email] [nvarchar](200) NULL,
	[CEP] [varchar](20) NULL,
	[QTD_Assentos] [int] NULL,
	[Locais_embarque] [varchar](max) NULL,
	[itinerario] [varchar](max) NULL,
	[Preco] [float] NULL,
	[SQ_TRANSPORTE] [bigint] NOT NULL,
	[NOME] [varchar](max) NULL,
 CONSTRAINT [PK_SEMEAR_TRANSPORTE] PRIMARY KEY CLUSTERED 
(
	[SQ_TRANSPORTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

