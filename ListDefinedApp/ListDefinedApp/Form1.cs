using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListDefinedApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>(3);
        private void saveButton_Click(object sender, EventArgs e)
        {

            while (regNoTextBox.Text != string.Empty && firstNameTextBox.Text != string.Empty &&
                   lastNameTextBox.Text != string.Empty)
            {
                Student student1 = new Student();
                student1.regNO = regNoTextBox.Text;
                student1.firstName = firstNameTextBox.Text;
                student1.lastName = lastNameTextBox.Text;

                if (students.Count < 3)
                {
                    students.Add(student1);
                }
               
                

                else
                {
                    MessageBox.Show("Already three entry has been given");
                    
                }
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

               value += aStudent.regNO + "             " + aStudent.GetFullName() + "\n";
               
                
                   
                
          }
            MessageBox.Show("Registration No    Full Name \n" + value);
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            students.Clear();
        }
    }
}
