CREATE TABLE [dbo].[Aliquota]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
    [PercentualPis] NUMERIC,
    [CstpPis] NUMERIC,
    [Cfop] NUMERIC,
    [CstConfins] NUMERIC,
    [PrecentualConfins] NUMERIC,
    [AliquotaCSOSN] NUMERIC,
    [Csosn] NUMERIC,
    [Cest] NUMERIC,
    [AliquotaICMS] NUMERIC,
    [AliquotaFederal] NUMERIC,
    [AliquotaEstadual] NUMERIC,
    [AliquotaMunicipal] NUMERIC,
    [SituacaoTributariaId] INT,
    [Ativo] BIT, 
    CONSTRAINT [FK_Aliquota_SituacaoTributaria] FOREIGN KEY (SituacaoTributariaId) REFERENCES SituacaoTributaria([Id])
)
