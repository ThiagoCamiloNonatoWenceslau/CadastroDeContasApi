namespace EntidadesDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TipoConta")]
    public partial class TipoConta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoConta()
        {
            Contas = new HashSet<Conta>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Código")]
        public string Codigo { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nome do Tipo da Conta")]
        public string Nome { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime DataDeCriacao { get; set; }

        [Display(Name = "Saldo")]
        public decimal Saldo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conta> Contas { get; set; }
    }
}
