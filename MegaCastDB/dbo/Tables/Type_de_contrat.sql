CREATE TABLE [dbo].[Type_de_contrat] (
    [Id_Contrat] INT          IDENTITY (1, 1) NOT NULL,
    [Libelle]    VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Contrat] ASC)
);

