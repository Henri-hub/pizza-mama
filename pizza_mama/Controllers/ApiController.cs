using Microsoft.AspNetCore.Mvc;
using pizza_mama.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller //ControllerBase
    {
        DataContext dataContext;
        public ApiController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        
        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            // Récuperer les pizzas au format json depuis la base de données
            var pizzas = dataContext.Pizzas.ToList();

            return Json(pizzas);
        }
        
    }
}
