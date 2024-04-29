using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semafor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_rdeca_Click(object sender, EventArgs e)
        {
            pictureBox_semafor.BackColor = Color.Red;
        }

        private void btn_rumena_Click(object sender, EventArgs e)
        {
            pictureBox_semafor.BackColor = Color.Yellow;
        }

        private void btn_zelena_Click(object sender, EventArgs e)
        {
            pictureBox_semafor.BackColor = Color.Green;
        }
    }
}
