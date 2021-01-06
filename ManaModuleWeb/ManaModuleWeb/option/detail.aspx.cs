using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManaModuleWeb.option
{
    public partial class detail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ManaModuleWeb_Model.UserDetail getUserDetail = new ManaModuleWeb_Model.UserDetail();
                getUserDetail = ManaModuleWeb_BLL.UserDetail_BLL.GetDetails(Request.QueryString["userid"]);
                timeQ.Text = getUserDetail.TimgeQ;
                school.Text = getUserDetail.School;
                certificate.Text = getUserDetail.Certificate;
            }
        }

        protected void returnToIndex_Click(object sender, EventArgs e)
        {
            ManaModuleWeb_Utility.JsHelper.Redirect("index.aspx");
        }

        protected void update_Click(object sender, EventArgs e)
        {

        }
    }
}