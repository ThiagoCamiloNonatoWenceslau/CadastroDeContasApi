Create Procedure UspContaConsultarPorId
	@Id int
As 
Begin

	Select 
		Numero,
		IdTipoConta,
		Nome,
		DataDeCriacao
		Saldo
	From
		Conta
	Where @Id = Id

	Select @Id As Retorno
End