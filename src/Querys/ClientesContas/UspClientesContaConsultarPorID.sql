Create Procedure UspClientesContasConsultarPorId
	@Id int
As 
Begin

	Select 
		IdCliente,
		IdConta
	From
		ClientesContas
	Where @Id = Id

	Select @Id As Retorno
End