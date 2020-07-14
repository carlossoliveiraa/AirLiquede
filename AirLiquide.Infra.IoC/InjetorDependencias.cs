using AirLiquede.Dominio.Interfaces.Repositorio;
using AirLiquede.Dominio.Interfaces.Servico;
using AirLiquede.Dominio.Servicos;
using AirLiquede.Infra.Dados.Repositorio;
using AirLiquide.Aplicacao.Interfaces;
using AirLiquide.Aplicacao.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirLiquide.Infra.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            // Aplicação
            svcCollection.AddTransient(typeof(IAppBasico<>), typeof(ServicoAppBasico<>));
            svcCollection.AddTransient<IClienteApp, ClienteApp>();
            // Domínio
            svcCollection.AddTransient(typeof(IServicoBasico<>), typeof(ServicoBasico<>));
            svcCollection.AddTransient<IClienteServico, ClienteServico>();
            // Repositorio
            svcCollection.AddScoped(typeof(IRepositorioBasico<>), typeof(RepositorioBasico<>));
            svcCollection.AddScoped<IClienteRepositorio, ClienteRepositorio>();
        }
    }
}
