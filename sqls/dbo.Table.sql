CREATE TABLE [dbo].[alimentos] (
    [id_alimento]  INT           IDENTITY (1, 1) NOT NULL,
    [descripcion]  VARCHAR (255) NULL,
    [tipo_unidad]  VARCHAR (255) NULL,
	[categoria]  VARCHAR (255) NULL,
    [cantidad]     FLOAT (53)    NULL,
    [costo_unidad] FLOAT (53)    NULL,
    [costo_total]  FLOAT (53)    NULL,
    PRIMARY KEY CLUSTERED ([id_alimento] ASC)
);
