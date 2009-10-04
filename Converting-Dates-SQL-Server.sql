SELECT 
   GETDATE() AS DefaultFormat,
   CONVERT(nvarchar(30), GETDATE(), 101) AS US,
   CONVERT(nvarchar(30), GETDATE(), 103) AS UK,
   CONVERT(nvarchar(30), GETDATE(), 111) AS Japan,
   CONVERT(nvarchar(30), GETDATE(), 104) AS German,
   CONVERT(nvarchar(30), GETDATE(), 112) AS ISO,
   CONVERT(nvarchar(30), GETDATE(), 109) AS Date_with_Milliseconds