CREATE TABLE [dbo].[KenTable] (
	[AreaCd] INT	NOT NULL,
	[KenCd]	INT	NOT NULL,
	[KenNm]	nchar(10),
	[KenKN]	nchar(10),
	PRIMARY KEY CLUSTERED ([AreaCd],[KenCd] ASC)
);