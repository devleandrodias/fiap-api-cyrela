
using ApiCyrela.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiCyrela.Controllers
{
    [ApiController, Route("v1/propertie")]
    public class PropertieController
    {
        private readonly PropertieService _service = new();

        public PropertieController(PropertieService service)
        {
            _service = service;
        }

        [HttpGet]
        public void GetAll()
        {
            _service.GetAll();
        }

        [HttpPost]
        public void Create()
        {
            _service.Create();
        }
    }
}
