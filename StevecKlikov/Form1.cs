using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StevecKlikov
{
    public partial class Form1 : Form
    {
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label_counter.Text = $"ŠTEVEC KLIKOV {counter++}";
        }

        private void label_counter_Click(object sender, EventArgs e)
        {
            label_counter.Text = $"ŠTEVEC KLIKOV {counter++}";
        }
    }
}
