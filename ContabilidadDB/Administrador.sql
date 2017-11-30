CREATE TABLE [dbo].[Administrador]
(
	[IdAdministrador] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NombreUsuario] NVARCHAR(20) NOT NULL, 
    [Contrasena] NVARCHAR(20) NOT NULL
)
