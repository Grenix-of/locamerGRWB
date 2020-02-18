CREATE TABLE [dbo].[Emplacement] (
    [codeEmplacement] INT        IDENTITY (1, 1) NOT NULL,
    [capaciteMob]     FLOAT (53) NOT NULL,
    [terrasseCouv]    BIT        NOT NULL,
    [idTarif]         INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([codeEmplacement] ASC),
    CONSTRAINT [FK_dbo.Emplacement_dbo.Tarif_idTarif] FOREIGN KEY ([idTarif]) REFERENCES [dbo].[Tarif] ([idTarif]) ON DELETE CASCADE
);

