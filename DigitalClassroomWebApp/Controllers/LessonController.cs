using DigitalClassroomWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DigitalClassroomWebApp.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            Lesson lesson = new Lesson()
            {
                Title = "Hallo Welt",
                Class = "5a",
            };

            lesson.Points.Add(new LessonPoint()
            {
                Title = "Aufgabe 1",
            });

            lesson.Points.Add(new LessonPoint()
            {
                Title = "Aufgabe 2",
            });

            lesson.Points.Add(new LessonPoint()
            {
                Title = "Aufgabe 3",
            });


            ViewData["Title"] = lesson.Title;
            return View(lesson);
        }
    }
}