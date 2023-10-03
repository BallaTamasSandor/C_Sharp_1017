CREATE TABLE [dbo].[Beosztasok] (
    [Id_Beosztas] INT        IDENTITY (1, 1) NOT NULL,
    [Beosztas]    NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Beosztas] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Beosztasok_Beosztas]
    ON [dbo].[Beosztasok]([Beosztas] ASC);

