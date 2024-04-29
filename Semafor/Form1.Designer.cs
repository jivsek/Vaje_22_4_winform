namespace Semafor
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
            this.btn_rdeca = new System.Windows.Forms.Button();
            this.btn_rumena = new System.Windows.Forms.Button();
            this.btn_zelena = new System.Windows.Forms.Button();
            this.pictureBox_semafor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_semafor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rdeca
            // 
            this.btn_rdeca.Location = new System.Drawing.Point(13, 13);
            this.btn_rdeca.Name = "btn_rdeca";
            this.btn_rdeca.Size = new System.Drawing.Size(104, 38);
            this.btn_rdeca.TabIndex = 0;
            this.btn_rdeca.Text = "Rdeča";
            this.btn_rdeca.UseVisualStyleBackColor = true;
            this.btn_rdeca.Click += new System.EventHandler(this.btn_rdeca_Click);
            // 
            // btn_rumena
            // 
            this.btn_rumena.Location = new System.Drawing.Point(13, 57);
            this.btn_rumena.Name = "btn_rumena";
            this.btn_rumena.Size = new System.Drawing.Size(104, 38);
            this.btn_rumena.TabIndex = 1;
            this.btn_rumena.Text = "Rumena";
            this.btn_rumena.UseVisualStyleBackColor = true;
            this.btn_rumena.Click += new System.EventHandler(this.btn_rumena_Click);
            // 
            // btn_zelena
            // 
            this.btn_zelena.Location = new System.Drawing.Point(13, 101);
            this.btn_zelena.Name = "btn_zelena";
            this.btn_zelena.Size = new System.Drawing.Size(104, 38);
            this.btn_zelena.TabIndex = 2;
            this.btn_zelena.Text = "Zelena";
            this.btn_zelena.UseVisualStyleBackColor = true;
            this.btn_zelena.Click += new System.EventHandler(this.btn_zelena_Click);
            // 
            // pictureBox_semafor
            // 
            this.pictureBox_semafor.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_semafor.Location = new System.Drawing.Point(123, 13);
            this.pictureBox_semafor.Name = "pictureBox_semafor";
            this.pictureBox_semafor.Size = new System.Drawing.Size(141, 126);
            this.pictureBox_semafor.TabIndex = 3;
            this.pictureBox_semafor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 162);
            this.Controls.Add(this.pictureBox_semafor);
            this.Controls.Add(this.btn_zelena);
            this.Controls.Add(this.btn_rumena);
            this.Controls.Add(this.btn_rdeca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_semafor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_rdeca;
        private System.Windows.Forms.Button btn_rumena;
        private System.Windows.Forms.Button btn_zelena;
        private System.Windows.Forms.PictureBox pictureBox_semafor;
    }
}

