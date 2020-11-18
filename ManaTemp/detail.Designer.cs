namespace ManaTemp
{
    partial class detail
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_timeQ = new System.Windows.Forms.TextBox();
            this.textBox_school = new System.Windows.Forms.TextBox();
            this.textBox_certificate = new System.Windows.Forms.TextBox();
            this.btn2_save = new System.Windows.Forms.Button();
            this.btn2_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间段：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "教育经历：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "学校：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "所获证书：";
            // 
            // textBox_timeQ
            // 
            this.textBox_timeQ.Location = new System.Drawing.Point(159, 96);
            this.textBox_timeQ.Name = "textBox_timeQ";
            this.textBox_timeQ.Size = new System.Drawing.Size(214, 25);
            this.textBox_timeQ.TabIndex = 4;
            // 
            // textBox_school
            // 
            this.textBox_school.Location = new System.Drawing.Point(159, 167);
            this.textBox_school.Name = "textBox_school";
            this.textBox_school.Size = new System.Drawing.Size(214, 25);
            this.textBox_school.TabIndex = 5;
            // 
            // textBox_certificate
            // 
            this.textBox_certificate.Location = new System.Drawing.Point(159, 227);
            this.textBox_certificate.Multiline = true;
            this.textBox_certificate.Name = "textBox_certificate";
            this.textBox_certificate.Size = new System.Drawing.Size(214, 115);
            this.textBox_certificate.TabIndex = 6;
            // 
            // btn2_save
            // 
            this.btn2_save.Location = new System.Drawing.Point(96, 362);
            this.btn2_save.Name = "btn2_save";
            this.btn2_save.Size = new System.Drawing.Size(75, 39);
            this.btn2_save.TabIndex = 7;
            this.btn2_save.Text = "保存";
            this.btn2_save.UseVisualStyleBackColor = true;
            this.btn2_save.Click += new System.EventHandler(this.Btn2_save_Click);
            // 
            // btn2_clear
            // 
            this.btn2_clear.Location = new System.Drawing.Point(256, 362);
            this.btn2_clear.Name = "btn2_clear";
            this.btn2_clear.Size = new System.Drawing.Size(75, 39);
            this.btn2_clear.TabIndex = 8;
            this.btn2_clear.Text = "清除";
            this.btn2_clear.UseVisualStyleBackColor = true;
            this.btn2_clear.Click += new System.EventHandler(this.Button2_Click);
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 413);
            this.Controls.Add(this.btn2_clear);
            this.Controls.Add(this.btn2_save);
            this.Controls.Add(this.textBox_certificate);
            this.Controls.Add(this.textBox_school);
            this.Controls.Add(this.textBox_timeQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "detail";
            this.Text = "detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_timeQ;
        private System.Windows.Forms.TextBox textBox_school;
        private System.Windows.Forms.TextBox textBox_certificate;
        private System.Windows.Forms.Button btn2_save;
        private System.Windows.Forms.Button btn2_clear;
    }
}