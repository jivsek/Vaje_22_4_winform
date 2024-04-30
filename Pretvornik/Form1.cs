using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pretvornik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_pretvori.Enabled = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_pretvori_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_cm.Text.Length == 0)
                {
                    int ft = Int32.Parse(tb_ft.Text);
                    int inch = Int32.Parse(tb_inch.Text);

                    tb_cm.Text = (ft * 30.48 + inch * 2.54).ToString();
                }
                else
                {
                    int cm = Int32.Parse(tb_cm.Text);
                    int ft = (int)Math.Floor(cm / 30.48);
                    double inch = 12*((cm / 30.48) - ft);

                    tb_ft.Text = ft.ToString();
                    tb_inch.Text = inch.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_cm_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_cm.Text) && string.IsNullOrEmpty(tb_ft.Text) && string.IsNullOrEmpty(tb_inch.Text))
            {
                btn_pretvori.Enabled = false;
            }
            else if (string.IsNullOrEmpty(tb_cm.Text) && (string.IsNullOrEmpty(tb_ft.Text) || string.IsNullOrEmpty(tb_inch.Text)))
            {
                btn_pretvori.Enabled = false;
            }
            else if ((!string.IsNullOrEmpty(tb_ft.Text) && string.IsNullOrEmpty(tb_inch.Text)) || (string.IsNullOrEmpty(tb_ft.Text) && !string.IsNullOrEmpty(tb_inch.Text)))
            {
                btn_pretvori.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(tb_cm.Text) && !string.IsNullOrEmpty(tb_ft.Text) && !string.IsNullOrEmpty(tb_inch.Text))
            {
                btn_pretvori.Enabled = false;
            }
            else
            {
                btn_pretvori.Enabled = true;
            }
        }

        private void tb_ft_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_cm.Text) && string.IsNullOrEmpty(tb_ft.Text) && string.IsNullOrEmpty(tb_inch.Text))
            {
                btn_pretvori.Enabled = false;
            }
            else if (string.IsNullOrEmpty(tb_cm.Text) && (string.IsNullOrEmpty(tb_ft.Text) || string.IsNullOrEmpty(tb_inch.Text)))
            {
                btn_pretvori.Enabled = false;
            }
            else if ((!string.IsNullOrEmpty(tb_ft.Text) && string.IsNullOrEmpty(tb_inch.Text)) || (string.IsNullOrEmpty(tb_ft.Text) && !string.IsNullOrEmpty(tb_inch.Text)))
            {
                btn_pretvori.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(tb_cm.Text) && !string.IsNullOrEmpty(tb_ft.Text) && !string.IsNullOrEmpty(tb_inch.Text))
            {
                btn_pretvori.Enabled = false;
            }
            else
            {
                btn_pretvori.Enabled = true;
            }
        }

        private void tb_inch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_cm.Text) && string.IsNullOrEmpty(tb_ft.Text) && string.IsNullOrEmpty(tb_inch.Text))
            {
                btn_pretvori.Enabled = false;
            }
            else if (string.IsNullOrEmpty(tb_cm.Text) && (string.IsNullOrEmpty(tb_ft.Text) || string.IsNullOrEmpty(tb_inch.Text)))
            {
                btn_pretvori.Enabled = false;
            }
            else if ((!string.IsNullOrEmpty(tb_ft.Text) && string.IsNullOrEmpty(tb_inch.Text)) || (string.IsNullOrEmpty(tb_ft.Text) && !string.IsNullOrEmpty(tb_inch.Text)))
            {
                btn_pretvori.Enabled = false;
            }
            else if (!string.IsNullOrEmpty(tb_cm.Text) && !string.IsNullOrEmpty(tb_ft.Text) && !string.IsNullOrEmpty(tb_inch.Text))
            {
                btn_pretvori.Enabled = false;
            }
            else
            {
                btn_pretvori.Enabled = true;
            }
        }

        private void btn_pocisti_Click(object sender, EventArgs e)
        {
            tb_cm.Text = "";
            tb_ft.Text = "";
            tb_inch.Text = "";
        }
    }
}
