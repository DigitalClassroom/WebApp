using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClassroomWebApp.Models
{
    public class ScheduleItem
    {
        public DayOfWeek DayOfWeek { get; set; }

        public int TimeSlot { get; set; }

        public string Title { get; set; }

        public string CssTag { get; set; }
    }
}
