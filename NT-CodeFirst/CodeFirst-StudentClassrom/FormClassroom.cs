using CodeFirst_StudentClassrom.Context;
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
    public partial class FormClassroom : Form
    {
        public FormClassroom()
        {
            InitializeComponent();
            dgvClassroom.MultiSelect = true;
            dgvClassroom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //DataGrig ekranında çoklu satır seçimi yapabilmek için MultiSelect propertysini true ve selectionModunu FullRowSelect yapmamız gerekir.
        }

        StudentClassroomContext db = new StudentClassroomContext();//Veritabanı bağlantı nesnemiz.
        private static int classroomID;
        private static Classroom classroom;
        private static Classroom classroomMultipleRow;
        private static int itemsCount;

        private void FormClassroom_Load(object sender, EventArgs e)
        {

            ClassroomFill();
        }
        private void ClassroomFill()
        {//Veritabanında kayıtlı olan bilgileri dataGridimize alıyoruz.
            dgvClassroom.DataSource = db.Classrooms.Select(x => new
            {//Sadece burada belirttiğimiz alanları getirir.
                x.ClassroomID, 
                x.Description
            }).ToList();
        }

        private void btnDecriptionInsert_Click(object sender, EventArgs e)
        {//veritabanımıza yeni sınıf ekliyoruz.
            try
            {
                Classroom classroom = new Classroom();
                classroom.Description = tbDescription.Text;
                db.Classrooms.Add(classroom);
                db.SaveChanges();
                ClassroomFill();
                tbDescription.Text = " ";
            }
            catch (Exception)
            {
                MessageBox.Show("You haven't any data for Insert operation");
            }
            
        }

        private void dgvClassroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {//Güncelleme yapılabilmesi için dataGridde seçilen alanımızdaki verileri ait olduğu textboxa yolluyoruz. 
            classroomID = (int)dgvClassroom.CurrentRow.Cells["ClassroomID"].Value;
            classroom = db.Classrooms.Where(x => x.ClassroomID == classroomID).Select(X => X).FirstOrDefault();
            tbDescription.Text = classroom.Description.ToString();
            itemsCount = dgvClassroom.SelectedRows.Count;//Seçilen item sayısını çoklu silme işlemi butonu için global bir değişken olarak tanımlıyoruz.
        }

        private void btnDescriptionUpdate_Click(object sender, EventArgs e)
        { //Seçilen verinin güncelleme işlemi yapılıyor.
            try
            {
                 classroom.Description = tbDescription.Text;
                 db.SaveChanges();
                 ClassroomFill();
                 tbDescription.Text = " ";
            }
            catch (Exception)
            {
                MessageBox.Show("You haven't any data for Update operation");
            }
           
        }

        private void btnDescriptionDelete_Click(object sender, EventArgs e)
        {//Seçilen verinin silme işlemi yapılıyor.
            try
            {
                 if (itemsCount > 1)
                 {
                     MessageBox.Show("For multiple row delete,click 'Delete Selected Items' button.");
                 }
                 else
                 {
                     db.Classrooms.Remove(classroom);
                     db.SaveChanges();
                     ClassroomFill();
                     tbDescription.Text = " ";
                 }
            }
            catch (Exception)
            {
                MessageBox.Show("You haven't any data for Delete operation");
            }
           

        }

        private void btnDescriptionMultiSelectedIDelete_Click(object sender, EventArgs e)
        {//Seçilen verilerin silme işlemi yapılıyor.
            try
            {
                if (itemsCount < 2)
                {
                    MessageBox.Show("For one row delete,click 'Delete' button.");
                }
                else
                {             
                    var selectedRows = dgvClassroom.SelectedRows
                         .OfType<DataGridViewRow>()
                         .Where(row => !row.IsNewRow).ToList();
               
                    foreach (var sR in selectedRows)
                    {
                        //int selectedID = (int)sR.Cells["ClassroomID"].Value;
                        //classroomMultipleRow = db.Classrooms.Find(selectedID);
                        //db.Classrooms.Remove(classroomMultipleRow);
                        //Alternatif yolu
               
                        int selectedID = (int)sR.Cells["ClassroomID"].Value;
                        classroomMultipleRow = db.Classrooms.Where(x => x.ClassroomID == selectedID).Select(x=>x).FirstOrDefault();
                        db.Classrooms.Remove(classroomMultipleRow);
                    }
                    db.SaveChanges();
                    tbDescription.Text = " ";
                    ClassroomFill();
                 
                }
                }
                catch (Exception)
                {
                    MessageBox.Show("You haven't any data for Multi Selected Items Delete operation");
             }
            
        }
    }
}
