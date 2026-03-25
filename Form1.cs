using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignments_Topic_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            imgGood.Visible = true;
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            imgBad.Visible = true;
        }

        private void imgBad_Click(object sender, EventArgs e)
        {

        }
    }
}
