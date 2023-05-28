using Banorte3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banorte3.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("GetHome")]
        public IActionResult GetHome()
        {
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            HomeResponse response = new HomeResponse()
            {
                HomeElements = intList
            };
            return new ObjectResult(response);
        }
    }
}
