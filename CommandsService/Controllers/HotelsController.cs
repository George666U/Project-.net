using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        public HotelsController()
        {
            
        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("--> Inbound  POST # Command Service");

            return Ok("Inbound test of from Hotels Controller");
        }
    }
}