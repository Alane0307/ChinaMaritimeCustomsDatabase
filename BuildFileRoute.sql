USE ChinaMarinetime
GO
CREATE TABLE FileRoute
(
FileNo NCHAR(5) PRIMARY KEY,
FileRoute VARCHAR(200) UNIQUE,
CallNo NCHAR(5) NOT NULL
);