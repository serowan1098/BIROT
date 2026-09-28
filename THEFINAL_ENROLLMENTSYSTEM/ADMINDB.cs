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
    public partial class ADMINDB : Form
    {
        public ADMINDB()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form11().Show();
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
    }
}
