using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Profile_Management_System
{
    public partial class Form2 : Form
    {

        public Student? student;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTxt.Text) || AgeNum.Value < 0 || string.IsNullOrEmpty(GenderTxt.Text))
            {
                MessageBox.Show("Enter Values");
            }
            else
            {
                student = new Student(NameTxt.Text, AgeNum.Value, GenderTxt.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
