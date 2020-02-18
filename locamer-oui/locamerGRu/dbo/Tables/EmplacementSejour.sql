CREATE TABLE [dbo].[EmplacementSejour] (
    [idES]            INT IDENTITY (1, 1) NOT NULL,
    [codeEmplacement] INT NOT NULL,
    [idSejour]        INT NOT NULL,
    PRIMARY KEY CLUSTERED ([idES] ASC),
    FOREIGN KEY ([codeEmplacement]) REFERENCES [dbo].[Emplacement] ([codeEmplacement]) ON DELETE CASCADE,
    FOREIGN KEY ([idSejour]) REFERENCES [dbo].[Sejour] ([idSejour]) ON DELETE CASCADE
);

