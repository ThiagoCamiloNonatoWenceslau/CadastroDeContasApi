namespace EntidadesDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Conta")]
    public partial class Conta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conta()
        {
            ClientesContas = new HashSet<ClientesConta>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "N° da Conta")]
        public string Numero { get; set; }

        [Display(Name = "Código do Tipo da Conta")]
        public int IdTipoConta { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Nome da Conta")]
        public string Nome { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime DataDeCriacao { get; set; }

        [Display(Name = "Saldo")]
        public decimal Saldo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientesConta> ClientesContas { get; set; }

        public virtual TipoConta TipoConta { get; set; }
    }
}
