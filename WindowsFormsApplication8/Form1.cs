using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Domain;
using Session;
using System.Data.OleDb;



namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {            
        Broker b = new Broker();
        

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Firstname = txtName.Text;
            p.Lastname = txtLastName.Text;
            p.Dob = txtDOB.Text;
            p.Position = txtPosition.Text;
            p.Catagory = txtCatagory.Text;
            p.Gender = txtGender.Text;

            b.Insert(p);

        }

        private void btnFillComboBox_Click(object sender, EventArgs e)
        {
            cmbPersons.DataSource = b.FillComboBox();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Person oldPerson = new Person();
            Person newPerson = new Person();

            oldPerson = cmbPersons.SelectedItem as Person;

            newPerson.Firstname = txtNewName.Text;
            newPerson.Lastname = txtNewLastName.Text;
            newPerson.Dob = txtNewCatagory.Text;
            newPerson.Gender = txtNewGender.Text;
            newPerson.Position = txtNewPosition.Text;
            newPerson.Catagory = txtNewCatagory.Text;

            b.Update(oldPerson, newPerson);





        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            p = cmbPersons.SelectedItem as Person;

            b.Delete(p);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtLastName.Text = "";
            txtCatagory.Text = "";
            txtGender.Text = "";
            txtDOB.Text = "";
            txtPosition.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmbPersons.DataSource = b.FillComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            
            Person p = new Person();
            p.Firstname = txtName.Text;
            p.Lastname = txtLastName.Text;
            p.Dob = txtDOB.Text;
            p.Position = txtPosition.Text;
            p.Catagory = txtCatagory.Text;
            p.Gender = txtGender.Text;

            Catagory catagory_a_2 = new Catagory();
            string thetime;

            thetime = txtCatagory.Text;

            switch (thetime)
            {
                case "Catagory A":

                    label5.Text = "Name = " + p.Firstname +" "+ p.Lastname + Environment.NewLine + "DOB = " + p.Dob + Environment.NewLine +
                                  "Gender = " + p.Gender + Environment.NewLine + "Position = " + p.Position + Environment.NewLine +
                                  "Payment = " + catagory_a_2.getCatagory_a_payment().ToString() + Environment.NewLine +
                                  "Tax = " + catagory_a_2.getCatagory_a_Tax().ToString() + Environment.NewLine +
                                  "National Insurance = " + catagory_a_2.getCatagory_a_NI() + Environment.NewLine +
                                  "Final Payment = " + catagory_a_2.getCatagory_a_Final().ToString();

                    break;

                case "Catagory B":
                    label5.Text = "Name = " + p.Firstname + " " + p.Lastname + Environment.NewLine + "DOB = " + p.Dob + Environment.NewLine +
                                  "Gender = " + p.Gender + Environment.NewLine + "Position = " + p.Position + Environment.NewLine +
                                  "Payment = " + catagory_a_2.getCatagory_b_payment().ToString() + Environment.NewLine +
                                  "Tax = " + catagory_a_2.getCatagory_b_Tax().ToString() + Environment.NewLine +
                                  "National Insurance = " + catagory_a_2.getCatagory_b_NI() + Environment.NewLine +
                                  "Final Payment = " + catagory_a_2.getCatagory_b_Final().ToString();
                    break;

                case "Catagory C":
                    label5.Text = "Name = " + p.Firstname + " " + p.Lastname + Environment.NewLine + "DOB = " + p.Dob + Environment.NewLine +
                                  "Gender = " + p.Gender + Environment.NewLine + "Position = " + p.Position + Environment.NewLine +
                                  "Payment = " + catagory_a_2.getCatagory_c_payment().ToString() + Environment.NewLine +
                                  "Tax = " + catagory_a_2.getCatagory_1_Tax().ToString() + Environment.NewLine +
                                  "National Insurance = " + catagory_a_2.getCatagory_1_NI() + Environment.NewLine +
                                  "Final Payment = " + catagory_a_2.getCatagory_1_Final().ToString();
                    break;

                case "Catagory D":
                    label5.Text = "Name = " + p.Firstname + " " + p.Lastname + Environment.NewLine + "DOB = " + p.Dob + Environment.NewLine +
                                  "Gender = " + p.Gender + Environment.NewLine + "Position = " + p.Position + Environment.NewLine +
                                  "Payment = " + catagory_a_2.getCatagory_d_payment().ToString() + Environment.NewLine +
                                  "Tax = " + catagory_a_2.getCatagory_d_Tax().ToString() + Environment.NewLine +
                                  "National Insurance = " + catagory_a_2.getCatagory_d_NI() + Environment.NewLine +
                                  "Final Payment = " + catagory_a_2.getCatagory_d_Final().ToString();
                    break;




            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNewName.Text = "";
            txtNewLastName.Text = "";
            txtNewCatagory.Text = "";
            txtNewGender.Text = "";
            txtNewDob.Text = "";
            txtNewPosition.Text = "";
        }


       private void onScreenHelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"onscreen help to assist the users of a computer program.docx");
        }

       private void accessDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
       {
           System.Diagnostics.Process.Start(@"Database.accdb");
       }
    }
}
