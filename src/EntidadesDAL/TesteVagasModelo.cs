namespace EntidadesDAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TesteVagasModelo : DbContext
    {
        public TesteVagasModelo()
            : base("name=TesteVagasModelo")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<ClientesConta> ClientesContas { get; set; }
        public virtual DbSet<Conta> Contas { get; set; }
        public virtual DbSet<TipoConta> TipoContas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.NomeCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.CPF)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.CNPJ)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.RazaoSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.NomeFantasia)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.ClientesContas)
                .WithRequired(e => e.Cliente)
                .HasForeignKey(e => e.IdCliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Conta>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Conta>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Conta>()
                .HasMany(e => e.ClientesContas)
                .WithRequired(e => e.Conta)
                .HasForeignKey(e => e.IdConta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoConta>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoConta>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<TipoConta>()
                .HasMany(e => e.Contas)
                .WithRequired(e => e.TipoConta)
                .HasForeignKey(e => e.IdTipoConta)
                .WillCascadeOnDelete(false);
        }
    }
}
