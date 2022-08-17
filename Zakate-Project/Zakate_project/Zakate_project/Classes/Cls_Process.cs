using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Zakate_project.conction;

namespace Zakate_project.Classes
{
    class Cls_Process
    {
        public DataTable select_item()
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.Cls_conctin O_con = new conction.Cls_conctin();
            DataTable data_Table = new DataTable();
            data_Table = O_con.Read_Data("select_item", null);
            O_con.cloes();
            return data_Table;
        }
  /*      public DataTable value_User_id()
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            conction.Cls_conctin O_con = new conction.Cls_conctin();
            DataTable data_Table = new DataTable();
            data_Table = O_con.Read_Data("Value_id_User", null);
            O_con.cloes();
            return data_Table;
        }*/
        public void insert_item(int id, string item)//insert item
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[1].Value = item;
            conction.process("insert_item", param);
            conction.cloes();

        }
        public void update_item(int id, string item)//
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[1].Value = item;
            conction.process("update_item", param);
            conction.cloes();

        }
        public void delete_item(int id)//
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            conction.process("delete_item", param);
            conction.cloes();

        }
        public DataTable select_Type()
        {
            conction.Cls_conctin O_con = new conction.Cls_conctin();
            DataTable data_Table = new DataTable();
            data_Table = O_con.Read_Data("select_Type", null);
            O_con.cloes();
            return data_Table;
        }
        public DataTable select_Type_comp()
        {
            conction.Cls_conctin O_con = new conction.Cls_conctin();
            DataTable data_Table = new DataTable();
            data_Table = O_con.Read_Data("select_Type_comp", null);
            O_con.cloes();
            return data_Table;
        }
        public void insert_Type(int id, string Type, int id_item_FK, float percentage)//insert item
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[1].Value = Type;
            param[2] = new SqlParameter("@id_Item_FK", SqlDbType.Int);
            param[2].Value = id_item_FK;
            param[3] = new SqlParameter("@percentage", SqlDbType.Float);
            param[3].Value = percentage;
            conction.process("insert_Type", param);
            conction.cloes();
        }
        public DataTable value_type_id()
        {
            conction.Cls_conctin O_con = new conction.Cls_conctin();
            O_con.open();
            DataTable data_Table = new DataTable();
            data_Table = O_con.Read_Data("value_Text_type", null);
            O_con.cloes();
            return data_Table;
        }
        public void delete_type(int id)
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            conction.process("delete_type", param);
            conction.cloes();
            
        }
       
     
        public void update_Type(int id, string name_T,int id_FK_item,float percentage )//
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[1].Value = name_T;
            param[2] = new SqlParameter("@id_FK_item", SqlDbType.Int);
            param[2].Value = id_FK_item;
            param[3] = new SqlParameter("@percentage", SqlDbType.Float);
            param[3].Value = percentage;
            conction.process("Update_type", param);
            conction.cloes();

        }
        public DataTable View_User()
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            conction.Cls_conctin O_con = new conction.Cls_conctin();
            DataTable data_Table = new DataTable();
            data_Table = O_con.Read_Data("View_User", null);
            O_con.cloes();
            return data_Table;
        }
       
        public void Add_Users(int id ,string name, string UserName,string Pass,string Type,string Email,
            string loc,string Phone)
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@id_user", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[1].Value = name;
            param[2] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[2].Value = UserName;
            param[3] = new SqlParameter("@Password", SqlDbType.VarChar);
            param[3].Value = Pass;
            param[4] = new SqlParameter("@Type", SqlDbType.VarChar);
            param[4].Value = Type;
            param[5] = new SqlParameter("@Email", SqlDbType.VarChar);
            param[5].Value = Email;
            param[6] = new SqlParameter("@location", SqlDbType.NVarChar);
            param[6].Value =loc;
            param[7] = new SqlParameter("@Phone", SqlDbType.VarChar);
            param[7].Value = Phone;
            conction.process("Insert_Users", param);
            conction.cloes();
        }
        public void Update_User(int id, string name, string UserName, string Pass, string Type, string Email,
         string loc, string Phone)
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@id_user", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
            param[1].Value = name;
            param[2] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[2].Value = UserName;
            param[3] = new SqlParameter("@Password", SqlDbType.VarChar);
            param[3].Value = Pass;
            param[4] = new SqlParameter("@Type", SqlDbType.VarChar);
            param[4].Value = Type;
            param[5] = new SqlParameter("@Email", SqlDbType.VarChar);
            param[5].Value = Email;
            param[6] = new SqlParameter("@location", SqlDbType.NVarChar);
            param[6].Value = loc;
            param[7] = new SqlParameter("@Phone", SqlDbType.VarChar);
            param[7].Value = Phone;
            conction.process("Update_User", param);
            conction.cloes();
        }
        public void delete_User(int id)
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            conction.process("delete_User", param);
            conction.cloes();

        }
        public void delete_all_User()
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            conction.process("delete_all_user", null);
            conction.cloes();

        }
        public void Modify_user_in_the_same_account(int id,string name , string Username,
            string password,string email)
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@id_user", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@name", SqlDbType.VarChar);
            param[1].Value = name;
            param[2] = new SqlParameter("@UserName", SqlDbType.VarChar);
            param[2].Value = Username;
            param[3] = new SqlParameter("@Password", SqlDbType.VarChar);
            param[3].Value = password;
            param[4] = new SqlParameter("@Email", SqlDbType.VarChar);
            param[4].Value = email;
            conction.process("Modify_user_in_the_same_account", param);
            conction.cloes();
        }
        public DataTable View_Don()
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            DataTable data_Table = new DataTable();
            data_Table = conction.Read_Data("View_Don", null);
            conction.cloes();
            return data_Table;
        }
        public DataTable View_Process()
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            DataTable data_Table = new DataTable();
            data_Table = conction.Read_Data("View_Process", null);
            conction.cloes();
            return data_Table;
        }

        public void insert_Don(int id,string name,string L_name,string age,string phone
            ,string address,string gender,string stutes,int id_user)
        {
            Cls_conctin connction = new Cls_conctin();
            connction.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@Don_Id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Don_F_Name", SqlDbType.NVarChar);
            param[1].Value = name;
            param[2] = new SqlParameter("@Don_L_Name", SqlDbType.NVarChar);
            param[2].Value = L_name;
            param[3] = new SqlParameter("@Don_Age", SqlDbType.NVarChar);
            param[3].Value = age;
            param[4] = new SqlParameter("@Don_Num_Phone", SqlDbType.VarChar);
            param[4].Value = phone;
            param[5] = new SqlParameter("@Don_Address", SqlDbType.NVarChar);
            param[5].Value = address;
            param[6] = new SqlParameter("@Don_Gender", SqlDbType.NVarChar);
            param[6].Value = gender;
            param[7] = new SqlParameter("@Don_Status", SqlDbType.NVarChar);
            param[7].Value = stutes;
            param[8] = new SqlParameter("@Don_User_Id", SqlDbType.Int);
            param[8].Value = id_user;
            connction.process("insert_Don", param);
            connction.cloes();
        }
        public void Update_Don(int id, string name, string L_name, string age, string phone
          , string address, string gender, string stutes, int id_user)
        {
            Cls_conctin connction = new Cls_conctin();
            connction.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@Don_Id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Don_F_Name", SqlDbType.NVarChar);
            param[1].Value = name;
            param[2] = new SqlParameter("@Don_L_Name", SqlDbType.NVarChar);
            param[2].Value = L_name;
            param[3] = new SqlParameter("@Don_Age", SqlDbType.NVarChar);
            param[3].Value = age;
            param[4] = new SqlParameter("@Don_Num_Phone", SqlDbType.VarChar);
            param[4].Value = phone;
            param[5] = new SqlParameter("@Don_Address", SqlDbType.NVarChar);
            param[5].Value = address;
            param[6] = new SqlParameter("@Don_Gender", SqlDbType.NVarChar);
            param[6].Value = gender;
            param[7] = new SqlParameter("@Don_Status", SqlDbType.NVarChar);
            param[7].Value = stutes;
            param[8] = new SqlParameter("@Don_User_Id", SqlDbType.Int);
            param[8].Value = id_user;
            connction.process("Update_Don", param);
            connction.cloes();
        }
        public void insert_processer(string id_type_F,int id_Don_Fk,float quntity,
           DateTime Date_Pros,  int User_id_F  ,int item_id_F)
        {
            Cls_conctin connction = new Cls_conctin();
            connction.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@Type_id_FK", SqlDbType.VarChar);
            param[0].Value = id_type_F;
            param[1] = new SqlParameter("@Don_id_FK", SqlDbType.Int);
            param[1].Value = id_Don_Fk;
            param[2] = new SqlParameter("@quntity", SqlDbType.Decimal,12);
            param[2].Value = quntity;
            param[3] = new SqlParameter("@Date_Pros", SqlDbType.DateTime);
            param[3].Value = Date_Pros;
            param[4] = new SqlParameter("@User_id", SqlDbType.Int);
            param[4].Value = User_id_F;
            param[5] = new SqlParameter("@id_item_Fk", SqlDbType.Int);
            param[5].Value = item_id_F;
            connction.process("insert_processer", param);
            connction.cloes();
        }
        public DataTable Flter_Compo(int id)
        {
            conction.Cls_conctin conction = new conction.Cls_conctin();
            conction.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_FK", SqlDbType.Int);
            param[0].Value = id;
            DataTable data_Table = new DataTable();
            data_Table = conction.Read_Data("Flter_Compo",param);
            conction.cloes();
            return data_Table;
        }


    }
}
