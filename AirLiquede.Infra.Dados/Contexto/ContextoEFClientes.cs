using AirLiquede.Dominio.Entidades;
using AirLiquede.Infra.Dados.Mapeamento;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Linq;

namespace AirLiquede.Infra.Dados.Contexto
{
    public  class ContextoEFClientes : DbContext
    {
        public ContextoEFClientes(DbContextOptions<ContextoEFClientes> options) : base(options)
        { 
        }

        public IDbContextTransaction Transaction { get; private set; }
        public virtual DbSet<Cliente> Clientes { get; set; }   

        public IDbContextTransaction InitTransacao()
        {
            if (this.Transaction == null)
            {
                this.Transaction = this.Database.BeginTransaction();
            }
            return this.Transaction;
        }

        public void SendChanges()
        {
            this.Salvar();
            this.Commit();
        }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClienteMap());    
        }

        private void RollBack()
        {
            if (this.Transaction != null)
            {
                this.Transaction.Rollback();
            }
        }

        private void Salvar()
        {
            try
            {
                this.ChangeTracker.DetectChanges();
                this.SaveChanges();
            }
            catch (Exception ex)
            {
                this.RollBack();
                throw new Exception(ex.Message);
            }
        }

        private void Commit()
        {
            if (this.Transaction != null)
            {
                this.Transaction.Commit();
                this.Transaction.Dispose();
                this.Transaction = null;
            }
        }
    }
}
