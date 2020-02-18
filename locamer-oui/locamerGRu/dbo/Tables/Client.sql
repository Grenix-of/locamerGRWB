CREATE TABLE [dbo].[Client] (
    [idCli]     INT           IDENTITY (1, 1) NOT NULL,
    [nomCli]    NVARCHAR (50) NOT NULL,
    [prenomCli] NVARCHAR (50) NOT NULL,
    [telephone] NVARCHAR (50) NOT NULL,
    [email]     NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([idCli] ASC)
);

