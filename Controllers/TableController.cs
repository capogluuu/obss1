using Microsoft.AspNetCore.Mvc;
using obss1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace obss1.Controllers
{
    public class TableController : Controller
    {
        public IActionResult Index(UserModel usermodel)
        {
            return View();
        }
    }
}
