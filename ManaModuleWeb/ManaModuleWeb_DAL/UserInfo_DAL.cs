using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaModuleWeb_DAL
{
    public class UserInfo_DAL
    {
        /// <summary>
        /// 数据显示
        /// </summary>
        /// <returns></returns>
        public static List<ManaModuleWeb_Model.UserInfo> list()
        {
            string sql = "select * from userInfo order by id desc";
            DataTable dataTable = ManaModuleWeb_Utility.SqlHelper.Query(sql).Tables[0];
            return dataTableToList(dataTable);
        }
        public static List<ManaModuleWeb_Model.UserInfo> dataTableToList(DataTable dataTable)
        {
            List<ManaModuleWeb_Model.UserInfo> userInfos = new List<ManaModuleWeb_Model.UserInfo>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                ManaModuleWeb_Model.UserInfo userInfo = new ManaModuleWeb_Model.UserInfo();

                userInfo.Id = int.Parse(dataTable.Rows[i]["id"].ToString());
                userInfo.Userid = dataTable.Rows[i]["userid"].ToString();
                userInfo.Name = dataTable.Rows[i]["name"].ToString();
                userInfo.Sex = int.Parse(dataTable.Rows[i]["sex"].ToString());
                userInfo.Address = dataTable.Rows[i]["address"].ToString();
                userInfo.Phone = dataTable.Rows[i]["phone"].ToString();
                userInfo.Birthday = DateTime.Parse(dataTable.Rows[i]["birthday"].ToString());
                userInfo.Hobby = dataTable.Rows[i]["hobby"].ToString();

                userInfos.Add(userInfo);
            }
            return userInfos;
        }
        public static ManaModuleWeb_Model.UserInfo GetUser(int id)
        {
            ManaModuleWeb_Model.UserInfo userInfo = new ManaModuleWeb_Model.UserInfo();
            string sql = "select * from userInfo where id = " + id + "";
            DataTable dataTable = ManaModuleWeb_Utility.SqlHelper.Query(sql).Tables[0];
            if (dataTable.Rows.Count != 0)
            {
                userInfo.Id = int.Parse(dataTable.Rows[0]["id"].ToString());
                userInfo.Userid = dataTable.Rows[0]["userid"].ToString();
                userInfo.Name = dataTable.Rows[0]["name"].ToString();
                userInfo.Sex = int.Parse(dataTable.Rows[0]["sex"].ToString());
                userInfo.Address = dataTable.Rows[0]["address"].ToString();
                userInfo.Phone = dataTable.Rows[0]["phone"].ToString();
                userInfo.Birthday = DateTime.Parse(dataTable.Rows[0]["birthday"].ToString());
                userInfo.Hobby = dataTable.Rows[0]["hobby"].ToString();
            }
            return userInfo;
        }
        public static bool add(ManaModuleWeb_Model.UserInfo userInfo)
        {
            string sexStr;
            string userIdStr;
            bool result = false;
            if (userInfo.Sex == 1)
            {
                sexStr = "M";
            }
            else
            {
                sexStr = "F";
            }
            string sql1 = "insert into userInfo(userid,name,sex,address,phone,birthday,hobby) values('','',3,'','','','')";
            if (ManaModuleWeb_Utility.SqlHelper.ExecuteSql(sql1) > 0)
            {
                List<ManaModuleWeb_Model.UserInfo> userIdUpdate = list();
                userIdStr = sexStr + userIdUpdate[0].Id;
                string sql2 = "update userInfo set userid='" + userIdStr + "',name='" + userInfo.Name + "',sex=" + userInfo.Sex + ",address='" + userInfo.Address + "',phone='" + userInfo.Phone + "',birthday='" + userInfo.Birthday + "',hobby='" + userInfo.Hobby + "'where id = " + userIdUpdate[0].Id + "";
                if (ManaModuleWeb_Utility.SqlHelper.ExecuteSql(sql2) > 0)
                {
                    result = true;
                }
            }
            return result;
        }
        public static bool del(int id)
        {
            bool result = false;
            string sql = "delete from userInfo where id = " + id + "";
            if(ManaModuleWeb_Utility.SqlHelper.ExecuteSql(sql)>0)
            {
                result = true;
            }
            return result;
        }
        public static bool editInfo(ManaModuleWeb_Model.UserInfo userInfo)
        {
            bool result = false;
            string sql = "update userInfo set name='" + userInfo.Name + "',sex=" + userInfo.Sex + ",address='" + userInfo.Address + "',phone='" + userInfo.Phone + "',birthday='" + userInfo.Birthday + "',hobby='" + userInfo.Hobby + "'where id = " + userInfo.Id + "";
            if (ManaModuleWeb_Utility.SqlHelper.ExecuteSql(sql)>0)
            {
                result = true;
            }
            return result;
        }
    }
}
