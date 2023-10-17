CREATE TABLE [dbo].[iktat] (
    [Id_iktat]   INT        IDENTITY (1, 1) NOT NULL,
    [Iktatoszam] NCHAR (20) NOT NULL,
    [IdUser]     INT        NOT NULL,
    [Datum]      DATE       NOT NULL,
    [IdTema]     INT        NOT NULL,
    [Leiras]     NCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_iktat] ASC),
    CONSTRAINT [FK_iktat_Temak] FOREIGN KEY ([IdTema]) REFERENCES [dbo].[Temak] ([Id_Tema]),
    CONSTRAINT [FK_iktat_Users] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[Users] ([Id_user])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_iktat_Iktatoszam]
    ON [dbo].[iktat]([Iktatoszam] ASC);

