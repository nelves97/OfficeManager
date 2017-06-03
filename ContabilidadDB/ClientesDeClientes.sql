CREATE TABLE [dbo].[ClientesDeClientes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Nombre] NVARCHAR(100) NOT NULL, 
    [Correo] NVARCHAR(100) NOT NULL, 
    [Telefono] NVARCHAR(20) NOT NULL, 
    [RFC] NVARCHAR(20) NOT NULL, 
    [IdCliente] INT NOT NULL, 
    CONSTRAINT [FK_ClientesDeClientes_Clientes] FOREIGN KEY ([IdCliente]) REFERENCES [Clientes]([Id]) ON DELETE CASCADE ON UPDATE CASCADE
)
