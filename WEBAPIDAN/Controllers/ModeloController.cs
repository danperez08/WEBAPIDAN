using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPIDAN.Entidades;

namespace WEBAPIDAN.Controllers
{
    public class ModeloController
    {

        [ApiController]
        [Route("api/modelo")]
        public class ModelosController : ControllerBase
        {

            private readonly ApplicationDbContext dbContext;
            public ModelosController(ApplicationDbContext context)
            {
                this.dbContext = context;
            }

            [HttpGet("Lista")]
            public async Task<ActionResult<List<Modelo>>> Get()
            {
                return await dbContext.Modelos.ToListAsync();
            }

            [HttpGet("{id:int}")]
            public async Task<ActionResult<Modelo>> GetById(int id)
            {
                return await dbContext.Modelos.FirstOrDefaultAsync(x => x.Id == id);
            }

            [HttpPost]
            public async Task<ActionResult> Post(Modelo modelo)
            {
                dbContext.Add(modelo);
                await dbContext.SaveChangesAsync();
                return Ok();
            }

            [HttpPut("{id:int}")]
            public async Task<ActionResult> Put(Modelo modelo, int id)
            {
                if (modelo.Id != id)
                {
                    return BadRequest("El id del modelo no coincide con el establecido en la url");
                }
                dbContext.Update(modelo);
                await dbContext.SaveChangesAsync();
                return Ok();
            }

            [HttpDelete("{id:int}")]
            public async Task<ActionResult> Delete(int id)
            {
                var exist = await dbContext.Modelos.AnyAsync(x => x.Id == id);
                if (!exist)
                {
                    return NotFound();
                }

                dbContext.Remove(new Modelo()
                {
                    Id = id
                });
                await dbContext.SaveChangesAsync();
                return Ok();

            }
        }
    }
}