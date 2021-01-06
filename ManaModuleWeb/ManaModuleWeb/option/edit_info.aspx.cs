using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManaModuleWeb.option
{
    public partial class edit_info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = Request.QueryString["id"];
                ManaModuleWeb_Model.UserInfo userInfo = ManaModuleWeb_BLL.UserInfo_BLL.GetUser(int.Parse(id));
                this.id.Value = userInfo.Id.ToString();
                name.Text = userInfo.Name;
                sex.Text = userInfo.Sex.ToString();
                phone.Text = userInfo.Phone;
                hobby.Text = userInfo.Hobby;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ManaModuleWeb_Model.UserInfo editUser = new ManaModuleWeb_Model.UserInfo();
            //111111111
            editUser.Id = int.Parse(this.id.Value);
            editUser.Name = name.Text.Trim();
            editUser.Sex = int.Parse(sex.Text);
            //addUser.Address = province_select.Items[province_select.SelectedIndex].Value + city_select.Items[city_select.SelectedIndex].Value + county_select.Items[county_select.SelectedIndex].Value;
            editUser.Address = Request.Form.Get("province_select") + Request.Form.Get("city_select") + Request.Form.Get("county_select");
            editUser.Phone = phone.Text.Trim();
            editUser.Birthday = DateTime.Parse(Request.Form.Get("birthday"));
            editUser.Hobby = hobby.Text;

            if (ManaModuleWeb_BLL.UserInfo_BLL.editInfo(editUser))
            {
                ManaModuleWeb_Utility.JsHelper.AlertAndRedirect("修改成功！", "../index.aspx");
            }
            else
            {
                ManaModuleWeb_Utility.JsHelper.AlertAndRedirect("修改失败！", "../edit_info.aspx");
            }
        }
    }
}