using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers
{
    public class TimedisplayyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult index()
        {
            return View();
            
        }
    }
}