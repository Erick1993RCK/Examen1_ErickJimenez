CREATE PROCEDURE [dbo].[ListarParametros]
 @Id_Parametro INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
			Id_Parametro
		,   Codigo
		,   Descripcion

		FROM Parametro

		WHERE
	     (@Id_Parametro IS NULL OR Id_Parametro=@Id_Parametro)
END