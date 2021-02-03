CREATE TABLE [dbo].[Table]
(
	[Sno] VARCHAR(3) NOT NULL, 
    [Pno] VARCHAR(3) NOT NULL, 
    [Qty] INT NULL DEFAULT 100, 
    [Price] DECIMAL(4, 3) NULL, 
    CONSTRAINT [check_price] CHECK ([Price] >= 0),
	PRIMARY KEY ([Sno], [Pno]),
	FOREIGN KEY ([Sno]) REFERENCES dbo.SUPPLIER([Sno]),
	FOREIGN KEY ([Pno]) REFERENCES dbo.PART([Pno]),
	 
)
