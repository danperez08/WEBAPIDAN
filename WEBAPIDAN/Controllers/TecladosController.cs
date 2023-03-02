using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPIDAN.Entidades;

namespace WEBAPIDAN.Controllers
{

    [ApiController]
    [Route("api/teclados")]
    public class TecladosController : ControllerBase
    {

        private readonly ApplicationDbContext dbContext;
        public TecladosController(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Teclado>>> Get()
        {
            return await dbContext.Teclados.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Teclado teclado)
        {
            dbContext.Add(teclado);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Teclado teclado, int id)
        {
            if(teclado.Id != id)
            {
                return BadRequest("El id del teclado no coincide con el establecido en la url");
            }
            dbContext.Update(teclado);
            await dbContext.SaveChangesAsync();
            return Ok();    
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Teclados.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound();
            }

            dbContext.Remove(new Teclado()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }

    }
}
