using AirLiquede.Dominio.Entidades;
using AirLiquede.Dominio.Interfaces.Repositorio;
using AirLiquede.Infra.Dados.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirLiquede.Infra.Dados.Repositorio
{
    
    public class ClienteRepositorio : RepositorioBasico<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(ContextoEFClientes contexto) : base(contexto)
        {
        }
    }
}
