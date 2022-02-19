CREATE TABLE [dbo].[Uzytkownik]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nazwa] NVARCHAR(21) NOT NULL, 
    [Haslo] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(50) NOT NULL, 
    [Kolor] NVARCHAR(1) NOT NULL, 
    
)
