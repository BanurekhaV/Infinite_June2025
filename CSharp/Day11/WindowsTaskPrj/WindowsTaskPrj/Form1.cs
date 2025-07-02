using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace WindowsTaskPrj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello and Welcome to Tasks...");
        }

        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader = new StreamReader("Bigfile.txt"))
            {
                string content = reader.ReadToEnd();
                count=content.Length;
                Thread.Sleep(5000); 
            }
            return count;
        }

        // the below event works synchronously
        private void btnClick_Click(object sender, EventArgs e)
        {
            int z = CountCharacters();
            txtMessage.Text = "Processing file counting job, Please wait....";
            txtMessage.Text= z.ToString();
        }

        private async void btnTask_Click(object sender, EventArgs e)
        {
            Task<int> mytask = new Task<int>(CountCharacters);
            mytask.Start();   // starts to execute the task (method associated with the task)
            txtMessage.Text = "Processing file counting job, Please wait....";
            txtMessage2.Text = "This should take some time..";
            label1.Visible = false;
            btnClick.Text = "OK";
            btnClick.ForeColor= System.Drawing.Color.Blue;
            btnTask.ForeColor = System.Drawing.Color.Red;
            int z = await mytask;
            txtMessage.Text = z.ToString() + " " +  "Characters found in the File.";
        }
    }
}
