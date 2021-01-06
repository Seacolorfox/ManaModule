namespace ManaTemp
{
    partial class AddForm
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_nativePlace = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_hobby = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_sex = new System.Windows.Forms.ComboBox();
            this.textBox_eduExp = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.checkedListBox_hobby = new System.Windows.Forms.CheckedListBox();
            this.btn_detail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(136, 20);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(170, 25);
            this.textBox_name.TabIndex = 0;
            // 
            // textBox_nativePlace
            // 
            this.textBox_nativePlace.Location = new System.Drawing.Point(136, 123);
            this.textBox_nativePlace.Name = "textBox_nativePlace";
            this.textBox_nativePlace.Size = new System.Drawing.Size(170, 25);
            this.textBox_nativePlace.TabIndex = 2;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(136, 178);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(170, 25);
            this.textBox_phone.TabIndex = 3;
            // 
            // textBox_hobby
            // 
            this.textBox_hobby.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_hobby.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_hobby.Location = new System.Drawing.Point(136, 277);
            this.textBox_hobby.Multiline = true;
            this.textBox_hobby.Name = "textBox_hobby";
            this.textBox_hobby.Size = new System.Drawing.Size(170, 27);
            this.textBox_hobby.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "籍贯：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "手机：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "出生年月：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "兴趣爱好：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "教育经历：";
            // 
            // comboBox_sex
            // 
            this.comboBox_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sex.FormattingEnabled = true;
            this.comboBox_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox_sex.Location = new System.Drawing.Point(136, 73);
            this.comboBox_sex.Name = "comboBox_sex";
            this.comboBox_sex.Size = new System.Drawing.Size(170, 23);
            this.comboBox_sex.TabIndex = 13;
            // 
            // textBox_eduExp
            // 
            this.textBox_eduExp.Location = new System.Drawing.Point(136, 405);
            this.textBox_eduExp.Name = "textBox_eduExp";
            this.textBox_eduExp.Size = new System.Drawing.Size(105, 25);
            this.textBox_eduExp.TabIndex = 14;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(136, 227);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(170, 25);
            this.dateTimePicker.TabIndex = 15;
            this.dateTimePicker.Value = new System.DateTime(2020, 11, 16, 11, 24, 31, 0);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(54, 440);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 33);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(200, 440);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 33);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(54, 440);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 33);
            this.btn_update.TabIndex = 18;
            this.btn_update.Text = "修改";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // checkedListBox_hobby
            // 
            this.checkedListBox_hobby.CheckOnClick = true;
            this.checkedListBox_hobby.FormattingEnabled = true;
            this.checkedListBox_hobby.Items.AddRange(new object[] {
            "音乐",
            "电影",
            "运动",
            "旅游"});
            this.checkedListBox_hobby.Location = new System.Drawing.Point(136, 310);
            this.checkedListBox_hobby.Name = "checkedListBox_hobby";
            this.checkedListBox_hobby.Size = new System.Drawing.Size(170, 84);
            this.checkedListBox_hobby.TabIndex = 19;
            this.checkedListBox_hobby.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox_hobby_SelectedIndexChanged);
            // 
            // btn_detail
            // 
            this.btn_detail.Font = new System.Drawing.Font("微软雅黑", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_detail.Location = new System.Drawing.Point(247, 400);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(59, 33);
            this.btn_detail.TabIndex = 20;
            this.btn_detail.Text = "详细";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 506);
            this.Controls.Add(this.btn_detail);
            this.Controls.Add(this.checkedListBox_hobby);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBox_eduExp);
            this.Controls.Add(this.comboBox_sex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_hobby);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_nativePlace);
            this.Controls.Add(this.textBox_name);
            this.Name = "AddForm";
            this.Text = "用户信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_nativePlace;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_hobby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_sex;
        private System.Windows.Forms.TextBox textBox_eduExp;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.CheckedListBox checkedListBox_hobby;
        private System.Windows.Forms.Button btn_detail;
    }
}