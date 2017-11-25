CREATE TABLE [dbo].[Empleados]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] NVARCHAR(100) NOT NULL, 
    [Fecha de nacimiento] DATE NOT NULL, 
    [Correo] NVARCHAR(50) NOT NULL, 
    [Telefono] NVARCHAR(20) NOT NULL, 
	[Horas semanales] INT NOT NULL,
    [Salario] FLOAT NOT NULL, 
    [Fecha de ingreso] DATE NOT NULL
)
