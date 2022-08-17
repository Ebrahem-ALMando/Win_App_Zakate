using System;


namespace Data_Access_Login
{
    public class Users_Model
    {
        User_Check User_C = new User_Check();
        public  bool Login_Users(string User_Name,string Pass,string Type_Log)
        {
            return User_C.Loogin(User_Name,Pass,Type_Log);
        }
        public bool Ckeck_Users(int id, string Username)
        {
            return User_C.Users_CHeck( id, Username);
        }
        public bool Ckeck_Users( string Username)
        {
            return User_C.Users_CHeck(Username);
        }
    }
}
