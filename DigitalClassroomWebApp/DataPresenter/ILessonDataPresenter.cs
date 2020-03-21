using DigitalClassroomWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClassroomWebApp.DataPresenter
{
    public interface ILessonDataPresenter
    {
        IEnumerable<Lesson> List();

        Lesson GetLesson(int id);

        LessonChapter GetLessonChapter(int id);

        LessonChapterTask GetLessonChapterTask(int id);

        IEnumerable<LessonChapter> GetChapter(int lessonId);

        IEnumerable<LessonChapterTask> GetChapterTasks(int chapterId);
    }
}
