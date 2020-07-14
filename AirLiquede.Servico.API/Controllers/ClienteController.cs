using AirLiquede.Dominio.Entidades;
using AirLiquide.Aplicacao.Interfaces;

namespace AirLiquede.Servico.API.Controllers
{

    public class ClienteController : BaseController<Cliente>
    {
        public ClienteController(IClienteApp app) : base(app)
        {

        }
    }
}