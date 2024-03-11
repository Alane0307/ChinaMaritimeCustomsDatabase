USE ChinaMarinetime
GO
CREATE TABLE PageInfo
(
CallNo NCHAR(5) PRIMARY KEY,
BookName VARCHAR(120) NOT NULL,
StartTime SMALLINT,
EndTime SMALLINT,
BookNo TINYINT NOT NULL DEFAULT(1),
StartPage SMALLINT,
EndPage SMALLINT,
Condition VARCHAR(100),
Region VARCHAR(50),
Title VARCHAR(50),
Tag NCHAR(1),
Category VARCHAR(10),
Remark1 VARCHAR(30),
Remark2 VARCHAR(30),
Composition NCHAR(20)
);
GO