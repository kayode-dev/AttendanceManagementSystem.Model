using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMangementSystem.Model
{
    public class AMSDbContext : DbContext
    {
        public AMSDbContext() : base("AMS")
        {

        }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<StudentDetail> StudentDetails { get; set; }
        public DbSet<LecturersCourse> LecturersCourses { get; set; }
        public DbSet<CourseAllocation> CourseAllocations { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}
