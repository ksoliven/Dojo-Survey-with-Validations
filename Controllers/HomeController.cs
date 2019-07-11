using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using DojoSurvey.Models;
namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        // localhost: 5000/
        // [Route("")]
        [HttpGet("")]

        public IActionResult Index()
        {
            //ViewResult myView = View();
            return View("Index");
        }
        [HttpPost("Result")]
        public IActionResult Result(Survey yourSurvey) 
        {
            if (ModelState.IsValid)
            {
                return View("Result", yourSurvey);
            }
            else
            {
                return View("Index");
            }
        }
    }
}