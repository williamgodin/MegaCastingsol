CREATE TABLE [dbo].[Artiste] (
    [Id_Artiste]  INT NOT NULL,
    [Id_Personne] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Artiste] ASC),
    FOREIGN KEY ([Id_Personne]) REFERENCES [dbo].[Personne] ([Id_Personne])
);

