using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_StudentClassrom
{
    public partial class Form1 : Form
    {//Bu projede öncelikle sınıf tanımlaması yapılıyor. Sonrasında yapılacak öğrenci tanımlamarında öğrencilerin hangi sınıfa ait olduğu seçilerek ve öğrenci bilgileri girilerek öğrenci kaydı yapılıyor.
     //Öğrenci ve sınıf bilgileri üzerinde ekleme,düzenleme,silme ve çoklu silme işlemleri tanımlanmıştır.
        public Form1()
        {
            InitializeComponent();
        }

        private void ıdentifyClassroomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClassroom frm = new FormClassroom();
            frm.Show();
        }

        private void ıdentifyStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent frm = new FormStudent();
            frm.Show();
        }
    }
}
