SET IDENTITY_INSERT [dbo].[ImoveisBD] ON
INSERT INTO [dbo].[ImoveisBD] ([Id], [nomeproprietario], [endereco], [valor], [datainicial], [foto]) VALUES (3, N'victor', N'rua dos baloes', CAST(3000.0000 AS Money), N'sábado, 23 de outubro de 2021', N'casavictor.png')
INSERT INTO [dbo].[ImoveisBD] ([Id], [nomeproprietario], [endereco], [valor], [datainicial], [foto]) VALUES (4, N'Lilian', N'rua tal', CAST(8000.0000 AS Money), N'sábado, 23 de outubro de 2021', N'casalilian.png')
SET IDENTITY_INSERT [dbo].[ImoveisBD] OFF
