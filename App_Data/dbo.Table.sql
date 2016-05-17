CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Imię] NCHAR(10) NOT NULL, 
    [Nazwisko] NCHAR(10) NOT NULL, 
    [Wiek] INT NOT NULL, 
    [KwotaUbezpieczenia] MONEY NOT NULL, 
    [WysokośćSkładki] MONEY NOT NULL, 
    [StanCywilny] NCHAR(10) NOT NULL, 
    [Zawód] NCHAR(10) NOT NULL, 
    [IlośćDzieci] INT NOT NULL, 
    [Miasto] NCHAR(20) NOT NULL, 
    [NumerKontaktowy] INT NOT NULL
)
