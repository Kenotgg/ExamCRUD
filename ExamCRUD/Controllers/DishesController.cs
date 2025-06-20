using ExamCRUD.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExamCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DishesController : Controller
    {
       private readonly IDishService _idishService;
        public DishesController(IDishService idishService)
        {
            _idishService = idishService;
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAll() 
        {
            var result = await _idishService.GetAll();
            return Ok(result);
        }

        [HttpGet("new")]
        public async Task<IActionResult> Create(string name,string description, int KCAL)
        {
            var result = await _idishService.Create(name,description,KCAL);
            return Ok(result);
        }

        


    }
}
