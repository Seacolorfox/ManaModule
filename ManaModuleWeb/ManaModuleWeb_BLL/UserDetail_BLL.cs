using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaModuleWeb_BLL
{
    public class UserDetail_BLL
    {
        public static ManaModuleWeb_Model.UserDetail GetDetails(string userid)
        {
            return ManaModuleWeb_DAL.UserDetail_DAL.GetDetails(userid);
        }
    }
}
