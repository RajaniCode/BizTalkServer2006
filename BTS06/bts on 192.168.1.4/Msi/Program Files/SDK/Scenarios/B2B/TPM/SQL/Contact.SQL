ALTER TABLE [dbo].[ContactObject] ADD
	[UserName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS,
	[Password] [nvarchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[keyindex] [int] NULL

GO

ALTER TABLE ContactObject
	ALTER COLUMN [UserName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
GO