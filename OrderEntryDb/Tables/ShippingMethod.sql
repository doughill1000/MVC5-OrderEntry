CREATE TABLE [dbo].[ShippingMethod]
(
	[Id] UNIQUEIDENTIFIER CONSTRAINT PK_ShippingMethod PRIMARY KEY,
    [Name] VARCHAR(35) NOT NULL, 
    [Active] BIT NOT NULL
)
