CREATE TABLE [dbo].[TitanicSyndrome]
(
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
    [name] NTEXT NOT NULL, 
    [age] INT NOT NULL, 
    [gender] BIT NOT NULL, 
    [cell_num] INT NOT NULL, 
    [email] TEXT NOT NULL, 
    [job] TEXT NOT NULL
)
