CREATE TABLE [dbo].[Professionnel] (
    [Id_Professionnel] INT NOT NULL,
    [Id_Personne]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Professionnel] ASC),
    FOREIGN KEY ([Id_Personne]) REFERENCES [dbo].[Personne] ([Id_Personne])
);

