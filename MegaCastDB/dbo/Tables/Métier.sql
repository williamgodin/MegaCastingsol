CREATE TABLE [dbo].[Métier] (
    [Id_Metier]         INT          IDENTITY (1, 1) NOT NULL,
    [Libelle]           VARCHAR (50) NOT NULL,
    [Id_Domaine_metier] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Metier] ASC),
    FOREIGN KEY ([Id_Domaine_metier]) REFERENCES [dbo].[Domaine_de_métier] ([Id_Domaine_metier])
);

