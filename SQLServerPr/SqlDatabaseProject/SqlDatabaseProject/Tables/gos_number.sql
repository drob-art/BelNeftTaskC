CREATE TABLE [dbo].[gos_number]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [number] NCHAR(10) NULL, 
    [serial] NCHAR(10) NULL, 
    [region] NCHAR(10) NULL, 
    [idModelCar] INT NULL, 
    [idColor] INT NULL
)
