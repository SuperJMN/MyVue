using Microsoft.AspNetCore.Mvc;

namespace MyVue.Controllers
{
    [Route("api/[controller]")]
    public class EjemploController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult People()
        {
            return Ok(new[]
            {
                new {FirstName = "Perico", LastName = "De los Palotes"},
                new {FirstName = "Johnny", LastName = "Bravo"}
            });
        }
    }
}
