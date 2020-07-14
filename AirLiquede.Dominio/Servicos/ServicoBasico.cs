using AirLiquede.Dominio.Entidades;
using AirLiquede.Dominio.Interfaces.Repositorio;
using AirLiquede.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;

namespace AirLiquede.Dominio.Servicos
{
    public class ServicoBasico<TEntidade> : IServicoBasico<TEntidade> where TEntidade : EntidadeBasica
    {
        protected readonly IRepositorioBasico<TEntidade> repositorio;
        public ServicoBasico(IRepositorioBasico<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }

        public bool Alterar(TEntidade entidade)
        {
           return this.repositorio.Alterar(entidade);
        }

        public bool Deletar(Guid id)
        {
            return this.repositorio.Deletar(id);
        }

        public Guid Incluir(TEntidade entidade)
        {
            return this.repositorio.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(Guid id)
        {
            return this.repositorio.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return this.repositorio.SelecionarTodos();
        }
    }
}
