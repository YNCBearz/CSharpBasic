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

        [HttpGet]
        public JsonResult Info()
        {
            var data = new {name="Bear"};
            return new JsonResult(data);
        }

        //TODO: how to get data when Content-Type: application/json 
        [HttpPost, ActionName("Info")]
        public JsonResult InfoPost()
        {
            string text = Request.Form["text"];
            var data = new {Age=22, Text=$"{text}"};
            return new JsonResult(data);
        }
    }
}