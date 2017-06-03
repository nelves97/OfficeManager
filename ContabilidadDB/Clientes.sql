﻿CREATE TABLE [dbo].[Clientes]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [GUID] NCHAR(36) NOT NULL, 
    [Nombre] NVARCHAR(100) NOT NULL , 
    [Correo] NVARCHAR(100) NOT NULL  , 
    [Telefono] NVARCHAR(20) NOT NULL, 
    [Domicilio] NVARCHAR(256) NOT NULL, 
    [RFC] NVARCHAR(20) NOT NULL, 
    [CURP] NVARCHAR(20) NOT NULL, 
    [PasswordRFC] NVARCHAR(20) NOT NULL, 
    [PasswordFIEL] NVARCHAR(100) NOT NULL, 
    [Periodo] INT NOT NULL, 
    [FilesUri] NVARCHAR(256) NULL 
)
