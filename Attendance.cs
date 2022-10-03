using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMangementSystem.Model
{
    public class Attendance
    {
        public string Id { get; set; }

        public string StudentId { get; set; }

        public string CourseId { get; set; }

        public bool AttendanceStatus { get; set; }

        public virtual StudentDetail Student { get; set; }

        public virtual Course Course { get; set; }

    }
}
