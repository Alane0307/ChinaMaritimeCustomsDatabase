CREATE PROC fuzsearch_procA
@_fzw VARCHAR(300),
@_bookname VARCHAR(300),
@_time SMALLINT,
@_page SMALLINT,
@_region VARCHAR(50),
@_title VARCHAR(300),
@_keyword VARCHAR(20),
@_mapflag NCHAR(1),
@_graphflag NCHAR(1),
@_photoflag NCHAR(1),
@_sketchflag NCHAR(1),
@_otherflag NCHAR(1)
AS
	IF @_otherflag = 'T'
		BEGIN
			SELECT *
			FROM PageInfo AS pa
			WHERE (pa.Tag = @_photoflag OR pa.Tag = @_sketchflag OR pa.Tag = @_mapflag OR pa.Tag = @_graphflag OR pa.Tag is NULL)
				AND pa.BookName LIKE '%'+@_bookname+'%'
				AND isNULL(pa.Region,0) LIKE '%'+@_region+'%'
				AND isNULL(pa.Title,0) LIKE '%'+@_title+'%'
				AND pa.CallNo IN
					(SELECT kw.CallNo FROM KeyWord AS kw WHERE kw.Keyword LIKE '%'+@_keyword+'%')
				AND ((pa.StartPage = CASE WHEN @_page <> 0 
						THEN @_page
						ELSE pa.StartPage 
						END)
					OR (isNULL(pa.StartPage,0) <= @_page AND isNULL(pa.EndPage,0) >= @_page))
				AND ((pa.StartTime = CASE WHEN @_time <> 0 
						THEN @_time
						ELSE pa.StartTime
						END)
					OR (isNULL(pa.StartTime,0) <= @_time AND isNULL(pa.EndTime,0) >= @_time))
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
			WHERE (pa.Tag = @_photoflag OR pa.Tag = @_sketchflag OR pa.Tag = @_mapflag OR pa.Tag = @_graphflag)
				AND pa.BookName LIKE '%'+@_bookname+'%'
				AND isNULL(pa.Region,0) LIKE '%'+@_region+'%'
				AND isNULL(pa.Title,0) LIKE '%'+@_title+'%'
				AND pa.CallNo IN
					(SELECT kw.CallNo FROM KeyWord AS kw WHERE kw.Keyword LIKE '%'+@_keyword+'%')
				AND ((pa.StartPage = CASE WHEN @_page <> 0 
						THEN @_page
						ELSE pa.StartPage 
						END)
					OR (isNULL(pa.StartPage,0) <= @_page AND isNULL(pa.EndPage,0) >= @_page))
				AND ((pa.StartTime = CASE WHEN @_time <> 0 
						THEN @_time
						ELSE pa.StartTime
						END)
					OR (isNULL(pa.StartTime,0) <= @_time AND isNULL(pa.EndTime,0) >= @_time))
				AND (pa.BookName LIKE '%'+@_fzw+'%'
					OR pa.Region LIKE '%'+@_fzw+'%'
					OR pa.Title LIKE '%'+@_fzw+'%'
					OR pa.CallNo IN
						(SELECT kw.CallNo FROM KeyWord AS kw WHERE kw.Keyword LIKE '%'+@_fzw+'%'))
		END