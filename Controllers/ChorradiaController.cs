using Microsoft.AspNetCore.Mvc;

namespace MyVue.Controllers
{
    [Route("api/[controller]")]
    public class ChorradiaController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult People()
        {
            return Ok(new[]
            {
                new {FirstName = "José Manuel", LastName = "Nieto"},
                new {FirstName = "Ana Isabel", LastName = "Meana"}
            });
        }
    }
}
