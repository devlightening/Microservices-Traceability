CREATE DATABASE ConsoleAppTraceabilityDb
GO
USE ConsoleAppTraceabilityDb
GO 
CREATE TABLE [dbo].[ConsoleAppTraceabilityLogs]
(
  [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [EventDateTime] DATETIME NOT NULL,
    [EventLevel] NVARCHAR(100) NOT NULL,
    [CorrelationId] UNIQUEIDENTIFIER NOT NULL,
    [MachineName] NVARCHAR(100) NOT NULL,
    [EventMessage] NVARCHAR(MAX) NOT NULL,
    [ErrorSource] NVARCHAR(100) NULL,
    [ErrorClass] NVARCHAR(500) NULL,
    [ErrorMethod] NVARCHAR(100) NULL,
    [ErrorMessage] NVARCHAR(MAX) NULL,
    [InnerErrorMessage] NVARCHAR(MAX) NULL
)