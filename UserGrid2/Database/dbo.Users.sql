CREATE TABLE [dbo].[Users] (
    [Id_user] INT        IDENTITY (1, 1) NOT NULL,
    [Nev]     NCHAR (20) NOT NULL,
    [Jelszo]  NCHAR (10) DEFAULT ((1234)) NOT NULL,
    [Admin]   TINYINT    DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_user] ASC),
    CONSTRAINT [CK_Users_Column] CHECK ([Admin] = (1)
                                            OR [Admin] = (0))
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_Nev]
    ON [dbo].[Users]([Nev] ASC);

SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([Id_user], [Nev], [Jelszo], [Admin]) VALUES (1, N'Attila              ', N'1234      ', 1)
INSERT INTO [dbo].[Users] ([Id_user], [Nev], [Jelszo], [Admin]) VALUES (3, N'Zsuzsa              ', N'1234      ', 0)
INSERT INTO [dbo].[Users] ([Id_user], [Nev], [Jelszo], [Admin]) VALUES (5, N'Alma                ', N'1234      ', 0)
INSERT INTO [dbo].[Users] ([Id_user], [Nev], [Jelszo], [Admin]) VALUES (6, N'Feri                ', N'1234      ', 0)
INSERT INTO [dbo].[Users] ([Id_user], [Nev], [Jelszo], [Admin]) VALUES (7, N'Ármin               ', N'1234      ', 0)
INSERT INTO [dbo].[Users] ([Id_user], [Nev], [Jelszo], [Admin]) VALUES (8, N'Zsolti              ', N'1234      ', 0)
INSERT INTO [dbo].[Users] ([Id_user], [Nev], [Jelszo], [Admin]) VALUES (9, N'Berci               ', N'1234      ', 0)
INSERT INTO [dbo].[Users] ([Id_user], [Nev], [Jelszo], [Admin]) VALUES (10, N'Zoli                ', N'1234      ', 0)
INSERT INTO [dbo].[Users] ([Id_user], [Nev], [Jelszo], [Admin]) VALUES (1008, N'Margó               ', N'1234      ', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
