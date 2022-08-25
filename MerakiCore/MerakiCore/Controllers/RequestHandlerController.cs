using LinqToDB;
using MerakiCore.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MerakiCore.Controllers
{
    [ApiController]
    public class RequestHandlerController : Controller
    {
        [HttpGet]
        [Route("/index")]
        public async Task<ActionResult> Index()
        {
           using(var conn = new DBConnection())
            {
                var data = await conn.Users.ToListAsync();
            }
            return View();
        }
    }
}
