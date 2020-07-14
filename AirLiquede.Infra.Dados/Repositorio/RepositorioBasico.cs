using AirLiquede.Dominio.Entidades;
using AirLiquede.Dominio.Interfaces.Repositorio;
using AirLiquede.Infra.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirLiquede.Infra.Dados.Repositorio
{
    public class RepositorioBasico<TEntidade> : IRepositorioBasico<TEntidade> where TEntidade : EntidadeBasica
    {
        protected readonly ContextoEFClientes contexto;
        public RepositorioBasico(ContextoEFClientes contexto): base()
        {
            this.contexto = contexto;
        }
        public bool Alterar(TEntidade entidade)
        {
            try
            {
                this.contexto.InitTransacao();
                this.contexto.Set<TEntidade>().Attach(entidade);
                this.contexto.Entry(entidade).State = EntityState.Modified;
                this.contexto.SendChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }         
        public bool Deletar(Guid id)
        {
            try
            {
                var entidade = this.SelecionarPorId(id);
                if (entidade != null)
                {
                    this.contexto.InitTransacao();
                    this.contexto.Set<TEntidade>().Remove(entidade);
                    this.contexto.SendChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
        public Guid Incluir(TEntidade entidade)
        {
            this.contexto.InitTransacao();
            var id = this.contexto.Set<TEntidade>().Add(entidade).Entity.Id;
            this.contexto.SendChanges();
            return id;
        }
        public TEntidade SelecionarPorId(Guid id)
        {
            return this.contexto.Set<TEntidade>().Find(id);
        }
        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return this.contexto.Set<TEntidade>().ToList();
        }
    }
}
