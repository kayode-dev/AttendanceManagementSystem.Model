using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMangementSystem.Model
{
    // creating the Course table
    public class Course
    {
        public string Id { get; set; }

        public string CourseCode { get; set; }

        public string CourseTitle { get; set; }

        public string DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public int LevelId { get; set; }

        public virtual Level Level { get; set; }

        public int SemesterId { get; set; }

        public virtual Semester Semester { get; set; }

        public int NoOfLectures { get; set; }

        public int NoOfLecturesTaken { get; set; }

        public virtual ICollection<LecturersCourse> LecturersCourses { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }

        public  virtual ICollection<CourseAllocation> CourseAllocations{ get; set; }
    }
}
