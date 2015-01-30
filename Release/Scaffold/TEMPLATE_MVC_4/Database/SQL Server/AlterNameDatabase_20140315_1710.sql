/* VERIFICA SE A BASE DE DADOS EXISTE E ALTERA O NOME DA BASE DE DADOS */
IF(DB_ID('Teste') IS NOT NULL)
	/* USE DATABASE */
	USE master
	GO
	ALTER DATABASE	Teste SET SINGLE_USER
	GO
	ALTER DATABASE	Teste MODIFY NAME = IoC_FW
	GO
	ALTER DATABASE	IoC_FW SET MULTI_USER
	GO
GO