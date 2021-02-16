CREATE TABLE [dbo].[ClienteTelefone]
(
	[ClienteId] UNIQUEIDENTIFIER NOT NULL,
	[TelefoneId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_ClienteTelefone_ToCliente] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente]([Id]), 
    CONSTRAINT [FK_ClienteTelefone_ToTelefone] FOREIGN KEY ([TelefoneId]) REFERENCES [Telefone]([Id]),
)
