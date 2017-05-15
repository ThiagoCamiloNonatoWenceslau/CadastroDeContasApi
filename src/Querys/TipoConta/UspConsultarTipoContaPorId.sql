Create Procedure UspTipoContaConsultarPorId
	@Id Int
As 
Begin

	Select 
		Codigo,
		Nome,
		DataDeCriacao,
		Saldo
	From
		TipoConta
	Where @Id = Id

	Select @Id As Retorno
End