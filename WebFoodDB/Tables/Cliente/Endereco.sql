CREATE TABLE [dbo].[Endereco]
(
	[Id] UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID(), 
    [Cep] VARCHAR(9) NULL, 
    [Logradouro] VARCHAR(200) NULL, 
    [Complemento] VARCHAR(100) NULL, 
    [Bairro] VARCHAR(80) NULL, 
    [Localidade] VARCHAR(80) NULL, 
    [Uf] VARCHAR(2) NULL, 
    [Ibge] VARCHAR(20) NULL, 
    [Gia] VARCHAR(20) NULL, 
    [Siafi] VARCHAR(20) NULL,
    [Localizacao] Geometry,
    [TipoEnderecoId] int NOT NULL,
    [Status] BIT DEFAULT 1,
    CONSTRAINT [FK_Endereco_ToTable] FOREIGN KEY ([TipoEnderecoId]) REFERENCES [TipoEndereco]([Id]),
)
