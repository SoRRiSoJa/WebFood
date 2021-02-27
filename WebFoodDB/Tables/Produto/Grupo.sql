CREATE TABLE [dbo].[Grupo]
(
	[Id] INT NOT NULL PRIMARY KEY Identity, 
    [Descricao] VARCHAR(30) NULL, 
    [CategoriaId] int ,
    [Status] BIT NULL, 
    CONSTRAINT [FK_Grupo_Categoria] FOREIGN KEY (CategoriaId) REFERENCES [Categoria]([Id])
)
