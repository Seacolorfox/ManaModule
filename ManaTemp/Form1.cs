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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            renderView();
        }
        public void renderView()
        {
            mainGridView.Rows.Clear();
            string sql = "select * from userInfo";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string r1,r2,r3,r4,r5,r6,r7,r8,r9;
                r1 = dr["Id"].ToString();
                r2 = dr["Name"].ToString();
                r3 = dr["Sex"].ToString();
                r4 = dr["NativePlace"].ToString();
                r5 = dr["Phone"].ToString();
                r6 = dr["Birthday"].ToString();
                r7 = dr["Age"].ToString();
                r8 = dr["Hobby"].ToString();
                r9 = dr["EduExp"].ToString();

                string[] str = { r1, r2, r3, r4, r5, r6, r7, r8, r9};
                mainGridView.Rows.Add(str);
            }
            dr.Close();
        }
        public void renderSearchNameView(string serachStr)
        {
            mainGridView.Rows.Clear();
            string sql = "select * from userInfo where Name = '"+ serachStr + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string r1, r2, r3, r4, r5, r6, r7, r8, r9;
                r1 = dr["Id"].ToString();
                r2 = dr["Name"].ToString();
                r3 = dr["Sex"].ToString();
                r4 = dr["NativePlace"].ToString();
                r5 = dr["Phone"].ToString();
                r6 = dr["Birthday"].ToString();
                r7 = dr["Age"].ToString();
                r8 = dr["Hobby"].ToString();
                r9 = dr["EduExp"].ToString();

                string[] str = { r1, r2, r3, r4, r5, r6, r7, r8, r9 };
                mainGridView.Rows.Add(str);
            }
            dr.Close();
        }
        public void renderSearchSexView(string serachStr)
        {
            mainGridView.Rows.Clear();
            string sql = "select * from userInfo where Sex = '" + serachStr + "'";
            Dao dao = new Dao();
            IDataReader dr = dao.read(sql);
            while (dr.Read())
            {
                string r1, r2, r3, r4, r5, r6, r7, r8, r9;
                r1 = dr["Id"].ToString();
                r2 = dr["Name"].ToString();
                r3 = dr["Sex"].ToString();
                r4 = dr["NativePlace"].ToString();
                r5 = dr["Phone"].ToString();
                r6 = dr["Birthday"].ToString();
                r7 = dr["Age"].ToString();
                r8 = dr["Hobby"].ToString();
                r9 = dr["EduExp"].ToString();

                string[] str = { r1, r2, r3, r4, r5, r6, r7, r8, r9 };
                mainGridView.Rows.Add(str);
            }
            dr.Close();
        }

        private void AddInfo_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.ShowDialog();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            renderView();
        }

        private void UpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str =
                {
                    mainGridView.SelectedCells[0].Value.ToString(),
                    mainGridView.SelectedCells[1].Value.ToString(),
                    mainGridView.SelectedCells[2].Value.ToString(),
                    mainGridView.SelectedCells[3].Value.ToString(),
                    mainGridView.SelectedCells[4].Value.ToString(),
                    mainGridView.SelectedCells[5].Value.ToString(),
                    mainGridView.SelectedCells[6].Value.ToString(),
                    mainGridView.SelectedCells[7].Value.ToString(),
                    mainGridView.SelectedCells[8].Value.ToString(),
                };
                AddForm updateAddForm = new AddForm(str, this);
                updateAddForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("非法操作");
            }


        }

        private void DelInfo_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要删除吗？", "提示", MessageBoxButtons.OKCancel);
            if(r == DialogResult.OK)
            {
                string id = mainGridView.SelectedCells[0].Value.ToString();
                string name = mainGridView.SelectedCells[1].Value.ToString();
                string sql = "delete from userInfo where Id = '" + id + "'and Name = '" + name + "'";
                Dao dao = new Dao();
                dao.Excute(sql);
                renderView();
            }
        }

        private void 详细信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userId = mainGridView.SelectedCells[0].Value.ToString();
            detail detail = new detail(this, userId);
            detail.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void 按姓名查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this,1);
            searchForm.ShowDialog();
        }

        private void 按性别查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this,2);
            searchForm.ShowDialog();
        }
    }
}
