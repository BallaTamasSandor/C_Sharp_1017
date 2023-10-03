CREATE TABLE [dbo].[Users] (
    [Id_user] INT        IDENTITY (1, 1) NOT NULL,
    [Nev]     NCHAR (20) NOT NULL,
    [Jelszo]  NCHAR (10) DEFAULT ((1234)) NOT NULL,
    [Admin]   TINYINT    DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_user] ASC),
    CONSTRAINT [CK_Users_Column] CHECK ([Admin]=(1) OR [Admin]=(0))
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_Nev]
    ON [dbo].[Users]([Nev] ASC);

