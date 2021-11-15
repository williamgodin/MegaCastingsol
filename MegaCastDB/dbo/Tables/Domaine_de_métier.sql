CREATE TABLE [dbo].[Domaine_de_métier] (
    [Id_Domaine_metier] INT          IDENTITY (1, 1) NOT NULL,
    [Libelle]           VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Domaine_metier] ASC)
);

