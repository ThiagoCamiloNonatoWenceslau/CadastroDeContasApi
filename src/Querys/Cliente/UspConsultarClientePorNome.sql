Create Procedure UspClienteConsultarPorNome
	@NomeCompleto varchar(100)
As 
Begin

	Select 
		Id,
		CPF,
		DataNascimento, 
		CNPJ, 
		RazaoSocial,
		NomeFantasia
	From
		Cliente
	Where NomeCompleto Like '%' + @NomeCompleto + '%'

	Select @NomeCompleto As Retorno
End