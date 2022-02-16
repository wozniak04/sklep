CREATE TABLE [dbo].[Person] (
    [Id]    INT          NOT NULL,
    [Nazwa] VARCHAR (21) NOT NULL,
    [Haslo] VARCHAR (50) NOT NULL,
    [Email] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
INSERT INTO Person (Nazwa,Haslo,Email) VALUES ("admin","root","Email")