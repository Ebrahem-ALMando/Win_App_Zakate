using System;
using System.Data.SqlClient;
using System.Data;


namespace Data_Access_Login
{
    public class User_Check:Coonction_Login
    {
       public bool Loogin(string User_Name,string Pass,string Type_Log)
        {
           using (var conction =GetConction() )
            {
                conction.Open();
                using (var command=new SqlCommand())
                {
                    command.Connection = conction;
                    command.CommandText = @"select * from Users_TBL 
                                            where User_UserName = @User_N
                                            and User_Password = @User_Pass
                                            and user_Type = @User_Type";

                    command.Parameters.AddWithValue("@User_N", User_Name);
                    command.Parameters.AddWithValue("@User_Pass",Pass);
                    command.Parameters.AddWithValue("@User_Type", Type_Log);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
        public bool Users_CHeck(int id, string Username)
        {
            using (var conction = GetConction())
            {
                conction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conction;
                    command.CommandText = @"select * from Users_TBL
                                           where User_UserName=@Username
                                           or User_id=@id";

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }
        public bool Users_CHeck(string Username)
        {
            using (var conction = GetConction())
            {
                conction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conction;
                    command.CommandText = @"select * from Users_TBL
                                           where User_UserName=@Username";
                    command.Parameters.AddWithValue("@Username", Username);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }


    }
}
