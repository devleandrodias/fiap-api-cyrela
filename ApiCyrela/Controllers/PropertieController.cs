
using System.Collections.Generic;
using System.Threading.Tasks;
using ApiCyrela.Data;
using ApiCyrela.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiCyrela.Controllers
{
    [ApiController, Route("v1/propertie")]
    public class PropertieController
    {
        [HttpGet]
        public async Task<ActionResult<List<Propertie>>> GetAll([FromServices] ApplicationContext context)
        {
            return await context.Properties.AsNoTracking().ToListAsync();
        }

        [HttpPost]
        public async Task Create([FromBody] Propertie propertie, [FromServices] ApplicationContext context)
        {
            context.Set<Propertie>().Add(propertie);

            await context.SaveChangesAsync();
        }
    }
}
