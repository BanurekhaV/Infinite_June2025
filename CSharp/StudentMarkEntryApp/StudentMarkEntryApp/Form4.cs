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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            // Assign same event handler to multiple buttons

         
            button1.Click += CommonButtonClick;
            button2.Click += CommonButtonClick;
            button3.Click += CommonButtonClick;
        }

        private void CommonButtonClick(object sender, EventArgs e)
        {
            // Cast sender to Button to know which one was clicked
            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                MessageBox.Show($"You clicked: {clickedButton.Text}", "Button Click");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
