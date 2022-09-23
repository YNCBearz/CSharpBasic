﻿using CSharpBasic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharpBasic.Controllers
{
    public class WhereAmIController : Controller
    {
        private readonly IGeoIpService _geoIpService;

        public WhereAmIController(IGeoIpService geoIpService)
        {
            _geoIpService = geoIpService;
        }
        
        // GET
        public JsonResult Index()
        {
            var data = _geoIpService.GetData();
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