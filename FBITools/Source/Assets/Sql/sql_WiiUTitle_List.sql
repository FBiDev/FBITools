--
SELECT 
	  UPPER(a.TitleID) AS TitleID
	, a.Key 
	, a.Name 
	, a.Region 
	, a.Type 
FROM App AS a 
WHERE 1 = 1 
ORDER BY a.TitleID ASC 
--