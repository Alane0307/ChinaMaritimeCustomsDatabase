USE ChinaMarinetime
GO
CREATE PROC fileroute_procA
@_fn NCHAR(5),
@_fr VARCHAR(200) OUTPUT
AS
	SELECT @_fr = FileRoute
	FROM FileRoute
	WHERE FileNo = @_fn
GO