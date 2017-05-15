Create Procedure UspTipoContaExcluir

	@Id int
As
Begin
	Delete From 
		TipoConta
	Where
		Id = @Id

	Select @Id As Retorno
End