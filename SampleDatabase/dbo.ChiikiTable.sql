CREATE TABLE [dbo].[ChiikiTable] (
	[KenCd] INT	NOT NULL,
	[ChiikiCd]	INT	NOT NULL,
	[ChiikiNm]	nvarchar(50),
	[ChiikiKN]	nvarchar(50),
	PRIMARY KEY CLUSTERED ([KenCd],[ChiikiCd] ASC)
);