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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ADMINDB().Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form11().Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new LOGIN().Show();
            this.Hide();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                IDext.Text = listView1.SelectedItems[0].SubItems[0].Text;
                Fnamext.Text = listView1.SelectedItems[0].SubItems[1].Text;
                genderbox.Text = listView1.SelectedItems[0].SubItems[2].Text;
                addressext.Text = listView1.SelectedItems[0].SubItems[3].Text;
                emailext.Text = listView1.SelectedItems[0].SubItems[4].Text;
                statusbox.Text = listView1.SelectedItems[0].SubItems[5].Text;
                depbox.Text = listView1.SelectedItems[0].SubItems[6].Text;

                IDext.Enabled = true;
                Fnamext.Enabled = true;
                genderbox.Enabled = true;
                addressext.Enabled = true;
                emailext.Enabled = true;
                statusbox.Enabled = true;
                depbox.Enabled = true;

                NEWBTN.Enabled = false;
                UPDBTN.Enabled = true;
                DELBTN.Enabled = true;

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("ID NUM", 75);
            listView1.Columns.Add("FULL NAME", 150);
            listView1.Columns.Add("GENDER", 120);
            listView1.Columns.Add("ADDRESS", 150);
            listView1.Columns.Add("EMAIL ADDRESS", 120);
            listView1.Columns.Add("STATUS", 120);
            listView1.Columns.Add("DEPARTMENT", 120);
        }

        private void NEWBTN_Click(object sender, EventArgs e)
        {
            Fnamext.Enabled = true;
            genderbox.Enabled = true;
            addressext.Enabled = true;
            emailext.Enabled = true;
            IDext.Enabled = true;
            statusbox.Enabled = true;
            depbox.Enabled = true;
            NEWBTN.Enabled = false;
            ADDBTN.Enabled = true;
        }

        private void ADDBTN_Click(object sender, EventArgs e)
        {
            if
            (string.IsNullOrWhiteSpace(IDext.Text) || string.IsNullOrWhiteSpace(Fnamext.Text) ||
    string.IsNullOrWhiteSpace(genderbox.Text) || string.IsNullOrWhiteSpace(addressext.Text) ||
        string.IsNullOrWhiteSpace(emailext.Text) || string.IsNullOrWhiteSpace(depbox.Text) ||
        string.IsNullOrWhiteSpace(statusbox.Text))
            {
                MessageBox.Show("Fill Empty.");
            }
            else
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem Birot = new ListViewItem(Fnamext.Text);
                    Birot.SubItems.Add(IDext.Text);
                    Birot.SubItems.Add(Fnamext.Text);
                    Birot.SubItems.Add(genderbox.Text);
                    Birot.SubItems.Add(addressext.Text);
                    Birot.SubItems.Add(emailext.Text);
                    Birot.SubItems.Add(statusbox.Text);


                    listView1.Items.Add(Birot);
                    ADDBTN.Enabled = false;
                    NEWBTN.Enabled = true;

                    IDext.Text = "";
                    Fnamext.Text = "";
                    genderbox.Text = "";
                    addressext.Text = "";
                    emailext.Text = "";
                    IDext.Text = "";
                    statusbox.Text = "";
                    depbox.Text = "";

                    Fnamext.Enabled = false;
                    genderbox.Enabled = false;
                    addressext.Enabled = false;
                    emailext.Enabled = false;
                    IDext.Enabled = false;
                    addressext.Enabled = false;
                    emailext.Enabled = false;
                    statusbox.Enabled = false;
                    depbox.Enabled = false;

                    MessageBox.Show("Added Successfuly!");
                }
            }
        }

        private void UPDBTN_Click(object sender, EventArgs e)
        {
            if
            (string.IsNullOrWhiteSpace(IDext.Text) || string.IsNullOrWhiteSpace(Fnamext.Text) ||
string.IsNullOrWhiteSpace(genderbox.Text) || string.IsNullOrWhiteSpace(addressext.Text) ||
string.IsNullOrWhiteSpace(emailext.Text) || string.IsNullOrWhiteSpace(depbox.Text) ||
string.IsNullOrWhiteSpace(statusbox.Text))
            {
                MessageBox.Show("Fill Empty.");
            }
            else
            {
                listView1.SelectedItems[0].SubItems[0].Text = IDext.Text;
                listView1.SelectedItems[0].SubItems[1].Text = Fnamext.Text;
                listView1.SelectedItems[0].SubItems[2].Text = genderbox.Text;
                listView1.SelectedItems[0].SubItems[3].Text = addressext.Text;
                listView1.SelectedItems[0].SubItems[4].Text = emailext.Text;
                listView1.SelectedItems[0].SubItems[5].Text = statusbox.Text;
                listView1.SelectedItems[0].SubItems[6].Text = depbox.Text;

                IDext.Text = "";
                Fnamext.Text = "";
                genderbox.Text = "";
                addressext.Text = "";
                emailext.Text = "";
                statusbox.Text = "";
                depbox.Text = "";

                NEWBTN.Enabled = true;
                UPDBTN.Enabled = false;
                DELBTN.Enabled = false;

            }
        }

        private void DELBTN_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

                IDext.Text = "";
                Fnamext.Text = "";
                genderbox.Text = "";
                addressext.Text = "";
                emailext.Text = "";
                statusbox.Text = "";
                depbox.Text = "";
          

                NEWBTN.Enabled = true;
                UPDBTN.Enabled = false;
                DELBTN.Enabled = false;
            }
        }

        private void IDext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        }
    }


