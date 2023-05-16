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
        [HttpPost]
        public IActionResult Create(Pizza pizza)
        {
            PizzaService.Add(pizza);
            return CreatedAtAction(nameof(Get), new { id = pizza.Id }, pizza);
        }
        // PUT action
        [HttpPut("{id}")]
        public IActionResult Update(int id,Pizza pizza)
        {
            if (id != pizza.Id)
                return BadRequest();

            var ExistingPizza = PizzaService.Get(id);
            if (ExistingPizza == null)
                return BadRequest();

            PizzaService.Update(pizza);

            return NoContent();
        }
        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var pizza = PizzaService.Get(id);
            if (pizza == null)
                return NotFound();

            PizzaService.Delete(id);

            return NoContent();
        }
    }
}
