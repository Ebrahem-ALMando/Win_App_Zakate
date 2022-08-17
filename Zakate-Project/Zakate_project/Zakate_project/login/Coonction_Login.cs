using System;
using System.Data;
using System.Data.SqlClient;



namespace Data_Access_Login
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
