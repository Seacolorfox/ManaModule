using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManaTemp
{
    public partial class AddForm : Form
    {
        Random R = new Random();
        MainForm MainForm;
        string IDplus;
        string[] acStr = new string[9];
        string tel;
        int status=1;
        string userId;
        public AddForm(MainForm mainForm)
        {
            InitializeComponent();
            btn_update.Visible = false;
            MainForm = mainForm;
        }
        public AddForm(string[] str,MainForm mainForm)
        {
            InitializeComponent();
            for(int i = 0;i<9;i++)
            {
                acStr[i] = str[i];
            }
            userId = acStr[0];
            textBox_name.Text = acStr[1];
            comboBox_sex.Text = acStr[2];
            textBox_nativePlace.Text = acStr[3];
            textBox_phone.Text = acStr[4];
            dateTimePicker.Text = acStr[5];
            textBox_hobby.Text = acStr[7];
            textBox_eduExp.Text = acStr[8];
            btn_save.Visible = false;
            MainForm = mainForm;
        }
        private void Btn_save_Click(object sender, EventArgs e)
        {
            if(comboBox_sex.Text.Equals("男"))
            {
                IDplus = "M" + R.Next(1000, 9999);
            }
            else
            {
                IDplus = "F"+ R.Next(1000, 9999);
            }
            int age = DateTime.Now.Year-dateTimePicker.Value.Year;
            tel = textBox_phone.Text.Trim();
            if (textBox_name.Text == "" || comboBox_sex.Text == "" || textBox_nativePlace.Text == "" || tel == "" || dateTimePicker.Text == "" || textBox_hobby.Text == "" || textBox_eduExp.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(textBox_phone.Text.Length !=11)
                {
                    MessageBox.Show("输入格式不正确，需要11位电话号码，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    status = 0;
                }
                //Regex
                if(!System.Text.RegularExpressions.Regex.IsMatch(tel, @"^((0?1[3578]\d{9})|((0(10|2[1-3]|[3-9]\d{2}))?[1-9]\d{6,7}))$"))
                {
                    MessageBox.Show("您输入的电话格式不合法！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    status = 0;
                }
                if (age > 0 && age <= 150)
                {
                    if(status==1)
                    {
                        string sql = "Insert into userInfo values('" + IDplus + "','" + textBox_name.Text + "','" + comboBox_sex.Text + "','" + textBox_nativePlace.Text + "','" + textBox_phone.Text + "','" + dateTimePicker.Text + "','" + age + "','" + textBox_hobby.Text + "','" + textBox_eduExp.Text + "')";
                        Dao dao = new Dao();
                        int i = dao.Excute(sql);
                        if (i > 0)
                        {
                            MessageBox.Show("添加成功");
                            textBox_name.Text = null;
                            comboBox_sex.Text = null;
                            textBox_nativePlace.Text = null;
                            textBox_phone.Text = null;
                            dateTimePicker.Text = null;
                            textBox_hobby.Text = null;
                            textBox_eduExp.Text = null;
                            MainForm.renderView();
                            Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("请输入正确的年龄");
                }
                
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            //Cancel Selected
            checkedListBox_hobby.ClearSelected();
            foreach (int i in checkedListBox_hobby.CheckedIndices)
            {
                checkedListBox_hobby.SetItemChecked(i, false);
            }
            textBox_name.Text = null;
            comboBox_sex.Text = null;
            textBox_nativePlace.Text = null;
            textBox_phone.Text = null;
            dateTimePicker.Text = null;
            textBox_hobby.Text = null;
            textBox_eduExp.Text = null;

        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" || comboBox_sex.Text == "" || textBox_nativePlace.Text == "" || textBox_phone.Text == "" || dateTimePicker.Text == "" || textBox_hobby.Text == "" || textBox_eduExp.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql_delete = "delete from userInfo where Id = '" + acStr[0] + "'and Name = '" + acStr[1] + "'";
                string sql_update = "Insert into userInfo values('" + acStr[0] + "','" + textBox_name.Text + "','" + comboBox_sex.Text + "','" + textBox_nativePlace.Text + "','" + textBox_phone.Text + "','" + dateTimePicker.Text + "','" + acStr[6] + "','" + textBox_hobby.Text + "','" + textBox_eduExp.Text + "')";
                Dao dao = new Dao();
                dao.Excute(sql_delete);
                dao.Excute(sql_update);
                MessageBox.Show("修改成功！");
                Close();
                MainForm.renderView();
            }
        }
        //动态添加
        private void CheckedListBox_hobby_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sb = "";
            for (int i = 0; i < checkedListBox_hobby.Items.Count; i++)
            {
                if (checkedListBox_hobby.GetItemChecked(i))
                {
                    sb += checkedListBox_hobby.GetItemText(checkedListBox_hobby.Items[i]);
                    textBox_hobby.Text = sb;
                }
            }
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            detail detail = new detail(userId);
            detail.ShowDialog();
        }
    }
}
