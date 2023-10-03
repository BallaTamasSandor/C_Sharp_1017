CREATE TABLE [dbo].[Osztalyok] (
    [Id_Osztaly] INT        IDENTITY (1, 1) NOT NULL,
    [Osztaly]    NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Osztaly] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Osztalyok_Osztaly]
    ON [dbo].[Osztalyok]([Osztaly] ASC);

