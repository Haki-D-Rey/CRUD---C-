USE [SCELLBD]
GO
/****** Object:  StoredProcedure [dbo].[prAgregarProducto]    Script Date: 23/09/2023 12:59:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER   PROCEDURE [dbo].[prAgregarProducto]
		@JsonProducto VARCHAR(MAX)
	AS
	BEGIN
		
		--DECLARE @JsonProducto VARCHAR(MAX) = '[{ "Descripcion": "Raqueta Tennis Jer" , "Cantidad": 3, "Precio": 150.00}]'

		--DELETE FROM dbo.Producto
		--UPDATE dbo.Producto
		--SET	Descripcion = 'Mouse Logitech 502g', Cantidad = 15, Precio  = 85.00
		--WHERE IdProducto = 2
		
		INSERT INTO dbo.Producto(Descripcion, Cantidad, Precio, EstadoActivo)
		SELECT *, 1
		FROM OPENJSON(@JsonProducto)
		WITH(
				Descripcion VARCHAR(256),
				Cantidad	INT,
				Precio      DECIMAL(18,2)
			)

		DECLARE @Id INT = SCOPE_IDENTITY();  

		IF(@Id IS NOT NULL)
		BEGIN 
				SELECT *
				FROM dbo.Producto
				WHERE IdProducto = @Id		
		END
		ELSE
		BEGIN
				SELECT *
				FROM dbo.Producto
				WHERE IdProducto = 0
		END
		
	END