using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ManaModuleWeb.option
{
    public partial class add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ManaModuleWeb_Model.UserInfo addUser = new ManaModuleWeb_Model.UserInfo();
            addUser.Name = name.Text.Trim();
            addUser.Sex = int.Parse(sex.Text);
            //addUser.Address = province_select.Items[province_select.SelectedIndex].Value + city_select.Items[city_select.SelectedIndex].Value + county_select.Items[county_select.SelectedIndex].Value;
            addUser.Address = Request.Form.Get("province_select") + Request.Form.Get("city_select") + Request.Form.Get("county_select");
            addUser.Phone = phone.Text.Trim();
            addUser.Birthday = DateTime.Parse(Request.Form.Get("birthday"));
            string getHobby = "";
            for (int i = 0; i < hobby.Items.Count; i++)
            {
                if(hobby.Items[i].Selected)
                {
                    getHobby += hobby.Items[i].Value+"|";
                }
            }
            
            addUser.Hobby = getHobby;

            if (ManaModuleWeb_BLL.UserInfo_BLL.add(addUser))
            {
                ManaModuleWeb_Utility.JsHelper.AlertAndRedirect("添加成功！", "../index.aspx");
            }
            else
            {
                ManaModuleWeb_Utility.JsHelper.AlertAndRedirect("添加失败！", "../add.aspx");
            }
        }
    }
}