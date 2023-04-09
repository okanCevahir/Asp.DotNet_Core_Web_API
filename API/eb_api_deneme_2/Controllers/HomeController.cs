using eb_api_deneme_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace eb_api_deneme_2.Controllers
{
    [ApiController]
    [Route("Home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            var resut=  new ResponseModel() { HttpStatus=200, Message="Hello"};
            return Ok(resut);
        }
    }
}
