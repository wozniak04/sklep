CREATE TABLE [dbo].[Oferty]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nazwa] NVARCHAR(50) NOT NULL, 
    [Cena] INT NOT NULL, 
    [Zdjecie] IMAGE NOT NULL, 
    [Opis] NTEXT NOT NULL
)
