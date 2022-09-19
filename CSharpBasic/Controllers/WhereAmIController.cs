using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharpBasic.Controllers
{
    public class WhereAmIController : Controller
    {
        // GET
        public JsonResult Index()
        {
            var data = new {color="black"};
            return new JsonResult(data);
        }

        public JsonResult Info()
        {
            var data = new {name="Bear"};
            return new JsonResult(data);
        }
    }
}