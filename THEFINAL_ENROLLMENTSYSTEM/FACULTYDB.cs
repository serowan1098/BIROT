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
    public partial class FACULTYDB : Form
    {
        public FACULTYDB()
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

        private void button3_Click(object sender, EventArgs e)
        {
            new Form10().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new LOGIN().Show();
            this.Hide();
        }
    }
}
