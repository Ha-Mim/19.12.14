using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        List<Student> students = new List<Student>(); 
        private void saveButton_Click(object sender, EventArgs e)
        {


            while (regNoTextBox.Text != string.Empty && firstNameTextBox.Text != string.Empty &&
                   lastNameTextBox.Text != string.Empty)
            {
                Student student1 = new Student();
                student1.regNO = regNoTextBox.Text;
                student1.firstName = firstNameTextBox.Text;
                student1.lastName = lastNameTextBox.Text;

                students.Add(student1);
                regNoTextBox.Text = string.Empty;
                firstNameTextBox.Text = string.Empty;
                lastNameTextBox.Text = string.Empty;
            }




        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            string value = "";
            foreach (Student aStudent in students)
            {
                value +=  aStudent.regNO + "             " + aStudent.GetFullName() + "\n";

            }
            MessageBox.Show("Registration No    Full Name \n"+value);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
          
            
                students.Clear();
            
        }
    }
}
