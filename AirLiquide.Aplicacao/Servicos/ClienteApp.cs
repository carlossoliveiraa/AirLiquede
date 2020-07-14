using AirLiquede.Dominio.Entidades;
using AirLiquede.Dominio.Interfaces.Servico;
using AirLiquide.Aplicacao.Interfaces;

namespace AirLiquide.Aplicacao.Servicos
{
    public class ClienteApp : ServicoAppBasico<Cliente>, IClienteApp
    {
        public ClienteApp(IClienteServico servico) : base(servico)
        {
        }
    }
}

