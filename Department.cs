using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMangementSystem.Model
{ // creating the Departments table
    public class Department
    {
        public string Id { get; set; }

        public int FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }

        [MaxLength(30)]
        public string DepartmentName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Lecturer> Lecturers { get; set; }

        public virtual ICollection<StudentDetail> StudentDetails { get; set; }

    }
}
