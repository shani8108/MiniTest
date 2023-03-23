-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
alter PROCEDURE getQPU
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	create table #QuantityOfUnit(ContentType nvarchar(20),Unit int)

	insert into #QuantityOfUnit
		SELECT 
	   RIGHT(QuantityPerUnit,(CHARINDEX(' ',REVERSE(QuantityPerUnit),0)))as ContentType
	  ,cast(SUBSTRING(QuantityPerUnit, 1, CHARINDEX(' ',QuantityPerUnit)) as int) as Unit
  FROM [Northwind].[dbo].[Products]

 -- select * from ##QuantityOfUnit

 select ContentType
       ,SUM(Unit) as Unit
 from #QuantityOfUnit
 group by ContentType
  
  
  END
GO
