﻿CREATE TABLE [dbo].[User]
(
	[IdUser] INT NOT NULL PRIMARY KEY,
	[Username] VARCHAR(120) NOT NULL,
	[Password] VARCHAR(MAX) NOT NULL,
	[Role] VARCHAR(120) NOT NULL,
)
