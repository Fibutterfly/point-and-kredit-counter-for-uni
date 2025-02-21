--CREATE DATABASE point_counter;
USE point_counter;
CREATE TABLE [Student] (
	NEPTUN varchar(6) NOT NULL,
	Name varchar(255) NOT NULL,
	Password varchar(255) NOT NULL,
  CONSTRAINT [PK_STUDENT] PRIMARY KEY CLUSTERED
  (
  [NEPTUN] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Subject] (
	Sub_SK integer IDENTITY(1,1) NOT NULL,
	SubCode_FK varchar(255) NOT NULL,
	Year integer NOT NULL,
	elegseges integer,
	kozepes integer,
	jo integer,
	jeles integer,
	alairas BIT NOT NULL DEFAULT '0',
  CONSTRAINT [PK_SUBJECT] PRIMARY KEY CLUSTERED
  (
  [Sub_SK] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Subject_name] (
	SubCode_ID varchar(255) NOT NULL,
	Name varchar(255) NOT NULL,
	Uni_FK varchar(10) NOT NULL,
  CONSTRAINT [PK_SUBJECT_NAME] PRIMARY KEY CLUSTERED
  (
  [SubCode_ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [StudxSub] (
	StudxSub_SK integer IDENTITY(1,1) NOT NULL,
	NEPTUN_FK varchar(6) NOT NULL,
	Sub_FK integer NOT NULL,
  CONSTRAINT [PK_STUDXSUB] PRIMARY KEY CLUSTERED
  (
  [StudxSub_SK] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Point] (
	Point_SK integer IDENTITY(1,1) NOT NULL,
	Point float NOT NULL,
	StudxSub_FK integer NOT NULL,
	PT_FK integer NOT NULL,
	datum date NOT NULL,
  CONSTRAINT [PK_POINT] PRIMARY KEY CLUSTERED
  (
  [Point_SK] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [point_types] (
	PT_SK integer IDENTITY(1,1) NOT NULL,
	PT_name varchar(255) NOT NULL UNIQUE,
  CONSTRAINT [PK_POINT_TYPES] PRIMARY KEY CLUSTERED
  (
  [PT_SK] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Max_type_points] (
	Act_max_SK integer IDENTITY(1,1) NOT NULL,
	Sub_FK integer NOT NULL,
	PT_FK integer NOT NULL,
	max integer NOT NULL DEFAULT '0',
	min integer NOT NULL DEFAULT '0',
  CONSTRAINT [PK_MAX_TYPE_POINTS] PRIMARY KEY CLUSTERED
  (
  [Act_max_SK] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [University] (
	Uni_ID varchar(10) NOT NULL,
	Name varchar(255) NOT NULL UNIQUE,
  CONSTRAINT [PK_UNIVERSITY] PRIMARY KEY CLUSTERED
  (
  [Uni_ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [StudentxUniversity] (
	NEPTUN_FK varchar(6) NOT NULL,
	Uni_FK varchar(10) NOT NULL,
  CONSTRAINT [PK_STUDENTXUNIVERSITY] PRIMARY KEY CLUSTERED
  (
  [NEPTUN_FK] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [Subject] WITH CHECK ADD CONSTRAINT [Subject_fk0] FOREIGN KEY ([SubCode_FK]) REFERENCES [Subject_name]([SubCode_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Subject] CHECK CONSTRAINT [Subject_fk0]
GO

ALTER TABLE [Subject_name] WITH CHECK ADD CONSTRAINT [Subject_name_fk0] FOREIGN KEY ([Uni_FK]) REFERENCES [University]([Uni_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [Subject_name] CHECK CONSTRAINT [Subject_name_fk0]
GO

ALTER TABLE [StudxSub] WITH CHECK ADD CONSTRAINT [StudxSub_fk0] FOREIGN KEY ([NEPTUN_FK]) REFERENCES [Student]([NEPTUN])
ON UPDATE CASCADE
GO
ALTER TABLE [StudxSub] CHECK CONSTRAINT [StudxSub_fk0]
GO
ALTER TABLE [StudxSub] WITH CHECK ADD CONSTRAINT [StudxSub_fk1] FOREIGN KEY ([Sub_FK]) REFERENCES [Subject]([Sub_SK])
ON UPDATE CASCADE
GO
ALTER TABLE [StudxSub] CHECK CONSTRAINT [StudxSub_fk1]
GO

ALTER TABLE [Point] WITH CHECK ADD CONSTRAINT [Point_fk0] FOREIGN KEY ([StudxSub_FK]) REFERENCES [StudxSub]([StudxSub_SK])
ON UPDATE CASCADE
GO
ALTER TABLE [Point] CHECK CONSTRAINT [Point_fk0]
GO
ALTER TABLE [Point] WITH CHECK ADD CONSTRAINT [Point_fk1] FOREIGN KEY ([PT_FK]) REFERENCES [Max_type_points]([Act_max_SK])
ON UPDATE CASCADE
GO
ALTER TABLE [Point] CHECK CONSTRAINT [Point_fk1]
GO


ALTER TABLE [Max_type_points] WITH CHECK ADD CONSTRAINT [Max_type_points_fk0] FOREIGN KEY ([Sub_FK]) REFERENCES [Subject]([Sub_SK])
GO
ALTER TABLE [Max_type_points] CHECK CONSTRAINT [Max_type_points_fk0]
GO
ALTER TABLE [Max_type_points] WITH CHECK ADD CONSTRAINT [Max_type_points_fk1] FOREIGN KEY ([PT_FK]) REFERENCES [point_types]([PT_SK])
ON UPDATE CASCADE
GO
ALTER TABLE [Max_type_points] CHECK CONSTRAINT [Max_type_points_fk1]
GO


ALTER TABLE [StudentxUniversity] WITH CHECK ADD CONSTRAINT [StudentxUniversity_fk0] FOREIGN KEY ([NEPTUN_FK]) REFERENCES [Student]([NEPTUN])
ON UPDATE CASCADE
GO
ALTER TABLE [StudentxUniversity] CHECK CONSTRAINT [StudentxUniversity_fk0]
GO
ALTER TABLE [StudentxUniversity] WITH CHECK ADD CONSTRAINT [StudentxUniversity_fk1] FOREIGN KEY ([Uni_FK]) REFERENCES [University]([Uni_ID])
ON UPDATE CASCADE
GO
ALTER TABLE [StudentxUniversity] CHECK CONSTRAINT [StudentxUniversity_fk1]
GO