using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Zakate_project.conction
{
    class Cls_conctin
    {
      public  SqlConnection conction;
        public Cls_conctin()
        {
            conction = new SqlConnection(@"server=DESKTOP-OVV6TDC\EBRAHEMSQLSERVER;database=zakate_database; integrated security = true; ");
        }
        public void open()// we will create method for  open connection with database
        {
            if (conction.State != ConnectionState.Open){
                conction.Open();
            }
        }
        public void cloes()// we will create method for close connection with database
        {
            if(conction.State==ConnectionState.Open)
            { conction.Close(); }
        }
        public DataTable Read_Data(string text,SqlParameter[] param) // created method for read data from database
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = text;
            cmd.Connection = conction;
            if (param != null)
            {
                cmd.Parameters.AddRange(param);
            }
            SqlDataAdapter O_Sda = new SqlDataAdapter(cmd);
            DataTable O_dataTable = new DataTable();
            O_Sda.Fill(O_dataTable);
            return O_dataTable;
        }
        // created method for insert and update and delete data from database
        public void process(string text, SqlParameter[] param) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = text;
            cmd.Connection = conction;
            if (param != null)
            {

                cmd.Parameters.AddRange(param);
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception m)
            {
               Console.WriteLine( m.Message);
            }
        
        }
        
        
        

    }
}
