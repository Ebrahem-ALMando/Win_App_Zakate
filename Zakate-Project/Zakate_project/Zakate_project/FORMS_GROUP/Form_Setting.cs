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
using Zakate_project.Classes;
using Zakate_project.login;
using Guna.UI2.WinForms;

namespace Zakate_project.FORMS_GROUP
{
    public partial class Form_Setting : Form
    {
        public string Username;
        Guna2MessageDialog Message_Word = new Guna2MessageDialog();
        Cls_Process Data_Base = new Cls_Process();
        Data_Setting data = new Data_Setting();
        public Form_Setting()
        {
            InitializeComponent();
            Load_Data_Users();
            Username = TX_Username.Text;
            lbl.Text = "";
            //animate();
        }//
        private void Load_Data_Users()
        {
            data.Load(User_Name.Text_Name);
            TX_name.Text = Data_Setting.Name;
            TX_Username.Text = Data_Setting.User_Name;
            TX_Password.Text = Data_Setting.Password;
            TX_Email.Text = Data_Setting.Email;
            User_Name.Text_Name = Data_Setting.User_Name;
        }
        private void Load_Data_Users_Update()
        {
            data.Load(Data_Setting.id);
            TX_name.Text = Data_Setting.Name;
            TX_Username.Text = Data_Setting.User_Name;
            TX_Password.Text = Data_Setting.Password;
            TX_Email.Text = Data_Setting.Email;
            User_Name.Text_Name = Data_Setting.User_Name;
        }
        private void animate()
        {
        //    char[] text = new char[Virs.Text.Length];
        //text = Virs.Text.ToArray();
        //    for(int i = 0; i<Virs.Text.Length; i++)
        //    {
        //        Virs.Text += text[i];
        //        Virs.ForeColor = Color.Gold;



        //    }
         }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
        }

        private void update_type_Click(object sender, EventArgs e)
        {
          
         
            
            
                Message_Word.Style = MessageDialogStyle.Light;
                Message_Word.Icon = MessageDialogIcon.Error;
                Message_Word.Buttons = MessageDialogButtons.OK;
                if (TX_Username.Text.Length < 5)
                {

                    Message_Word.Show("  اسم المستخدم قصير جداً" + "\n" + "\n" + "يرجى ادخال اسم مستخدم صحيح", "خطأ");


                }
                else if (TX_Password.Text.Length< 8)
                {
                    Message_Word.Show("  كلمة السر قصيرة جداً" + "\n" + "\n" + "يرجى ادخال كلمة سر أكثر من 8 محارف", "خطأ");


                }
                else if (TX_Email.Text==Data_Setting.Email&& TX_name.Text == Data_Setting.Name&&
                TX_Password.Text == Data_Setting.Password&& TX_Username.Text == Data_Setting.User_Name)
                    {
                Message_Word.Icon = MessageDialogIcon.Warning;

                Message_Word.Show("لم تقم بإجراء اي تعديل", "تنبيه");
                      }
                else
                {
                    var Ckeck = data.Load(TX_Username.Text);
                    if (TX_Username.Text != Username &&
                        Ckeck == true)
                    {
                        Message_Word.Style = MessageDialogStyle.Light;
                        Message_Word.Icon = MessageDialogIcon.Error;
                        Message_Word.Buttons = MessageDialogButtons.OK;
                        Message_Word.Show("اسم المستخدم موجود مسبقاً", "فشل");
                    }
                    else
                    {
                        Message_Word.Style = MessageDialogStyle.Dark;
                        Message_Word.Icon = MessageDialogIcon.Question;
                        Message_Word.Buttons = MessageDialogButtons.YesNo;
                        DialogResult check = Message_Word.Show("هل تريد تعديل بياناتك الشخصية؟", "تعديل");
                        if (check == DialogResult.Yes)
                        {
                            Data_Base.Modify_user_in_the_same_account(Data_Setting.id, TX_name.Text, TX_Username.Text
                                , TX_Password.Text, TX_Email.Text);
                            Load_Data_Users_Update();
                            Message_Word.Buttons = MessageDialogButtons.OK;
                            Message_Word.Show("تم التعديل بنجاح", "نجاح");
                            Username = TX_Username.Text;
                        }
                    }
                }
        }

        private void TX_Username_TextChanged(object sender, EventArgs e)
        {
          
            var Ckeck = data.Load(TX_Username.Text);
            if (TX_Username.Text != Username &&
                Ckeck == true)
            {
                lbl.Text = "غير متاح";
            }
            else
            {
                if (TX_Username.Text != ""&& TX_Username.Text.Length>=5)
                {

                    lbl.Text = "متاح";
                }
                else
                {
                    lbl.Text = "";

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
