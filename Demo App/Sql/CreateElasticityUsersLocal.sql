USE [master]
GO

CREATE LOGIN [Superman] WITH PASSWORD=N'Blank123', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO

ALTER SERVER ROLE [sysadmin] ADD MEMBER [Superman]
GO

CREATE LOGIN [Batman] WITH PASSWORD=N'Blank123', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO

