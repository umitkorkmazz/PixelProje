USE [PixelP]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17.04.2022 18:27:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Abone]    Script Date: 17.04.2022 18:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Abone](
	[AboneId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Tel] [nvarchar](max) NULL,
	[Adress] [nvarchar](max) NULL,
	[Deposit] [int] NOT NULL,
	[AboneSituation] [bit] NOT NULL,
	[Balance] [int] NOT NULL,
 CONSTRAINT [PK_Abone] PRIMARY KEY CLUSTERED 
(
	[AboneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 17.04.2022 18:27:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[InvoiceId] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceName] [nvarchar](max) NULL,
	[InvoiceSurname] [nvarchar](max) NULL,
	[InvoiceTel] [int] NOT NULL,
	[InvoiceAdress] [nvarchar](max) NULL,
	[InvoiceAmount] [int] NOT NULL,
	[AboneId] [int] NOT NULL,
	[InvoicesInvoiceId] [int] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220415193610_ilk', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220415194914_ilkk', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220415195219_iki', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220415222153_uc', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220416102749_dort', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220416201123_bes', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220417104651_altı', N'6.0.4')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220417111240_yedi', N'6.0.4')
GO
SET IDENTITY_INSERT [dbo].[Abone] ON 

INSERT [dbo].[Abone] ([AboneId], [Name], [LastName], [Tel], [Adress], [Deposit], [AboneSituation], [Balance]) VALUES (1, N'ümit', N'korkmaz', N'505', N'istanbul', 1000, 1, 0)
INSERT [dbo].[Abone] ([AboneId], [Name], [LastName], [Tel], [Adress], [Deposit], [AboneSituation], [Balance]) VALUES (2, N'Emin', N'Aylar', N'507', N'tokat', 1000, 1, 120)
INSERT [dbo].[Abone] ([AboneId], [Name], [LastName], [Tel], [Adress], [Deposit], [AboneSituation], [Balance]) VALUES (4, N'batuhan', N'kalaycı', N'508', N'trabzon', 1000, 1, 100)
INSERT [dbo].[Abone] ([AboneId], [Name], [LastName], [Tel], [Adress], [Deposit], [AboneSituation], [Balance]) VALUES (5, N'görkem', N'alcay', N'509', N'bursa', 1000, 1, 110)
INSERT [dbo].[Abone] ([AboneId], [Name], [LastName], [Tel], [Adress], [Deposit], [AboneSituation], [Balance]) VALUES (6, N'cihan', N'ünal', N'510', N'sakarya', 1000, 1, 120)
INSERT [dbo].[Abone] ([AboneId], [Name], [LastName], [Tel], [Adress], [Deposit], [AboneSituation], [Balance]) VALUES (7, N'bilal', N'pala', N'511', N'adana', 1000, 1, 130)
SET IDENTITY_INSERT [dbo].[Abone] OFF
GO
SET IDENTITY_INSERT [dbo].[Invoice] ON 

INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceName], [InvoiceSurname], [InvoiceTel], [InvoiceAdress], [InvoiceAmount], [AboneId], [InvoicesInvoiceId]) VALUES (1, N'ümit', N'korkmaz', 505, N'istanbul', 0, 1, 1)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceName], [InvoiceSurname], [InvoiceTel], [InvoiceAdress], [InvoiceAmount], [AboneId], [InvoicesInvoiceId]) VALUES (2, N'emin', N'aylar', 507, N'tokat', 90, 2, 2)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceName], [InvoiceSurname], [InvoiceTel], [InvoiceAdress], [InvoiceAmount], [AboneId], [InvoicesInvoiceId]) VALUES (3, N'Batuhan', N'kalaycı', 508, N'trabzon', 50, 4, 3)
INSERT [dbo].[Invoice] ([InvoiceId], [InvoiceName], [InvoiceSurname], [InvoiceTel], [InvoiceAdress], [InvoiceAmount], [AboneId], [InvoicesInvoiceId]) VALUES (4, N'Görkem', N'Alcay', 509, N'bursa', 300, 5, 4)
SET IDENTITY_INSERT [dbo].[Invoice] OFF
GO
ALTER TABLE [dbo].[Abone] ADD  DEFAULT (CONVERT([bit],(0))) FOR [AboneSituation]
GO
ALTER TABLE [dbo].[Abone] ADD  DEFAULT ((0)) FOR [Balance]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT ((0)) FOR [InvoiceAmount]
GO
ALTER TABLE [dbo].[Invoice] ADD  DEFAULT ((0)) FOR [AboneId]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Abone_AboneId] FOREIGN KEY([AboneId])
REFERENCES [dbo].[Abone] ([AboneId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Abone_AboneId]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Invoice_InvoicesInvoiceId] FOREIGN KEY([InvoicesInvoiceId])
REFERENCES [dbo].[Invoice] ([InvoiceId])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Invoice_InvoicesInvoiceId]
GO
