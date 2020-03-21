using DigitalClassroomWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClassroomWebApp.DataPresenter
{
    public class LessonDataPresenterMock : ILessonDataPresenter
    {
        Lesson demoLesson;

        public LessonDataPresenterMock()
        {
            int id = 0;
            this.demoLesson = new Lesson()
            {
                Id = id++,
                Teacher = "Frau Schütze",
                Subject = "Biologie",
                Title = "Synapsen",
                Class = "5a",
            };

            this.demoLesson.Chapter.Add(new LessonChapter()
            {
                Lesson = this.demoLesson,
                Id = id++,
                Title = "Abschnitt 1",
            });

            this.demoLesson.Chapter.Last().Tasks.Add(new LessonChapterTask()
            {
                Chapter = this.demoLesson.Chapter.Last(),
                Id = id++,
                Title = "Aufgabe 1",
                Done = true,
            });
            this.demoLesson.Chapter.Last().Tasks.Add(new LessonChapterTask()
            {
                Chapter = this.demoLesson.Chapter.Last(),
                Id = id++,
                Title = "Aufgabe 2",
                Done = true,
            });

            this.demoLesson.Chapter.Add(new LessonChapter()
            {
                Lesson = this.demoLesson,
                Id = id++,
                Title = "Abschnitt 2",
            });

            this.demoLesson.Chapter.Last().Tasks.Add(new LessonChapterTask()
            {
                Chapter = this.demoLesson.Chapter.Last(),
                Id = id++,
                Title = "Aufgabe 1",
                Done = true,
            });

            this.demoLesson.Chapter.Last().Tasks.Add(new LessonChapterTask()
            {
                Chapter = this.demoLesson.Chapter.Last(),
                Id = id++,
                Title = "Aufgabe 2",
            });

            this.demoLesson.Chapter.Last().Tasks.Add(new LessonChapterTask()
            {
                Chapter = this.demoLesson.Chapter.Last(),
                Id = id++,
                Title = "Aufgabe 3",
            });

            this.demoLesson.Chapter.Last().Tasks.Add(new LessonChapterTask()
            {
                Chapter = this.demoLesson.Chapter.Last(),
                Id = id++,
                Title = "Aufgabe 4",
            });

            this.demoLesson.Chapter.Add(new LessonChapter()
            {
                Lesson = this.demoLesson,
                Id = id++,
                Title = "Abschnitt 3",
            });

            this.demoLesson.Chapter.Last().Tasks.Add(new LessonChapterTask()
            {
                Chapter = this.demoLesson.Chapter.Last(),
                Id = id++,
                Title = "Aufgabe 1",
            });
            this.demoLesson.Chapter.Last().Tasks.Add(new LessonChapterTask()
            {
                Chapter = this.demoLesson.Chapter.Last(),
                Id = id++,
                Title = "Aufgabe 2",
            });
        }

        public IEnumerable<Lesson> List()
        {
            return new List<Lesson>()
            {
                this.demoLesson,
            };
        }

        public Lesson GetLesson(int id)
        {
            return demoLesson;
        }

        public IEnumerable<LessonChapter> GetChapter(int lessonId)
        {
            return demoLesson.Chapter;
        }

        public IEnumerable<LessonChapterTask> GetChapterTasks(int chapterId)
        {
            return demoLesson.Chapter.Find(o => o.Id == chapterId)?.Tasks;
        }

        public LessonChapter GetLessonChapter(int id)
        {
            return this.demoLesson.Chapter.FirstOrDefault(o => o.Id == id);
        }

        public LessonChapterTask GetLessonChapterTask(int id)
        {
            return this.demoLesson.Chapter.SelectMany(o => o.Tasks).FirstOrDefault(o => o.Id == id);
        }
    }
}
