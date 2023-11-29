using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UP4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pct.Left + pct.Width + 10 > this.ClientSize.Width)
            {
                tmr.Enabled = true;
            }
            else
            {
                pct.Left += 10;
            }
        }

        private void btcStart_Click(object sender, EventArgs e)
        {
            tmr.Enabled = true;
            tmr.Interval = 50;
            if (btcStart.Text == "Старт")
            {
                btcStart.Text = "Стоп";
            }
            else
            {
                btcStart.Text = "Старт";
            }
            if (btcStart.Text == "Старт")
            {
                tmr.Enabled = false;
            }
            if (pct.Left + pct.Width + 10 > this.ClientSize.Width)
            {
                tmr.Enabled = false;
                pct.Left = 10;
            }
        }

        private void btcExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
