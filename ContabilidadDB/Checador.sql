CREATE TABLE [dbo].[Checador]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Dia] DATE NOT NULL, 
    [HoraEntrada] TIME NULL, 
    [HoraSalida] TIME NULL, 
    [IdEmpleado] INT NOT NULL, 
    CONSTRAINT [FK_idEmpleado] FOREIGN KEY ([IdEmpleado]) REFERENCES [Empleados]([IdEmpleado]),
)