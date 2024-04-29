namespace Casovnik
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_start_stop = new System.Windows.Forms.Button();
            this.label_speed = new System.Windows.Forms.Label();
            this.btn_faster = new System.Windows.Forms.Button();
            this.btn_slower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_timer.Location = new System.Drawing.Point(113, 25);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(202, 76);
            this.lbl_timer.TabIndex = 0;
            this.lbl_timer.Text = "Timer";
            // 
            // btn_start_stop
            // 
            this.btn_start_stop.Location = new System.Drawing.Point(145, 138);
            this.btn_start_stop.Name = "btn_start_stop";
            this.btn_start_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_start_stop.TabIndex = 1;
            this.btn_start_stop.Text = "Stop";
            this.btn_start_stop.UseVisualStyleBackColor = true;
            this.btn_start_stop.Click += new System.EventHandler(this.btn_start_stop_Click);
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_speed.Location = new System.Drawing.Point(163, 174);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(37, 29);
            this.label_speed.TabIndex = 2;
            this.label_speed.Text = "1x";
            // 
            // btn_faster
            // 
            this.btn_faster.Location = new System.Drawing.Point(206, 180);
            this.btn_faster.Name = "btn_faster";
            this.btn_faster.Size = new System.Drawing.Size(75, 23);
            this.btn_faster.TabIndex = 3;
            this.btn_faster.Text = ">>";
            this.btn_faster.UseVisualStyleBackColor = true;
            this.btn_faster.Click += new System.EventHandler(this.btn_faster_Click);
            // 
            // btn_slower
            // 
            this.btn_slower.Location = new System.Drawing.Point(82, 180);
            this.btn_slower.Name = "btn_slower";
            this.btn_slower.Size = new System.Drawing.Size(75, 23);
            this.btn_slower.TabIndex = 4;
            this.btn_slower.Text = "<<";
            this.btn_slower.UseVisualStyleBackColor = true;
            this.btn_slower.Click += new System.EventHandler(this.btn_slower_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 234);
            this.Controls.Add(this.btn_slower);
            this.Controls.Add(this.btn_faster);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.btn_start_stop);
            this.Controls.Add(this.lbl_timer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_start_stop;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Button btn_faster;
        private System.Windows.Forms.Button btn_slower;
    }
}

