CREATE TABLE [dbo].[Tarif] (
    [idTarif] INT           IDENTITY (1, 1) NOT NULL,
    [libelle] NVARCHAR (50) NOT NULL,
    [prix]    FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([idTarif] ASC)
);

