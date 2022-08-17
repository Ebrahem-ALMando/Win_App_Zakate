using Data_Access_Login;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zakate_project.FORMS_GROUP
{


    public partial class Form_Users : Form
    {
        Users_Model UserCheck = new Users_Model();
        Form_Dashbord Dashbord = new Form_Dashbord();
        Form_ALMozke Mozke = new Form_ALMozke();
        Form_Home F_HOME_color = new Form_Home();
        Classes.Cls_Process User_proc = new Classes.Cls_Process();
        Guna2MessageDialog message = new Guna2MessageDialog();
        private Random random;
        private Button cruntbutton;
        public Form_Users()
        {
            random = new Random();
            InitializeComponent();
        
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           
            data_add_usrs.DataSource = User_proc.View_User();
      /*  *//*    Data_ID_Value.DataSource = User_proc.value_User_id();*//*
            id_User.Text = Data_ID_Value.CurrentRow.Cells[0].Value.ToString();*/
           


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Color selectThimecolor()
        {
            return F_HOME_color.selectThimecolor_HOME();
        }
        public void Diseblebutton()
        {
            foreach (Control selbutton in pan_grope_add_Users.Controls)
            {
                if (selbutton.GetType() == typeof(Button))
                {
                    selbutton.BackColor = Color.SeaGreen;
                    selbutton.ForeColor = Color.White;
                    selbutton.Font = new System.Drawing.Font("AGA Arabesque", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void Activatebutton(object btnsander)
        {
            Diseblebutton();
            if (btnsander != null)
            {
                if (cruntbutton != (Button)btnsander)
                {
                    Color color = selectThimecolor();
                    cruntbutton = (Button)btnsander;
                    cruntbutton.BackColor = color;
                    cruntbutton.ForeColor = Color.White;
                    cruntbutton.Font = new System.Drawing.Font("AGA Arabesque", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            Guna2MessageDialog obt_message_back = new Guna2MessageDialog();
            obt_message_back.Icon = MessageDialogIcon.Question;
            obt_message_back.Style = MessageDialogStyle.Light;
            obt_message_back.Buttons = MessageDialogButtons.YesNo;
            DialogResult check = obt_message_back.Show("هل تريد العودة الى الواجهةالرئيسية ؟");
            if (check == DialogResult.Yes)
            {
                this.Close();
                F_HOME_color.Show();
             

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            this.Close();
            Form_Item Item = new Form_Item();
            Item.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            this.Close();
            Mozke.Show();
    
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }
       
        private void button6_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

            Activatebutton(sender);
            this.Close();
            Dashbord.Show();


        }
        private void button7_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void add_type_Click(object sender, EventArgs e)
        {
            char[] email = new char[Email_user.Text.Length];
            email =Email_user.Text.ToArray();
            message.Icon = MessageDialogIcon.Warning;
            message.Buttons = MessageDialogButtons.OK;
            message.Style = MessageDialogStyle.Light;
            if (id_User.Text==""&&Name_user.Text==""&&UserName_User.Text==""
                &&Pass_User.Text==""&&Type_User.Text==""&&Email_user.Text==""
                &&Address_User.Text==""&&Phone_User.Text=="")
            {
                message.Icon = MessageDialogIcon.Warning;
                message.Show("أدخل المعلومات من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text != "" && UserName_User.Text != ""
                      && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم  من فضلك", "تنبيه");
            }
            else if (id_User.Text != "" && Name_user.Text == "" && UserName_User.Text != ""
                      && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الاسم  من فضلك", "تنبيه");
            }
            else if (id_User.Text != "" && Name_user.Text != "" && UserName_User.Text == ""
                      && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل اسم الحساب  من فضلك", "تنبيه");
            }
            else if (id_User.Text != "" && Name_user.Text != "" && UserName_User.Text != ""
                      && Pass_User.Text == "" && Type_User.Text != "" && Email_user.Text != ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل  كلمة السر  من فضلك", "تنبيه");
            }
            else if (id_User.Text != "" && Name_user.Text != "" && UserName_User.Text != ""
                      && Pass_User.Text != "" && Type_User.Text == "" && Email_user.Text != ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل نوع الحساب  من فضلك", "تنبيه");
            }
            else if (id_User.Text != "" && Name_user.Text != "" && UserName_User.Text != ""
                      && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text == ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الايميل من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text != ""
                     && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
                     && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم والاسم من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text != "" && UserName_User.Text == ""
                  && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
                  && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show("  ادخل الرقم واسم الحساب من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text != "" && UserName_User.Text != ""
                    && Pass_User.Text == "" && Type_User.Text != "" && Email_user.Text != ""
                    && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم وكلمة السر من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text != "" && UserName_User.Text != ""
                     && Pass_User.Text != "" && Type_User.Text == "" && Email_user.Text != ""
                     && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم ونوع الحساب من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text != "" && UserName_User.Text != ""
                  && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text == ""
                  && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم والايميل من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
                && Pass_User.Text == "" && Type_User.Text == "" && Email_user.Text == ""
                && Address_User.Text == "" && Phone_User.Text != "")
            {
                message.Show("يرجى اكمال المعلومات من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
              && Pass_User.Text == "" && Type_User.Text == "" && Email_user.Text == ""
              && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show("يرجى اكمال المعلومات من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
            && Pass_User.Text == "" && Type_User.Text == "" && Email_user.Text != ""
            && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show("يرجى اكمال المعلومات من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
           && Pass_User.Text == "" && Type_User.Text != "" && Email_user.Text != ""
           && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم والاسم "+"\n"+"واسم الحساب وكلمة السر من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
        && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
        && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم والاسم واسم الحساب من فضلك", "تنبيه");

            }
            else if (id_User.Text == "" || Name_user.Text == "" || UserName_User.Text == ""
                    || Pass_User.Text == "" || Type_User.Text == "" || Email_user.Text == "")
            {
                message.Show(" يرجى اكمال المعلومات من فضلك", "تنبيه");
            }
            else
            {
                if (UserName_User.Text.Length < 5)
                {
                    message.Style = MessageDialogStyle.Light;
                    message.Icon = MessageDialogIcon.Error;
                    message.Show("  اسم المستخدم قصير جداً"+"\n" + "\n" + "يرجى ادخال اسم مستخدم صحيح", "خطأ");

                }
                else if (Pass_User.Text.Length < 8)
                {
                    message.Style = MessageDialogStyle.Light;
                    message.Icon = MessageDialogIcon.Error;
                    message.Show("  كلمة السر قصيرة جداً" + "\n" + "\n" + "يرجى ادخال كلمة سر أكثر من 8 محارف", "خطأ");
                }
                else
                 {
                    bool em = true;
                 for (int i = 0; i < email.Length; i++)
                 {
                     if(email[i] != '@')
                     { em = false; }
                     else {
                         em = true;
                            break;
                     }
                 }
             if (em != true)
             {
                 message.Style = MessageDialogStyle.Light;
                 message.Icon = MessageDialogIcon.Error;
                 message.Show("  صيغة الايميل خطأ" + "\n" + "\n" + "الرجاء ادخال ايميل صحيح", "خطأ");
             }
             else
             {
                 message.Icon = MessageDialogIcon.Error;
                 message.Style = MessageDialogStyle.Light;
                 message.Buttons = MessageDialogButtons.OK;
                 var Ckeck = UserCheck.Ckeck_Users(Convert.ToInt32(id_User.Text), UserName_User.Text);
                 if (Ckeck == true)
                 {
                     message.Show("الحساب موجود مسبقا", "خطأ");
                 }
                 else
                 {
                     try
                 {
                     message.Buttons = MessageDialogButtons.YesNo;
                     message.Style = MessageDialogStyle.Dark;
                     message.Icon = MessageDialogIcon.Question;
                     DialogResult check = message.Show("هل تريد الاضافة", "إضافة");
                     if (check == DialogResult.Yes)
                     {
                         if (Type_User.Text == "مسؤول")
                         {
                             User_proc.Add_Users(Convert.ToInt32(id_User.Text), Name_user.Text, UserName_User.Text, Pass_User.Text, "Responsible",
                                 Email_user.Text, Address_User.Text, Phone_User.Text);
                             /*  Data_ID_Value.DataSource = User_proc.value_User_id();
                               id_User.Text = Data_ID_Value.CurrentRow.Cells[0].Value.ToString();*/
                             data_add_usrs.DataSource = User_proc.View_User();
                             id_User.Clear();
                             Name_user.Clear();
                             UserName_User.Clear();
                             Pass_User.Clear();
                             Type_User.StartIndex = -1;
                             Email_user.Clear();
                             Address_User.Clear();
                             Phone_User.Clear();
                         }
                         else if (Type_User.Text == "مستخدم")
                         {
                             User_proc.Add_Users(Convert.ToInt32(id_User.Text), Name_user.Text, UserName_User.Text, Pass_User.Text, "User",
                             Email_user.Text, Address_User.Text, Phone_User.Text);
                             data_add_usrs.DataSource = User_proc.View_User();
                             id_User.Clear();
                             Name_user.Clear();
                             UserName_User.Clear();
                             Pass_User.Clear();
                             Type_User.StartIndex = -1;
                             Email_user.Clear();
                             Address_User.Clear();
                             Phone_User.Clear();
                         }
                                    message.Icon = MessageDialogIcon.Information;
                                    message.Buttons = MessageDialogButtons.OK;
                                    message.Show("تمت الإضافة بنجاح", "نجاح");
                         }
                     }
                     catch(Exception ex)
                     {
                         message.Buttons = MessageDialogButtons.OK;
                         message.Show(ex.Message, "تنبيه");
                     }
                 }
             }
          }
      } 
}
        private void update_type_Click(object sender, EventArgs e)
        {
            char[] email = new char[Email_user.Text.Length];
            email = Email_user.Text.ToArray();
            message.Icon = MessageDialogIcon.Warning;
            message.Buttons = MessageDialogButtons.OK;
            message.Style = MessageDialogStyle.Light;

            if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
                && Pass_User.Text == "" && Type_User.Text == "" && Email_user.Text == ""
                && Address_User.Text == "" && Phone_User.Text == "")
            {
                message.Icon = MessageDialogIcon.Warning;
                message.Show("أدخل المعلومات من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text != "" && UserName_User.Text != ""
                      && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم  من فضلك", "تنبيه");
            }
            else if (id_User.Text != "" && Name_user.Text == "" && UserName_User.Text != ""
                      && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الاسم  من فضلك", "تنبيه");
            }
            else if (id_User.Text != "" && Name_user.Text != "" && UserName_User.Text == ""
                      && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل اسم الحساب  من فضلك", "تنبيه");
            }
            else if (id_User.Text != "" && Name_user.Text != "" && UserName_User.Text != ""
                      && Pass_User.Text == "" && Type_User.Text != "" && Email_user.Text != ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل  كلمة السر  من فضلك", "تنبيه");
            }
            else if (id_User.Text != "" && Name_user.Text != "" && UserName_User.Text != ""
                      && Pass_User.Text != "" && Type_User.Text == "" && Email_user.Text != ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل نوع الحساب  من فضلك", "تنبيه");
            }
            else if (id_User.Text != "" && Name_user.Text != "" && UserName_User.Text != ""
                      && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text == ""
                      && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الايميل من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text != ""
                     && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
                     && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم والاسم من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text != "" && UserName_User.Text == ""
                  && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
                  && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show("  ادخل الرقم واسم الحساب من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text != "" && UserName_User.Text != ""
                    && Pass_User.Text == "" && Type_User.Text != "" && Email_user.Text != ""
                    && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم وكلمة السر من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text != "" && UserName_User.Text != ""
                     && Pass_User.Text != "" && Type_User.Text == "" && Email_user.Text != ""
                     && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم ونوع الحساب من فضلك", "تنبيه");
            }
            else if (id_User.Text == "" && Name_user.Text != "" && UserName_User.Text != ""
                  && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text == ""
                  && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم والايميل من فضلك", "تنبيه");
            }

            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
                && Pass_User.Text == "" && Type_User.Text == "" && Email_user.Text == ""
                && Address_User.Text == "" && Phone_User.Text != "")
            {
                message.Show("يرجى اكمال المعلومات من فضلك", "تنبيه");

            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
              && Pass_User.Text == "" && Type_User.Text == "" && Email_user.Text == ""
              && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show("يرجى اكمال المعلومات من فضلك", "تنبيه");

            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
            && Pass_User.Text == "" && Type_User.Text == "" && Email_user.Text != ""
            && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show("يرجى اكمال المعلومات من فضلك", "تنبيه");

            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
           && Pass_User.Text == "" && Type_User.Text != "" && Email_user.Text != ""
           && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم والاسم " + "\n" + "واسم الحساب وكلمة السر من فضلك", "تنبيه");

            }
            else if (id_User.Text == "" && Name_user.Text == "" && UserName_User.Text == ""
        && Pass_User.Text != "" && Type_User.Text != "" && Email_user.Text != ""
        && Address_User.Text != "" && Phone_User.Text != "")
            {
                message.Show(" ادخل الرقم والاسم واسم الحساب من فضلك", "تنبيه");

            }
            else if (id_User.Text == "" || Name_user.Text == "" || UserName_User.Text == ""
                    || Pass_User.Text == "" || Type_User.Text == "" || Email_user.Text == "")
            {
                message.Show(" يرجى اكمال المعلومات من فضلك", "تنبيه");
            }
            else

            {if (id_User.Text == data_add_usrs.CurrentRow.Cells[0].Value.ToString())
                {
                    if (Name_user.Text == data_add_usrs.CurrentRow.Cells[1].Value.ToString()&&
                        UserName_User.Text == data_add_usrs.CurrentRow.Cells[2].Value.ToString() &&
                        Pass_User.Text == data_add_usrs.CurrentRow.Cells[3].Value.ToString() &&
                        Type_User.SelectedIndex==0 &&
                        data_add_usrs.CurrentRow.Cells[4].Value.ToString() == "Responsible" &&
                        Email_user.Text == data_add_usrs.CurrentRow.Cells[5].Value.ToString() &&
                        Address_User.Text == data_add_usrs.CurrentRow.Cells[6].Value.ToString() &&
                        Phone_User.Text == data_add_usrs.CurrentRow.Cells[7].Value.ToString()
                        )
                    {
                        message.Show(" لم تقم بإجراء ايً تعديلات", "تنبيه");

                    }
                    else if (Name_user.Text == data_add_usrs.CurrentRow.Cells[1].Value.ToString() &&
                        UserName_User.Text == data_add_usrs.CurrentRow.Cells[2].Value.ToString() &&
                        Pass_User.Text == data_add_usrs.CurrentRow.Cells[3].Value.ToString() &&
                        Type_User.SelectedIndex == 1 &&
                        data_add_usrs.CurrentRow.Cells[4].Value.ToString() == "User" &&
                        Email_user.Text == data_add_usrs.CurrentRow.Cells[5].Value.ToString() &&
                        Address_User.Text == data_add_usrs.CurrentRow.Cells[6].Value.ToString() &&
                        Phone_User.Text == data_add_usrs.CurrentRow.Cells[7].Value.ToString())
                    {
                        message.Show(" لم تقم بإجراء ايً تعديلات", "تنبيه");
                    }
                    else
                    {
                        if (UserName_User.Text.Length < 5)
                        {
                            message.Style = MessageDialogStyle.Light;
                            message.Icon = MessageDialogIcon.Error;
                            message.Show("  اسم المستخدم قصير جداً" + "\n" + "\n" + "يرجى ادخال اسم مستخدم صحيح", "خطأ");

                        }
                        else if (Pass_User.Text.Length < 8)
                        {
                            message.Style = MessageDialogStyle.Light;
                            message.Icon = MessageDialogIcon.Error;
                            message.Show("  كلمة السر قصيرة جداً" + "\n" + "\n" + "يرجى ادخال كلمة سر أكثر من 8 محارف", "خطأ");
                        }
                        else
                        {
                            bool em = true;
                            for (int i = 0; i < email.Length; i++)
                            {
                                if (email[i] != '@')
                                { em = false; }
                                else
                                {
                                    em = true;
                                    break;

                                }
                            }
                            if (em != true)
                            {
                                message.Style = MessageDialogStyle.Light;
                                message.Icon = MessageDialogIcon.Error;
                                message.Show("  صيغة الايميل خطأ" + "\n" + "\n" + "الرجاء ادخال ايميل صحيح", "خطأ");
                            }
                            else
                            {
                                message.Icon = MessageDialogIcon.Error;
                                message.Style = MessageDialogStyle.Light;
                                message.Buttons = MessageDialogButtons.OK;
                                var Ckeck = UserCheck.Ckeck_Users(UserName_User.Text);

                                if (UserName_User.Text!= data_add_usrs.CurrentRow.Cells[2].Value.ToString()
                                    && Ckeck == true)
                                {
                                    message.Show("الحساب موجود مسبقا", "خطأ");
                                }
                                else
                                {
                                    try
                                    {
                                        message.Buttons = MessageDialogButtons.YesNo;
                                        message.Style = MessageDialogStyle.Dark;
                                        message.Icon = MessageDialogIcon.Question;
                                        DialogResult check = message.Show("هل تريد التعديل", "تعديل");
                                        if (check == DialogResult.Yes)
                                        {
                                            if (Type_User.Text == "مسؤول")
                                            {
                                                User_proc.Update_User(Convert.ToInt32(id_User.Text), Name_user.Text, UserName_User.Text, Pass_User.Text, "Responsible",
                                                 Email_user.Text, Address_User.Text, Phone_User.Text);
                                                /*  Data_ID_Value.DataSource = User_proc.value_User_id();
                                                  id_User.Text = Data_ID_Value.CurrentRow.Cells[0].Value.ToString();*/
                                                data_add_usrs.DataSource = User_proc.View_User();
                                                id_User.Clear();
                                                Name_user.Clear();
                                                UserName_User.Clear();
                                                Pass_User.Clear();
                                                Type_User.StartIndex = -1;
                                                Email_user.Clear();
                                                Address_User.Clear();
                                                Phone_User.Clear();
                                            }
                                            else if (Type_User.Text == "مستخدم")
                                            {
                                                User_proc.Update_User(Convert.ToInt32(id_User.Text), Name_user.Text, UserName_User.Text, Pass_User.Text, "User",
                                                Email_user.Text, Address_User.Text, Phone_User.Text);
                                                data_add_usrs.DataSource = User_proc.View_User();
                                                id_User.Clear();
                                                Name_user.Clear();
                                                UserName_User.Clear();
                                                Pass_User.Clear();
                                                Type_User.StartIndex = -1;
                                                Email_user.Clear();
                                                Address_User.Clear();
                                                Phone_User.Clear();
                                            }
                                            message.Icon = MessageDialogIcon.Information;
                                            message.Buttons = MessageDialogButtons.OK;
                                            message.Show("تم التعديل بنجاح", "نجاح");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        message.Buttons = MessageDialogButtons.OK;
                                        message.Show(ex.Message, "تنبيه");
                                    }
                                }
                            }

                        }
                    }
                }
                else
                {
                    message.Buttons = MessageDialogButtons.OK;
                    message.Show("ادخل الرقم بشكل صحيح", "تنبيه");
                }
            }
        }
        private void remove_type_Click(object sender, EventArgs e)
        {
            message.Style = MessageDialogStyle.Light;
            message.Icon = MessageDialogIcon.Warning;
            message.Buttons = MessageDialogButtons.OK;
            if (UserName_User.Text == "ebrahem-m" || UserName_User.Text == "Host")
            {
                message.Show("لا يمكن حذف حساب المسؤول او حساب المضيف", "خطأ");

            }
            else {

                if (id_User.Text == "")
                {
                    message.Show("يرجى ادخال رقم المستخدم المراد حذفه", "تنبيه");
                }
                else
                {
                    message.Style = MessageDialogStyle.Dark;
                    message.Icon = MessageDialogIcon.Question;
                    message.Buttons = MessageDialogButtons.YesNo;
                    try
                    {
                        DialogResult check = message.Show("هل تريد حذف المستخدم بالتأكيد", "حذف");
                        if (check == DialogResult.Yes)
                        {
                            User_proc.delete_User(Convert.ToInt32(id_User.Text));
                            data_add_usrs.DataSource = User_proc.View_User();
                            id_User.Clear();
                            Name_user.Clear();
                            UserName_User.Clear();
                            Pass_User.Clear();
                            Type_User.StartIndex = -1;
                            Email_user.Clear();
                            Address_User.Clear();
                            Phone_User.Clear();
                            message.Icon = MessageDialogIcon.Information;
                            message.Buttons = MessageDialogButtons.OK;
                            message.Show("تم الحذف بنجاح", "نجاح");
                        }
                    }
                    catch (Exception ex)
                    {
                        message.Show(ex.Message, "خطأ");

                    }
                }
            }
        }
        private void delete_all_Users_Click(object sender, EventArgs e)
        {
            message.Style = MessageDialogStyle.Dark;
            message.Icon = MessageDialogIcon.Question;
            message.Buttons = MessageDialogButtons.YesNo;
            DialogResult check = message.Show("هل تريد حذف جميع المستخدمين بالتأكيد", "حذف");
            if (check == DialogResult.Yes)
            {
                try
                {
                  
                    User_proc.delete_all_User();
                    data_add_usrs.DataSource = User_proc.View_User();
                    id_User.Clear();
                    Name_user.Clear();
                    UserName_User.Clear();
                    Pass_User.Clear();
                    Type_User.StartIndex = -1;
                    Email_user.Clear();
                    Address_User.Clear();
                    Phone_User.Clear();
                    message.Icon = MessageDialogIcon.Information;
                    message.Buttons = MessageDialogButtons.OK;
                    message.Show("تم حذف المستخدمين  بنجاح", "نجاح");
                }
                catch (Exception ex)
                {
                    message.Show(ex.Message, "خطأ");

                }
            }
        }
        private void data_add_usrs_SelectionChanged(object sender, EventArgs e)
        {
            if (data_add_usrs.CurrentRow != null)
            {
                id_User.Text =data_add_usrs.CurrentRow.Cells[0].Value.ToString();
                Name_user.Text = data_add_usrs.CurrentRow.Cells[1].Value.ToString();
                UserName_User.Text = data_add_usrs.CurrentRow.Cells[2].Value.ToString();
                Pass_User.Text= data_add_usrs.CurrentRow.Cells[3].Value.ToString();
                if (data_add_usrs.CurrentRow.Cells[4].Value.ToString() == "Responsible") 
                {
                    Type_User.Text = "مسؤول";
                }
                else if (data_add_usrs.CurrentRow.Cells[4].Value.ToString() == "User")
                {
                    Type_User.Text = "مستخدم";

                }
                Email_user.Text = data_add_usrs.CurrentRow.Cells[5].Value.ToString();
                Address_User.Text= data_add_usrs.CurrentRow.Cells[6].Value.ToString();
               Phone_User.Text = data_add_usrs.CurrentRow.Cells[7].Value.ToString();
            }
            else
            {
                id_User.Clear();
                Name_user.Clear();
                UserName_User.Clear();
                Pass_User.Clear();
                Type_User.StartIndex = -1;
                Email_user.Clear();
                Address_User.Clear();
                Phone_User.Clear();
            }
        }


     
        private void id_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar >= 'ا' && e.KeyChar <= 'ي'||e.KeyChar>='A'&&e.KeyChar<='Z'
                ||e.KeyChar>='a'&&e.KeyChar<='z')
            {
                e.Handled = true;
            }
            else 
            {
                e.Handled = false;

            }

        }

        private void Phone_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
          || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void Form_Users_Load(object sender, EventArgs e)
        {
            Serch_Users_Type.StartIndex = 0;
            data_add_usrs.Columns[0].Width = 55;
            data_add_usrs.Columns[5].Width = 200;

            id_User.Clear();
            Name_user.Clear();
            UserName_User.Clear();
            Pass_User.Clear();
            Type_User.StartIndex = -1;
            Email_user.Clear();
            Address_User.Clear();
            Phone_User.Clear();
            id_User.Focus();
        }

        private void UserName_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                message.Style = MessageDialogStyle.Light;
                message.Buttons = MessageDialogButtons.OK;
                message.Icon = MessageDialogIcon.Warning;
                if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
                {
                    e.Handled = true;

                    message.Show(" لا يمكن ان يحتوي اسم المستخدم" + "\n" + " محارف باللغة العربية  ", " تنبيه");

                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void Pass_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                message.Style = MessageDialogStyle.Light;
                message.Buttons = MessageDialogButtons.OK;
                message.Icon = MessageDialogIcon.Warning;
                if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
                {
                    e.Handled = true;

                    message.Show(" لا يمكن ان تحتوي كلمة المرور" + "\n" + " محارف باللغة العربية  ", " تنبيه");

                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void Serch_Users_TextChanged(object sender, EventArgs e)
        {
            conction.Cls_conctin Conction = new conction.Cls_conctin();
            DataTable data = new DataTable();
            data.Clear();
            if (Serch_Users_Type.SelectedIndex == 0)
            {
                SqlDataAdapter result = new SqlDataAdapter(@"select User_id'الرقم',USER_NAME'الاسم',User_UserName'اسم الحساب',User_Password'كلمة السر'
                    , User_Type'نوع الحساب', User_Email'الايميل', User_location'العنوان', User_Phone'الهاتف' from Users_TBL
                    where User_UserName != 'ebrahem-m' and User_UserName != 'Host'
                    and CONVERT(varchar, User_id) + User_Name + User_UserName + User_Password +
                    User_Email + User_Type + User_location + CONVERT(varchar, User_Phone) like '%" + Serch_Users.Text + "%';", Conction.conction);
                result.Fill(data);
            }
           else if (Serch_Users_Type.SelectedIndex == 1)
            {
                SqlDataAdapter result = new SqlDataAdapter(@"select User_id'الرقم',USER_NAME'الاسم',User_UserName'اسم الحساب',User_Password'كلمة السر'
                    , User_Type'نوع الحساب', User_Email'الايميل', User_location'العنوان', User_Phone'الهاتف' from Users_TBL
                    where User_UserName != 'ebrahem-m' and User_UserName != 'Host'
                    and CONVERT(varchar, User_id) like '%" + Serch_Users.Text + "%';", Conction.conction);
                result.Fill(data);
            }
            else if (Serch_Users_Type.SelectedIndex == 2)
            {
                SqlDataAdapter result = new SqlDataAdapter(@"select User_id'الرقم',USER_NAME'الاسم',User_UserName'اسم الحساب',User_Password'كلمة السر'
                    , User_Type'نوع الحساب', User_Email'الايميل', User_location'العنوان', User_Phone'الهاتف' from Users_TBL
                    where User_UserName != 'ebrahem-m' and User_UserName != 'Host'
                    and User_Name like '%" + Serch_Users.Text + "%';", Conction.conction);
                result.Fill(data);
            }
            else if (Serch_Users_Type.SelectedIndex == 3)
            {
                SqlDataAdapter result = new SqlDataAdapter(@"select User_id'الرقم',USER_NAME'الاسم',User_UserName'اسم الحساب',User_Password'كلمة السر'
                    , User_Type'نوع الحساب', User_Email'الايميل', User_location'العنوان', User_Phone'الهاتف' from Users_TBL
                    where User_UserName != 'ebrahem-m' and User_UserName != 'Host'
                    and User_UserName like '%" + Serch_Users.Text + "%';", Conction.conction);
                result.Fill(data);
            }

            data_add_usrs.DataSource = data;
        }

        private void Serch_Users_KeyPress(object sender, KeyPressEventArgs e)
        {
            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.OK;
            message.Icon = MessageDialogIcon.Warning;
            if (Serch_Users_Type.SelectedIndex == 1)
            {
                if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar >= 'A' && e.KeyChar <= 'Z'
                    || e.KeyChar >= 'a' && e.KeyChar <= 'z')
                {
                    e.Handled = true;
                    message.Show(" لا يمكن كتابة محارف عند البحث بالرقم ", " تنبيه");
                }
                else
                {
                    e.Handled = false;

                }
            }
        }

        private void Serch_Users_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Serch_Users.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_now.Text = DateTime.Now.ToString("h:mm:ss ");
            date_now.Text = DateTime.Now.ToString("d/MM/yyyy");
        }

        private void btn_type_moz_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

            Form_Type Type = new Form_Type();
            this.Close();
            Type.Show();
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }
    }
}
