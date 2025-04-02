using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        public List<string> fruits = new List<string>() { "apple", "banana", "orange", "pineapple", "grapes", "watermelon", "pear", "kivi" };

        [HttpGet]
        public List<string> gerFruits()
        {
            return fruits;
        }

        [HttpGet("{id}")]
        public string gerFruitsById(int id)
        {
            return fruits.ElementAt(id);
        }


    }
}
