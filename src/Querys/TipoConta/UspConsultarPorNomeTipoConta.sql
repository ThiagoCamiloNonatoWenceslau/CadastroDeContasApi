Create Procedure UspTipoContaConsultarPorNome
	@Nome varchar(50)
As 
Begin

	Select 
		Id,
		Codigo,
		DataDeCriacao,
		Saldo
	From
		TipoConta
	Where @Nome = Nome

	Select @Nome As Retorno
End