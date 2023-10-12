using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql
{
    public partial class Form1 : Form
    {
        StudentDataContext dbcontext;
        List<STUDENT> studentsList;
        int indexNo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbcontext = new StudentDataContext();
            studentsList = dbcontext.STUDENTs.ToList();
            GetdataInForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Text;

            if (buttonText == "Next")
            {

            }
            else if(buttonText == "Pervious")
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GetdataInForm()
        {
            NameTextBox.Text = studentsList[indexNo].StudentName;
            ClassTextBox.Text = studentsList[indexNo].@class.ToString();
            GenderTextBox.Text = studentsList[indexNo].gender;
            AgeTextBox.Text = studentsList[indexNo].age.ToString();
        }
    }
}
