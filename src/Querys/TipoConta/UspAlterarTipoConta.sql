Create Procedure uspTipoContaAlterar
	@Id int,
	@Codigo varchar(20),
	@Nome varchar(50),
	@DataDeCriacao datetime,
	@Saldo decimal(18,2) 
	
As
Begin
	Update
		TipoConta
	Set
	Codigo = @Codigo,
	Nome = @Nome,
	DataDeCriacao = @DataDeCriacao,
	Saldo= @Saldo
	Where Id = @Id

	Select @Id AS Retorno
End