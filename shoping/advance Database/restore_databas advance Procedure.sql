USE [master]
GO

/****** Object:  StoredProcedure [dbo].[restore_database]    Script Date: 4/4/2021 9:57:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


  CREATE procedure [dbo].[restore_database](@file_name nvarchar(250))
  as 
  begin
ALTER DATABASE [advance] SET SINGLE_USER WITH ROLLBACK IMMEDIATE
BACKUP LOG [advance] TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup\advance_LogBackup_2021-04-04_21-49-27.bak' WITH NOFORMAT, NOINIT,  NAME = N'advance_LogBackup_2021-04-04_21-49-27', NOSKIP, NOREWIND, NOUNLOAD,  NORECOVERY ,  STATS = 5
RESTORE DATABASE [advance] FROM  DISK =@file_name WITH  FILE = 1,  NOUNLOAD,  STATS = 5
ALTER DATABASE [advance] SET MULTI_USER
  end
GO

