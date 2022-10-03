using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMangementSystem.Model
{
    public class CourseAllocation
    {
        public string Id { get; set; }

        public virtual string StudentId { get; set; }

        public virtual StudentDetail Student { get; set; }

        public virtual string CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
