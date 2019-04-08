using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return View("Index");
            }
            else
            {
                System.Console.WriteLine("\n!!!!!!!!!!!!!!!!!!!!!!!!!!!!!\n");
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return View("NewUser");
            }
        }

    }
}
