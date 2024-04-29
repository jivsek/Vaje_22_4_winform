using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casovnik
{
    public partial class Form1 : Form
    {
        private double inter = 100;
        private double time = 0;
        private double speed = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = (int)inter;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 0.1*speed;
            time = Math.Round(time, 4);
            lbl_timer.Text = time.ToString();
        }

        private void btn_start_stop_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btn_start_stop.Text = "Start";
            }
            else
            {
                timer1.Start();
                btn_start_stop.Text = "Stop";
            }
            
        }

        private void btn_faster_Click(object sender, EventArgs e)
        {
            speed += 0.1;
            string txt = $"{speed}x";
            label_speed.Text = txt;
        }

        private void btn_slower_Click(object sender, EventArgs e)
        {
            if (speed >= 0.2)
            {
                speed -= 0.1;
            }
            string txt = $"{speed}x";
            label_speed.Text = txt;
        }
    }
}
