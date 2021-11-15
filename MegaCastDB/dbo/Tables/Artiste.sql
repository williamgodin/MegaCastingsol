CREATE TABLE [dbo].[Artiste] (
    [Id_Personne]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Personne] ASC),
    FOREIGN KEY ([Id_Personne]) REFERENCES [dbo].[Personne] ([Id_Personne])
);



