Create Procedure uspClienteAlterar
	@Id Int,
	@NomeCompleto varchar(100),
	@CPF varchar(15), 
	@DataNascimento datetime,
	@CNPJ varchar(20),
	@RazaoSocial varchar(100),
	@NomeFantasia varchar(100)
As
Begin
	Update
		Cliente
	Set
	NomeCompleto = @NomeCompleto,
	CPF = @CPF,
	DataNascimento = @DataNascimento, 
	CNPJ = @CNPJ, 
	RazaoSocial = @RazaoSocial,
	NomeFantasia = @NomeFantasia
	Where Id = @Id

	Select @Id AS Retorno
End