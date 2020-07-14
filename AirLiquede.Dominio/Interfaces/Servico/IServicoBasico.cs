using AirLiquede.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirLiquede.Dominio.Interfaces.Servico
{
    public interface IServicoBasico<TEntidade> where TEntidade : EntidadeBasica
    {
        Guid Incluir(TEntidade entidade);
        bool Alterar(TEntidade entidade);
        bool Deletar(Guid id);
        TEntidade SelecionarPorId(Guid id);
        IEnumerable<TEntidade> SelecionarTodos();
    }
}
