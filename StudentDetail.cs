using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMangementSystem.Model
{
    //creating the Student detail Table
    public class StudentDetail
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }

        public virtual ICollection<CourseAllocation> CourseAllocations { get; set; }

    }
}
