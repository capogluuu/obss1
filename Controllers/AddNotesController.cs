using Microsoft.AspNetCore.Mvc;
using obss1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace obss1.Controllers
{
    public class AddNotesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<StudentModel> MultipleRowNotes = new List<StudentModel> { new StudentModel { studentNumber = "_studentNumber", courseName = "courseName", firstExam = 0, secondExam = 0, passState = "false" } };
            return View(MultipleRowNotes);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index2(List<StudentModel> ci)
        {
            if (ModelState.IsValid)
            {
                /*db işlemler,*/
            }
            return View(ci);
        }
    }
}
