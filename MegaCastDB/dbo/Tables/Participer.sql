CREATE TABLE [dbo].[Participer] (
[Id_Participer] INT NOT NULL IDENTITY(1,1),
    [Id_Casting] INT NOT NULL,
    [Id_Artiste] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Casting] ASC, [Id_Artiste] ASC),
    FOREIGN KEY ([Id_Artiste]) REFERENCES [dbo].[Artiste] ([Id_Personne]),
    FOREIGN KEY ([Id_Casting]) REFERENCES [dbo].[Casting] ([Id_Casting])
);

