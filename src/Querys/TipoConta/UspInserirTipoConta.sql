Create Procedure UspTipoContaInserir

	@Codigo varchar(20),
	@Nome varchar(50), 
	@DataDeCriacao datetime,
	@Saldo decimal(18,2)
	
As
Begin
	Insert Into TipoConta
(
	Codigo,
	Nome, 
	DataDeCriacao,
	Saldo
)
	Values
	(
	@Codigo,
	@Nome,
	@DataDeCriacao,
	@Saldo
	)

	Select @@IDENTITY AS Retorno
End