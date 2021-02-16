﻿CREATE TABLE [dbo].[Cliente]
(
	[Id] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(), 
    [Nome] VARCHAR(200) NULL,  
    [DataNascmento] DateTime NOT NULL,
    [Cpf] VARCHAR(14) NULL, 
    [Rg] VARCHAR(12) NULL, 
)
