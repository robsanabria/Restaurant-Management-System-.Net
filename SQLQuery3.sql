CREATE TABLE [dbo].[Telefonos] (
    [id_telefono] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [descripcion] CHAR(50) NOT NULL,
    [numero_telefono] INT NULL
);