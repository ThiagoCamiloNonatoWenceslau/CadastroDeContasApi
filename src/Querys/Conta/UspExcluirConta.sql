Create Procedure UspContaExcluir

	@Id int
As
Begin
	Delete From 
		Conta
	Where
		Id = @Id

	Select @Id As Retorno
End