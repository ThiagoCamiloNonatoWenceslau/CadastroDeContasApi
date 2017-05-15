Create Procedure UspClienteConsultarPorId
	@Id int
As 
Begin

	Select 
		NomeCompleto,
		CPF,
		DataNascimento, 
		CNPJ, 
		RazaoSocial,
		NomeFantasia
	From
		Cliente
	Where @Id = Id

	Select @Id As Retorno
End