Create Procedure UspClientesContasInserir
	@IdCliente int,
	@IdConta int
As
Begin
	Insert Into ClientesContas
(
	IdCliente,
	IdConta
)
	Values
	(
	@IdCliente,
	@IdConta
	)

	Select @@IDENTITY AS Retorno
End