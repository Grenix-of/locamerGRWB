CREATE TABLE [dbo].[Sejour] (
    [idSejour]        INT  IDENTITY (1, 1) NOT NULL,
    [dateDebut]       DATE NOT NULL,
    [dateFin]         DATE NOT NULL,
    [codeEmplacement] INT  NOT NULL,
    [idCli]           INT  NOT NULL,
    [idReduc]         INT  NOT NULL,
    PRIMARY KEY CLUSTERED ([idSejour] ASC),
    CONSTRAINT [FK_dbo.Client_dbo.client_idCli] FOREIGN KEY ([idCli]) REFERENCES [dbo].[Client] ([idCli]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.Type_dbo.Type_idReduc] FOREIGN KEY ([idReduc]) REFERENCES [dbo].[Type] ([idReduc]) ON DELETE CASCADE
);

