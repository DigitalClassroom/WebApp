using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClassroomWebApp.Models
{
    public class LessonChapter
    {
        public Lesson Lesson { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public List<LessonChapterTask> Tasks { get; } = new List<LessonChapterTask>();

        public int Status
        {
            get
            {
                return Tasks.Count(o => o.Done) * 100 / Tasks.Count;
            }
        }
    }
}
