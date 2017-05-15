Create Procedure UspClientesContasExcluir

	@Id int
As
Begin
	Delete From 
		ClientesContas
	Where
		Id = @Id

	Select @Id As Retorno
End