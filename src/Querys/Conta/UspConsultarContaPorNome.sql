Create Procedure UspContaConsultarPorNome
	@Nome varchar(30)
As 
Begin

	Select 
		Id,
		IdTipoConta,
		Nome,
		DataDeCriacao
		Saldo
	From
		Conta
	Where @Nome = Nome

	Select @Nome As Retorno
End