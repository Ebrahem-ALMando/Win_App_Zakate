using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Runtime.InteropServices;


namespace Zakate_project.FORMS_GROUP
{
    public partial class Form_Item : Form
    {
        Guna2MessageDialog message = new Guna2MessageDialog();
        Form_Home F_HOME_color = new Form_Home();
        //int count;
        Classes.Cls_Process dept = new Classes.Cls_Process();
        
        private Button cruntbutton;//varible
        private Random random;//varible
        private int temp_index;

        public Form_Item()
        {
            
            InitializeComponent();
            random = new Random();
            data_Item.DataSource = dept.select_item();
            this.Text = string.Empty;
            this.ControlBox = false;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color selectThimecolor()
        {
            return F_HOME_color.selectThimecolor_HOME();
        }
        private void Activatebutton(object btnsander)
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
        private void Diseblebutton()
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void Form_Item_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

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
        
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Form_Item_Load(object sender, EventArgs e)
        {
            Text_id.Clear();
            Text_item.Clear();
            //count =Convert.ToInt32( data_Add_Type.CurrentRow.Cells[0].Value.ToString())+2;
            //Text_id.Text = Convert.ToString(count);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            this.Close();
            Form_Type F_Type = new Form_Type();
            F_Type.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            this.Close();
            Form_ALMozke F_almozke = new Form_ALMozke();
            F_almozke.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time_now.Text = DateTime.Now.ToString("h:mm:ss ");
            date_now.Text = DateTime.Now.ToString("d/MM/yyyy");
        }

        private void date_now_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      

        private void data_Item_SelectionChanged_1(object sender, EventArgs e)
        {
            if (data_Item.CurrentRow != null)
            {
                Text_id.Text = data_Item.CurrentRow.Cells[0].Value.ToString();
                Text_item.Text = data_Item.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

            message.Style = MessageDialogStyle.Dark;
            message.Icon = MessageDialogIcon.Question;
            message.Buttons = MessageDialogButtons.YesNo;
            if (Text_id.Text == "" && Text_item.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الرقم والاسم من فضلك", "تنبيه");
            }
            else if (Text_id.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الرقم من فضلك", "تنبيه");
            }
            else if (Text_item.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الاسم من فضلك", "تنبيه");
            }
            else
            {
                try
                {
                    DialogResult check = message.Show("هل تريد اضافة", "حفظ ");

                    if (check == DialogResult.Yes)

                    {
                        dept.insert_item(Convert.ToInt32(Text_id.Text), Text_item.Text);
                        data_Item.DataSource = dept.select_item();
                        message.Buttons = MessageDialogButtons.OK;
                        message.Show("تمت الإضافة بنجاح");
                        Text_id.Clear();
                        Text_item.Clear();
                    }
                }
                catch
                {
                    message.Buttons = MessageDialogButtons.OK;
                    message.Show("ادخل الرقم بشكل صحيح", "تنبيه");
                }
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            if (Text_id.Text == "1" || Text_id.Text == "2" || Text_id.Text == "3" || Text_id.Text == "4"
              || Text_id.Text == "5")
            {
                message.Style = MessageDialogStyle.Light;
                message.Icon = MessageDialogIcon.Warning;
                message.Buttons = MessageDialogButtons.OK;
                message.Show("لا يمكن حذف صنف اساسي", "فشلت العملية");

            }
            else
            {
                try
                {
                    message.Style = MessageDialogStyle.Dark;
                    message.Icon = MessageDialogIcon.Question;
                    message.Buttons = MessageDialogButtons.OKCancel;
                    DialogResult check = message.Show("هل تريد الحذف؟", "حذف");
                    if (check == DialogResult.OK)
                    {
                        dept.delete_item(Convert.ToInt32(Text_id.Text));
                        data_Item.DataSource = dept.select_item();
                        message.Style = MessageDialogStyle.Dark;
                        message.Icon = MessageDialogIcon.Information;
                        message.Buttons = MessageDialogButtons.OK;
                        message.Show("تم الحذف بنجاح", "حذف");

                        Text_id.Clear();
                        Text_item.Clear();
                    }
                }
                catch
                {
                    message.Buttons = MessageDialogButtons.OK;
                    message.Show("يرجى تحديد السجل المطلوب", "خطأ");
                }

            }
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {

            if (Text_item.Text == data_Item.CurrentRow.Cells[1].Value.ToString() &&
                Text_id.Text == data_Item.CurrentRow.Cells[0].Value.ToString())
            {
                message.Style = MessageDialogStyle.Dark;
                message.Icon = MessageDialogIcon.Warning;
                message.Buttons = MessageDialogButtons.OK;
                message.Show("! ! ! لم تقم بإجراء اي تعديل ", "فشلت العملية");
            }
            else if (Text_id.Text != data_Item.CurrentRow.Cells[0].Value.ToString() &&
                Text_item.Text == data_Item.CurrentRow.Cells[1].Value.ToString())
            {
                message.Style = MessageDialogStyle.Light;
                message.Icon = MessageDialogIcon.Warning;
                message.Buttons = MessageDialogButtons.OK;
                message.Show("! ! ! لا يمكن تعديل رقم الصنف ", "فشلت العملية");
            }
            else if (Text_id.Text != data_Item.CurrentRow.Cells[0].Value.ToString() &&
                     Text_item.Text != data_Item.CurrentRow.Cells[1].Value.ToString())
            {
                message.Style = MessageDialogStyle.Light;
                message.Icon = MessageDialogIcon.Warning;
                message.Buttons = MessageDialogButtons.OK;
                message.Show("! ! ! لا يمكن تعديل رقم الصنف ", "فشلت العملية");
            }
            else
            {
                message.Style = MessageDialogStyle.Dark;
                message.Icon = MessageDialogIcon.Question;
                message.Buttons = MessageDialogButtons.OKCancel;
                DialogResult check = message.Show("هل تريد التعديل؟", "تعديل");
                if (check == DialogResult.OK)
                {
                    dept.update_item(Convert.ToInt32(Text_id.Text), Text_item.Text);
                    data_Item.DataSource = dept.select_item();
                    message.Style = MessageDialogStyle.Dark;
                    message.Icon = MessageDialogIcon.Information;
                    message.Buttons = MessageDialogButtons.OK;
                    message.Show("تم التعديل بنجاح", "تعديل");
                }
            }
        }
    }
}
