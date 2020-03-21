using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClassroomWebApp.Models
{
    public class Lesson
    {
        public string Title { get; set; }

        public string Class { get; set; }

        public List<LessonPoint> Points { get; set; } = new List<LessonPoint>();
    }
}
