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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Fnamext.Text = listView1.SelectedItems[0].SubItems[0].Text;
                Mnamext.Text = listView1.SelectedItems[0].SubItems[1].Text;
                Lnamext.Text = listView1.SelectedItems[0].SubItems[2].Text;
                agext.Text = listView1.SelectedItems[0].SubItems[3].Text;
                genderbox.Text = listView1.SelectedItems[0].SubItems[4].Text;
                dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[5].Text;
                addressext.Text = listView1.SelectedItems[0].SubItems[6].Text;
                emailext.Text = listView1.SelectedItems[0].SubItems[7].Text;
                Cnoext.Text = listView1.SelectedItems[0].SubItems[8].Text;
                Csext.Text = listView1.SelectedItems[0].SubItems[9].Text;
                Nationext.Text = listView1.SelectedItems[0].SubItems[10].Text;
                Regionext.Text = listView1.SelectedItems[0].SubItems[11].Text;
                Enext.Text = listView1.SelectedItems[0].SubItems[12].Text;
                IDext.Text = listView1.SelectedItems[0].SubItems[13].Text;
                coursebox.Text = listView1.SelectedItems[0].SubItems[14].Text;

                Fnamext.Enabled = true;
                Mnamext.Enabled = true;
                Lnamext.Enabled = true;
                agext.Enabled = true;
                genderbox.Enabled = true;
                dateTimePicker1.Enabled = true;
                addressext.Enabled = true;
                emailext.Enabled = true;
                Cnoext.Enabled = true;
                Csext.Enabled = true;
                Nationext.Enabled = true;
                Regionext.Enabled = true;
                Enext.Enabled = true;
                IDext.Enabled = true;
                coursebox.Enabled = true;






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
            listView1.Columns.Add("FIRST NAME", 120);
            listView1.Columns.Add("MIDDLE NAME", 120);
            listView1.Columns.Add("LAST NAME", 120);
            listView1.Columns.Add("AGE", 50);
            listView1.Columns.Add("GENDER", 120);
            listView1.Columns.Add("DATE OF BIRTH", 120);
            listView1.Columns.Add("ADDRESS", 120);
            listView1.Columns.Add("EMAIL ADDRESS", 120);
            listView1.Columns.Add("CONTACT NUMBER", 120);
            listView1.Columns.Add("CIVIL STATUS", 120);
            listView1.Columns.Add("NATIONALITY", 120);
            listView1.Columns.Add("REGION", 120);
            listView1.Columns.Add("EMERGENCY NO.", 120);
            listView1.Columns.Add("ID NUMBER", 120);
            listView1.Columns.Add("COURSE", 120);
        }

        private void NEWBTN_Click(object sender, EventArgs e)
        {
            Fnamext.Enabled = true;
            Mnamext.Enabled = true;
            Lnamext.Enabled = true;
            agext.Enabled = true;
            genderbox.Enabled = true;      
            addressext.Enabled = true;
            dateTimePicker1.Enabled = true;
            emailext.Enabled = true;
            Cnoext.Enabled = true;
            Csext.Enabled = true;
            Nationext.Enabled = true;
            Regionext.Enabled = true;
            Enext.Enabled = true;
            IDext.Enabled = true;
            coursebox.Enabled = true;
            NEWBTN.Enabled = false;
            ADDBTN.Enabled = true;
        }

        private void ADDBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Fnamext.Text) || string.IsNullOrWhiteSpace(Mnamext.Text) ||
                string.IsNullOrWhiteSpace(Lnamext.Text) || string.IsNullOrWhiteSpace(agext.Text) ||
                string.IsNullOrWhiteSpace(genderbox.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                string.IsNullOrWhiteSpace(Cnoext.Text) || string.IsNullOrWhiteSpace(Csext.Text) ||
                string.IsNullOrWhiteSpace(Nationext.Text) || string.IsNullOrWhiteSpace(Regionext.Text) ||
                string.IsNullOrWhiteSpace(Enext.Text) || string.IsNullOrWhiteSpace(IDext.Text) ||
                string.IsNullOrWhiteSpace(coursebox.Text))
            {
                MessageBox.Show("Fill Empty.");
            }
            else
            {

                ListViewItem Birot = new ListViewItem(Fnamext.Text);
                Birot.SubItems.Add(Mnamext.Text);
                Birot.SubItems.Add(Lnamext.Text);
                Birot.SubItems.Add(agext.Text);
                Birot.SubItems.Add(genderbox.Text);
                Birot.SubItems.Add(dateTimePicker1.Text);
                Birot.SubItems.Add(addressext.Text);
                Birot.SubItems.Add(emailext.Text);
                Birot.SubItems.Add(Cnoext.Text);
                Birot.SubItems.Add(Csext.Text);
                Birot.SubItems.Add(Nationext.Text);
                Birot.SubItems.Add(Regionext.Text);
                Birot.SubItems.Add(Enext.Text);
                Birot.SubItems.Add(IDext.Text);
                Birot.SubItems.Add(coursebox.Text);





                listView1.Items.Add(Birot);
                ADDBTN.Enabled = false;
                NEWBTN.Enabled = true;

                Fnamext.Text = "";
                Mnamext.Text = "";
                Lnamext.Text = "";
                agext.Text = "";
                genderbox.Text = "";
                dateTimePicker1.Text = "";
                addressext.Text = "";
                emailext.Text = "";
                Cnoext.Text = "";
                Csext.Text = "";
                Nationext.Text = "";
                Regionext.Text = "";
                Enext.Text = "";
                IDext.Text = "";
                coursebox.Text = "";

                Fnamext.Enabled = false;
                Mnamext.Enabled = false;
                Lnamext.Enabled = false;
                agext.Enabled = false;
                genderbox.Enabled = false;
                addressext.Enabled = false;
                dateTimePicker1.Enabled = false;
                emailext.Enabled = false;
                Cnoext.Enabled = false;
                Csext.Enabled = false;
                Nationext.Enabled = false;
                Regionext.Enabled = false;
                Enext.Enabled = false;
                IDext.Enabled = false;
                coursebox.Enabled = false;
                MessageBox.Show("Added Successfuly!");

            }
        }

        private void UPDBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Fnamext.Text) || string.IsNullOrWhiteSpace(Mnamext.Text) ||
                  string.IsNullOrWhiteSpace(Lnamext.Text) || string.IsNullOrWhiteSpace(agext.Text) ||
                  string.IsNullOrWhiteSpace(genderbox.Text) || string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                  string.IsNullOrWhiteSpace(Cnoext.Text) || string.IsNullOrWhiteSpace(Csext.Text) ||
                  string.IsNullOrWhiteSpace(Nationext.Text) || string.IsNullOrWhiteSpace(Regionext.Text) ||
                  string.IsNullOrWhiteSpace(Enext.Text) || string.IsNullOrWhiteSpace(IDext.Text) ||
                  string.IsNullOrWhiteSpace(coursebox.Text))
            {
                MessageBox.Show("Fill Empty.");
            }
            else
            {
                listView1.SelectedItems[0].SubItems[0].Text = Fnamext.Text;
                listView1.SelectedItems[0].SubItems[1].Text = Mnamext.Text;
                listView1.SelectedItems[0].SubItems[2].Text = Lnamext.Text;
                listView1.SelectedItems[0].SubItems[3].Text = agext.Text;
                listView1.SelectedItems[0].SubItems[4].Text = genderbox.Text;
                listView1.SelectedItems[0].SubItems[5].Text = dateTimePicker1.Text;
                listView1.SelectedItems[0].SubItems[6].Text = addressext.Text;
                listView1.SelectedItems[0].SubItems[7].Text = emailext.Text;
                listView1.SelectedItems[0].SubItems[8].Text = Cnoext.Text;
                listView1.SelectedItems[0].SubItems[9].Text = Csext.Text;
                listView1.SelectedItems[0].SubItems[10].Text = Nationext.Text;
                listView1.SelectedItems[0].SubItems[11].Text = Regionext.Text;
                listView1.SelectedItems[0].SubItems[12].Text = Enext.Text;
                listView1.SelectedItems[0].SubItems[13].Text = IDext.Text;
                listView1.SelectedItems[0].SubItems[14].Text = coursebox.Text;

                Fnamext.Text = "";
                Mnamext.Text = "";
                Lnamext.Text = "";
                agext.Text = "";
                genderbox.Text = "";
                dateTimePicker1.Text = "";
                addressext.Text = "";
                emailext.Text = "";
                Cnoext.Text = "";
                Csext.Text = "";
                Nationext.Text = "";
                Regionext.Text = "";
                Enext.Text = "";
                IDext.Text = "";
                coursebox.Text = "";

                Fnamext.Enabled = false;
                Mnamext.Enabled = false;
                Lnamext.Enabled = false;
                agext.Enabled = false;
                genderbox.Enabled = false;
                addressext.Enabled = false;
                dateTimePicker1.Enabled = false;
                emailext.Enabled = false;
                Cnoext.Enabled = false;
                Csext.Enabled = false;
                Nationext.Enabled = false;
                Regionext.Enabled = false;
                Enext.Enabled = false;
                IDext.Enabled = false;
                coursebox.Enabled = false;

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

                Fnamext.Text = "";
                Mnamext.Text = "";
                Lnamext.Text = "";
                agext.Text = "";
                genderbox.Text = "";
                dateTimePicker1.Text = "";
                addressext.Text = "";
                emailext.Text = "";
                Cnoext.Text = "";
                Csext.Text = "";
                Nationext.Text = "";
                Regionext.Text = "";
                Enext.Text = "";
                IDext.Text = "";
                coursebox.Text = "";

                Fnamext.Enabled = false;
                Mnamext.Enabled = false;
                Lnamext.Enabled = false;
                agext.Enabled = false;
                genderbox.Enabled = false;
                addressext.Enabled = false;
                dateTimePicker1.Enabled = false;
                emailext.Enabled = false;
                Cnoext.Enabled = false;
                Csext.Enabled = false;
                Nationext.Enabled = false;
                Regionext.Enabled = false;
                Enext.Enabled = false;
                IDext.Enabled = false;
                coursebox.Enabled = false;

                NEWBTN.Enabled = true;
                UPDBTN.Enabled = false;
                DELBTN.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ADMINDB().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form12().Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new LOGIN().Show();
            this.Hide();

        }

        private void agext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cnoext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Enext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
