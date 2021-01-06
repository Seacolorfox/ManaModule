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
    public partial class detail : Form
    {
        MainForm MainForm;
        string userID;
        public detail(string userId)
        {
            InitializeComponent();
            userID = userId;
            renderView();
        }
        public detail(MainForm mainForm,string userId)
        {
            InitializeComponent();
            MainForm = mainForm;
            userID = userId;
            renderView();
        }
        public void renderView()
        {
            string sql = "select * from detail where userId = '" + userID + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                textBox_timeQ.Text = dr["TimeQ"].ToString();
                textBox_school.Text = dr["School"].ToString();
                textBox_certificate.Text = dr["Certificate"].ToString();
            }
            dr.Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox_timeQ = null;
            textBox_school = null;
            textBox_certificate = null;
        }

        private void Btn2_save_Click(object sender, EventArgs e)
        {
            string sql = "Insert into detail values('" + textBox_timeQ.Text + "','" + textBox_school.Text + "','" + textBox_certificate.Text + "','" + userID + "')"; 
              Dao dao = new Dao();
            int i = dao.Excute(sql);
            if (i > 0)
            {
                MessageBox.Show("操作成功");
                Close();
            }

        }
    }
}
