
CREATE TABLE [Max_type_points](
	[Act_max_SK] [int] IDENTITY(1,1) NOT NULL,
	[Sub_FK] [int] NOT NULL,
	[PT_FK] [int] NOT NULL,
	[max] [int] NOT NULL,
	[min] [int] NOT NULL,
 CONSTRAINT [PK_MAX_TYPE_POINTS] PRIMARY KEY CLUSTERED 
(
	[Act_max_SK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Point](
	[Point_SK] [int] IDENTITY(1,1) NOT NULL,
	[Point] [float] NOT NULL,
	[StudxSub_FK] [int] NOT NULL,
	[PT_FK] [int] NOT NULL,
	[datum] [date] NOT NULL,
 CONSTRAINT [PK_POINT] PRIMARY KEY CLUSTERED 
(
	[Point_SK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [point_types](
	[PT_SK] [int] IDENTITY(1,1) NOT NULL,
	[PT_name] [varchar](255) NOT NULL,
 CONSTRAINT [PK_POINT_TYPES] PRIMARY KEY CLUSTERED 
(
	[PT_SK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Student](
	[NEPTUN] [varchar](6) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Password] [varchar](255) NOT NULL,
 CONSTRAINT [PK_STUDENT] PRIMARY KEY CLUSTERED 
(
	[NEPTUN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [StudentxUniversity](
	[su_SK] [int] IDENTITY(1,1) NOT NULL,
	[NEPTUN_FK] [varchar](6) NOT NULL,
	[Uni_FK] [varchar](10) NOT NULL,
 CONSTRAINT [PK_StudentxUniversity] PRIMARY KEY CLUSTERED 
(
	[su_SK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [StudxSub](
	[StudxSub_SK] [int] IDENTITY(1,1) NOT NULL,
	[NEPTUN_FK] [varchar](6) NOT NULL,
	[Sub_FK] [int] NOT NULL,
 CONSTRAINT [PK_STUDXSUB] PRIMARY KEY CLUSTERED 
(
	[StudxSub_SK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Subject](
	[Sub_SK] [int] IDENTITY(1,1) NOT NULL,
	[SubCode_FK] [varchar](255) NOT NULL,
	[Year] [nvarchar](6) NOT NULL,
	[elegseges] [int] NULL,
	[kozepes] [int] NULL,
	[jo] [int] NULL,
	[jeles] [int] NULL,
	[alairas] [bit] NOT NULL,
 CONSTRAINT [PK_SUBJECT] PRIMARY KEY CLUSTERED 
(
	[Sub_SK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Subject_name](
	[SubCode_ID] [varchar](255) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Uni_FK] [varchar](10) NOT NULL,
 CONSTRAINT [PK_SUBJECT_NAME] PRIMARY KEY CLUSTERED 
(
	[SubCode_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [University](
	[Uni_ID] [varchar](10) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Uni_sk] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_UNIVERSITY] PRIMARY KEY CLUSTERED 
(
	[Uni_sk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Max_type_points] ON 

INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (1, 5, 1, 60, 30)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (2, 5, 2, 46, 0)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (3, 1, 2, 30, 0)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (4, 2, 1, 70, 0)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (6, 2, 3, 30, 0)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (7, 3, 1, 60, 0)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (8, 3, 3, 40, 0)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (9, 1, 1, 70, 0)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (10, 4, 3, 20, 0)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (11, 9, 1, 100, 10)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (12, 10, 1, 100, 40)
INSERT [Max_type_points] ([Act_max_SK], [Sub_FK], [PT_FK], [max], [min]) VALUES (13, 9, 1, 100, 10)
SET IDENTITY_INSERT [Max_type_points] OFF
GO
SET IDENTITY_INSERT [Point] ON 

INSERT [Point] ([Point_SK], [Point], [StudxSub_FK], [PT_FK], [datum]) VALUES (1, 11, 4, 10, CAST(N'2020-03-08' AS Date))
INSERT [Point] ([Point_SK], [Point], [StudxSub_FK], [PT_FK], [datum]) VALUES (2, 18, 3, 8, CAST(N'2020-03-08' AS Date))
INSERT [Point] ([Point_SK], [Point], [StudxSub_FK], [PT_FK], [datum]) VALUES (3, 19, 1, 3, CAST(N'2020-04-15' AS Date))
INSERT [Point] ([Point_SK], [Point], [StudxSub_FK], [PT_FK], [datum]) VALUES (5, 2, 6, 2, CAST(N'2020-04-20' AS Date))
INSERT [Point] ([Point_SK], [Point], [StudxSub_FK], [PT_FK], [datum]) VALUES (6, 18, 3, 8, CAST(N'2020-04-28' AS Date))
INSERT [Point] ([Point_SK], [Point], [StudxSub_FK], [PT_FK], [datum]) VALUES (7, 18, 3, 7, CAST(N'2020-04-29' AS Date))
INSERT [Point] ([Point_SK], [Point], [StudxSub_FK], [PT_FK], [datum]) VALUES (11, 4, 2, 4, CAST(N'2020-05-01' AS Date))
SET IDENTITY_INSERT [Point] OFF
GO
SET IDENTITY_INSERT [point_types] ON 

INSERT [point_types] ([PT_SK], [PT_name]) VALUES (1, N'beadandó')
INSERT [point_types] ([PT_SK], [PT_name]) VALUES (2, N'vizsga')
INSERT [point_types] ([PT_SK], [PT_name]) VALUES (3, N'zh')
SET IDENTITY_INSERT [point_types] OFF
GO
INSERT [Student] ([NEPTUN], [Name], [Password]) VALUES (N'HHHHHH', N'Teszt Elek', N'ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f')
INSERT [Student] ([NEPTUN], [Name], [Password]) VALUES (N'HS3SS4', N'Filep Illés Attila', N'ef797c8118f02dfb649607dd5d3f8c7623048c9c063d532cc95c5ed7a898a64f')
GO
SET IDENTITY_INSERT [StudentxUniversity] ON 

INSERT [StudentxUniversity] ([su_SK], [NEPTUN_FK], [Uni_FK]) VALUES (3, N'HHHHHH', N'TE')
INSERT [StudentxUniversity] ([su_SK], [NEPTUN_FK], [Uni_FK]) VALUES (1, N'HS3SS4', N'BCE')
INSERT [StudentxUniversity] ([su_SK], [NEPTUN_FK], [Uni_FK]) VALUES (10, N'HS3SS4', N'BTE')
SET IDENTITY_INSERT [StudentxUniversity] OFF
GO
SET IDENTITY_INSERT [StudxSub] ON 

INSERT [StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (1, N'HS3SS4', 1)
INSERT [StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (2, N'HS3SS4', 2)
INSERT [StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (3, N'HS3SS4', 3)
INSERT [StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (4, N'HS3SS4', 4)
INSERT [StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (5, N'HS3SS4', 5)
INSERT [StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (6, N'HHHHHH', 5)
INSERT [StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (7, N'HS3SS4', 10)
INSERT [StudxSub] ([StudxSub_SK], [NEPTUN_FK], [Sub_FK]) VALUES (8, N'HS3SS4', 9)
SET IDENTITY_INSERT [StudxSub] OFF
GO
SET IDENTITY_INSERT [Subject] ON 

INSERT [Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (1, N'2SZ31NAK14B', N'2019/2', 54, 68, 82, 92, 0)
INSERT [Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (2, N'2SZ31NAK11B', N'2019/2', 50, 62, 74, 86, 0)
INSERT [Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (3, N'2SZ31NAK20B', N'2019/2', 60, 70, 80, 90, 0)
INSERT [Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (4, N'4OP13NAK01B', N'2019/2', 40, 55, 70, 85, 0)
INSERT [Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (5, N'4ST14NAK16B', N'2019/2', 55, 65, 80, 90, 0)
INSERT [Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (9, N'ASDASDASD', N'2020/1', 20, 30, 40, 50, 0)
INSERT [Subject] ([Sub_SK], [SubCode_FK], [Year], [elegseges], [kozepes], [jo], [jeles], [alairas]) VALUES (10, N'TESZT2019/2', N'2019/2', 20, 30, 40, 50, 0)
SET IDENTITY_INSERT [Subject] OFF
GO
INSERT [Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'2SZ31NAK11B', N'Adatbázis rendszerek', N'BCE')
INSERT [Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'2SZ31NAK14B', N'Számítógéphálózatok', N'BCE')
INSERT [Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'2SZ31NAK20B', N'Szoftvertechnológia II.', N'BCE')
INSERT [Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'4OP13NAK01B', N'Operációkutatás', N'BCE')
INSERT [Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'4ST14NAK16B', N'Statisztika I. (emelt szint)', N'BCE')
INSERT [Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'ASDASDASD', N'ASDASDASD', N'BCE')
INSERT [Subject_name] ([SubCode_ID], [Name], [Uni_FK]) VALUES (N'TESZT2019/2', N'Mostani évteszt', N'BCE')
GO
SET IDENTITY_INSERT [University] ON 

INSERT [University] ([Uni_ID], [Name], [Uni_sk]) VALUES (N'BCE', N'Budapest Corvinus Egyetem', 1)
INSERT [University] ([Uni_ID], [Name], [Uni_sk]) VALUES (N'BTE', N'Budapesti Teszt Egyetem', 2)
INSERT [University] ([Uni_ID], [Name], [Uni_sk]) VALUES (N'ÓE', N'Óbudai Egyetem', 3)
INSERT [University] ([Uni_ID], [Name], [Uni_sk]) VALUES (N'TEE', N'Teszt Eggyetem', 4)
INSERT [University] ([Uni_ID], [Name], [Uni_sk]) VALUES (N'TE', N'Teszt Egyetem', 5)
INSERT [University] ([Uni_ID], [Name], [Uni_sk]) VALUES (N'MTE', N'Másik Teszt Egyetem', 6)
SET IDENTITY_INSERT [University] OFF
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [point_types] ADD UNIQUE NONCLUSTERED 
(
	[PT_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [StudentxUniversity] ADD  CONSTRAINT [uq_uni_neptun] UNIQUE NONCLUSTERED 
(
	[NEPTUN_FK] ASC,
	[Uni_FK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [University] ADD  CONSTRAINT [uniq_name] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
ALTER TABLE [University] ADD  CONSTRAINT [UQ__Universi__737584F63675D5B2] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_University] ON [University]
(
	[Uni_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [Max_type_points] ADD  DEFAULT ('0') FOR [max]
GO
ALTER TABLE [Max_type_points] ADD  DEFAULT ('0') FOR [min]
GO
ALTER TABLE [Subject] ADD  CONSTRAINT [DF__Subject__alairas__37A5467C]  DEFAULT ('0') FOR [alairas]
GO
ALTER TABLE [Max_type_points]  WITH CHECK ADD  CONSTRAINT [Max_type_points_fk0] FOREIGN KEY([Sub_FK])
REFERENCES [Subject] ([Sub_SK])
GO
ALTER TABLE [Max_type_points] CHECK CONSTRAINT [Max_type_points_fk0]
GO
ALTER TABLE [Max_type_points]  WITH CHECK ADD  CONSTRAINT [Max_type_points_fk1] FOREIGN KEY([PT_FK])
REFERENCES [point_types] ([PT_SK])
ON UPDATE CASCADE
GO
ALTER TABLE [Max_type_points] CHECK CONSTRAINT [Max_type_points_fk1]
GO
ALTER TABLE [Point]  WITH CHECK ADD  CONSTRAINT [Point_fk0] FOREIGN KEY([StudxSub_FK])
REFERENCES [StudxSub] ([StudxSub_SK])
ON UPDATE CASCADE
GO
ALTER TABLE [Point] CHECK CONSTRAINT [Point_fk0]
GO
ALTER TABLE [Point]  WITH CHECK ADD  CONSTRAINT [Point_fk1] FOREIGN KEY([PT_FK])
REFERENCES [Max_type_points] ([Act_max_SK])
ON UPDATE CASCADE
GO
ALTER TABLE [Point] CHECK CONSTRAINT [Point_fk1]
GO
ALTER TABLE [StudentxUniversity]  WITH CHECK ADD  CONSTRAINT [fk_UNI] FOREIGN KEY([Uni_FK])
REFERENCES [University] ([Uni_ID])
GO
ALTER TABLE [StudentxUniversity] CHECK CONSTRAINT [fk_UNI]
GO
ALTER TABLE [StudentxUniversity]  WITH CHECK ADD  CONSTRAINT [neptun_fk] FOREIGN KEY([NEPTUN_FK])
REFERENCES [Student] ([NEPTUN])
GO
ALTER TABLE [StudentxUniversity] CHECK CONSTRAINT [neptun_fk]
GO
ALTER TABLE [StudxSub]  WITH CHECK ADD  CONSTRAINT [StudxSub_fk0] FOREIGN KEY([NEPTUN_FK])
REFERENCES [Student] ([NEPTUN])
ON UPDATE CASCADE
GO
ALTER TABLE [StudxSub] CHECK CONSTRAINT [StudxSub_fk0]
GO
ALTER TABLE [StudxSub]  WITH CHECK ADD  CONSTRAINT [StudxSub_fk1] FOREIGN KEY([Sub_FK])
REFERENCES [Subject] ([Sub_SK])
ON UPDATE CASCADE
GO
ALTER TABLE [StudxSub] CHECK CONSTRAINT [StudxSub_fk1]
GO
ALTER TABLE [Subject]  WITH CHECK ADD  CONSTRAINT [Subject_fk0] FOREIGN KEY([SubCode_FK])
REFERENCES [Subject_name] ([SubCode_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Subject] CHECK CONSTRAINT [Subject_fk0]
GO
ALTER DATABASE [point_counter] SET  READ_WRITE 
GO
