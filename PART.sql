CREATE TABLE [dbo].[PART]
(
	[Pno] VARCHAR(3) NOT NULL PRIMARY KEY, 
    [Pname] VARCHAR(15) NOT NULL, 
    [Color] VARCHAR(10) NULL, 
    [Weight] INT NULL, 
    [City] VARCHAR(15) NULL, 
    CONSTRAINT [CK_PART_weight] CHECK ([Weight] <= 100 AND [Weight] > 0),
	UNIQUE([Pname], [Color])
)
