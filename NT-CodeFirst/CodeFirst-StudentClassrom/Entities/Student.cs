using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_StudentClassrom.Context
{
    public class Student
    {
        public long StudentID { get; set; }
        public string FullName { get; set; }
        public int ClassroomID { get; set; }

        public virtual Classroom classroom { get; set; }
    }
}
