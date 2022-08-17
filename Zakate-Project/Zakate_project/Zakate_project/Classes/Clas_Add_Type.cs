using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zakate_project
{
    class Cls_Add_Type
    {
        private int id;
        private string type;
       private string Type_name;
        public int pro_id { get { return id; }set { id = value; }}
        public string pro_type { get { return type; } set { type = value; } }
        public string pro_Type_name { get { return Type_name; } set {Type_name=value; } }
        public Cls_Add_Type() { }
        public Cls_Add_Type(int id, string type,string Type_name) {
            this.pro_id = id;
            this.pro_type = type;
            this.pro_Type_name = Type_name;
        }
       
    }
}
