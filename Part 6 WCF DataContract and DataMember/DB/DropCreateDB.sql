USE master;
GO

-- 1. Drop db if exist
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'Part6WCF')
BEGIN
    ALTER DATABASE Part6WCF SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE Part6WCF;
END
GO

-- 2. Create the database with specific MDF and LDF paths
CREATE DATABASE Part6WCF
ON PRIMARY (
    NAME = N'Part6WCF_Data',
    FILENAME = N'E:\Git\WCF_Exercises\Part 6 WCF DataContract and DataMember\DB\DB Files\Part6WCF.mdf', -- Specify your .mdf path here
    SIZE = 10MB,
    MAXSIZE = UNLIMITED,
    FILEGROWTH = 5MB
)
LOG ON (
    NAME = N'Part6WCF_Log',
    FILENAME = N'E:\Git\WCF_Exercises\Part 6 WCF DataContract and DataMember\DB\DB Files\Part6WCF_log.ldf', -- Specify your .ldf path here
    SIZE = 5MB,
    MAXSIZE = 2GB,
    FILEGROWTH = 5MB
);
GO