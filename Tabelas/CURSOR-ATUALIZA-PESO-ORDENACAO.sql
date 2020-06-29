	SELECT
			 Marca 
			,COUNT(*) AS Quantidade 
			,ROW_NUMBER() OVER(PARTITION BY Marca ORDER BY Marca) AS ROW_NUMBER1
			,RANK() OVER(ORDER BY Veiculo.Marca) AS RANK1
			,DENSE_RANK() OVER(ORDER BY Marca) AS DENSE_RANK1
			,RANK() OVER (PARTITION BY Marca ORDER BY Marca) AS RANK2		
	FROM Veiculo 
			GROUP BY Marca 
	ORDER BY Quantidade DESC, Marca


DECLARE 
		  @Marca VARCHAR(200)
		 ,@Quantidade INT
		 ,@PesoOrdenacao INT
		 ,@MarcaTemporaria VARCHAR(200) = ''
		 ,@Contador INT = 0

DECLARE CursorData CURSOR FOR
				
	SELECT
			 Marca 
			,COUNT(*) AS Quantidade
	FROM Veiculo 
			GROUP BY Marca 
	ORDER BY Quantidade DESC, Marca

OPEN CursorData

FETCH NEXT FROM CursorData INTO @Marca, @Quantidade

		WHILE @@FETCH_STATUS = 0

			BEGIN
				
				IF (@MarcaTemporaria <> @Marca) 
				
				BEGIN
					SET @Contador = @Contador + 1
					SET @MarcaTemporaria = @Marca
				END
				
				IF (@MarcaTemporaria = @Marca)
					
					BEGIN
							SET @PesoOrdenacao = @Contador
					END

				UPDATE Veiculo SET PesoOrdenacao = @PesoOrdenacao
				WHERE Marca = @Marca

FETCH NEXT FROM CursorData INTO @Marca, @Quantidade

		END

CLOSE CursorData

DEALLOCATE CursorData

GO