CREATE TABLE [dbo].[Type] (
    [idReduc]   INT           IDENTITY (1, 1) NOT NULL,
    [libelle]   NVARCHAR (50) NOT NULL,
    [coefReduc] FLOAT (53)    NOT NULL,
    PRIMARY KEY CLUSTERED ([idReduc] ASC)
);

