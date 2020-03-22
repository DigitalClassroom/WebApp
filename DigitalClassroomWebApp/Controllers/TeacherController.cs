using DigitalClassroomWebApp.DataPresenter;
using DigitalClassroomWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClassroomWebApp.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index(int id = 0)
        {
            return View();
        }
    }
}
