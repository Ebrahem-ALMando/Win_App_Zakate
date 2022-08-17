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
using Guna.UI2.WinForms;
using Zakate_project.Classes;
using Zakate_project.Classes.Calculator_Zakah;

namespace Zakate_project.FORMS_GROUP
{
    public partial class Form_Calculator_Host : Form
    {
        Calculator_livestock math_Livestock = new Calculator_livestock();
        Calculator_Crops math_Crops = new Calculator_Crops();
        Calculator_Money math_money = new Calculator_Money();
         Calculator_Gold math_Gold = new Calculator_Gold();
           Calculator_Silver Math_Silver = new Calculator_Silver();
        conction.Cls_conctin reade = new conction.Cls_conctin();
        Classes.Cls_Process dept = new Classes.Cls_Process();
        Form_Home F_HOME_color = new Form_Home();
        Guna2MessageDialog message_work = new Guna2MessageDialog();
        private Random random;
        private Button cruntbutton;
        public Form_Calculator_Host()
        {
            InitializeComponent();
            L_mos.Visible = false;
            Price_Sheep_Dol_mos.Visible = false;
            random = new Random();       
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            com_items_moz.DataSource = reade.Read_Data("select_Item_comp", null);
            com_items_moz.DisplayMember = "Item_name";
            com_items_moz.ValueMember = "Item_id";
            com_types_moz.DataSource = dept.Flter_Compo(1);
            com_types_moz.DisplayMember = "Type_name";
            com_types_moz.ValueMember = "TYPE_ID";
            Comp_gold_caliber.StartIndex = 0;
            Compo_caliber.StartIndex = 0;
            Como_Type_spotter.StartIndex = 0;

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

        private void date_now_MouseDown(object sender, MouseEventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activatebutton(sender);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_now.Text = DateTime.Now.ToString("h:mm:ss ");
            date_now.Text = DateTime.Now.ToString("d/MM/yyyy");
        }
        private void com_types_moz_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (com_types_moz.Text == "الذهب")
            {
                pan_crops.Visible = true;
                pan_monye.Visible = true;
                pan_Fda.Visible = true;
                pan_crops_not.Visible = true;
                pan_livestock.Visible = true;
                pan_child_moz.BringToFront();

            }
            else if (com_types_moz.Text == "الفضة")
            {
                pan_crops.Visible = true;
                pan_monye.Visible = true;
                pan_child_moz.Visible = true;
                pan_crops_not.Visible = true;
                pan_livestock.Visible = true;
                pan_Fda.BringToFront();
            }
            if (com_types_moz.Text == "الغنم السائمة")
            {
                L_tab.Text = " السعر بالدولار للغنم";
            }
            else if (com_types_moz.Text == "البقر السائمة")
            {
                L_tab.Text = "السعر بالدولار للتبيع";


            }
            else if (com_types_moz.Text == "الإبل السائمة")
            {
                L_tab.Text = "السعر بالدولار للإبل ";

            }
        }
        private void guna2TextBox17_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2TextBox13_KeyPress(object sender, KeyPressEventArgs e)
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
        private void guna2TextBox11_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2TextBox8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2TextBox9_KeyPress(object sender, KeyPressEventArgs e)
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
      

       

        private void com_items_moz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (com_items_moz.SelectedIndex != -1)
            {
                int i;

                Int32.TryParse(com_items_moz.SelectedValue.ToString(), out i);
                com_types_moz.DataSource = dept.Flter_Compo(i);
                com_types_moz.DisplayMember = "Type_name";
                com_types_moz.ValueMember = "TYPE_ID";
                if (com_items_moz.SelectedIndex == 0)
                {
                    pan_crops.Visible = true;
                    pan_monye.Visible = true;
                    pan_Fda.Visible = true;
                    pan_crops_not.Visible = true;
                    pan_livestock.Visible = true;
                    pan_child_moz.BringToFront();
                }
                else if (com_items_moz.Text == "المحاصيل المروية")
                {

                    pan_Fda.Visible = true;
                    pan_child_moz.Visible = true;
                    pan_monye.Visible = true;
                    pan_crops_not.Visible = true;
                    pan_livestock.Visible = true;
                    pan_crops.BringToFront();

                }
                else if (com_items_moz.Text == "المحاصيل غير المروية")
                {

                    pan_Fda.Visible = true;
                    pan_child_moz.Visible = true;
                    pan_monye.Visible = true;
                    pan_crops.Visible = true;
                    pan_livestock.Visible = true;
                    pan_crops_not.BringToFront();

                }

                else if (com_items_moz.Text == "الأموال التجارية")
                {

                    pan_crops.Visible = true;
                    pan_Fda.Visible = true;
                    pan_child_moz.Visible = true;
                    pan_crops_not.Visible = true;
                    pan_livestock.Visible = true;
                    pan_monye.BringToFront();
                }
                else if (com_items_moz.Text == "المواشي")
                {

                    pan_crops.Visible = true;
                    pan_Fda.Visible = true;
                    pan_child_moz.Visible = true;
                    pan_crops_not.Visible = true;
                    pan_monye.Visible = true;
                    pan_livestock.BringToFront();
                }
            }
        }

    
          private void text_Chang_Silver()
          {
            try
            {
                if (Nisba_Silver.Text != "" && Nisba_Silver.Text != " ")
                {
                    if (Convert.ToDouble(Nisba_Silver.Text) <
                     Math_Silver.Nisab_silver(Convert.ToDouble(Compo_caliber.Text)))
                    {

                        Value_zaka_Silver.Text = "لم يكتمل النصاب";
                        Value_zaka_dol.Text = "";

                    }
                    else
                    {
                        Value_zaka_Silver.Text = "";
                        Value_zaka_dol.Text = "";


                    }
                }
                else if (Nisba_Silver.Text == "")
                {
                    Value_zaka_Silver.Text = "";
                    Value_zaka_dol.Text = "";
                }
            }
            catch
            {
               
                message_work.Style = MessageDialogStyle.Light;
                message_work.Buttons = MessageDialogButtons.OK;
                message_work.Icon = MessageDialogIcon.Error;
                message_work.Show("يرجى ادخال ارقام فقط", "خطأ");
            }
          }
       

        private void Bt_math_zaka_S_Click(object sender, EventArgs e)
        {
            if (Value_zaka_Silver.Text == ""&& price_dol_S.Text!="")
            {
               double result= Math_Silver.math_zaka_silver(Convert.ToDouble(Nisba_Silver.Text),
                    Convert.ToDouble(Compo_caliber.Text));
                Value_zaka_Silver.Text = Math.Round(result, 4).ToString() + "غرام";
                double result_dol = result * Convert.ToDouble( price_dol_S.Text);
                Value_zaka_dol.Text =Math.Round( result_dol,2).ToString()+"$"+"دولار امريكي ";


            }
            else
            {
                message_work.Style = MessageDialogStyle.Light;
                message_work.Buttons = MessageDialogButtons.OK;
                message_work.Icon = MessageDialogIcon.Error;
                if(price_dol_S.Text == ""&& Nisba_Silver.Text == "")
                {
                    message_work.Show("يرجى ادخال البيانات ", "خطأ");

                }
                else if (Value_zaka_Silver.Text == "لم يكتمل النصاب")
                {
                    message_work.Show("يرجى التحقق من اكتمال النصاب  ", "خطأ");

                }
                else if (price_dol_S.Text == "")
                {
                    message_work.Show("يرجى ادخال سعر غرام الفضة ", "خطأ");
                }
               else if (Nisba_Silver.Text == "")
                {
                    message_work.Show("يرجى ادخال وزن الفضة ","خطأ");

                }
          

            }
        }

        private void Compo_caliber_SelectedIndexChanged(object sender, EventArgs e)
        {
            text_Chang_Silver();
        }

        private void Nisba_Silver_TextChanged(object sender, EventArgs e)
        {
            text_Chang_Silver();
        }

        private void price_dol_S_TextChanged(object sender, EventArgs e)
        {
            text_Chang_Silver();
        }

        private void Nisba_Silver_KeyPress(object sender, KeyPressEventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z'|| e.KeyChar >= 'a' && e.KeyChar <= 'z'||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي'||e.KeyChar==' ')
            {
                e.Handled = true;
                message_work.Show("يرجى ادخال ارقام فقط ", "تنبيه");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void price_dol_S_KeyPress(object sender, KeyPressEventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ')
            {
                e.Handled = true;
                message_work.Show("يرجى ادخال ارقام فقط ", "تنبيه");
            }
            else
            {
                e.Handled = false;
            }
        }
        private void Text_Change_Gold()
        {
            try {
                if (T_weight_Gold.Text != "")
                {
                    if (Convert.ToDouble(T_weight_Gold.Text) <
                        math_Gold.gold_spotter(Convert.ToDouble(Comp_gold_caliber.Text)))
                    {
                        Resolt_Z_Gold.Text = "لم يكتمل النصاب";
                        Price_Gold_Dol.Text = "";
                       
                    }
                    else
                    {
                        Resolt_Z_Gold.Text = "";
                        Price_Gold_Dol.Text = "";
                    } }
                else if(T_weight_Gold.Text=="")
                {
                    Resolt_Z_Gold.Text = "";
                    Price_Gold_Dol.Text = "";
                }
            }
            catch
            {
                message_work.Style = MessageDialogStyle.Light;
                message_work.Buttons = MessageDialogButtons.OK;
                message_work.Icon = MessageDialogIcon.Error;
                message_work.Show("يرجى ادخال ارقام فقط", "خطأ");
            }
        }

        private void T_weight_Gold_TextChanged(object sender, EventArgs e)
        {
            Text_Change_Gold();
        }

       

        private void T_Price_gold_TextChanged(object sender, EventArgs e)
        {
            Text_Change_Gold();
        }

        private void Bt_math_Zaka_Gold_Click(object sender, EventArgs e)
        {
            try
            {
                if (T_Price_gold.Text != "" && Resolt_Z_Gold.Text == "")
                {
                    double result = math_Gold.math_zaka_gold(Convert.ToDouble( T_weight_Gold.Text),
                       Convert.ToDouble(Comp_gold_caliber.Text));
                    Resolt_Z_Gold.Text = Math.Round(result, 4).ToString();
                    double resolt_Dol = result * Convert.ToDouble(T_Price_gold.Text);
                    Price_Gold_Dol.Text =Math.Round( resolt_Dol,2).ToString();
                }
                else
                {
                    message_work.Style = MessageDialogStyle.Light;
                    message_work.Buttons = MessageDialogButtons.OK;
                    message_work.Icon = MessageDialogIcon.Error;
                    if (T_Price_gold.Text == "" && T_weight_Gold.Text == "")
                    {
                        message_work.Show("يرجى ادخال البيانات ", "خطأ");

                    }
                    else if (Resolt_Z_Gold.Text == "لم يكتمل النصاب")
                    {
                        message_work.Show("يرجى التحقق من اكتمال النصاب  ", "خطأ");

                    }
                    else if (T_Price_gold.Text == "")
                    {
                        message_work.Show("يرجى ادخال سعر غرام الذهب ", "خطأ");
                    }
                    else if (T_weight_Gold.Text == "")
                    {
                        message_work.Show("يرجى ادخال وزن الذهب ", "خطأ");

                    }


                }
            }
            catch(Exception ex)
            {
                message_work.Show(ex.Message, "Error");
            }
        }

        private void T_weight_Gold_KeyPress(object sender, KeyPressEventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ')
            {
                e.Handled = true;
                message_work.Show("يرجى ادخال ارقام فقط ", "تنبيه");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void T_Price_gold_KeyPress(object sender, KeyPressEventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ')
            {
                e.Handled = true;
                message_work.Show("يرجى ادخال ارقام فقط ", "تنبيه");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Comp_gold_caliber_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text_Change_Gold();

        }
        private void Como_Type_spotter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(Como_Type_spotter.Text=="حسب نصاب الذهب")
            {
                L_Price_Silver.Visible = false;
                L_Calper_Silver.Visible =false;
                T_price_Silver.Visible = false;
                Comp_Silver_spo.Visible = false;
                Comp_Gold_spo.Visible = true;
                L_Gold_cl.Visible = true;
                TX_price_Gold.Visible = true;
                L_Price_Gold.Visible = true;
                Lbl_mo1.Visible = true;
                Lbl_mo.Visible = true;
                

            }
            else if (Como_Type_spotter.Text=="حسب نصاب الفضة")
            {
                this.Comp_Silver_spo.Location = new System.Drawing.Point(8, 100);
                this.T_price_Silver.Location = new System.Drawing.Point(8, 150);
                this.L_Calper_Silver.Location = new System.Drawing.Point(225, 102);
                this.L_Price_Silver.Location = new System.Drawing.Point(205, 150);


                L_Price_Silver.Visible = true;
                L_Calper_Silver.Visible = true;
                T_price_Silver.Visible = true;
                Comp_Silver_spo.Visible = true;
                L_Gold_cl.Visible = false;
                Comp_Gold_spo.Visible = false;
                TX_price_Gold.Visible = false;
                L_Price_Gold.Visible = false;
                Lbl_mo1.Visible = true;
                Lbl_mo.Visible = true;

            }
            else if(Como_Type_spotter.Text== "حسب اقل النصابين ")
            {
                this.Comp_Silver_spo.Location = new System.Drawing.Point(8, 185);
                this.T_price_Silver.Location = new System.Drawing.Point(8, 235);
                this.L_Calper_Silver.Location = new System.Drawing.Point(220, 190);
                this.L_Price_Silver.Location = new System.Drawing.Point(199, 240);
                L_Price_Silver.Visible = true;
                L_Calper_Silver.Visible = true;
                T_price_Silver.Visible = true;
                Comp_Silver_spo.Visible = true;
                Comp_gold_caliber.Visible = true;
                TX_price_Gold.Visible = true;
                L_Price_Gold.Visible = true;
                L_Gold_cl.Visible = true;
                Comp_Gold_spo.Visible = true;
                Lbl_mo1.Visible = false;
                Lbl_mo.Visible = false;
            }
        }

        private void TX_price_Gold_KeyPress(object sender, KeyPressEventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ')
            {
                e.Handled = true;
                message_work.Show("يرجى ادخال ارقام فقط ", "تنبيه");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void T_price_Silver_KeyPress(object sender, KeyPressEventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ')
            {
                e.Handled = true;
                message_work.Show("يرجى ادخال ارقام فقط ", "تنبيه");
            }
            else
            {
                e.Handled = false;
            }
        }
        //private void Checl_key_press()
        //{
        //    //KeyPressEventArgs e=new KeyPressEventArgs('A');
        //    //message_work.Style = MessageDialogStyle.Light;
        //    //message_work.Buttons = MessageDialogButtons.OK;
        //    //message_work.Icon = MessageDialogIcon.Warning;
        //    //if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
        //    //    e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ')
        //    //{
        //    //    e.Handled = true;
        //    //    message_work.Show("يرجى ادخال ارقام فقط ", "تنبيه");
        //    //}
        //    //else
        //    //{
        //    //    e.Handled = false;
        //    //}
        //}
        private void guna2TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' ')
            {
                e.Handled = true;
                message_work.Show("يرجى ادخال ارقام فقط ", "تنبيه");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Text_Change_Money()
        {
            if (Como_Type_spotter.SelectedIndex == 0)
            {
                try {
                    if (T_amuont.Text != "")
                    {
                        if (math_money.math_zaka_money_gold(Convert.ToDouble(T_amuont.Text), Convert.ToDouble(Comp_Gold_spo.Text)
                            , Convert.ToDouble(TX_price_Gold.Text)) != -1)
                        {
                            L_Value_Money.Text = math_money.math_zaka_money_gold(Convert.ToDouble(T_amuont.Text), Convert.ToDouble(Comp_Gold_spo.Text)
                             , Convert.ToDouble(TX_price_Gold.Text)).ToString();
                        }
                        else
                        {
                            L_Value_Money.Text = "لم يكتمل النصاب ";
                        }
                    }
                }
                catch { message_work.Show(); }
            }
            else if (Como_Type_spotter.SelectedIndex == 1)
            {
                try
                {
                    if (T_amuont.Text != "")
                    {
                        if (math_money.math_zaka_money_Silver(Convert.ToDouble(T_amuont.Text), Convert.ToDouble(Comp_Silver_spo.Text)
                            , Convert.ToDouble(T_price_Silver.Text)) != -1)
                        {
                            L_Value_Money.Text = math_money.math_zaka_money_Silver(Convert.ToDouble(T_amuont.Text), Convert.ToDouble(Comp_Silver_spo.Text)
                             , Convert.ToDouble(T_price_Silver.Text)).ToString();
                        }
                        else
                        {
                            L_Value_Money.Text = "لم يكتمل النصاب ";
                        }
                    }
                }
                catch
                {

                }
            }
            else if (Como_Type_spotter.SelectedIndex == 2)
            {
                try
                {
                  double result=  math_money.math_zaka_money_Low(Convert.ToDouble(T_amuont.Text), Convert.ToDouble(Comp_Gold_spo.Text),
                       Convert.ToDouble(Comp_Silver_spo.Text), Convert.ToDouble(TX_price_Gold.Text),
                       Convert.ToDouble(T_price_Silver.Text));

                    if (math_money.check == 2)
                    {
                        L_Value_Money.Text = result.ToString();
                    }
                    else if (math_money.check == 595)
                    {
                        L_Value_Money.Text = result.ToString();
                    }
                    else if (math_money.check == 85)
                    {
                        L_Value_Money.Text = result.ToString();

                    }
                    else
                    {
                        L_Value_Money.Text = "لم يكتمل النصاب ";

                    }
                }
                catch
                {

                }
            }
        
            
        }
        private void TX_price_Gold_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
         /*   if(L_Value_Money.Text != "لم يكتمل النصاب "&&L_Value_Money.Text!="")
            { 
              L_Value_Money.Text=math_money.math_zaka_money_gold(Convert.ToDouble(T_amuont.Text), Convert.ToDouble(Comp_Gold_spo.Text)
                        , Convert.ToDouble(TX_price_Gold.Text)).ToString();
            }*/
        }

        private void T_amuont_TextChanged(object sender, EventArgs e)
        {
            Text_Change_Money();
        }
        private void Text_Change_Crops()
        {
            int select = 1;
            try {

                if (com_items_moz.Text == "المحاصيل غير المروية")
                {
                    if (T_weight_Crops.Text != "")
                    {
                        double result = math_Crops.math_Crops(Convert.ToDouble(T_weight_Crops.Text),
                           Convert.ToInt32(select));

                        if (result == -1)
                        {
                            L_Value_Crops.Text = "لم يكتمل النصاب";
                            L_Value_Crops_dol.Text = "";
                        }
                        else
                        {
                            L_Value_Crops.Text = result.ToString()+"غرام";
                            if (T_Price_CropK.Text != "")
                            {
                                double Resolt_Dol = result * Convert.ToDouble(T_Price_CropK.Text);
                                L_Value_Crops_dol.Text = Resolt_Dol.ToString()+"$"+"دولار";
                            }
                            else
                            {
                                L_Value_Crops_dol.Text = "";
                                
                            }
                        }
                    }
                    else
                    {
                        L_Value_Crops.Text = "";

                    }
                }
                else if (com_items_moz.Text == "المحاصيل المروية")
                {
                    if (txt_w.Text != "")
                    {
                      
                        select = 2;
                        double result = math_Crops.math_Crops(Convert.ToDouble(txt_w.Text),
                            select);
                        if (result == -1)
                        {
                            L_value_crept.Text = "لم يكتمل النصاب";
                            Crops_Value_Dol.Text = "";


                        }
                        else
                        {
                            if (T_Price_Crop.Text != "")
                            {
                                double Resolt_dol = result * Convert.ToDouble(T_Price_Crop.Text);
                                Crops_Value_Dol.Text = Resolt_dol.ToString()+"$"+"دولار";
                            }
                            else if(T_Price_Crop.Text == "")
                            {
                                Crops_Value_Dol.Text = "";
                            }
                            L_value_crept.Text = result.ToString()+ "غرام";
                            
                        }
                    }
                    else if(txt_w.Text=="")
                    {
                        L_value_crept.Text = "";

                    }


                }
            }
            catch
            {
                message_work.Show("يرجى ادخال ارقام فقط ", "خطأ");
            }
            }
        


        private void T_weight_Crops_TextChanged(object sender, EventArgs e)
        {
            Text_Change_Crops();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Error;
               if (T_Price_CropK.Text == "" && T_weight_Crops.Text == "")
            {
                message_work.Show("ادخل المعلومات من فضلك", "خطأ");

            }
            else if (T_weight_Crops.Text == "")
            {
                message_work.Show("ادخل الوزن من فضلك", "خطأ");

            }
            else if (L_Value_Crops.Text == "لم يكتمل النصاب")
            {
                message_work.Show("لم يكتمل النصاب", "تنبيه");

            }
            else if (T_Price_CropK.Text == "")
            {
                message_work.Show("ادخل السعر من فضلك", "خطأ");

            }
          
            else if (L_Value_Crops.Text != "" || L_Value_Crops.Text != "لم يكتمل النصاب")
            {
                message_work.Icon = MessageDialogIcon.Information;
                message_work.Show("تم حساب الزكاة بالفعل", "تنبيه");
            }
            else
            {
                try
                {
                    Text_Change_Crops();
                }
                catch
                {
                    message_work.Show("يرجى ادخال ارقام فقط", "خطأ");
                }
            }
            
        }

        private void txt_w_TextChanged(object sender, EventArgs e)
        {
            Text_Change_Crops();
        }

        private void T_Price_Crop_TextChanged(object sender, EventArgs e)
        {
            Text_Change_Crops();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Error;
             if (txt_w.Text == "" &&T_Price_Crop.Text == "")
            {
                message_work.Show("ادخل المعلومات من فضلك", "خطأ");

            }
            else if (txt_w.Text == "")
            {
                message_work.Show("ادخل الوزن من فضلك","خطأ");
            }
            else if (L_value_crept.Text == "لم يكتمل النصاب")
            {
                message_work.Show("لم يكتمل النصاب", "تنبيه");

            }
            else if (T_Price_Crop.Text == "")
            {
                message_work.Show("ادخل السعر من فضلك","خطأ");
            }
        
         
            else if (L_value_crept.Text != ""||L_value_crept.Text != "لم يكتمل النصاب")
            {
                message_work.Icon = MessageDialogIcon.Information;
                message_work.Show("تم حساب الزكاة بالفعل","تنبيه");
            }
            else
            {
                try        
                {
                    Text_Change_Crops();
                }
                catch
                {
                    message_work.Show("يرجى ادخال ارقام فقط","خطأ");
                }
            }

        }

        private void txt_w_KeyPress(object sender, KeyPressEventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;
            if (e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' ||
                e.KeyChar >= 'ا' && e.KeyChar <= 'ي' || e.KeyChar == ' '||e.KeyChar=='`'
                ||e.KeyChar=='+' || e.KeyChar == '-' || e.KeyChar == '*' || e.KeyChar == '@'
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

        private void T_Price_Crop_KeyPress(object sender, KeyPressEventArgs e)
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

        private void T_weight_Crops_KeyPress(object sender, KeyPressEventArgs e)
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

        private void guna2TextBox11_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void T_Price_CropK_TextChanged(object sender, EventArgs e)
        {
            Text_Change_Crops();
        }
        private void Text_Change_livestock()
        {
            if (Num_livestock.Text != "")
            {
                try
                //-------------------
                //-------------------
                // status_One => 1 
                //-------------------
                //-------------------
                {
                    if (com_types_moz.Text == "الغنم السائمة")
                    {


                        double resolt = math_Livestock.math_zaka_Sheep(Convert.ToInt32(Num_livestock.Text));
                        if (resolt == -1)
                        {

                            L_Value_Sheep.Text = "لم يكتمل النصاب";
                            L_Value_Sheep_Dol.Text = "";
                        }
                        else if (resolt == 1)
                        {
                            if (Price_Sheep_Dol.Text != "")
                            {
                                double Resolt_dol = resolt * Convert.ToDouble(Price_Sheep_Dol.Text);
                                L_Value_Sheep_Dol.Text = Resolt_dol.ToString() + "$";

                            }
                            else
                            {
                                L_Value_Sheep_Dol.Text = "";

                            }
                            L_Value_Sheep.Text = "شاة واحدة";

                        }
                        else if (resolt == 2)
                        {
                            if (Price_Sheep_Dol.Text != "")
                            {
                                double Resolt_dol = resolt * Convert.ToDouble(Price_Sheep_Dol.Text);
                                L_Value_Sheep_Dol.Text = Resolt_dol.ToString() + "$";

                            }
                            else
                            {
                                L_Value_Sheep_Dol.Text = "";

                            }
                            L_Value_Sheep.Text = "شاتان";

                        }
                        else if (resolt == 3)
                        {
                            if (Price_Sheep_Dol.Text != "")
                            {
                                double Resolt_dol = resolt * Convert.ToDouble(Price_Sheep_Dol.Text);
                                L_Value_Sheep_Dol.Text = Resolt_dol.ToString() + "$";

                            }
                            else
                            {
                                L_Value_Sheep_Dol.Text = "";

                            }
                            L_Value_Sheep.Text = "ثلاث شياة";

                        }
                        else if (resolt == 4)
                        {

                            double res = Convert.ToInt32(Num_livestock.Text) / 100;
                            L_Value_Sheep.Text = "من رؤوس الأغنام لديك" + "[ " + res.ToString() + " ]";
                            if (Price_Sheep_Dol.Text != "")
                            {
                                double Resolt_dol = res * Convert.ToDouble(Price_Sheep_Dol.Text);
                                L_Value_Sheep_Dol.Text = Resolt_dol.ToString() + "$";

                            }
                            else
                            {
                                L_Value_Sheep_Dol.Text = "";

                            }
                        }
                    }
                    //-------------------
                    //-------------------
                    // status_Two => 2 
                    //-------------------
                    //-------------------
                    else if (com_types_moz.Text == "البقر السائمة")
                    {

                        string resolt = math_Livestock.math_zaka_Cows(Convert.ToInt32(Num_livestock.Text));
                        L_Value_Sheep.Text = resolt.ToString();



                        if (L_Value_Sheep.Text != "")
                        {

                            if (math_Livestock.check == 1 &&
                            L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {

                                L_mos.Visible = true;
                                Price_Sheep_Dol_mos.Visible = true;
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                if (Price_Sheep_Dol.Text != "" && Price_Sheep_Dol_mos.Text != "")
                                {
                                    double resolt_Dol_mos = math_Livestock.mos *
                                    Convert.ToDouble(Price_Sheep_Dol_mos.Text);
                                    double resolt_Dol_tab = math_Livestock.tab *
                                        Convert.ToDouble(Price_Sheep_Dol.Text);
                                    L_Value_Sheep_Dol.Text = "[$" + resolt_Dol_tab.ToString() + "]" + " :التبيع" + "\n\n"
                                       + "[$" + resolt_Dol_mos.ToString() + "]" + " :المسنة";
                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }

                            }
                            else if (math_Livestock.check == 0 &&
                                L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_mos.Visible = true;
                                Price_Sheep_Dol_mos.Visible = true;
                                L_tab.Visible = false;
                                Price_Sheep_Dol.Visible = false;
                                if (Price_Sheep_Dol_mos.Text != "")
                                {
                                    double resolt_Dol_mos = math_Livestock.mos *
                             Convert.ToDouble(Price_Sheep_Dol_mos.Text);

                                    L_Value_Sheep_Dol.Text = "[$" + resolt_Dol_mos.ToString() + "]" + " :المسنة";
                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (math_Livestock.check == 2 &&
                          L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_mos.Visible = false;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                if (Price_Sheep_Dol.Text != "")
                                {
                                    double resolt_Dol_tab = math_Livestock.tab *
                             Convert.ToDouble(Price_Sheep_Dol.Text);

                                    L_Value_Sheep_Dol.Text = "[$" + resolt_Dol_tab.ToString() + "]" + " :التبيع";
                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (math_Livestock.check == 3 &&
                              L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {

                                L_mos.Visible = true;
                                Price_Sheep_Dol_mos.Visible = true;
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                if (Price_Sheep_Dol.Text != "" && Price_Sheep_Dol_mos.Text != "")
                                {
                                    double resolt_Dol_mos = math_Livestock.mos *
                                    Convert.ToDouble(Price_Sheep_Dol_mos.Text);
                                    double resolt_Dol_tab = math_Livestock.tab *
                                        Convert.ToDouble(Price_Sheep_Dol.Text);
                                    L_Value_Sheep_Dol.Text = "[$" + resolt_Dol_tab.ToString() + "]" + " :التبيع" + "\nاو\n"
                                       + "[$" + resolt_Dol_mos.ToString() + "]" + " :المسنة";
                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else
                            {
                                L_mos.Visible = false;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_Value_Sheep_Dol.Text = "";

                            }


                        }


                    }
                    //-------------------
                    //-------------------
                    // status_Third => 3 
                    //-------------------
                    //-------------------
                    else if (com_types_moz.Text == "الإبل السائمة")
                    {
                        double resolt_dol;
                        string resolt = math_Livestock.math_zaka_Camel(Convert.ToInt32(Num_livestock.Text));
                        L_Value_Sheep.Text = resolt.ToString();
                        if (L_Value_Sheep.Text != "")
                        {

                            if (resolt == "شاة واحدة" &&
                               L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                L_tab.Text = "السعر بالدولار للشاة";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 1;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString()+"$";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (resolt == "شاتان" &&
                             L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                L_tab.Text = "السعر بالدولار للشاة";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 2;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (resolt == "ثلاث شياة" &&
                           L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                L_tab.Text = "السعر بالدولار للشاة";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 3;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (resolt == "أربع شياة" &&
                          L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                L_tab.Text = "السعر بالدولار للشاة";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 4;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (resolt == "بنت مخاض" &&
                     L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                L_tab.Text = "السعر بالدولار لبنت مخاض ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 1;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (resolt == "بنت لبون" &&
                     L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                L_tab.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 1;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (resolt == "حقة" &&
                           L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                L_tab.Text = "السعر بالدولار للحقة ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 1;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (resolt == "جذعة" &&
                          L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                L_tab.Text = "السعر بالدولار للجذعة ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 1;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (resolt == "بنتا لبون" &&
                          L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                L_tab.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 2;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (resolt == "حقًتان" &&
                             L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                L_tab.Text = "السعر بالدولار للحقة ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 2;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (math_Livestock.Check_Ibel==1 &&
                          L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = true;
                                L_mos.Visible = true;
                               
                                L_tab.Text = "السعر بالدولار للحقة ";
                                L_mos.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol.Text != "" && Price_Sheep_Dol_mos.Text!="")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol_mos.Text)*math_Livestock.Bent;
                                    double resolt_haq = Convert.ToDouble(Price_Sheep_Dol.Text) * math_Livestock.Haq;
                                

                                    L_Value_Sheep_Dol.Text = "[$" + resolt_dol.ToString() + "]" + " :بنت لبون" + "\nاو\n"
                                    + "[$" + resolt_haq.ToString() + "]" + " :الحقة";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (math_Livestock.Check_Ibel == 2 &&
                      L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {

                                L_mos.Visible = true;
                                Price_Sheep_Dol_mos.Visible = true;
                                Price_Sheep_Dol.Visible = false;
                                L_tab.Visible = false;
                                L_mos.Text = "السعر بالدولار لبنت لبون ";

                                if ( Price_Sheep_Dol_mos.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol_mos.Text) * math_Livestock.Bent;
                                    L_Value_Sheep_Dol.Text = "[$" + resolt_dol.ToString() + "]" + " :بنت لبون";
                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (math_Livestock.Check_Ibel == 3 &&
                          L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {

                                L_mos.Visible = false;
                                Price_Sheep_Dol_mos.Visible = false;
                                Price_Sheep_Dol.Visible = true;
                                L_tab.Visible = true;
                                L_tab.Text = "السعر بالدولار للحقة ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    double resolt_haq = Convert.ToDouble(Price_Sheep_Dol.Text) * math_Livestock.Haq;

                                    L_Value_Sheep_Dol.Text = "[$" + resolt_haq.ToString() + "]" + " :الحقة";
                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (math_Livestock.Check_Ibel == 4 &&
                     L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = true;
                                L_mos.Visible = true;
                                L_tab.Text = "السعر بالدولار للحقة ";
                                L_mos.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol.Text != "" && Price_Sheep_Dol_mos.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol_mos.Text) * math_Livestock.Bent;
                                    double resolt_haq = Convert.ToDouble(Price_Sheep_Dol.Text) * math_Livestock.Haq;


                                    L_Value_Sheep_Dol.Text = "[$" + resolt_dol.ToString() + "]" + " :بنت لبون" + "\nو\n"
                                    + "[$" + resolt_haq.ToString() + "]" + " :الحقة";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (math_Livestock.Check_Ibel == 5 &&
                     L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = true;
                                L_mos.Visible = true;
                                L_tab.Text = "السعر بالدولار للحقة ";
                                L_mos.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol.Text != "" && Price_Sheep_Dol_mos.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol_mos.Text) * math_Livestock.Bent;
                                    double resolt_haq = Convert.ToDouble(Price_Sheep_Dol.Text) * math_Livestock.Haq;


                                    L_Value_Sheep_Dol.Text = "[$" + resolt_dol.ToString() + "]" + " :بنت لبون" + "\nو\n"
                                    + "[$" + resolt_haq.ToString() + "]" + " :الحقة";

                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }

                        }
                        else
                        {
                            L_mos.Visible = false;
                            Price_Sheep_Dol_mos.Visible = false;
                            L_Value_Sheep_Dol.Text = "";
                        }
                    }
                }
                catch
                {
                    message_work.Style = MessageDialogStyle.Light;
                    message_work.Icon = MessageDialogIcon.Error;
                    message_work.Buttons = MessageDialogButtons.OK;
                    message_work.Show("يرجى ادخال ارقام فقط", "خطأ");
                }
            }
            else
            {
                L_Value_Sheep_Dol.Text = "";
                L_Value_Sheep.Text = "";
            }
        }

        private void Num_livestock_TextChanged(object sender, EventArgs e)
        {
            Text_Change_livestock();
        }

        private void Num_livestock_KeyPress(object sender, KeyPressEventArgs e)
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

      

        private void Price_Sheep_Dol_TextChanged(object sender, EventArgs e)
        {
            Text_Change_livestock();
        }

        private void Price_Sheep_Dol_KeyPress(object sender, KeyPressEventArgs e)
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

        private void bt_math_Zakah_livestock_Click(object sender, EventArgs e)
        {
            message_work.Style = MessageDialogStyle.Light;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Icon = MessageDialogIcon.Warning;

            if (Num_livestock.Text == "")
            {
                message_work.Show("ادخل العدد من فضلك", "خطأ");

            }
            else if( L_Value_Sheep.Text == "لم يكتمل النصاب")
            {
                message_work.Show("لم يكتمل النصاب ", "خطأ");

            }
            else if (L_Value_Sheep.Text != "لم يكتمل النصاب" &&L_Value_Sheep.Text!="")
            {
                message_work.Icon = MessageDialogIcon.Information;
                message_work.Show("تم حساب الزكاة بالفعل ", "تنبيه");

            }
            else
            {
                try
                {
                    Text_Change_livestock();
                }
                catch
                {
                    message_work.Show("يرجى ادخال ارقام فقط ", "خطأ");
                }
            }
          
        }

        private void Price_Sheep_Dol_mos_TextChanged(object sender, EventArgs e)
        {
            Text_Change_livestock();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pan_grope_Paint(object sender, PaintEventArgs e)
        {

        }

        private void time_now_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void date_now_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void pan_Fda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Value_zaka_dol_Click(object sender, EventArgs e)
        {

        }

        private void pan_mony_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void Value_zaka_Silver_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbl_item_moz_Click(object sender, EventArgs e)
        {

        }

        private void lbl_type_moz_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pan_child_moz_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Price_Gold_Dol_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Resolt_Z_Gold_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pan_livestock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void L_mos_Click(object sender, EventArgs e)
        {

        }

        private void L_Value_Sheep_Dol_Click(object sender, EventArgs e)
        {

        }

        private void L_tab_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void L_Value_Sheep_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void pan_crops_not_Paint(object sender, PaintEventArgs e)
        {

        }

        private void L_Value_Crops_dol_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void l_Name_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void L_Value_Crops_Click(object sender, EventArgs e)
        {

        }

        private void Name_zara_TextChanged(object sender, EventArgs e)
        {

        }

        private void pan_crops_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Crops_Value_Dol_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void L_value_crept_Click(object sender, EventArgs e)
        {

        }

        private void pan_monye_Paint(object sender, PaintEventArgs e)
        {

        }

        private void L_Calper_Silver_Click(object sender, EventArgs e)
        {

        }

        private void T_price_Silver_TextChanged(object sender, EventArgs e)
        {

        }

        private void L_Price_Silver_Click(object sender, EventArgs e)
        {

        }

        private void Comp_Silver_spo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_mo_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_mo1_Click(object sender, EventArgs e)
        {

        }

        private void L_Gold_cl_Click(object sender, EventArgs e)
        {

        }

        private void Comp_Gold_spo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void L_Price_Gold_Click(object sender, EventArgs e)
        {

        }

        private void L_Value_Money_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Data_Grid_Silver_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void update_type_Click(object sender, EventArgs e)
        {

        }

        private void remove_type_Click(object sender, EventArgs e)
        {

        }

        private void add_type_Click(object sender, EventArgs e)
        {

        }
    }

}
