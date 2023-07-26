USE [tailandia]
GO

/****** Object:  Table [dbo].[SEMEAR_VIAGEM]    Script Date: 25/07/2023 20:54:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SEMEAR_VIAGEM](
	[NOME_VIAGEM] [varchar](max) NULL,
	[DT_InicialPeriodo_viagem] [datetime] NULL,
	[DTFinalperiodo_viagem] [datetime] NULL,
	[Descricao_do_pacote] [varchar](max) NULL,
	[Tipo_Transporte] [varchar](50) NULL,
	[Preco] [float] NULL,
	[Formas_de_pagamento] [smallint] NULL,
	[OBSERVACAO] [varchar](max) NULL,
	[FL_STATUS] [smallint] NULL,
	[SQ_VIAGEM] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_SEMEAR_VIAGEM] PRIMARY KEY CLUSTERED 
(
	[SQ_VIAGEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

