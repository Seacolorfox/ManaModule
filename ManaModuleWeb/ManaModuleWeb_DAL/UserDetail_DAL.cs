using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaModuleWeb_DAL
{
    public class UserDetail_DAL
    {
        public static ManaModuleWeb_Model.UserDetail GetDetails(string userid)
        {
            string sql = "select * from userDetail where userid = '"+userid+"'";
            DataTable dataTable = ManaModuleWeb_Utility.SqlHelper.Query(sql).Tables[0];
            return dataTableToList(dataTable);
        }
        public static ManaModuleWeb_Model.UserDetail dataTableToList(DataTable dataTable)
        {
            ManaModuleWeb_Model.UserDetail userDetails = new ManaModuleWeb_Model.UserDetail();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //userDetail.Userid = dataTable.Rows[i]["userid"].ToString();
                userDetails.TimgeQ = dataTable.Rows[i]["timeQ"].ToString();
                userDetails.School = dataTable.Rows[i]["school"].ToString();
                userDetails.Certificate = dataTable.Rows[i]["certificate"].ToString();

            }
            return userDetails;
        }
        //public static ManaModuleWeb_Model.UserDetail updateDetail(ManaModuleWeb_Model.UserDetail userDetail)
        //{
        //    bool result = false;
        //    string sql = "update userDetail set userid = "
        //}
    }
}
