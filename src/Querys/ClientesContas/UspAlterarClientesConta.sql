Create Procedure uspClientesContasAlterar
	@Id Int,
	@IdCliente Int,
	@IdConta Int
As
Begin
	Update
		ClientesContas
	Set
	IdCliente = @IdCliente,
	IdConta = @IdConta
	Where Id = @Id

	Select @Id AS Retorno
End