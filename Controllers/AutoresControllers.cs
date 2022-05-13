using Microsoft.AspNetCore.Mvc;
using Web_Api_.NET.Controllers.Entidades;

namespace Web_Api_.NET.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresControllers: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get() 
        {
            return new List<Autor>()
            {
                new Autor() { Id = 1, Nombre = "Diana"},
                new Autor() { Id = 2, Nombre ="Noemi"}
            };
        }
    }
}
