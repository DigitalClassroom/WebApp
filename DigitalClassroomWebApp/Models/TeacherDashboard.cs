using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalClassroomWebApp.Models
{
    public class TeacherDashboard
    {
        public List<ScheduleItem> Schedules { get; set; } = new List<ScheduleItem>();
    }
}
