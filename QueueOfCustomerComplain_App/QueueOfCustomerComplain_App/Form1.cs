using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueOfCustomerComplain_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showListView.Columns.Add("Serial");
            showListView.Columns.Add("Name");
            showListView.Columns.Add("Complain");
        }
        Queue<Customer> customers=new Queue<Customer>();
        Queue<Customer> customerdeQueue = new Queue<Customer>();
        private int serial = 0;
        string name = "";
        private void enqueueButton_Click(object sender, EventArgs e)
        {
            while (enqueueComplainTextBox.Text != string.Empty && enqueueNameTextBox.Text != string.Empty)
            {
                Customer customer1 = new Customer();

                serial = serial + 1;
                customer1.name = enqueueNameTextBox.Text;
                customer1.complain = enqueueComplainTextBox.Text;
                customer1.serial = serial.ToString();
                customers.Enqueue(customer1);

                enqueueNameTextBox.Clear();
                enqueueComplainTextBox.Clear();


                ListViewItem myView = new ListViewItem();





                myView.Text = (customer1.serial);
                myView.SubItems.Add(customer1.name);
                myView.SubItems.Add(customer1.complain);


                name = customer1.name + " ,Your serial no is " + customer1.serial;




                MessageBox.Show(name);
                showListView.Items.Add(myView);
            }

        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            Customer customer1 = new Customer();
            
            customer1 = customers.Dequeue();

            dequeueSerialNoTextBox.Text = customer1.serial;
            dequeueNameTextBox.Text = customer1.name;
            dequeueComplainTextBox.Text = customer1.complain;
            showListView.Items.RemoveAt(0);
            
        }
    }
}
