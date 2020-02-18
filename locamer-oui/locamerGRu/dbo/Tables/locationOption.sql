CREATE TABLE [dbo].[locationOption] (
    [idLoc]     INT        IDENTITY (1, 1) NOT NULL,
    [quantitee] FLOAT (53) NOT NULL,
    [duree]     FLOAT (53) NOT NULL,
    [idOption]  INT        NOT NULL,
    [idSejour]  INT        NOT NULL,
    PRIMARY KEY CLUSTERED ([idLoc] ASC),
    CONSTRAINT [FK_dbo.locationOption_dbo.OPTION_idOption] FOREIGN KEY ([idOption]) REFERENCES [dbo].[Option] ([idOption]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Sejour_dbo.Sejour_idSejour] FOREIGN KEY ([idSejour]) REFERENCES [dbo].[Sejour] ([idSejour]) ON DELETE CASCADE
);

