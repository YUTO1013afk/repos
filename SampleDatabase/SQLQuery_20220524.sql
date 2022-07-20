-- ②-1 エリア別県の一覧
SELECT A.AreaCd AS "エリアコード",
       A.AreaNm AS "エリア名",
       B.KenCd AS "県コード",
       B.KenNm AS "県名" 
FROM dbo.AreaTable AS A
INNER JOIN dbo.KenTable AS B ON A.AreaCd = B.AreaCd
ORDER BY A.AreaCd, B.AreaCd;

--②-2 エリア別県の数
SELECT A.AreaCd AS "エリアコード", A.AreaNm AS "エリア名", COUNT(*) AS "県の数"
FROM dbo.AreaTable AS A
INNER JOIN dbo.KenTable AS B ON A.AreaCd = B.AreaCd
GROUP BY A.AreaCd, A.AreaNm
ORDER BY A.AreaCd;

--②-3 エリア別県別地域の一覧 
SELECT A.AreaNm AS "エリア名",
       B.KenNm AS "県名",
       C.ChiikiNm AS "地域名"
FROM dbo.AreaTable AS A
INNER JOIN dbo.KenTable AS B ON A.AreaCd = B.AreaCd
INNER JOIN dbo.ChiikiTable AS C ON B.KenCd = C.KenCd
ORDER BY A.AreaCd, B.KenCd;