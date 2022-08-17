using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using System.Runtime.InteropServices;
using Guna.UI2.WinForms;
using BunifuAnimatorNS;
using Data_Access_Login;
using Zakate_project.login;

namespace Zakate_project.FORMS_GROUP
{
  
    public partial class Form_Login : Form
    {
        Form_Calculator_Host Caluc = new Form_Calculator_Host();
        Form_Reception rece = new Form_Reception();
        Users_Model user_domain = new Users_Model();
        Form_Home F_HOME_color = new Form_Home();
        Guna2MessageDialog mesage_login = new Guna2MessageDialog();


        private Random random;
        private Button cruntbutton;
            Guna2AnimateWindow animate = new Guna2AnimateWindow();
        public Form_Login()
        {
            random = new Random();
            InitializeComponent();
        
            Radio1.Visible = false;
            Radio2.Visible = false;
            Radio3.Visible = false;


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
            foreach (Control selbutton in pan_grope.Controls)
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




        private void T_Username_Enter_1(object sender, EventArgs e)
        {
            if (T_Username.Text == "UserName")
            {
                T_Username.Text = "";
                T_Username.ForeColor = Color.DarkGreen;
            }
        }

        private void T_Username_Leave(object sender, EventArgs e)
        {
            if (T_Username.Text =="")
            {
                T_Username.Text = "UserName";
                T_Username.ForeColor = Color.FromArgb(100, 100, 100);
            }
        }

        private void T_Password_Enter(object sender, EventArgs e)
        {
            if(T_Password.Text== "Password")
            {
                T_Password.Text = "";
                T_Password.ForeColor = Color.SeaGreen;
                T_Password.UseSystemPasswordChar = true;
            }
            
        }

        private void T_Password_Leave(object sender, EventArgs e)
        {
            if (T_Password.Text == "")
            {
                T_Password.Text = "Password";
                T_Password.ForeColor = Color.FromArgb(100, 100, 100);
                T_Password.UseSystemPasswordChar = false;
            }
        }

        private void Form_Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
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

        private void  B_Login_Click(object sender, EventArgs e)
        {
            mesage_login.Style = MessageDialogStyle.Light;
            mesage_login.Buttons = MessageDialogButtons.OK;
            mesage_login.Icon = MessageDialogIcon.Warning;

            if(Radio1.Checked==false && Radio2.Checked == false && Radio3.Checked == false)
            {
                mesage_login.Show(" يرجي تحديد نوعية الدخول","تنبيه");

            }
            else {
                if (T_Username.Text == "UserName" && T_Password.Text == "Password")
                {

                    mesage_login.Show(" يرجي ادخال اسم المستخدم وكلمة المرور","تنبيه");

                }
                else if (T_Username.Text == "UserName" && T_Password.Text != "Password")
                {
                    mesage_login.Show(" يرجي ادخال اسم المستخدم ","تنبيه");

                }
                else if (T_Username.Text != "UserName" && T_Password.Text == "Password")
                {
                    mesage_login.Show(" يرجي ادخال كلمة المرور "," تنبيه");

                }
                else
                {
                    if (Radio1.Checked == true)
                    {



                        var ValidLogin = user_domain.Login_Users(T_Username.Text, T_Password.Text, "Responsible");
                        if (ValidLogin == true)
                        {
                            this.Hide();
                            rece.ShowDialog();
                       
                            F_HOME_color.ShowDialog();


                        }
                        else
                        {
                            mesage_login.Show("  " + " "+"\""+ T_Username.Text+"\""+" " + "اسم المستخدم" + " \n"+"\n"+ ""+"او كلمة السر خطأ "+"","تنبيه");
                        }
                    }
                    else if (Radio2.Checked == true)
                    {



                        var ValidLogin = user_domain.Login_Users(T_Username.Text, T_Password.Text, "User");
                        if (ValidLogin == true)
                        {
                            Text = T_Username.Text;

                            this.Hide();
                            rece.ShowDialog();
                            F_HOME_color.show_F_Home_User();
                        }
                        else
                        {
                            mesage_login.Show("  " + " " + "\"" + T_Username.Text + "\"" + " " + "اسم المستخدم" + " \n" + "" + "او كلمة السر خطأ " + "", "تنبيه");

                        }
                    }
                    else if (Radio3.Checked == true)
                    {
                        var ValidLogin = user_domain.Login_Users(T_Username.Text, T_Password.Text, "Host");
                        if (ValidLogin == true)
                        {
                            this.Hide();
                            rece.ShowDialog();
                            Caluc.ShowDialog();
                        }
                    }
                }

            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            show_password.Checked = false;
            Radio3.Checked = false;
            Radio2.Checked = false;
            Radio1.Checked = true;
            T_Username.ReadOnly = false;
            T_Password.ReadOnly = false;
            T_Username.ForeColor = Color.FromArgb(100, 100, 100);
            T_Password.ForeColor = Color.FromArgb(100, 100, 100);
            T_Username.Text = "UserName";
            T_Password.Text = "Password";
            T_Password.UseSystemPasswordChar = false;
            Activatebutton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show_password.Checked = false;
            Radio1.Checked = false;
            Radio3.Checked = false;
            Radio2.Checked = true;
            T_Username.ReadOnly = false;
            T_Password.ReadOnly = false;
            T_Username.ForeColor = Color.FromArgb(100, 100, 100);
            T_Password.ForeColor = Color.FromArgb(100, 100, 100);


            T_Username.Text = "UserName";
            T_Password.UseSystemPasswordChar = false;
            T_Password.Text = "Password";
            Activatebutton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            show_password.Checked = false;
            Radio2.Checked = false;
            Radio1.Checked = false;
            Radio3.Checked = true;
            T_Username.ReadOnly = true;
            T_Password.ReadOnly = true;
            Activatebutton(sender);
            T_Username.ForeColor = Color.SeaGreen;
            T_Password.ForeColor = Color.SeaGreen;
            T_Username.Text = "Host";
            T_Password.UseSystemPasswordChar = true;
            T_Password.Text = "Host";
        }

        private void T_Username_KeyPress(object sender, KeyPressEventArgs e)
        {
            mesage_login.Style = MessageDialogStyle.Light;
            mesage_login.Buttons = MessageDialogButtons.OK;
            mesage_login.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
            {
                e.Handled = true;
             
                mesage_login.Show(" لا يمكن ان يحتوي اسم المستخدم"+"\n"+" محارف باللغة العربية  ", " تنبيه");

            }
            else
            {
                e.Handled = false;
            }
        }

        private void T_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            mesage_login.Style = MessageDialogStyle.Light;
            mesage_login.Buttons = MessageDialogButtons.OK;
            mesage_login.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
            {
                e.Handled = true;
                mesage_login.Show(" لا يمكن ان تحتوي كلمة المرور " + "\n" + " محارف باللغة العربية  ", " تنبيه");


            }
            else
            {
                e.Handled = false;
            }
        }

        private void show_password_OnChange(object sender, EventArgs e)
        {
            mesage_login.Style = MessageDialogStyle.Light;
            mesage_login.Buttons = MessageDialogButtons.OK;
            mesage_login.Icon = MessageDialogIcon.Error;
            if (T_Password.Text !="Password")
            {if( T_Password.Text == "Host")
                {
                    T_Password.UseSystemPasswordChar = true;
                    mesage_login.Show(" لا يمكن اظهار كلمة السر"+"\n"+ "\"الحساب محمي\"", " خطأ");
                }
                else if (T_Password.UseSystemPasswordChar == false)
                {
                    T_Password.UseSystemPasswordChar = true;
                }
                else if (T_Password.UseSystemPasswordChar == true)
                {
                    T_Password.UseSystemPasswordChar = false;
                }
            }
        }

     

        private void T_Username_TextChanged(object sender, EventArgs e)
        {
            User_Name.Text_Name = T_Username.Text;

        }
    }
}
