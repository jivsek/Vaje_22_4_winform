namespace LeviInDesni
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
            this.gmb_levi = new System.Windows.Forms.Button();
            this.gmb_desni = new System.Windows.Forms.Button();
            this.label_levi_desni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gmb_levi
            // 
            this.gmb_levi.Location = new System.Drawing.Point(32, 44);
            this.gmb_levi.Name = "gmb_levi";
            this.gmb_levi.Size = new System.Drawing.Size(118, 33);
            this.gmb_levi.TabIndex = 0;
            this.gmb_levi.Text = "Levi";
            this.gmb_levi.UseVisualStyleBackColor = true;
            this.gmb_levi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gmb_levi_MouseDown);
            this.gmb_levi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zbrisi);
            // 
            // gmb_desni
            // 
            this.gmb_desni.Location = new System.Drawing.Point(284, 44);
            this.gmb_desni.Name = "gmb_desni";
            this.gmb_desni.Size = new System.Drawing.Size(118, 33);
            this.gmb_desni.TabIndex = 1;
            this.gmb_desni.Text = "Desni";
            this.gmb_desni.UseVisualStyleBackColor = true;
            this.gmb_desni.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gmb_desni_MouseDown);
            this.gmb_desni.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zbrisi);
            // 
            // label_levi_desni
            // 
            this.label_levi_desni.AutoSize = true;
            this.label_levi_desni.Location = new System.Drawing.Point(182, 63);
            this.label_levi_desni.Name = "label_levi_desni";
            this.label_levi_desni.Size = new System.Drawing.Size(0, 13);
            this.label_levi_desni.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 108);
            this.Controls.Add(this.label_levi_desni);
            this.Controls.Add(this.gmb_desni);
            this.Controls.Add(this.gmb_levi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gmb_levi;
        private System.Windows.Forms.Button gmb_desni;
        private System.Windows.Forms.Label label_levi_desni;
    }
}

