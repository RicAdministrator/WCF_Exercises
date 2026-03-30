USE master;
GO

-- 1. Drop db if exist
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'Part8WCF')
BEGIN
    ALTER DATABASE Part8WCF SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE Part8WCF;
END
GO

-- 2. Create the database with specific MDF and LDF paths
CREATE DATABASE Part8WCF
ON PRIMARY (
    NAME = N'Part8WCF_Data',
    FILENAME = N'E:\Git\WCF_Exercises\Part 8 Different ways of associating known types in wcf\DB\DB Files\Part8WCF.mdf', -- Specify your .mdf path here
    SIZE = 10MB,
    MAXSIZE = UNLIMITED,
    FILEGROWTH = 5MB
)
LOG ON (
    NAME = N'Part8WCF_Log',
    FILENAME = N'E:\Git\WCF_Exercises\Part 8 Different ways of associating known types in wcf\DB\DB Files\Part8WCF_log.ldf', -- Specify your .ldf path here
    SIZE = 5MB,
    MAXSIZE = 2GB,
    FILEGROWTH = 5MB
);
GO