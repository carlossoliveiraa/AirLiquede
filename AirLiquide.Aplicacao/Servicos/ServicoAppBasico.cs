using AirLiquede.Dominio.Entidades;
using AirLiquede.Dominio.Interfaces.Servico;
using AirLiquide.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;

namespace AirLiquide.Aplicacao.Servicos
{
    public class ServicoAppBasico<TEntidade> : IAppBasico<TEntidade> where TEntidade : EntidadeBasica
    {

        protected readonly IServicoBasico<TEntidade> servico;

        public ServicoAppBasico(IServicoBasico<TEntidade> servico) : base()
        {
            this.servico = servico;
        }

        public bool Alterar(TEntidade entidade)
        {
            return this.servico.Alterar(entidade);
        }
  
        public bool Deletar(Guid id)
        {
            return this.servico.Deletar(id);
        }

        public Guid Incluir(TEntidade entidade)
        {
            return this.servico.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(Guid id)
        {
            return this.servico.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return this.servico.SelecionarTodos();
        }
    }
}
