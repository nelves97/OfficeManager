CREATE TABLE [dbo].[Empleados]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] NVARCHAR(100) NOT NULL, 
    [FechaNacimiento] DATETIME NOT NULL, 
    [Correo] NVARCHAR(50) NOT NULL, 
    [Telefono] NVARCHAR(20) NOT NULL, 
	[HorasSemanales] INT NOT NULL,
    [Salario] INT NOT NULL, 
    [FechaIngreso] DATETIME NOT NULL
)
