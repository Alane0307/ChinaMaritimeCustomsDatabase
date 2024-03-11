CREATE PROC fileno_procA
@_cn NCHAR(20)
AS
	SELECT FileNo
	FROM FileRoute
	WHERE CallNo = @_cn