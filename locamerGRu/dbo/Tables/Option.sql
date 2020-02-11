CREATE TABLE [dbo].[Option] (
    [idOption] INT           IDENTITY (1, 1) NOT NULL,
    [libelle]  NVARCHAR (50) NOT NULL,
    [prixJour] FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([idOption] ASC)
);

