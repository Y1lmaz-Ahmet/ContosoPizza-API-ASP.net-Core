using ContosoPizza_API_ASP.net_Core.Models;
using ContosoPizza_API_ASP.net_Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza_API_ASP.net_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        public PizzaController() { }

        // GET all action
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = PizzaService.Get(id);
            if(pizza == null)
                return NotFound();
            return pizza;
        }

        // POST action

        // PUT action

        // DELETE action
    }
}
