--
SELECT 
	  UPPER(t.TitleID) AS TitleID 
	, t.TitleKey 
	, t.Name 
	, t.Region 
	, t.Category 
FROM Title AS t 
WHERE 1 = 1 
ORDER BY t.TitleID ASC;
--