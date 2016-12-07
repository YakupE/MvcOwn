using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcOwn.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcOwn.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(int id)
        {

            //return Unauthorized();
            //return BadRequest();
            //return NotFound();

            
            Contact contact = new Contact()
            {
                ID = id,
                FirstName = "Yakup",
                LastName = "Evci"
            };

            return View(contact);
            

            //return Content("<!doctype html><html><head></head><body><h2>Hallo daar!</h2></body></html>", "text/html");

        }

        
        public IActionResult DownloadFile()
        {
            return File("/download/TestData.txt", "text/plain", "Test data.txt");
        }
    }
}
