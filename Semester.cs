using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMangementSystem.Model
{
    //creating the Semester Table
    public class Semester
    {
        public int Id { get; set; }

        public string semesterName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
