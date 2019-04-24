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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
            dgvStudent.MultiSelect = true;
            dgvStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        StudentClassroomContext db = new StudentClassroomContext();
        private static Student student;
        private static int studentID;
        private static int itemsCount;
        private void FormStudent_Load(object sender, EventArgs e)
        {
            StudentFill();
            ClassFill();
        }
        private void ClassFill()
        {
            var classroom = db.Classrooms.Select(x => new
            {
                x.ClassroomID,
                x.Description
            }).ToList();
            cbClass.DisplayMember = "Description";
            cbClass.ValueMember = "ClassroomID";
            cbClass.DataSource = classroom;
        }
        private void StudentFill()
        {
            dgvStudent.DataSource = db.Students.Select(x => new
            {
                x.StudentID,
                x.FullName,
                x.classroom.Description
            }).ToList();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {//Bu tryları
            try
            {
                Student student = new Student();
                student.FullName = tbFullName.Text;
                student.ClassroomID = (int)cbClass.SelectedValue;
                db.Students.Add(student);
                db.SaveChanges();
                StudentFill();
            }
            catch (Exception)
            {
                MessageBox.Show("You haven't any data for Insert operation");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                student.FullName = tbFullName.Text;
                student.ClassroomID = (int)cbClass.SelectedValue;
                db.SaveChanges();
                StudentFill();
                tbFullName.Text = " ";
                cbClass.SelectedValue = " ";
            }
            catch (Exception)
            {
                MessageBox.Show("You haven't any data for Update operation");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemsCount > 1)
                {
                    MessageBox.Show("For multiple row delete,click 'Delete Selected Items' button.");
                }
                else
                {
                    db.Students.Remove(student);
                    db.SaveChanges();
                    StudentFill();
                    tbFullName.Text = " ";
                    cbClass.SelectedValue = " ";
                }

            }
            catch (Exception)
            {
                MessageBox.Show("You haven't any data for Delete operation");
            }

        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            studentID = Convert.ToInt32(dgvStudent.CurrentRow.Cells["StudentID"].Value);
            student = db.Students.Where(x => x.StudentID == studentID).Select(X => X).FirstOrDefault();
            tbFullName.Text = student.FullName;
            cbClass.SelectedValue = student.ClassroomID;
            itemsCount = dgvStudent.SelectedRows.Count;
        }

        private void btnDeleteSelectedItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemsCount < 2)
                {
                    MessageBox.Show("For one row delete,click 'Delete' button.");
                }
                else
                {
                    var selectedRows = dgvStudent.SelectedRows
                         .OfType<DataGridViewRow>()
                         .Where(row => !row.IsNewRow).ToList();

                    foreach (var sR in selectedRows)
                    {
                        int selectedID = (int)sR.Cells["StudentID"].Value;
                        student = db.Students.Find(selectedID);
                        db.Students.Remove(student);
                    }
                    db.SaveChanges();
                    tbFullName.Text = " ";
                    cbClass.SelectedValue = " ";
                    StudentFill();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You haven't any data for Delete Selected Items operation");
            }

        }
    }
}
