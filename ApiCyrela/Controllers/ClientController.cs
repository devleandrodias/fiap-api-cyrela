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
        public async Task Create([FromBody] Client client, [FromServices] ApplicationContext context)
        {
            context.Set<Client>().Add(client);

            await context.SaveChangesAsync();
        }

        [HttpPost("bulk")]
        public async Task CreateBulk([FromBody] List<Client> client, [FromServices] ApplicationContext context)
        {
            context.Set<Client>().AddRange(client);

            await context.SaveChangesAsync();
        }
    }
}
