CREATE TABLE [dbo].[Telefone]
(
	[Id] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(), 
    [DDD] NCHAR(3) NULL, 
    [Numero] VARCHAR(11) NULL, 
    [TipoTelefoneId] INT NULL, 
    [Status] BIT NULL,
    CONSTRAINT [FK_Telefone_ToTable] FOREIGN KEY ([TipoTelefoneId]) REFERENCES [TipoTelefone]([Id]),

)
