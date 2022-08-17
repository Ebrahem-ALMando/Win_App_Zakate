using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakate_project.Classes
{
    class Cls_AlMozke
    {
        private int id;
        private string Firs_name;
        private string Last_name;
        private DateTime date;
        private string gender;
        private string stute;
        private string num_phone;
        private string Email;
        private string Address;
        public int Pro_id { get { return id; } set { id = value; } }
        public string Pro_First_name { get { return Firs_name; }set { Firs_name = value; } }
        public string Pro_Last_name { get { return Last_name; } set { Last_name = value; } }
        public DateTime Pro_date { get {return date; }set { date = value; } }
        public string Pro_gender { get { return gender; } set { gender = value; } }
        public string Pro_stute { get { return stute; } set { stute = value; } }
        public string Pro_num_phone { get { return num_phone; } set {  num_phone = value;} }
        public string Pro_Email { get { return Email; } set { Email = value; } }
        public string Pro_Address { get { return Address; }set { Address = value; } }
        public virtual void input(int id,string Firs_name, string Last_name, DateTime date, string gender, 
            string stute, string num_phone, string Email, string Address) {
        
        }

        public virtual void input( string Firs_name, string Last_name, DateTime date, string gender,
             string stute, string num_phone, string Email, string Address)
        { }

    }
}
