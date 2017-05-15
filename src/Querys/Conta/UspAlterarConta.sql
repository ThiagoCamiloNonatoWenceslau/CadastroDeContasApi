Create Procedure uspContaAlterar
	@Id Int,
	@Nummero varchar(20),
	@IdTipoConta int,
	@Nome varchar(30),
	@DataDeCriacao datetime,
	@Saldo decimal(18,2) 
	
As
Begin
	Update
		Conta
	Set
	Numero = @Nummero,
	IdTipoConta = @IdTipoConta,
	Nome = @Nome,
	DataDeCriacao = @DataDeCriacao,
	Saldo= @Saldo
	Where Id = @Id

	Select @Id AS Retorno
End