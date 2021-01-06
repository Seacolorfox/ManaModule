using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaModuleWeb_BLL
{
    public class UserInfo_BLL
    {
        public static List<ManaModuleWeb_Model.UserInfo> list()
        {
            return ManaModuleWeb_DAL.UserInfo_DAL.list();
        }
        public static ManaModuleWeb_Model.UserInfo GetUser(int id)
        {
            return ManaModuleWeb_DAL.UserInfo_DAL.GetUser(id);
        }
        public static bool add(ManaModuleWeb_Model.UserInfo userInfo)
        {
            return ManaModuleWeb_DAL.UserInfo_DAL.add(userInfo);
        }
        public static bool del(int id)
        {
            return ManaModuleWeb_DAL.UserInfo_DAL.del(id);
        }
        public static bool editInfo(ManaModuleWeb_Model.UserInfo userInfo)
        {
            return ManaModuleWeb_DAL.UserInfo_DAL.editInfo(userInfo);
        }
    }
}
