Create Procedure UspContaInserir

	@Numero varchar(20),
	@IdTipoConta int,
	@Nome varchar(30), 
	@DataDeCriacao datetime,
	@Saldo decimal(18,2)
	
As
Begin
	Insert Into Conta
(
	Numero,
	IdTipoConta,
	Nome, 
	DataDeCriacao,
	Saldo
)
	Values
	(
	@Numero,
	@IdTipoConta,
	@Nome,
	@DataDeCriacao,
	@Saldo
	)

	Select @@IDENTITY AS Retorno
End