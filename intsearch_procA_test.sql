DECLARE @_fzw as VARCHAR(300) = ''
DECLARE @_bookname as VARCHAR(300) = ''
DECLARE @_time as SMALLINT = ''
DECLARE @_page as SMALLINT = ''
DECLARE @_region as VARCHAR(50) = ''
DECLARE @_title as VARCHAR(300) = ''
DECLARE @_keyword as VARCHAR(20) = ''
DECLARE @_mapflag as NCHAR(1) = 'N'
DECLARE @_graphflag as NCHAR(1) = 'N'
DECLARE @_photoflag as NCHAR(1) = 'P'
DECLARE @_sketchflag as NCHAR(1) = 'S'
DECLARE @_otherflag as NCHAR(1) = 'N'
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