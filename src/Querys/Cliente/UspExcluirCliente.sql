Create Procedure UspClienteExcluir

	@Id int
As
Begin
	Delete From 
		Cliente
	Where
		Id = @Id

	Select @Id As Retorno
End