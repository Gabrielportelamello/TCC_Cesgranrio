USE [tailandia]
GO

/****** Object:  Table [dbo].[SEMEAR_PESSOA]    Script Date: 25/07/2023 20:55:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SEMEAR_PESSOA](
	[Nome] [varchar](500) NULL,
	[Telefone] [varchar](50) NULL,
	[Email] [varchar](500) NULL,
	[Data_Nascimento] [datetime] NULL,
	[CPF] [varchar](50) NULL,
	[Passaporte] [varchar](50) NULL,
	[emissao_passaporte] [datetime] NULL,
	[Validade_Passaporte] [datetime] NULL,
	[RG] [varchar](50) NULL,
	[orgao_emissor_RG] [varchar](50) NULL,
	[data_emissao_RG] [datetime] NULL,
	[Perfil_Acesso] [varchar](50) NULL,
	[salario] [float] NULL,
	[Saldo] [float] NULL,
	[FL_FUNCIONARIO] [smallint] NULL,
	[FL_EXCLUIDO] [smallint] NULL,
	[bairro_endereco] [varchar](50) NULL,
	[cidade_endereco] [varchar](50) NULL,
	[uf_endereco] [varchar](10) NULL,
	[rua_endereco] [varchar](500) NULL,
	[CEP] [varchar](50) NULL,
	[SQ_PESSOA] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_SEMEAR_PESSOA] PRIMARY KEY CLUSTERED 
(
	[SQ_PESSOA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

