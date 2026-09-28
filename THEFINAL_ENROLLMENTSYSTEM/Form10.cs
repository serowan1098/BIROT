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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new LOGIN().Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("STUDENT ID", 100);
            listView1.Columns.Add("NAME", 150);
            listView1.Columns.Add("SUBJECT", 120);
            listView1.Columns.Add("DATE", 150);
            listView1.Columns.Add("GRADE", 100);
            listView1.Columns.Add("GRADE PERIOD", 150);


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                comboBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[3].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[4].Text;
                comboBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                comboBox1.Enabled = true;
                dateTimePicker1.Enabled = true;
                textBox3.Enabled = true;
                comboBox2.Enabled = true;


                newbtn.Enabled = false;
                updbtn.Enabled = true;
                delbtn.Enabled = true;

            }
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            comboBox1.Enabled = true;
            dateTimePicker1.Enabled = true;
            textBox3.Enabled = true;
            comboBox2.Enabled = true;
            newbtn.Enabled = false;
            addbtn.Enabled = true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Fill Empty.");
            }
            else
            {
                ListViewItem Birot = new ListViewItem(textBox1.Text);
                Birot.SubItems.Add(textBox2.Text);
                Birot.SubItems.Add(comboBox1.Text);
                Birot.SubItems.Add(dateTimePicker1.Text);
                Birot.SubItems.Add(textBox3.Text);
                Birot.SubItems.Add(comboBox2.Text);

                listView1.Items.Add(Birot);
                addbtn.Enabled = false;
                newbtn.Enabled = true;


                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                textBox3.Text = "";
                comboBox2.Text = "";

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                comboBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
                textBox3.Enabled = false;
                comboBox2.Enabled = false;
                MessageBox.Show("Added Successfuly!");
            }
        }

        private void updbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Fill Empty.");
            }
            else
            {

                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[2].Text = comboBox1.Text;
                listView1.SelectedItems[0].SubItems[3].Text = dateTimePicker1.Text;
                listView1.SelectedItems[0].SubItems[4].Text = textBox3.Text;
                listView1.SelectedItems[0].SubItems[5].Text = comboBox2.Text;

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                textBox3.Text = "";
                comboBox2.Text = "";

                newbtn.Enabled = true;
                updbtn.Enabled = false;
                delbtn.Enabled = false;
            }



        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);

                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                textBox3.Text = "";
                comboBox2.Text = "";

                newbtn.Enabled = true;
                updbtn.Enabled = false;
                delbtn.Enabled = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }




    }
}
