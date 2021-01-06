using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaModuleWeb_Model
{
    public class UserDetail
    {
        private string userid;
        private string timgeQ;
        private string school;
        private string certificate;

        public string Userid { get => userid; set => userid = value; }
        public string TimgeQ { get => timgeQ; set => timgeQ = value; }
        public string School { get => school; set => school = value; }
        public string Certificate { get => certificate; set => certificate = value; }
    }
}
