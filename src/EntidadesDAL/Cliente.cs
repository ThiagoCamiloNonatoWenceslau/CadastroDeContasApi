namespace EntidadesDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Cliente")]
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            ClientesContas = new HashSet<ClientesConta>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Razão Social")]
        public string RazaoSocial { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientesConta> ClientesContas { get; set; }
    }
}
