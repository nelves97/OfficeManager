CREATE USER [ContabilidadUser]
	FROM LOGIN [ContabilidadLogin]
	WITH DEFAULT_SCHEMA = dbo

GO

GRANT CONNECT TO [ContabilidadUser]

GO

ALTER ROLE db_owner ADD MEMBER ContabilidadUser

GO