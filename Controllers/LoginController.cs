using Microsoft.AspNetCore.Mvc;
using obss1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace obss1.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Index(string studentNumber, string password)
        {
            UserModel user = new UserModel();
            
            
            /*check name passworn is in the database
               if it is okey
                you should do write a query and send all of Usermodel details to Table Index 
                and there, you just filter all note by using student number
             */

            return RedirectToAction("Index","Table");
        }
    }
}
