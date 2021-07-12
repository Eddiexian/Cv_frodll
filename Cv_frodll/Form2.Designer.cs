namespace Cv_frodll
{
    partial class Form2
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
            this.sizebar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typebar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.srcpic = new System.Windows.Forms.PictureBox();
            this.dstpic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstpic)).BeginInit();
            this.SuspendLayout();
            // 
            // sizebar
            // 
            this.sizebar.Location = new System.Drawing.Point(32, 31);
            this.sizebar.Name = "sizebar";
            this.sizebar.Size = new System.Drawing.Size(201, 45);
            this.sizebar.TabIndex = 1;
            this.sizebar.Scroll += new System.EventHandler(this.sizebar_Scroll);
            this.sizebar.ValueChanged += new System.EventHandler(this.sizebar_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(249, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "kernel_size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(346, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "3";
            // 
            // typebar
            // 
            this.typebar.Location = new System.Drawing.Point(32, 83);
            this.typebar.Name = "typebar";
            this.typebar.Size = new System.Drawing.Size(201, 45);
            this.typebar.TabIndex = 4;
            this.typebar.Scroll += new System.EventHandler(this.typebar_Scroll);
            this.typebar.ValueChanged += new System.EventHandler(this.typebar_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(252, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "blur_type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(346, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Average";
            // 
            // srcpic
            // 
            this.srcpic.Location = new System.Drawing.Point(32, 181);
            this.srcpic.Name = "srcpic";
            this.srcpic.Size = new System.Drawing.Size(256, 256);
            this.srcpic.TabIndex = 7;
            this.srcpic.TabStop = false;
            // 
            // dstpic
            // 
            this.dstpic.Location = new System.Drawing.Point(330, 181);
            this.dstpic.Name = "dstpic";
            this.dstpic.Size = new System.Drawing.Size(256, 256);
            this.dstpic.TabIndex = 8;
            this.dstpic.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(32, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Source";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(330, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Blured";
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("新細明體", 12F);
            this.btn_ok.Location = new System.Drawing.Point(639, 414);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 11;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dstpic);
            this.Controls.Add(this.srcpic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typebar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizebar);
            this.Name = "Form2";
            this.Text = "Blur";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar sizebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar typebar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox srcpic;
        private System.Windows.Forms.PictureBox dstpic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ok;
    }
}