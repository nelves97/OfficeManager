/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
INSERT INTO Administrador (NombreUsuario, Contrasena) Values('aguirre123', 'administrador123');

INSERT INTO Empleados (Nombre, FechaNacimiento, Correo, Telefono, HorasSemanales, Salario, FechaIngreso, Sexo, NombreUsuario, Contrasena)
VALUES('Persona', 11/11/11, 'correo_persona@hotmail.com', '12345', 12, 5, 12/12/12, 'Masculino', 'persona123', 'empleado123');
