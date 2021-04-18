using System;
using ApiCyrela.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiCyrela.Controllers
{
    [ApiController]
    [Route("v1/cliente")]
    public class CyrelaController : ControllerBase
    {
        private readonly CyrelaService _service = new CyrelaService();

        public CyrelaController(CyrelaService service)
        {
            _service = service;
        }

        [HttpGet]
        public string HelloCyrela()
        {
            return this._service.HelloCyrela();
        }

        [HttpPost]
        public void CreateCliente()
        {
            // Logica cadastrar um clienete...
        }
    }
}
