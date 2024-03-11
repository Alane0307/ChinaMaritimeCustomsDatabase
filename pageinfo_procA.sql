CREATE PROC pageinfo_procA
@_kw VARCHAR(20)
AS
	SELECT CallNo, Condition, Region, Title, Tag, Category, Remark1, Remark2
	FROM PageInfo
	WHERE CallNo IN
	(SELECT kw.CallNo FROM KeyWord AS kw WHERE kw.Keyword = @_kw)