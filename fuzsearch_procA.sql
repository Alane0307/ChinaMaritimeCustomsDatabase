CREATE PROC fuzsearch_procA
@_fzw VARCHAR(120)
@_mapflag NCHAR(1)
@_graphflag NCHAR(1)
@_otherflag NCHAR(1)
AS
	IF @_otherflag = 'T'
		BEGIN
			SELECT *
			FROM PageInfo AS pa
			WHERE (pa.Tag = @_mapflag OR pa.Tag = @_graphflag OR pa.Tag is NULL)
				AND (pa.BookName LIKE '%'+@_fzw+'%'
					OR pa.Region LIKE '%'+@_fzw+'%'
					OR pa.Title LIKE '%'+@_fzw+'%'
					OR pa.CallNo IN
						(SELECT kw.CallNo FROM KeyWord AS kw WHERE kw.Keyword LIKE '%'+@_fzw+'%'))
		END
	ELSE
		BEGIN
			SELECT *
			FROM PageInfo AS pa
			WHERE (pa.Tag = @_mapflag OR pa.Tag = @_graphflag)
				AND (pa.BookName LIKE '%'+@_fzw+'%'
					OR pa.Region LIKE '%'+@_fzw+'%'
					OR pa.Title LIKE '%'+@_fzw+'%'
					OR pa.CallNo IN
						(SELECT kw.CallNo FROM KeyWord AS kw WHERE kw.Keyword LIKE '%'+@_fzw+'%'))
		END
							
	(SELECT pa.CallNo FROM PageInfo AS pa WHERE (pa.StartPage <=30 and pa.EndPage >= 30) OR pa.StartPage = 35)