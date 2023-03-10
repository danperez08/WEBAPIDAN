using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPIDAN.Entidades;

namespace WEBAPIDAN.Controllers
{
    public class MarcaController
    {
        [ApiController]
        [Route("api/marca")]
        public class MarcasController : ControllerBase
        {

            private readonly ApplicationDbContext dbContext;
            public MarcasController(ApplicationDbContext context)
            {
                this.dbContext = context;
            }

            [HttpGet("Lista")]
            public async Task<ActionResult<List<Marca>>> Get()
            {
                return await dbContext.Marcas.ToListAsync();
            }

            [HttpGet("{id:int}")]
            public async Task<ActionResult<Marca>> GetById(int id)
            {
                return await dbContext.Marcas.FirstOrDefaultAsync(x => x.Id == id);
            }


            [HttpPost]
            public async Task<ActionResult> Post(Marca marca)
            {
                dbContext.Add(marca);
                await dbContext.SaveChangesAsync();
                return Ok();
            }

            [HttpPut("{id:int}")]
            public async Task<ActionResult> Put(Marca marca, int id)
            {
                if (marca.Id != id)
                {
                    return BadRequest("El id del marca no coincide con el establecido en la url");
                }
                dbContext.Update(marca);
                await dbContext.SaveChangesAsync();
                return Ok();
            }

            [HttpDelete("{id:int}")]
            public async Task<ActionResult> Delete(int id)
            {
                var exist = await dbContext.Marcas.AnyAsync(x => x.Id == id);
                if (!exist)
                {
                    return NotFound();
                }

                dbContext.Remove(new Marca()
                {
                    Id = id
                });
                await dbContext.SaveChangesAsync();
                return Ok();
            }
        }
    }
}
