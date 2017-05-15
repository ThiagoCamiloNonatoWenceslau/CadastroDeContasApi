Create Procedure UspTipoContaConsultarPorCodigoEspecial
	@Codigo varchar(20)
As 
Begin

	Select 
		Id,
		Nome,
		DataDeCriacao,
		Saldo
	From
		TipoConta
	Where @Codigo = Codigo

	Select @Codigo As Retorno
End