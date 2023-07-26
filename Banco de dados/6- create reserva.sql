USE [tailandia]
GO

/****** Object:  Table [dbo].[SEMEAR_RESERVA]    Script Date: 25/07/2023 20:55:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SEMEAR_RESERVA](
	[SQ_RESERVA] [bigint] NOT NULL,
	[SQ_FUNCIONARIO] [bigint] NULL,
	[SQ_CLIENTE] [bigint] NULL,
	[FL_EXISTEVIAGEM] [smallint] NULL,
	[FL_existeTransporte] [smallint] NULL,
	[FL_existeHospedagem] [smallint] NULL,
	[FL_EXISTECLIENTE] [smallint] NULL,
	[FL_STATUSRESERVA] [int] NULL,
	[tipoCama] [varchar](50) NULL,
	[nu_quarto] [varchar](50) NULL,
	[LocalEmbarque] [varchar](max) NULL,
	[nu_acentoTransporte] [varchar](50) NULL,
	[preçoViagemCliente] [decimal](18, 0) NULL,
	[FL_FORMADEPAGAMENTO] [smallint] NULL,
	[FL_STATUSPAGAMENTO] [smallint] NULL,
	[SALDODEPAGAMENTO] [decimal](18, 0) NULL,
	[OBSERVACAO] [varchar](max) NULL,
 CONSTRAINT [PK_SEMEAR_RESERVA] PRIMARY KEY CLUSTERED 
(
	[SQ_RESERVA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

