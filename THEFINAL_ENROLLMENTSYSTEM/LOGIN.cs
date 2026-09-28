using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userext.Text == "admin" && passext.Text == "123" && userbox.Text == "ADMIN")
            {

                MessageBox.Show("Login Successful!");
                new ADMINDB().Show();
                this.Hide();
                return;
            }
            {
                if (userext.Text == "student" && passext.Text == "123" && userbox.Text == "STUDENT")
                {

                    MessageBox.Show("Login Successful!");
                    new STUDENTDB().Show();
                    this.Hide();
                    return;
                }
                {
                    if (userext.Text == "faculty" && passext.Text == "123" && userbox.Text == "FACULTY")
                    {

                        MessageBox.Show("Login Successful!");
                        new FACULTYDB().Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("The User or Pass is Incorrect. Please Try Again.");
                        userext.Clear();
                        passext.Clear();
                        userbox.Focus();
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SIGNUP().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                passext.UseSystemPasswordChar = false;
            }
            else
            {
                passext.UseSystemPasswordChar = true;

            }
        }
    }
}
