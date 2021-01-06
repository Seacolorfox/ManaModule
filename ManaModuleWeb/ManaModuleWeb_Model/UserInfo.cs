using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManaModuleWeb_Model
{
    public class UserInfo
    {
        private int id;
        private string userid;
        private string name;
        private int sex;
        private string address;
        private string phone;
        private DateTime birthday;
        private string hobby;

        public int Id { get => id; set => id = value; }
        public string Userid { get => userid; set => userid = value; }
        public int Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Hobby { get => hobby; set => hobby = value; }
        public string Name { get => name; set => name = value; }
    }
}
