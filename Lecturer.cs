using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMangementSystem.Model
{//creatng the Lecturer
    public class Lecturer
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<LecturersCourse> LecturersCourses { get; set; }
    }
}
