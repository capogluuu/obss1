using Microsoft.AspNetCore.Mvc;
using obss1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace obss1.Controllers
{
    public class SignupController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index2(string studentNumber, string name, string password, string status)
        {
            UserModel userInfo = new UserModel { studentNumber = studentNumber, name= name, password = password, status = status  };
            if (ModelState.IsValid)
            {
                /*db işlemler,*/
            }
            return View(userInfo);
        }
    }



}
