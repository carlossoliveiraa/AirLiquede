using System;
using AirLiquede.Dominio.Entidades;
using AirLiquide.Aplicacao.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirLiquede.Servico.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]  
    public class BaseController<TEntidade> : Controller where TEntidade : EntidadeBasica        
    {
        public BaseController(IAppBasico<TEntidade> app)
        {
            this.App = app ?? throw new ArgumentNullException(nameof(app));
        }

        protected IAppBasico<TEntidade> App { get; private set; }

        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                var obj = this.App.SelecionarTodos();
                return new OkObjectResult(obj);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(Guid id)
        {
            try
            {
                var obj = this.App.SelecionarPorId(id);
                return new OkObjectResult(obj);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir([FromBody]TEntidade entidade)
        {
            try
            {
                return new OkObjectResult(this.App.Incluir(entidade));
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Alterar([FromBody] TEntidade entidade)
        {
            try
            {
                this.App.Alterar(entidade);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(Guid id)
        {
            try
            {
                this.App.Deletar(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return this.BadRequest(ex.Message);
            }
        }
    }
}
