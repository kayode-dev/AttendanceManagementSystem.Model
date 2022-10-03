using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMangementSystem.Model
{
    public class LecturersCourse
    {
        public string Id { get; set; }

        public virtual string LecturerId { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        public virtual string CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
