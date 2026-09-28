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
    public partial class SIGNUP : Form
    {
        public SIGNUP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfname.Text) || string.IsNullOrWhiteSpace(txtlname.Text) || string.IsNullOrWhiteSpace(txtemail.Text) || string.IsNullOrWhiteSpace(txtusername.Text))
            {
                MessageBox.Show("Fill Empty.");
            }
           

            else if (txtpassword.Text == txtcopass.Text)
            {
                MessageBox.Show("Account Registered!");


                LOGIN loginForm = new LOGIN();
                loginForm.Show();

                this.Hide();
            }

            else
            {
                MessageBox.Show("Passwords didn’t match. Try again.");
                txtpassword.Clear();
                txtcopass.Clear();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;

            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtcopass.UseSystemPasswordChar = false;
            }
            else
            {
                txtcopass.UseSystemPasswordChar = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             new LOGIN().Show();
            this.Hide();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            string suffix = "@sjp2cd.edu.ph"; if (!txtemail.Text.EndsWith(suffix))
            {

                txtemail.Text = txtemail.Text.Split('@')[0] + suffix;

                txtemail.SelectionStart = txtemail.Text.Length - suffix.Length;
            }
        }
        }
    
        }


