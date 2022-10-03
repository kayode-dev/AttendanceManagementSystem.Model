using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceMangementSystem.Model
{//creating the Level Table
    public class Level
    {
        public int Id { get; set; }

        public int LevelNo { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
