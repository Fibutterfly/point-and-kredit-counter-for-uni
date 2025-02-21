USE [point_counter]
GO
INSERT [dbo].[Student] ([NEPTUN], [Name], [Password]) VALUES (N'HS3SS4', N'Filep Illés Attila', N'12345678')
GO
INSERT [dbo].[University] ([Uni_ID], [Name]) VALUES (N'BCE', N'Budapest Corvinus Egyetem')
GO
INSERT [dbo].[Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'2SZ31NAK11B', N'Adatbázis rendszerek', N'BCE')
INSERT [dbo].[Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'2SZ31NAK14B', N'Számítógéphálózatok', N'BCE')
INSERT [dbo].[Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'2SZ31NAK20B', N'Szoftvertechnológia II.', N'BCE')
INSERT [dbo].[Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'4OP13NAK01B', N'Operációkutatás', N'BCE')
INSERT [dbo].[Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'4ST14NAK16B', N'Statisztika I. (emelt szint)', N'BCE')
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (1, N'2SZ31NAK14B', 2019, 54, 68, 82, 92, 0)
INSERT [dbo].[Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (2, N'2SZ31NAK11B', 2019, 50, 62, 74, 86, 0)
INSERT [dbo].[Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (3, N'2SZ31NAK20B', 2019, 60, 70, 80, 90, 0)
INSERT [dbo].[Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (4, N'4OP13NAK01B', 2019, 40, 55, 70, 85, 0)
INSERT [dbo].[Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (5, N'4ST14NAK16B', 2019, 55, 65, 80, 90, 0)
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
SET IDENTITY_INSERT [dbo].[StudxSub] ON 

INSERT [dbo].[StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (1, N'HS3SS4', 1)
INSERT [dbo].[StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (2, N'HS3SS4', 2)
INSERT [dbo].[StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (3, N'HS3SS4', 3)
INSERT [dbo].[StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (4, N'HS3SS4', 4)
INSERT [dbo].[StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (5, N'HS3SS4', 5)
SET IDENTITY_INSERT [dbo].[StudxSub] OFF
GO
INSERT [dbo].[StudentxUniversity] ([NEPTUN_FK], [Uni_FK]) VALUES (N'HS3SS4', N'BCE')
GO
SET IDENTITY_INSERT [dbo].[point_types] ON 

INSERT [dbo].[point_types] ([PT_SK], [PT_name]) VALUES (1, N'beadandó')
INSERT [dbo].[point_types] ([PT_SK], [PT_name]) VALUES (2, N'vizsga')
INSERT [dbo].[point_types] ([PT_SK], [PT_name]) VALUES (3, N'zh')
SET IDENTITY_INSERT [dbo].[point_types] OFF
GO
SET IDENTITY_INSERT [dbo].[Max_type_points] ON 

INSERT [dbo].[Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (1, 5, 1, 60, 30)
INSERT [dbo].[Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (2, 5, 2, 46, 0)
INSERT [dbo].[Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (3, 1, 2, 0, 0)
INSERT [dbo].[Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (4, 2, 1, 70, 0)
INSERT [dbo].[Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (6, 2, 3, 30, 0)
INSERT [dbo].[Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (7, 3, 1, 60, 0)
INSERT [dbo].[Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (8, 3, 3, 40, 0)
SET IDENTITY_INSERT [dbo].[Max_type_points] OFF
GO
SET IDENTITY_INSERT [dbo].[Point] ON 

INSERT [dbo].[Point] ([Point_SK], [Point], [StudxSub_FK], [PT_FK], [datum]) VALUES (1, 11, 4, 3, CAST(N'2020-03-08' AS Date))
INSERT [dbo].[Point] ([Point_SK], [Point], [StudxSub_FK], [PT_FK], [datum]) VALUES (2, 18, 3, 3, CAST(N'2020-03-08' AS Date))
SET IDENTITY_INSERT [dbo].[Point] OFF
GO
