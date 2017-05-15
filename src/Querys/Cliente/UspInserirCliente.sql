Create Procedure UspClienteInserir
	@NomeCompleto varchar(100),
	@CPF varchar(15), 
	@DataNascimento datetime,
	@CNPJ varchar(20),
	@RazaoSocial varchar(100),
	@NomeFantasia varchar(100)
As
Begin
	Insert Into Cliente
(
	NomeCompleto,
	CPF,
	DataNascimento, 
	CNPJ, 
	RazaoSocial,
	NomeFantasia
)
	Values
	(
	@NomeCompleto,
	@CPF,
	@DataNascimento,
	@CNPJ,
	@RazaoSocial,
	@NomeFantasia
	)

	Select @@IDENTITY AS Retorno
End