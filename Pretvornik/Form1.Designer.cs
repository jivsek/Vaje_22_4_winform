namespace Pretvornik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_pretvori = new System.Windows.Forms.Button();
            this.tb_cm = new System.Windows.Forms.TextBox();
            this.tb_ft = new System.Windows.Forms.TextBox();
            this.tb_inch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_pocisti = new System.Windows.Forms.Button();
            this.btn_kviz = new System.Windows.Forms.Button();
            this.btn_resitev = new System.Windows.Forms.Button();
            this.lbl_res_ft = new System.Windows.Forms.Label();
            this.lbl_res_inch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_pretvori
            // 
            this.btn_pretvori.Location = new System.Drawing.Point(311, 134);
            this.btn_pretvori.Name = "btn_pretvori";
            this.btn_pretvori.Size = new System.Drawing.Size(105, 34);
            this.btn_pretvori.TabIndex = 0;
            this.btn_pretvori.Text = "PRETVORI";
            this.btn_pretvori.UseVisualStyleBackColor = true;
            this.btn_pretvori.Click += new System.EventHandler(this.btn_pretvori_Click);
            // 
            // tb_cm
            // 
            this.tb_cm.Location = new System.Drawing.Point(122, 148);
            this.tb_cm.Multiline = true;
            this.tb_cm.Name = "tb_cm";
            this.tb_cm.Size = new System.Drawing.Size(97, 20);
            this.tb_cm.TabIndex = 1;
            this.tb_cm.TextChanged += new System.EventHandler(this.tb_cm_TextChanged);
            // 
            // tb_ft
            // 
            this.tb_ft.Location = new System.Drawing.Point(505, 148);
            this.tb_ft.Multiline = true;
            this.tb_ft.Name = "tb_ft";
            this.tb_ft.Size = new System.Drawing.Size(97, 20);
            this.tb_ft.TabIndex = 2;
            this.tb_ft.TextChanged += new System.EventHandler(this.tb_ft_TextChanged);
            // 
            // tb_inch
            // 
            this.tb_inch.Location = new System.Drawing.Point(639, 148);
            this.tb_inch.Multiline = true;
            this.tb_inch.Name = "tb_inch";
            this.tb_inch.Size = new System.Drawing.Size(97, 20);
            this.tb_inch.TabIndex = 3;
            this.tb_inch.TextChanged += new System.EventHandler(this.tb_inch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(118, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(635, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "inch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(501, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ft";
            // 
            // btn_pocisti
            // 
            this.btn_pocisti.Location = new System.Drawing.Point(325, 174);
            this.btn_pocisti.Name = "btn_pocisti";
            this.btn_pocisti.Size = new System.Drawing.Size(75, 23);
            this.btn_pocisti.TabIndex = 9;
            this.btn_pocisti.Text = "POČISTI";
            this.btn_pocisti.UseVisualStyleBackColor = true;
            this.btn_pocisti.Click += new System.EventHandler(this.btn_pocisti_Click);
            // 
            // btn_kviz
            // 
            this.btn_kviz.Location = new System.Drawing.Point(325, 73);
            this.btn_kviz.Name = "btn_kviz";
            this.btn_kviz.Size = new System.Drawing.Size(75, 23);
            this.btn_kviz.TabIndex = 10;
            this.btn_kviz.Text = "Kviz";
            this.btn_kviz.UseVisualStyleBackColor = true;
            this.btn_kviz.Click += new System.EventHandler(this.btn_kviz_Click);
            // 
            // btn_resitev
            // 
            this.btn_resitev.Location = new System.Drawing.Point(325, 102);
            this.btn_resitev.Name = "btn_resitev";
            this.btn_resitev.Size = new System.Drawing.Size(75, 23);
            this.btn_resitev.TabIndex = 11;
            this.btn_resitev.Text = "Rešitev";
            this.btn_resitev.UseVisualStyleBackColor = true;
            this.btn_resitev.Click += new System.EventHandler(this.btn_resitev_Click);
            // 
            // lbl_res_ft
            // 
            this.lbl_res_ft.AutoSize = true;
            this.lbl_res_ft.ForeColor = System.Drawing.Color.Green;
            this.lbl_res_ft.Location = new System.Drawing.Point(502, 174);
            this.lbl_res_ft.Name = "lbl_res_ft";
            this.lbl_res_ft.Size = new System.Drawing.Size(0, 13);
            this.lbl_res_ft.TabIndex = 12;
            // 
            // lbl_res_inch
            // 
            this.lbl_res_inch.AutoSize = true;
            this.lbl_res_inch.ForeColor = System.Drawing.Color.Green;
            this.lbl_res_inch.Location = new System.Drawing.Point(636, 174);
            this.lbl_res_inch.Name = "lbl_res_inch";
            this.lbl_res_inch.Size = new System.Drawing.Size(0, 13);
            this.lbl_res_inch.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 226);
            this.Controls.Add(this.lbl_res_inch);
            this.Controls.Add(this.lbl_res_ft);
            this.Controls.Add(this.btn_resitev);
            this.Controls.Add(this.btn_kviz);
            this.Controls.Add(this.btn_pocisti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_inch);
            this.Controls.Add(this.tb_ft);
            this.Controls.Add(this.tb_cm);
            this.Controls.Add(this.btn_pretvori);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pretvori;
        private System.Windows.Forms.TextBox tb_cm;
        private System.Windows.Forms.TextBox tb_ft;
        private System.Windows.Forms.TextBox tb_inch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_pocisti;
        private System.Windows.Forms.Button btn_kviz;
        private System.Windows.Forms.Button btn_resitev;
        private System.Windows.Forms.Label lbl_res_ft;
        private System.Windows.Forms.Label lbl_res_inch;
    }
}

