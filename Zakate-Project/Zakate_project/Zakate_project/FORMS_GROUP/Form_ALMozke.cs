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
using Zakate_project.login;



namespace Zakate_project.FORMS_GROUP
{
    public partial class Form_ALMozke : Form
    {
        Form_math_moz Math_Moz = new Form_math_moz();
        Guna2MessageDialog message_work = new Guna2MessageDialog();
        conction.Cls_conctin reade = new conction.Cls_conctin();
        Classes.Cls_Process data_Edite = new Classes.Cls_Process();
        Data_Setting data = new Data_Setting();
        private string Gender;
        private Button cruntbutton;//varible
        private Random random;//varible
        private int temp_index;
        private Form activeform;
        public Form_ALMozke()
        {
            random = new Random();
            InitializeComponent();
            data.Load(User_Name.Text_Name);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            data_show_moz.DataSource = data_Edite.View_Don();
            data_show_moz.Columns[0].Width = 55;
            data_show_moz.Columns[1].Width = 65;
            data_show_moz.Columns[2].Width = 65;
            data_show_moz.Columns[3].Width = 150;
            data_show_moz.Columns[4].Width = 100;
            data_show_moz.Columns[5].Width = 50;
            data_show_moz.Columns[6].Width = 150;
            data_show_moz.Columns[7].Width = 150;
            data_show_moz.Columns[8].Width = 150;









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
                index = random.Next(Cls_Thime_Color.colorlist.Count);
            }
            temp_index = index;
            string Color = Cls_Thime_Color.colorlist[index];
            return ColorTranslator.FromHtml(Color);
        }
        public void Activatebutton(object btnsander)
        {
            Diseblebutton_HOME();
            if (btnsander != null)
            {
                if (cruntbutton != (Button)btnsander)
                {
                    Color color = selectThimecolor_HOME();
                    cruntbutton = (Button)btnsander;
                    cruntbutton.BackColor = color;
                    cruntbutton.ForeColor = Color.White;
                    cruntbutton.Font = new System.Drawing.Font("AGA Arabesque", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void Diseblebutton_HOME()
        {
            foreach (Control selbutton in pan_gruop_moz.Controls)
            {
                if (selbutton.GetType() == typeof(Button))
                {
                    selbutton.BackColor = Color.SeaGreen;
                    selbutton.ForeColor = Color.White;
                    selbutton.Font = new System.Drawing.Font("AGA Arabesque", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void btn_Home_moz_Click(object sender, EventArgs e)
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
                Form_Home Home = new Form_Home();
                Home.Show();

            }
        }
        private void btn_type_moz_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            this.Hide();
            Form_Type object1 = new Form_Type();
            object1.Show();

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_logo_moz_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_logo_text_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pan_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btn_item_moz_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

            this.Hide();
            FORMS_GROUP.Form_Item object_item = new FORMS_GROUP.Form_Item();
            object_item.Show();

        }

        private void btn_reports_moz_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
            this.Close();
            Form_Dashbord d1 = new Form_Dashbord();
            d1.ShowDialog();

        }

        private void btn_note_moz_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

        private void btn_settings_moz_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

        private void btn_about_moz_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }
        private void txt_id_moz_KeyPress(object sender, KeyPressEventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ' || e.KeyChar == '`'
                || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '@'
                || e.KeyChar == '!' || e.KeyChar == '^' || e.KeyChar == '&' || e.KeyChar == '('
                || e.KeyChar == ')' || e.KeyChar == '_' || e.KeyChar == '~'
                || e.KeyChar == '/' || e.KeyChar == ';')
            {
                e.Handled = true;
                message_work.Show("يرجى ادخال ارقام فقط ", "تنبيه");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_phone_moz_KeyPress(object sender, KeyPressEventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ' || e.KeyChar == '`'
                || e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '@'
                || e.KeyChar == '!' || e.KeyChar == '^' || e.KeyChar == '&' || e.KeyChar == '('
                || e.KeyChar == ')' || e.KeyChar == '_' || e.KeyChar == '~'
                || e.KeyChar == '/' || e.KeyChar == ';')
            {
                e.Handled = true;
                message_work.Show("يرجى ادخال ارقام فقط ", "تنبيه");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void math_zaka_Moz_Click(object sender, EventArgs e)
        {
            Math_Moz.ShowDialog();
            txMony.Text= Data_Zaka.Value_Monye_Gold;
            Tx_nsba.Text = Data_Zaka.Value_Zakah_Gold;
            Tx_M_Sil.Text = Data_Zaka.Value_Monye_Silver;
            Tx_Z_Sil.Text = Data_Zaka.Value_Zakah_Silver;
            Tx_M_Money.Text = Data_Zaka.Value_Monye_Money;
            Tx_CR_M.Text = Data_Zaka.Value_Monye_Crops;
            Tx_CR_Z.Text = Data_Zaka.Value_Zakah_Crops;
            ////
            Tx_CR_M_n.Text = Data_Zaka.Value_Monye_Crops_n;
            Tx_CR_Z_n.Text = Data_Zaka.Value_Zakah_Crops_n;
            Tx_LiveS_Z_G.Text = Data_Zaka.Value_Zakah_Livestock;
            Tx_LiveS_M_G.Text = Data_Zaka.Value_Monye_Livestock;
            Tx_M_B.Text = Data_Zaka.Value_Monye_Livestock_b;
            Tx_Z_B.Text = Data_Zaka.Value_Zakah_Livestock_b;
            Tx_Abel_M.Text = Data_Zaka.Value_Monye_Livestock_A;
            Tx_Abel_Z.Text = Data_Zaka.Value_Zakah_Livestock_A;
            Data_Zaka.Value_Monye_Livestock_A = "";
            Data_Zaka.Value_Zakah_Livestock_A="";
            Data_Zaka.Value_Zakah_Livestock_b = "";
            Data_Zaka.Value_Monye_Livestock_b = "";
            Data_Zaka.Value_Monye_Livestock = "";
            Data_Zaka.Value_Zakah_Livestock = "";
            Data_Zaka.Value_Monye_Crops = "";
            Data_Zaka.Value_Zakah_Crops = "";
            Data_Zaka.Value_Zakah_Crops_n = "";
            Data_Zaka.Value_Monye_Crops_n = "";
            Data_Zaka.Value_Monye_Money = "";
            Data_Zaka.Value_Zakah_Silver = "";
            Data_Zaka.Value_Monye_Silver = "";
            Data_Zaka.Value_Monye_Gold = "";
            Data_Zaka.Value_Zakah_Gold = "";




        }

        private void add_type_Click(object sender, EventArgs e)
        {
            try
            {

                if (txMony.Text == "" && Tx_nsba.Text == "" && Tx_M_Sil.Text == "" && Tx_Z_Sil.Text == ""
                          && Tx_M_Money.Text == "" && Tx_CR_M.Text == "" && Tx_CR_Z.Text == "" &&
                        Tx_CR_M_n.Text == "" && Tx_CR_Z_n.Text == "" && Tx_LiveS_Z_G.Text == "" &&
                        Tx_LiveS_M_G.Text == "" && Tx_M_B.Text == "" && Tx_Z_B.Text == "" &&
                        Tx_Abel_M.Text == "" && Tx_Abel_Z.Text == "")
                {
                    message_work.Style = MessageDialogStyle.Light;
                    message_work.Icon = MessageDialogIcon.Error;
                    message_work.Buttons = MessageDialogButtons.OK;
                    message_work.Show("لم يتم إضافة اي عملية زكاة", "خطأ");
                }
                else
                {
                    if (txt_id_moz.Text == "" || txt_First_Name_moz.Text == "" ||
                       txt_Last_Name_moz.Text == "" || date_moz.Text == "" || com_status_moz.Text == "" ||
                       txt_phone_moz.Text == "" || rdu_male_moz.Checked == false && rdu_female_moz.Checked == false)
                    {
                        message_work.Style = MessageDialogStyle.Light;
                        message_work.Icon = MessageDialogIcon.Error;
                        message_work.Buttons = MessageDialogButtons.OK;

                        message_work.Show(" يرجى إدخال جميع البيانات للمزكي", "خطأ");
                    }
                    else
                    {
                        message_work.Style = MessageDialogStyle.Dark;
                        message_work.Icon = MessageDialogIcon.Question;
                        message_work.Buttons = MessageDialogButtons.YesNo;
                        DialogResult check = message_work.Show("هل تريد الإضافة", "إاضافة");
                        if (check == DialogResult.Yes)
                        {
                            data_Edite.insert_Don(Convert.ToInt32(txt_id_moz.Text), txt_First_Name_moz.Text
                            , txt_Last_Name_moz.Text, date_moz.Value.ToShortDateString(), txt_phone_moz.Text
                            , txt_address_moz.Text, Gender, com_status_moz.Text, Data_Setting.id);
                            if (txMony.Text != "")
                            {
                                data_Edite.insert_processer("الذهب", Convert.ToInt32(txt_id_moz.Text), Convert.ToSingle(txMony.Text)
                                 , DateTime.Now, Data_Setting.id, 1);
                            }
                            else
                            { }
                            if (Tx_M_Sil.Text != "")
                            {
                                data_Edite.insert_processer("الفضة", Convert.ToInt32(txt_id_moz.Text), Convert.ToSingle(Tx_M_Sil.Text)
                                     , DateTime.Now, Data_Setting.id, 1);
                            }
                            else
                            { }
                            if (Tx_CR_M.Text != "")
                            {
                                data_Edite.insert_processer(Data_Zaka.Type_Crops, Convert.ToInt32(txt_id_moz.Text), Convert.ToSingle(Tx_CR_M.Text)
                                     , DateTime.Now, Data_Setting.id, 3);
                            }
                            if (Tx_CR_M_n.Text != "")
                            {
                                data_Edite.insert_processer(Data_Zaka.Type_Crops_N, Convert.ToInt32(txt_id_moz.Text), Convert.ToSingle(Tx_CR_M_n.Text)
                                     , DateTime.Now, Data_Setting.id, 4);
                            }
                            message_work.Buttons = MessageDialogButtons.OK;
                            message_work.Icon = MessageDialogIcon.Information;
                            message_work.Show("تمت الإضافة بنجاح", "نجاح");
                            txt_id_moz.Clear();
                            txt_First_Name_moz.Clear();
                            txt_Last_Name_moz.Clear();
                            com_status_moz.SelectedIndex = -1;
                            txt_phone_moz.Clear();
                            txt_address_moz.Clear();
                            rdu_male_moz.Checked = false;
                            rdu_female_moz.Checked = false;
                            txMony.Clear();
                            Tx_nsba.Clear();
                            Tx_M_Sil.Clear();
                            Tx_Z_Sil.Clear();
                            Tx_M_Money.Clear();
                            Tx_CR_M.Clear();
                            Tx_CR_Z.Clear();
                            Tx_CR_M_n.Clear();
                            Tx_CR_Z_n.Clear();
                            Tx_LiveS_Z_G.Clear();
                            Tx_LiveS_M_G.Clear();
                            Tx_M_B.Clear();
                            Tx_Z_B.Clear();
                            Tx_Abel_M.Clear();
                            Tx_Abel_Z.Clear();

                        }
                        data_show_moz.DataSource = data_Edite.View_Don();
                    }
                }
            }
            catch
            {
                message_work.Style = MessageDialogStyle.Light;
                message_work.Icon = MessageDialogIcon.Error;
                message_work.Buttons = MessageDialogButtons.OK;
                message_work.Show("أدخل البيانات بشكل صحيح", "خطأ");
            }
          



        }

        private void rdu_male_moz_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "ذكر";
        }

        private void rdu_female_moz_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "انثى";

        }

        private void update_type_Click(object sender, EventArgs e)
        {
            data_Edite.Update_Don(Convert.ToInt32(txt_id_moz.Text), txt_First_Name_moz.Text
                            , txt_Last_Name_moz.Text, date_moz.Value.ToShortDateString(), txt_phone_moz.Text
                            , txt_address_moz.Text, Gender, com_status_moz.Text, Data_Setting.id);
                        data_show_moz.DataSource = data_Edite.View_Don();

        }
    }
}