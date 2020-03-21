using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClassroomWebApp.Models
{
    public class Lesson
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Class { get; set; }

        public List<LessonChapter> Chapter { get; set; } = new List<LessonChapter>();

        public string Subject { get; internal set; }

        public string Teacher { get; internal set; }
    }
}
