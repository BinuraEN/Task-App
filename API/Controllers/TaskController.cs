using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks(){
            var tasks = new string[] { "task 1", "tasl 2", "task 3" };
            return Ok(tasks);
        }

        [HttpPost]
        public IActionResult NewTask()
        {

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            var somethingwentwrong = true;
            if (somethingwentwrong) return BadRequest();
            return Ok();
        }


    }
}