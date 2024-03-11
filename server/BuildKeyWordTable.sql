USE ChinaMarinetime
GO
CREATE TABLE KeyWord
(
CallNo NCHAR(5) ,
Keyword NVARCHAR(20),
CONSTRAINT KW
PRIMARY KEY(CallNo, KeyWord)
);
GO