CREATE TABLE [dbo].[SUPPLIER]
(
	[Sno] VARCHAR(3) NOT NULL PRIMARY KEY,
	[Sname] VARCHAR(15) NOT NULL, 
    [Status] INT NULL, 
    CONSTRAINT [CK_status] CHECK ([status] >= 0),
	[City] VARCHAR(15)
	

)
