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


namespace Zakate_project.FORMS_GROUP
{
    public partial class Form_Home : Form
    {
        
        private Button cruntbutton;//varible
        private Random random;//varible
        private int temp_index;
        Guna2MessageDialog message_work = new Guna2MessageDialog();

        public Form_Home()
        {
          InitializeComponent();
          
            message_work.Style = MessageDialogStyle.Light;
            message_work.Icon = MessageDialogIcon.Warning;
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Color selectThimecolor_HOME()
        {
            int index = random.Next(Cls_Thime_Color.colorlist.Count);
            while (temp_index == index)
            {
               index= random.Next(Cls_Thime_Color.colorlist.Count);
            }
            temp_index = index;
            string Color = Cls_Thime_Color.colorlist[index];
            return ColorTranslator.FromHtml(Color);
        }
        public void Activatebutton_HOME(object btnsander)
        {
            Diseblebutton_HOME();
            if (btnsander != null)
            {
                if (cruntbutton != (Button)btnsander)
                {
                    Color color = selectThimecolor_HOME();
                    cruntbutton = (Button)btnsander;
                    cruntbutton.BackColor = color;
                    cruntbutton.ForeColor=Color.White;
                    cruntbutton.Font = new System.Drawing.Font("AGA Arabesque", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void Diseblebutton_HOME()
        {
            foreach(Control selbutton in pan_grope.Controls)
            {
                if (selbutton.GetType() == typeof(Button))
                {
                    selbutton.BackColor = Color.SeaGreen;
                    selbutton.ForeColor = Color.White;
                    selbutton.Font= new System.Drawing.Font("AGA Arabesque", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
          

        }

        private void timer_time_H_Tick(object sender, EventArgs e)
        {
            time_now.Text = DateTime.Now.ToString("h:mm:ss ");
            date_now.Text = DateTime.Now.ToString("d/MM/yyyy");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Activatebutton_HOME(sender);
            this.Close();
            FORMS_GROUP.Form_ALMozke F_almozke = new FORMS_GROUP.Form_ALMozke();
            F_almozke.Show();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);
            this.Hide();
            Form_Type object1 = new Form_Type();
            object1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);
            this.Close();
            FORMS_GROUP.Form_Item object_item = new FORMS_GROUP.Form_Item();
            object_item.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);
            this.Close();
            Form_Dashbord d1 = new Form_Dashbord();
            d1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
          
            Activatebutton_HOME(sender);
            this.Close();
            Form_Users user = new Form_Users();
            user.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);
            Form_Setting setting = new Form_Setting();
            setting.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);
            Guna2MessageDialog message_about = new Guna2MessageDialog();
            message_about.Style = MessageDialogStyle.Light;
            message_about.Icon = MessageDialogIcon.Information;
            message_about.Show("about. . . . ");    
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);
        
            message_work.Show("الواجهة قيد العمل  ", "تنبيه");
            

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
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

        private void date_now_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form_Home_MaximumSizeChanged(object sender, EventArgs e)
        {
         
            //if (FormWindowState.Maximized == FormWindowState.Maximized)
            //{
            //    pictureBox1.Location = new System.Drawing.Point(320, 150);
            //    pictureBox2.Location = new System.Drawing.Point(411, 500);
            //}
            //   else
            //    {
            //        pictureBox1.Location = new System.Drawing.Point(336, 95);
            //        pictureBox2.Location = new System.Drawing.Point(411, 411);
            //    }
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {

        }
        public void show_F_Home_User()
        {
            Form_Home f = new Form_Home();
           /* Guna2AnimateWindow animate = new Guna2AnimateWindow();
            animate.AnimationType = Guna2AnimateWindow.AnimateWindowType.AW_VER_NEGATIVE;
            animate.TargetForm = f;*/
            f.bt_Reports.Visible = false;
            f.bt_User.Visible = false;
            f.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
          
            Activatebutton_HOME(sender);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Activatebutton_HOME(sender);
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.YesNo;
            message_work.Icon = MessageDialogIcon.Question;
            DialogResult check = message_work.Show("هل تريد تسجيل الخروج ", "خروج");
            if (check == DialogResult.Yes)
            {
                this.Hide();
                Form_Login login = new Form_Login();
                login.ShowDialog();
            }
        }

      

        private void date_now_Click(object sender, EventArgs e)
        {

        }
    }
}
