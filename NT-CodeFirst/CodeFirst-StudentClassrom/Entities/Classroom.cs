using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_StudentClassrom.Context
{
    public class Classroom
    {
        public Classroom()
        {
            this.students=new HashSet<Student>();
            //public virtual ICollection<Student> students { get; set; }
            //This ile bu classta yazılan ICollection türünden nesneyi kastediyor. 
        }

        public int ClassroomID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Student> students { get; set; }
        //one to many relaionship için virtual tanımlanır.
        //Bir projede ı colletion kullanılıyorsa muhakkak hashset olarak propertysi tanımlanmalıdır.
    }
}
