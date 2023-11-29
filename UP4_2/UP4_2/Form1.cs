using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(txtSeconds.Text);
            tmp += 1;
            txtSeconds.Text = tmp.ToString();
            if (tmp == 60)
            {
                txtSeconds.Text = 0.ToString();
                txtMinutes.Text += 1;
            }
        textBox1.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Enabled = false;
        }

        private void btnSbros_Click(object sender, EventArgs e)
        {
            txtMinutes.Text = "";
            txtSeconds.Text = "";
        }
    }
}
