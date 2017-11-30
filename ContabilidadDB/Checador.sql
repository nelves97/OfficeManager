CREATE TABLE [dbo].[Checador]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Dia] DATETIME NOT NULL, 
    [HoraEntrada] DATETIME NULL, 
    [HoaSalida] DATETIME NULL, 
    [IdEmpleado] INT NOT NULL, 
    CONSTRAINT [FK_idEmpleado] FOREIGN KEY ([IdEmpleado]) REFERENCES [Empleados]([IdEmpleado]),
)
