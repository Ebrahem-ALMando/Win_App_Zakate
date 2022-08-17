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
    public partial class Form_Type : Form
    {
        Guna2MessageDialog message = new Guna2MessageDialog();
        Form_Home F_HOME_color = new Form_Home();
        FORMS_GROUP.Form_Item F_item = new FORMS_GROUP.Form_Item();
        FORMS_GROUP.Form_ALMozke F_almozke = new FORMS_GROUP.Form_ALMozke();
        Classes.Cls_Process Type = new Classes.Cls_Process();
        conction.Cls_conctin reade = new conction.Cls_conctin();
        private Button cruntbutton;//varible
        private Random random;//varible
        int count;
        public Form_Type()
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            InitializeComponent();
            random = new Random();
            data_Add_Type.DataSource = Type.select_Type();
            combo_type.DataSource = reade.Read_Data("select_Item_comp", null);
            combo_type.DisplayMember = "Item_name";
            combo_type.ValueMember = "Item_id";
            Text_id.Clear();
            

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color selectThimecolor()
        {
        return  F_HOME_color.selectThimecolor_HOME();
        }
        //public void Test_Eroor()
        //{
        //    message.Style = MessageDialogStyle.Light;
        //    message.Icon = MessageDialogIcon.Warning;
        //    message.Buttons = MessageDialogButtons.OK;
        //    if (Text_id.Text == "" && name_type.Text == "" && nsba.Text == "")
        //    {
        //        message.Buttons = MessageDialogButtons.OK;
        //        message.Show("أدخل المعلومات من فضلك", "تنبيه");
        //    }
        //    else if (name_type.Text == "" && nsba.Text == "")
        //    {
        //        message.Buttons = MessageDialogButtons.OK;
        //        message.Show("أدخل الاسم ونسبة الزكاة من فضلك", "تنبيه");
        //    }
        //    else if (Text_id.Text == "" && name_type.Text == "")
        //    {
        //        message.Buttons = MessageDialogButtons.OK;
        //        message.Show("أدخل الرقم والاسم من فضلك", "تنبيه");
        //    }
        //    else if (Text_id.Text == "" && nsba.Text == "")
        //    {
        //        message.Buttons = MessageDialogButtons.OK;
        //        message.Show("أدخل الرقم والنسبة من فضلك", "تنبيه");
        //    }
        //    else if (nsba.Text == "")
        //    {
        //        message.Buttons = MessageDialogButtons.OK;
        //        message.Show("أدخل نسبة الزكاة من فضلك", "تنبيه");
        //    }
        //    else if (name_type.Text == "")
        //    {
        //        message.Buttons = MessageDialogButtons.OK;
        //        message.Show("أدخل الاسم  من فضلك", "تنبيه");
        //    }
        //    else if (Text_id.Text == "")
        //    {
        //        message.Buttons = MessageDialogButtons.OK;
        //        message.Show("أدخل الرقم  من فضلك", "تنبيه");
        //    }
        //}
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
            foreach (Control selbutton in pan_grope_add_Type.Controls)
            {
                if (selbutton.GetType() == typeof(Button))
                {
                    selbutton.BackColor = Color.SeaGreen;
                    selbutton.ForeColor = Color.White;
                    selbutton.Font = new System.Drawing.Font("AGA Arabesque", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

            private void button1_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            Guna2MessageDialog obt_message_back = new Guna2MessageDialog();
            obt_message_back.Icon = MessageDialogIcon.Question;
            obt_message_back.Style = MessageDialogStyle.Light;
            obt_message_back.Buttons = MessageDialogButtons.YesNo;
            DialogResult check = obt_message_back.Show("هل تريد العودة الى الواجهةالرئيسية ؟");
            if (check == DialogResult.Yes){
                F_HOME_color.Show();
                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            this.Close();
            F_item.Show();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            this.Close();
            F_almozke.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

     
        private void Form_Type_Load(object sender, EventArgs e)
        {

            //Text_id.Text = Type.value_type_id().ToString();
           
            name_type.Clear();
            nsba.Clear();
        }
      

        private void Text_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                e.Handled = true;
            else if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
                e.Handled = true;
            else if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void nsba_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z')
                e.Handled = true;
            else if (e.KeyChar >= 'ا' && e.KeyChar <= 'ي')
                e.Handled = true;
            else if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.Handled = true;
            else
                e.Handled = false;
        }


        private void add_type_Click(object sender, EventArgs e)
        {

            message.Style = MessageDialogStyle.Light;
            message.Icon = MessageDialogIcon.Warning;
            message.Buttons = MessageDialogButtons.OK;
            if (Text_id.Text == "" && name_type.Text == "" && nsba.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل المعلومات من فضلك", "تنبيه");
            }
            else if (name_type.Text == "" && nsba.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الاسم ونسبة الزكاة من فضلك", "تنبيه");
            }
            else if (Text_id.Text == "" && name_type.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الرقم والاسم من فضلك", "تنبيه");
            }
            else if (Text_id.Text == "" && nsba.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الرقم والنسبة من فضلك", "تنبيه");
            }
            else if (nsba.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل نسبة الزكاة من فضلك", "تنبيه");
            }
            else if (name_type.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الاسم  من فضلك", "تنبيه");
            }
            else if (Text_id.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الرقم  من فضلك", "تنبيه");
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
                        Type.insert_Type(Convert.ToInt32(Text_id.Text), name_type.Text, Convert.ToInt32(combo_type.SelectedValue),
                         Convert.ToSingle(nsba.Text));
                        data_Add_Type.DataSource = Type.select_Type();
                        message.Buttons = MessageDialogButtons.OK;
                        message.Show("تمت الإضافة بنجاح");
                        Text_id.Clear();
                        Text_id.Text = count.ToString();
                        name_type.Clear();
                        nsba.Clear();

                    }

                }
                catch
                {
                    message.Buttons = MessageDialogButtons.OK;
                    message.Show("ادخل الرقم بشكل صحيح", "تنبيه");

                }
            }
        }

      

        private void remove_type_Click_1(object sender, EventArgs e)
        {
            message.Style = MessageDialogStyle.Light;
            message.Icon = MessageDialogIcon.Warning;


            if (Text_id.Text == "")
            {
                message.Show("أدخل رقم العنصر المراد حذفه");
            }
            else
            {

                try
                {
                    message.Style = MessageDialogStyle.Dark;
                    message.Icon = MessageDialogIcon.Question;
                    message.Buttons = MessageDialogButtons.YesNo;
                    DialogResult chick = message.Show("هل تريد الحذف بالتأكيد ؟", "حذف");
                    if (chick == DialogResult.Yes)
                    {
                        message.Buttons = MessageDialogButtons.OK;
                        message.Icon = MessageDialogIcon.Information;
                        Type.delete_type(Convert.ToInt32(Text_id.Text));
                        data_Add_Type.DataSource = Type.select_Type();
                        message.Show("تم الحذف بنجاح", "تمت العملية");
                        Text_id.Clear();
                        name_type.Clear();
                        nsba.Clear();
                    }

                }
                catch (Exception me)
                {
                    message.Show(me.Message, "فشلت العملية");
                }
            }
        }

        private void update_type_Click(object sender, EventArgs e)
        {
            message.Style = MessageDialogStyle.Light;
            message.Icon = MessageDialogIcon.Warning;
            message.Buttons = MessageDialogButtons.OK;
            if (Text_id.Text == "" && name_type.Text == "" && nsba.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل المعلومات من فضلك", "تنبيه");
            }
            else if (name_type.Text == "" && nsba.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الاسم ونسبة الزكاة من فضلك", "تنبيه");
            }
            else if (Text_id.Text == "" && name_type.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الرقم والاسم من فضلك", "تنبيه");
            }
            else if (Text_id.Text == "" && nsba.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الرقم والنسبة من فضلك", "تنبيه");
            }
            else if (nsba.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل نسبة الزكاة من فضلك", "تنبيه");
            }
            else if (name_type.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الاسم  من فضلك", "تنبيه");
            }
            else if (Text_id.Text == "")
            {
                message.Buttons = MessageDialogButtons.OK;
                message.Show("أدخل الرقم  من فضلك", "تنبيه");
            }

            else
            {
                message.Style = MessageDialogStyle.Dark;
                message.Icon = MessageDialogIcon.Question;
                message.Buttons = MessageDialogButtons.YesNo;
                DialogResult chick = message.Show("هل تريد التعديل باالتأكيد ؟", "تعديل");
                if (chick == DialogResult.Yes)
                {
                    Type.update_Type(Convert.ToInt32(Text_id.Text), name_type.Text, Convert.ToInt32(combo_type.SelectedValue),
                     Convert.ToSingle(nsba.Text));
                    data_Add_Type.DataSource = Type.select_Type();
                    message.Icon = MessageDialogIcon.Information;
                    message.Buttons = MessageDialogButtons.OK;
                    message.Show("تم التعديل بنجاح", "تمت العملية");

                    name_type.Clear();
                    nsba.Clear();

                }
            }
        }

        private void data_Add_Type_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                if (data_Add_Type.CurrentRow != null)
                {
                    Text_id.Text = data_Add_Type.CurrentRow.Cells[0].Value.ToString();
                    combo_type.Text = data_Add_Type.CurrentRow.Cells[2].Value.ToString();
                    name_type.Text = data_Add_Type.CurrentRow.Cells[1].Value.ToString();
                    nsba.Text = data_Add_Type.CurrentRow.Cells[3].Value.ToString();
                }
            }
            catch (Exception me)
            {
                Guna2MessageDialog Message_Add = new Guna2MessageDialog();
                Message_Add.Style = MessageDialogStyle.Dark;
                Message_Add.Icon = MessageDialogIcon.Information;
                Message_Add.Show(me.Message);
            }
        }
    }
}

