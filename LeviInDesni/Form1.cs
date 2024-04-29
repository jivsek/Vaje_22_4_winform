using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeviInDesni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zbrisi(object sender, MouseEventArgs e)
        {
            label_levi_desni.Text = "";
        }

        private void gmb_levi_MouseDown(object sender, MouseEventArgs e)
        {
            label_levi_desni.Text = "<- pritisnjen";
        }

        private void gmb_desni_MouseDown(object sender, MouseEventArgs e)
        {
            label_levi_desni.Text = "pritisnjen ->";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
