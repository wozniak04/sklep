CREATE TABLE [dbo].[Uzytkownik]
(
	[IdUzytkownika] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nazwa] NVARCHAR(21) NOT NULL, 
    [Haslo] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Zdjecie] IMAGE NULL 
    
)
