CREATE TABLE [dbo].[Casting] (
    [Id_Casting]             INT           IDENTITY (1, 1) NOT NULL,
    [Intitule]               VARCHAR (50)  NOT NULL,
    [Reference]              INT           NOT NULL,
    [Date_debut_publication] DATETIME      NOT NULL,
    [Nbr_poste]              INT           NOT NULL,
    [Localisation]           VARCHAR (50)  NOT NULL,
    [Description_poste]      VARCHAR (250) NOT NULL,
    [Description_profil]     VARCHAR (250) NOT NULL,
    [Coordonnees]            VARCHAR (250) NOT NULL,
    [Duree_diffusion]        DATETIME      NOT NULL,
    [Id_Professionnel]       INT           NOT NULL,
    [Id_Contrat]             INT           NOT NULL,
    [Id_Metier]              INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Casting] ASC),
    FOREIGN KEY ([Id_Contrat]) REFERENCES [dbo].[Type_de_contrat] ([Id_Contrat]),
    FOREIGN KEY ([Id_Metier]) REFERENCES [dbo].[Métier] ([Id_Metier]),
    FOREIGN KEY ([Id_Professionnel]) REFERENCES [dbo].[Professionnel] ([Id_Professionnel])
);

