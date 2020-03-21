using DigitalClassroomWebApp.DataPresenter;
using DigitalClassroomWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DigitalClassroomWebApp.Controllers
{
    public class LessonController : Controller
    {
        private readonly ILessonDataPresenter lessonDataPresenter;

        public LessonController(ILessonDataPresenter lessonDataPresenter)
        {
            this.lessonDataPresenter = lessonDataPresenter
                ?? throw new ArgumentNullException(nameof(lessonDataPresenter));
        }

        public IActionResult Index(int id = 0)
        {
            Lesson lesson = lessonDataPresenter.GetLesson(id);
            ViewData["Title"] = lesson.Title;
            return View(lesson);
        }

        public IActionResult Chapter(int id = 1)
        {
            LessonChapter c = lessonDataPresenter.GetLessonChapter(id);

            ViewData["Title"] = c.Title;
            return View(c);
        }
    }
}