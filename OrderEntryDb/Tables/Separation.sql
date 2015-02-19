CREATE TABLE [dbo].[Separation]
(
	[DesignId] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [DesignNum] VARCHAR(10) NULL, 
    [DesignName] VARCHAR(75) NULL, 
	[CustDesignNum] Varchar(15) NULL,
	[CustDesignName] VARCHAR(75) NULL,
    [Owner] VARCHAR(50) NULL, 
    [SoldTo] VARCHAR(50) NULL, 
	[Disk] BIT NULL,
	[Swatch] BIT NULL,
	[Artwork] BIT NULL,
    [DateReceived] DATE NULL, 
    [ToBeEngraved] BIT NULL, 
    [SentToSeparation] DATE NULL, 
	[SentToEngraveDept] DATE NULL, 
    [DesignDescription] VARCHAR(25) NULL, 
    [DesignCoordinates] VARCHAR(15) NULL, 
    [WebUpload] BIT NULL, 
    [Comments] VARCHAR(100) NULL, 
    [SeparationCharges] MONEY NULL, 
    [SeparationChargesDescription] VARCHAR(50) NULL
)
