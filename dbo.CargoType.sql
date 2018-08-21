CREATE TABLE [dbo].[CargoType] (
    [CargoID]          VARCHAR (10) NOT NULL,
    [CargoDescription] VARCHAR (1)  NOT NULL,
    [CargoWeight]      VARCHAR (1)  NOT NULL,
    [CargoHeight]      VARCHAR (1)  NOT NULL,
    [CargoLength]      VARCHAR (1)  NOT NULL,
    [CargoWidth]       VARCHAR (1)  NOT NULL,
    [AbnormalLoad]     VARCHAR (5)  NOT NULL,
    PRIMARY KEY CLUSTERED ([CargoID] ASC)
);

