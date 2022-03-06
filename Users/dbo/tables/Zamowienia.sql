CREATE TABLE [dbo].[Zamowienia]
(
	[IdZamowienia] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ZdjecieOferty] IMAGE NOT NULL, 
    [NazwaUzytkownika] NVARCHAR(50) NOT NULL, 
    [NazwaOferty] NVARCHAR(50) NOT NULL, 
    [CenaOferty] INT NOT NULL
)
