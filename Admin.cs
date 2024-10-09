using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TeacherAdmin_Winform
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Student.Data.Add(new Student() { Id = 1001, Name = "Tommy", GPA = 3.2f });
            Student.Data.Add(new Student() { Id = 1002, Name = "Ben", GPA = 4.4f });
            Student.Data.Add(new Student() { Id = 1003, Name = "Alice", GPA = 4.9f });
            Student.Data.Add(new Student() { Id = 1004, Name = "Amy", GPA = 3.9f });
            Student.Data.Add(new Student() { Id = 1005, Name = "George", GPA = 3.3f });
            gridStudents.DataSource = Student.Data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();

            newStudent.Id = int.Parse(txtStudid.Text);
            newStudent.Name = txtStudName.Text;
            newStudent.GPA = float.Parse(txtStudGPA.Text);

            Student.Data.Add(newStudent);

            RefreshData();


        }

        private void RefreshData()
        {
            gridStudents.DataSource = null;
            gridStudents.DataSource = Student.Data;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Student.Data.RemoveAt(gridStudents.CurrentRow.Index);
                RefreshData();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            const string path = @"C:\MSSA\Files\";
            string filename = "HighestGPA_";
            string extension = ".txt";
            StreamWriter writer = null;
            string datetime = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");

            Student.Data.Sort(new StudentGPAComparer());
            



            try
            {
                if (!File.Exists(filename))
                {
                    writer = File.CreateText(path + filename + datetime + extension);
                    writer.WriteLine($"Highest GPA {Student.Data[0].GPA} Name: {Student.Data[0].Name}");
                    MessageBox.Show("File Exported!");
                }
                //else
                //{
                //    File.AppendAllText(path + filename, $"Highest GPA {DateTime.Now}");
                //    MessageBox.Show("Exported into existing file.");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }


            // add this when multiple checkboxes later
            //if (cboxHighest.Checked == true)
            //{
            //    filename = "HighestGPA.txt";
            //}
        }
    }
}
