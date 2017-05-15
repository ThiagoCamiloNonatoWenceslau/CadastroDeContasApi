namespace EntidadesDAL
{
    using System.ComponentModel.DataAnnotations;

    public partial class ClientesConta
    {
        public int Id { get; set; }

        [Display(Name = "Código do Cliente")]
        public int IdCliente { get; set; }

        [Display(Name = "Código da Conta")]
        public int IdConta { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual Conta Conta { get; set; }
    }
}
