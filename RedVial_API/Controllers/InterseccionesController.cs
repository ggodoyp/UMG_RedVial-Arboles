using Microsoft.AspNetCore.Mvc;
using RedVial_API.Data;
using Microsoft.EntityFrameworkCore;
using RedVial_API.Models;

namespace RedVial_API.Controllers
{
    [ApiController]
    [Route("api/Intersecciones")]
    public class InterseccionesController : ControllerBase
    {
        private readonly AppDbContext? _context;
        public InterseccionesController(AppDbContext context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<ActionResult<List<Interseccion>>> GetIntersecciones()
            {
                return await _context.Intersecciones.ToListAsync();
            }

            [HttpGet("congestionadas")]
            public async Task<ActionResult<List<Interseccion>>> GetInterseccionesCongestionadas()
            {
                List<Interseccion> congestionadas = await _context.Intersecciones.OrderByDescending(i => i.CantidadVehiculosEspera).ToListAsync();
                return congestionadas;
            }
      
    }
}
