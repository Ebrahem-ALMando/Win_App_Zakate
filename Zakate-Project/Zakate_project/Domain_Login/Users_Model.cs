using System;
using Data_Access_Login;

namespace Domain_Login
{
    public class Users_Model
    {
        User_Check User_C = new User_Check();
        public  bool Login_Users(string User_Name,string Pass,string Type_Log)
        {
            return User_C.Loogin(User_Name,Pass,Type_Log);
        }
    }
}
