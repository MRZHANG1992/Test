USE [newsellinggas]
GO
/****** Object:  UserDefinedFunction [dbo].[ints]    Script Date: 11/29/2014 22:12:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ints]
( @start bigint,
  @end bigint,
  @step int )
RETURNS @tb TABLE
( [value] bigint )
AS
BEGIN
WHILE @start <=@end
BEGIN
insert into @tb VALUES(@start)
set @start = @start + @step
END
RETURN
END