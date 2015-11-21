SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.RelacionaCandidatoVestibular
	-- Parametros
	@IDVESTIBULAR int,
	@CPF varchar(50)
	
AS
BEGIN
	SET NOCOUNT ON;

    -- Comandos a partir daqui
	insert into dbo.VESTIBULAR_CANDIDATO (IDVESTIBULAR, CPF) VALUES (@IDVESTIBULAR, @CPF)
END
GO
