USE master;
GO

-- 1. Drop db if exist
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'Part7WCF')
BEGIN
    ALTER DATABASE Part7WCF SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE Part7WCF;
END
GO

-- 2. Create the database with specific MDF and LDF paths
CREATE DATABASE Part7WCF
ON PRIMARY (
    NAME = N'Part7WCF_Data',
    FILENAME = N'E:\Git\WCF_Exercises\Part 7 KnownType attribute in WCF\DB\DB Files\Part7WCF.mdf', -- Specify your .mdf path here
    SIZE = 10MB,
    MAXSIZE = UNLIMITED,
    FILEGROWTH = 5MB
)
LOG ON (
    NAME = N'Part7WCF_Log',
    FILENAME = N'E:\Git\WCF_Exercises\Part 7 KnownType attribute in WCF\DB\DB Files\Part7WCF_log.ldf', -- Specify your .ldf path here
    SIZE = 5MB,
    MAXSIZE = 2GB,
    FILEGROWTH = 5MB
);
GO