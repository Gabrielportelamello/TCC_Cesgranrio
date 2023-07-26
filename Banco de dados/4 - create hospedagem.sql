USE [tailandia]
GO

/****** Object:  Table [dbo].[SEMEAR_HOSPEDAGEM]    Script Date: 25/07/2023 20:56:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SEMEAR_HOSPEDAGEM](
	[SEQ_HOSPEDAGEM] [bigint] NOT NULL,
	[Nome] [varchar](250) NULL,
	[Endereco] [varchar](max) NULL,
	[CNPJ] [varchar](50) NULL,
	[Telefones] [varchar](50) NULL,
	[Email] [varchar](max) NULL,
	[CEP] [varchar](50) NULL,
	[qtd_quartos] [int] NULL,
	[qtd_camas] [int] NULL,
	[tipo_cama] [smallint] NULL,
	[pacote_incluso] [varchar](max) NULL,
	[data_checkin] [datetime] NULL,
	[data_checkout] [datetime] NULL,
	[preco] [float] NULL,
 CONSTRAINT [PK_SEMEAR_HOSPEDAGEM] PRIMARY KEY CLUSTERED 
(
	[SEQ_HOSPEDAGEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

