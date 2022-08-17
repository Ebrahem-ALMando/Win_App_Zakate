using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Zakate_project.DB
{
  public abstract class Concition_Reports
    {
        private readonly string Server_Conction_R;
        public Concition_Reports()
        {
            Server_Conction_R = @"server=DESKTOP-OVV6TDC\EBRAHEMSQLSERVER;database=zakate_database; integrated security = true; ";
        }
        protected SqlConnection GetConction()
        {
            return new SqlConnection (Server_Conction_R);
        }
    }
}
