USE [DBTESTE]
GO

DECLARE @IDVESTIBULAR int
DECLARE @CPF varchar(50)

set @IDVESTIBULAR = 1
set @CPF = 122122122122
-- TODO: Defina valores de parāmetros aqui.

EXECUTE [dbo].[RelacionaCandidatoVestibular] @IDVESTIBULAR, @CPF
GO


