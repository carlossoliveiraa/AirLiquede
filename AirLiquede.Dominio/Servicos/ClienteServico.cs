using AirLiquede.Dominio.Entidades;
using AirLiquede.Dominio.Interfaces.Repositorio;
using AirLiquede.Dominio.Interfaces.Servico;

namespace AirLiquede.Dominio.Servicos
{
    public class ClienteServico : ServicoBasico<Cliente>, IClienteServico
    {
        public ClienteServico(IClienteRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
