using Data_Access_Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zakate_project.login;
namespace Zakate_project.login
{
    class Data_Setting: Coonction_Login
    {
        public static int id { get; set; }
        public static string Name { get; set; }
        public static string User_Name{ get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public bool Load(string Username)
        {
            using (var conction = GetConction())
            {
                conction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conction;
                    command.CommandText = @"select User_id, User_Name,User_UserName
                                             ,User_Password,User_Email from Users_TBL
                                         where User_UserName=@Username;";
                    command.Parameters.AddWithValue("@Username", Username);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt32(0);
                            Name = reader.GetString(1);
                            User_Name = reader.GetString(2);
                            Password = reader.GetString(3);
                            Email = reader.GetString(4);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool Load(int id)
        {
            using (var conction = GetConction())
            {
                conction.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = conction;
                    command.CommandText = @"select User_id, User_Name,User_UserName
                                             ,User_Password,User_Email from Users_TBL
                                         where User_id=@id;";
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                           
                            Name = reader.GetString(1);
                            User_Name = reader.GetString(2);
                            Password = reader.GetString(3);
                            Email = reader.GetString(4);
                        }
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
