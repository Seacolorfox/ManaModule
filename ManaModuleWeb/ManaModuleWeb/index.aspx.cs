using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ManaModuleWeb
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //this.Repeater1.DataSource = ManaModuleWeb_BLL.UserInfo_BLL.list();
                //this.Repeater1.DataBind();
                con();
                first.Visible = true;
                last.Visible = true;
            }

        }
        private void con()
        {
            //SqlConnection con = new SqlConnection("");
            //SqlConnection conn = new SqlConnection();
            //DataSet ds = new DataSet();
            //SqlDataAdapter sda = new SqlDataAdapter("select * from userInfo", con);
            //sda.Fill(ds, "name");
            DataSet ds = ManaModuleWeb_Utility.SqlHelper.Query("select * from userInfo", "name");
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = ds.Tables["name"].DefaultView;
            //PagedDataSource aa = new PagedDataSource();
            pds.AllowPaging = true;//允许分页
            pds.PageSize = 8;//单页显示项数
            int CurPage;
            if (Request.QueryString["Page"] != null)
                CurPage = Convert.ToInt32(Request.QueryString["Page"]);
            else
                CurPage = 1;
            pds.CurrentPageIndex = CurPage - 1;
            int Count = pds.PageCount;
            this.lblCurrentPage.Text = "当前页：" + CurPage.ToString();
            labPage.Text = Count.ToString();

            if (!pds.IsFirstPage)
            {
                this.first.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=1";
                this.last.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(Count); ;
                up.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage - 1);
            }
            else
            {
                this.first.Visible = false;
                this.last.Visible = false;

            }

            if (!pds.IsLastPage)
            {

                next.NavigateUrl = Request.CurrentExecutionFilePath + "?Page=" + Convert.ToString(CurPage + 1);
            }
            else
            {
                this.first.Visible = false;
                this.last.Visible = false;

            }
            Repeater1.DataSource = pds;
            Repeater1.DataBind();
            //public void bindsql()
            //{
            //    SqlConnection con = new SqlConnection("Data Source=20090731-5465;Initial Catalog=Northwind;Integrated Security=True");
            //    con.Open();
            //    SqlDataAdapter sqlda = new SqlDataAdapter("select * from customers", con);
            //    DataSet ds = new DataSet();
            //    sqlda.Fill(ds);
            //    PagedDataSource pdsList = new PagedDataSource();
            //    pdsList.DataSource = ds.Tables[0].DefaultView;
            //    pdsList.AllowPaging = true;//数据源允许分页
            //    pdsList.PageSize = this.Repeater1.PageSize;//取控件的分页大小
            //    pdsList.CurrentPageIndex = this.Repeater1.CurrentPageIndex - 1;//显示当前页
            //                                                                      //设置控件
            //    this.Repeater1.RecordCount = ds.Tables[0].Rows.Count;//记录总数
            //    this.Repeater1.PageSize = 10;
            //    this.Repeater1.DataSource = pdsList;
            //    this.Repeater1.DataBind();

            //}
            //protected void AspNetPager1_PageChanging(object src, PageChangingEventArgs e)
            //{
            //    Repeater1.CurrentPageIndex = e.NewPageIndex;
            //    bindsql();
            //}
        }
    }
}