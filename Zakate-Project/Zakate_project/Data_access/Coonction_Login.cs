using System;
using System.Data;
using System.Data.SqlClient;



namespace Coonction
{
    public class Coonction_Login
    {
       
            private readonly string Server_Conction_R;
            public Coonction_Login()
            {
                Server_Conction_R = @"server=DESKTOP-OVV6TDC\EBRAHEMSQLSERVER;database=zakate_database; integrated security = true; ";
            }
            protected SqlConnection GetConction()
            {
                return new SqlConnection(Server_Conction_R);
            }
        
    }
}
