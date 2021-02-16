CREATE TABLE [dbo].[ClienteEndereco]
(
	[ClienteId] UNIQUEIDENTIFIER NOT NULL,
	[EnderecoId] UNIQUEIDENTIFIER NOT NULL, 
    CONSTRAINT [FK_ClienteEndereco_ToCliente] FOREIGN KEY ([ClienteId]) REFERENCES [Cliente]([Id]), 
    CONSTRAINT [FK_ClienteEndereco_ToEndereco] FOREIGN KEY ([EnderecoId]) REFERENCES [Endereco]([Id]),
)
