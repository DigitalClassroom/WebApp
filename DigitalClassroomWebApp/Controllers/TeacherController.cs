using DigitalClassroomWebApp.DataPresenter;
using DigitalClassroomWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DigitalClassroomWebApp.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index(int id = 0)
        {
            TeacherDashboard model = new TeacherDashboard();
            model.Schedules.Add(new ScheduleItem()
            {
                Title = "Englisch\n6a",
                DayOfWeek = DayOfWeek.Monday,
                TimeSlot = 1,
                CssTag = "Aqua",
            });

            model.Schedules.Add(new ScheduleItem()
            {
                Title = "Englisch\n8a",
                DayOfWeek = DayOfWeek.Monday,
                TimeSlot = 2,
                CssTag = "Aqua",
            });

            model.Schedules.Add(new ScheduleItem()
            {
                Title = "Biologie\n6a",
                DayOfWeek = DayOfWeek.Monday,
                TimeSlot = 3,
                CssTag = "Lime",
            });

            model.Schedules.Add(new ScheduleItem()
            {
                Title = "Englisch\n5b",
                DayOfWeek = DayOfWeek.Monday,
                TimeSlot = 6,
                CssTag = "Aqua",
            });

            return View(model);
        }
    }
}
