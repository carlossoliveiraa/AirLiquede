using AirLiquede.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace AirLiquede.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioBasico<TEntidade> where TEntidade : EntidadeBasica
    {
        Guid Incluir(TEntidade entidade);
        bool Alterar(TEntidade entidade);
        bool Deletar(Guid id);       
        TEntidade SelecionarPorId(Guid id);
        IEnumerable<TEntidade> SelecionarTodos();
    }
}
