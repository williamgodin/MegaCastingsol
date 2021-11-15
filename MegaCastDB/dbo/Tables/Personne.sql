CREATE TABLE [dbo].[Personne] (
    [Id_Personne] INT          IDENTITY (1, 1) NOT NULL,
    [Nom]         VARCHAR (50) NOT NULL,
    [Prenom]      VARCHAR (50) NOT NULL,
    [Ville]       VARCHAR (50) NOT NULL,
    [Adresse]     VARCHAR (50) NOT NULL,
    [Email]       VARCHAR (50) NOT NULL,
    [Telephone]   VARCHAR (50) NULL,
    [Id_Civilite] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Personne] ASC),
    FOREIGN KEY ([Id_Civilite]) REFERENCES [dbo].[Civilité] ([Id_Civilite])
);

