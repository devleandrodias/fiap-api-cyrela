using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiCyrela.Data;
using ApiCyrela.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCyrela.Controllers
{
    [Route("v1/client"), ApiController]
    public class ClientController : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<Client>>> GetAll([FromServices] ApplicationContext context)
        {
            return await context.Clients.AsNoTracking().ToListAsync();
        }

        [HttpPost]
        public async Task Create([FromServices] ApplicationContext context)
        {

            Client client = new()
            {
                Id = Guid.NewGuid(),
                Name = "Leandro",
                Salary = 5200,
                Job = "PL Desenvolvedor Fullstack",
                BirthDate = new DateTime(),
            };

            context.Set<Client>().Add(client);

            await context.SaveChangesAsync();
        }
    }
}
