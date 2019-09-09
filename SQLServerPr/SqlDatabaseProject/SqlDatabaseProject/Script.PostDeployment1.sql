/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [dbo].[color] ([id], [color]) VALUES (1, N'Red       ')
GO

INSERT INTO [dbo].[color] ([id], [color]) VALUES (2, N'Black     ')
GO

INSERT INTO [dbo].[gos_number] ([id], [number], [serial], [region], [idModelCar], [idColor]) VALUES (1, N'1111      ', N'AA        ', N'3         ', 1, 1)
GO

INSERT INTO [dbo].[gos_number] ([id], [number], [serial], [region], [idModelCar], [idColor]) VALUES (2, N'2222      ', N'BB        ', N'4         ', 2, 1)
GO

INSERT INTO [dbo].[model_car] ([id], [model]) VALUES (1, N'Audi      ')
GO

INSERT INTO [dbo].[model_car] ([id], [model]) VALUES (2, N'VW        ')
GO

