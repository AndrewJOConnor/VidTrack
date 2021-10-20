CREATE TABLE [dbo].[Videos]
(
	[videoID] INT NOT NULL PRIMARY KEY, 
    [title] NCHAR(100) NULL, 
    [seriesName] NCHAR(100) NOT NULL, 
    [episode] NCHAR(10) NOT NULL, 
    [recorded] NCHAR(10) NOT NULL, 
    [edited] NCHAR(10) NOT NULL, 
    [rendered] NCHAR(10) NOT NULL, 
    [thumbnailMade] NCHAR(10) NOT NULL, 
    [uploaded] NCHAR(10) NOT NULL
)
