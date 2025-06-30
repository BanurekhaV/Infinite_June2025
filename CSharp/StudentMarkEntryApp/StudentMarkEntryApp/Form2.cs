using StudentMarkEntryApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarkEntryApp
{
    public partial class Form2 : Form
    {
        public List<Student> studentList = new List<Student>();
        public Form2(List<Student> students)
        {
            InitializeComponent();
            studentList = students;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*  dataGridView1.DataSource = new List<Student>
              {
                  new Student{ StudentId = 1, StudentName="Jai",Scores = 90 },
                  new Student{ StudentId = 1, StudentName="Jai",Scores = 90 },
                  new Student{ StudentId = 1, StudentName="Jai",Scores = 90 },
              };*/

            dataGridView1.DataSource = studentList;

        }
    }
}
