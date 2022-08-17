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
using Zakate_project.login;

namespace Zakate_project.FORMS_GROUP
{
    public partial class Form_math_moz : Form
    {
        public double sum = -1;

        public string Val_LiveS_M, Val_LiveS_Z;//غنم
        public string Val_LiveS_M_B, Val_LiveS_M_B_t, Val_LiveS_Z_B, Val_B_end;//بقر   
        public string Val_M_Crops_n, Val_Z_Crops_n;
        public string Val_M_Crops, Val_Z_Crops;
        public string Val_M_Money;
        public double Silver_M;
        public double Value_Monye;
        public string Value_Type, Silver_Z, Value_zaka;
        Calculator_livestock math_Livestock = new Calculator_livestock();
        Calculator_Crops math_Crops = new Calculator_Crops();
        Calculator_Money math_money = new Calculator_Money();
        Calculator_Gold math_Gold = new Calculator_Gold();
        Calculator_Silver Math_Silver = new Calculator_Silver();
        conction.Cls_conctin reade = new conction.Cls_conctin();
        Classes.Cls_Process dept = new Classes.Cls_Process();
        Form_Home F_HOME_color = new Form_Home();
        Guna2MessageDialog message_work = new Guna2MessageDialog();
        public Form_math_moz()
        {
            InitializeComponent();
            L_mos.Visible = false;
            Price_Sheep_Dol_mos.Visible = false;
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
        private void date_now_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

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
            if (com_items_moz.SelectedIndex == 2)
            {
                if (com_types_moz.Text != "")
                {
                    Data_Zaka.Type_Crops = com_types_moz.Text;
                }
                
            }
            if (com_items_moz.SelectedIndex == 3)
            {
                if (com_types_moz.Text != "")
                {
                    Data_Zaka.Type_Crops_N = com_types_moz.Text;
                }

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
            if (Value_zaka_Silver.Text == "" && price_dol_S.Text != "")
            {
                double result = Math_Silver.math_zaka_silver(Convert.ToDouble(Nisba_Silver.Text),
                     Convert.ToDouble(Compo_caliber.Text));

                Value_zaka_Silver.Text = Math.Round(result, 4).ToString() + "غرام";
                double result_dol = result * Convert.ToDouble(price_dol_S.Text);
                Value_zaka_dol.Text = Math.Round(result_dol, 2).ToString() + "$" + "دولار امريكي ";
                Silver_M = result_dol;
                Silver_Z = Value_zaka_Silver.Text;
            }
            else
            {
                message_work.Style = MessageDialogStyle.Light;
                message_work.Buttons = MessageDialogButtons.OK;
                message_work.Icon = MessageDialogIcon.Error;
                if (price_dol_S.Text == "" && Nisba_Silver.Text == "")
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
                    message_work.Show("يرجى ادخال وزن الفضة ", "خطأ");

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
            try
            {
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
                    }
                }
                else if (T_weight_Gold.Text == "")
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
                    double result = math_Gold.math_zaka_gold(Convert.ToDouble(T_weight_Gold.Text),
                       Convert.ToDouble(Comp_gold_caliber.Text));
                    Value_Type = com_types_moz.Text;


                    Resolt_Z_Gold.Text = Math.Round(result, 4).ToString() + "غرام";
                    Value_zaka = Resolt_Z_Gold.Text;
                    double resolt_Dol = result * Convert.ToDouble(T_Price_gold.Text);
                    Price_Gold_Dol.Text = Math.Round(resolt_Dol, 2).ToString() + "$";
                    Value_Monye = resolt_Dol;
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
            catch (Exception ex)
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

            if (Como_Type_spotter.Text == "حسب نصاب الذهب")
            {
                L_Price_Silver.Visible = false;
                L_Calper_Silver.Visible = false;
                T_price_Silver.Visible = false;
                Comp_Silver_spo.Visible = false;
                Comp_Gold_spo.Visible = true;
                L_Gold_cl.Visible = true;
                TX_price_Gold.Visible = true;
                L_Price_Gold.Visible = true;
                Lbl_mo1.Visible = true;
                Lbl_mo.Visible = true;


            }
            else if (Como_Type_spotter.Text == "حسب نصاب الفضة")
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
            else if (Como_Type_spotter.Text == "حسب اقل النصابين ")
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
                try
                {
                    if (T_amuont.Text != "")
                    {
                        if (math_money.math_zaka_money_gold(Convert.ToDouble(T_amuont.Text), Convert.ToDouble(Comp_Gold_spo.Text)
                            , Convert.ToDouble(TX_price_Gold.Text)) != -1)
                        {
                            double resolt = math_money.math_zaka_money_gold(Convert.ToDouble(T_amuont.Text), Convert.ToDouble(Comp_Gold_spo.Text)
                             , Convert.ToDouble(TX_price_Gold.Text));
                            L_Value_Money.Text = resolt.ToString() + "$";
                            Val_M_Money = resolt.ToString();
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
                            double resolt = math_money.math_zaka_money_Silver(Convert.ToDouble(T_amuont.Text), Convert.ToDouble(Comp_Silver_spo.Text)
                             , Convert.ToDouble(T_price_Silver.Text));
                            L_Value_Money.Text = resolt.ToString() + "$";
                            Val_M_Money = resolt.ToString();


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
                    double result = math_money.math_zaka_money_Low(Convert.ToDouble(T_amuont.Text), Convert.ToDouble(Comp_Gold_spo.Text),
                         Convert.ToDouble(Comp_Silver_spo.Text), Convert.ToDouble(TX_price_Gold.Text),
                         Convert.ToDouble(T_price_Silver.Text));

                    if (math_money.check == 2)
                    {
                        L_Value_Money.Text = result.ToString() + "$";
                        Val_M_Money = result.ToString();
                    }
                    else if (math_money.check == 595)
                    {
                        L_Value_Money.Text = result.ToString() + "$";
                        Val_M_Money = result.ToString();

                    }
                    else if (math_money.check == 85)
                    {
                        L_Value_Money.Text = result.ToString() + "$";
                        Val_M_Money = result.ToString();


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
            Text_Change_Money();
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
            try
            {

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
                            L_Value_Crops.Text = result.ToString() + "كيلو غرام";
                            Val_Z_Crops_n = L_Value_Crops.Text;
                            if (T_Price_CropK.Text != "")
                            {
                                double Resolt_Dol = result * Convert.ToDouble(T_Price_CropK.Text);
                                L_Value_Crops_dol.Text = Resolt_Dol.ToString() + "$" + "دولار";
                                Val_M_Crops_n = Resolt_Dol.ToString();
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
                                Crops_Value_Dol.Text = Resolt_dol.ToString() + "$" + "دولار";
                                Val_M_Crops = Resolt_dol.ToString();
                            }
                            else if (T_Price_Crop.Text == "")
                            {
                                Crops_Value_Dol.Text = "";
                            }
                            L_value_crept.Text = result.ToString() + "كيلو غرام";
                            Val_Z_Crops = L_value_crept.Text;

                        }
                    }
                    else if (txt_w.Text == "")
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
            if (txt_w.Text == "" && T_Price_Crop.Text == "")
            {
                message_work.Show("ادخل المعلومات من فضلك", "خطأ");

            }
            else if (txt_w.Text == "")
            {
                message_work.Show("ادخل الوزن من فضلك", "خطأ");
            }
            else if (L_value_crept.Text == "لم يكتمل النصاب")
            {
                message_work.Show("لم يكتمل النصاب", "تنبيه");

            }
            else if (T_Price_Crop.Text == "")
            {
                message_work.Show("ادخل السعر من فضلك", "خطأ");
            }


            else if (L_value_crept.Text != "" || L_value_crept.Text != "لم يكتمل النصاب")
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

        private void txt_w_KeyPress(object sender, KeyPressEventArgs e)
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

        public string Val_LiveS_M_A, Val_LiveS_Z_A, Val_Abel_end_M;//إبل

        public string Val_MOS_M_A;
        public string Val_Haq_M_A;

        public double Sum_Abel = -1;

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
                                Val_LiveS_M = Resolt_dol.ToString();
                            }
                            else
                            {
                                L_Value_Sheep_Dol.Text = "";

                            }
                            L_Value_Sheep.Text = "شاة واحدة";
                            Val_LiveS_Z = L_Value_Sheep.Text;

                        }
                        else if (resolt == 2)
                        {
                            if (Price_Sheep_Dol.Text != "")
                            {
                                double Resolt_dol = resolt * Convert.ToDouble(Price_Sheep_Dol.Text);
                                L_Value_Sheep_Dol.Text = Resolt_dol.ToString() + "$";
                                Val_LiveS_M = Resolt_dol.ToString();

                            }
                            else
                            {
                                L_Value_Sheep_Dol.Text = "";

                            }
                            L_Value_Sheep.Text = "شاتان";
                            Val_LiveS_Z = L_Value_Sheep.Text;


                        }
                        else if (resolt == 3)
                        {
                            if (Price_Sheep_Dol.Text != "")
                            {
                                double Resolt_dol = resolt * Convert.ToDouble(Price_Sheep_Dol.Text);
                                L_Value_Sheep_Dol.Text = Resolt_dol.ToString() + "$";
                                Val_LiveS_M = Resolt_dol.ToString();


                            }
                            else
                            {
                                L_Value_Sheep_Dol.Text = "";

                            }
                            L_Value_Sheep.Text = "ثلاث شياة";
                            Val_LiveS_Z = L_Value_Sheep.Text;


                        }
                        else if (resolt == 4)
                        {

                            double res = Convert.ToInt32(Num_livestock.Text) / 100;
                            L_Value_Sheep.Text = "من رؤوس الأغنام لديك" + "[ " + res.ToString() + " ]";
                            Val_LiveS_Z = L_Value_Sheep.Text;

                            if (Price_Sheep_Dol.Text != "")
                            {
                                double Resolt_dol = res * Convert.ToDouble(Price_Sheep_Dol.Text);
                                L_Value_Sheep_Dol.Text = Resolt_dol.ToString() + "$";
                                Val_LiveS_M = Resolt_dol.ToString();


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
                        Val_LiveS_Z_B = L_Value_Sheep.Text;
                        if (Val_LiveS_M_B == "" && Val_LiveS_M_B_t == "")
                        {
                            R_mos.Visible = false;
                            R_Tab.Visible = false;

                        }
                        else
                        {
                            R_mos.Visible = true;
                            R_Tab.Visible = true;
                        }
                        if (L_Value_Sheep.Text != "")
                        {
                            if (math_Livestock.check == 1 &&
                            L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_mos.Visible = true;
                                Price_Sheep_Dol_mos.Visible = true;
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                R_mos.Visible = false;
                                R_Tab.Visible = false;
                                if (Price_Sheep_Dol.Text != "" && Price_Sheep_Dol_mos.Text != "")
                                {
                                    double resolt_Dol_mos = math_Livestock.mos *
                                    Convert.ToDouble(Price_Sheep_Dol_mos.Text);
                                    double resolt_Dol_tab = math_Livestock.tab *
                                        Convert.ToDouble(Price_Sheep_Dol.Text);
                                    sum = resolt_Dol_mos + resolt_Dol_tab;

                                    L_Value_Sheep_Dol.Text = "[$" + resolt_Dol_tab.ToString() + "]" + " :التبيع" + "\n-و-\n"
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
                                R_mos.Visible = false;
                                R_Tab.Visible = false;
                                if (Price_Sheep_Dol_mos.Text != "")
                                {
                                    double resolt_Dol_mos = math_Livestock.mos *
                             Convert.ToDouble(Price_Sheep_Dol_mos.Text);
                                    Val_B_end = resolt_Dol_mos.ToString();

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
                                R_mos.Visible = false;
                                R_Tab.Visible = false;
                                if (Price_Sheep_Dol.Text != "")
                                {
                                    double resolt_Dol_tab = math_Livestock.tab *
                             Convert.ToDouble(Price_Sheep_Dol.Text);
                                    Val_B_end = resolt_Dol_tab.ToString();

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
                                    Val_LiveS_M_B = resolt_Dol_mos.ToString();
                                    Val_LiveS_M_B_t = resolt_Dol_tab.ToString();
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
                                R_mos.Visible = false;
                                R_Tab.Visible = false;
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
                        if (Val_MOS_M_A == "" && Val_Haq_M_A == "")
                        {
                            R_A_Mos.Visible = false;
                            R_A_Haq.Visible = false;

                        }
                        else
                        {
                            R_A_Mos.Visible = true;
                            R_A_Haq.Visible = true;
                        }
                        Val_LiveS_Z_A = L_Value_Sheep.Text;
                        if (L_Value_Sheep.Text != "")
                        {

                            if (resolt == "شاة واحدة" &&
                               L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = false;
                                L_mos.Visible = false;
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار للشاة";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 1;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";
                                    Val_Abel_end_M = resolt_dol.ToString();

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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار للشاة";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 2;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";
                                    Val_Abel_end_M = resolt_dol.ToString();
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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار للشاة";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 3;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";
                                    Val_Abel_end_M = resolt_dol.ToString();

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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار للشاة";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 4;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";
                                    Val_Abel_end_M = resolt_dol.ToString();


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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار لبنت مخاض ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 1;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";
                                    Val_Abel_end_M = resolt_dol.ToString();


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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 1;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";
                                    Val_Abel_end_M = resolt_dol.ToString();


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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار للحقة ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 1;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";
                                    Val_Abel_end_M = resolt_dol.ToString();


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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار للجذعة ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 1;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";
                                    Val_Abel_end_M = resolt_dol.ToString();


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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 2;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";
                                    Val_Abel_end_M = resolt_dol.ToString();


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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار للحقة ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol.Text) * 2;
                                    L_Value_Sheep_Dol.Text = resolt_dol.ToString() + "$";
                                    Val_Abel_end_M = resolt_dol.ToString();


                                }
                                else
                                {
                                    L_Value_Sheep_Dol.Text = "";
                                }
                            }
                            else if (math_Livestock.Check_Ibel == 1 &&
                          L_Value_Sheep.Text != "لم يكتمل النصاب")
                            {
                                L_tab.Visible = true;
                                Price_Sheep_Dol.Visible = true;
                                Price_Sheep_Dol_mos.Visible = true;
                                L_mos.Visible = true;
                                R_A_Mos.Visible = true;
                                R_A_Haq.Visible = true;

                                L_tab.Text = "السعر بالدولار للحقة ";
                                L_mos.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol.Text != "" && Price_Sheep_Dol_mos.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol_mos.Text) * math_Livestock.Bent;
                                    double resolt_haq = Convert.ToDouble(Price_Sheep_Dol.Text) * math_Livestock.Haq;

                                    Val_MOS_M_A = resolt_dol.ToString();
                                    Val_Haq_M_A = resolt_haq.ToString();

                                    /*
                                     /------------*--
                                     ---------------
                                     -----------------
                                     ----------
                                     --
                                     */

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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_mos.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol_mos.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol_mos.Text) * math_Livestock.Bent;
                                    L_Value_Sheep_Dol.Text = "[$" + resolt_dol.ToString() + "]" + " :بنت لبون";
                                    Val_Abel_end_M = resolt_dol.ToString();

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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار للحقة ";

                                if (Price_Sheep_Dol.Text != "")
                                {
                                    double resolt_haq = Convert.ToDouble(Price_Sheep_Dol.Text) * math_Livestock.Haq;
                                    Val_Abel_end_M = resolt_haq.ToString();


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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار للحقة ";
                                L_mos.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol.Text != "" && Price_Sheep_Dol_mos.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol_mos.Text) * math_Livestock.Bent;
                                    double resolt_haq = Convert.ToDouble(Price_Sheep_Dol.Text) * math_Livestock.Haq;

                                    Sum_Abel = resolt_dol + resolt_haq;
                                    Val_LiveS_M_A = sum.ToString();

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
                                R_A_Mos.Visible = false;
                                R_A_Haq.Visible = false;
                                L_tab.Text = "السعر بالدولار للحقة ";
                                L_mos.Text = "السعر بالدولار لبنت لبون ";

                                if (Price_Sheep_Dol.Text != "" && Price_Sheep_Dol_mos.Text != "")
                                {
                                    resolt_dol = Convert.ToDouble(Price_Sheep_Dol_mos.Text) * math_Livestock.Bent;
                                    double resolt_haq = Convert.ToDouble(Price_Sheep_Dol.Text) * math_Livestock.Haq;
                                    Sum_Abel = resolt_dol + resolt_haq;
                                    Val_LiveS_M_A = sum.ToString();
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
                            R_A_Mos.Visible = false;
                            R_A_Haq.Visible = false;
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
            else if (L_Value_Sheep.Text == "لم يكتمل النصاب")
            {
                message_work.Show("لم يكتمل النصاب ", "خطأ");

            }
            else if (L_Value_Sheep.Text != "لم يكتمل النصاب" && L_Value_Sheep.Text != "")
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
        // ==> Success To Add Proccess --Message-- ==>Function
        private void message()
        {
            message_work.Icon = MessageDialogIcon.Information;
            message_work.Style = MessageDialogStyle.Dark;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Show("تمت إضافة الزكاة بنجاح", "نجاح");
        }
        // ==> meseage_style_error --Style-- ==>Function
        private void meseage_style_error()
        {
            message_work.Icon = MessageDialogIcon.Error;
            message_work.Buttons = MessageDialogButtons.OK;
            message_work.Style = MessageDialogStyle.Light;
        }
        private void add_type_Click(object sender, EventArgs e)
        {
            try
            {
                message_work.Style = MessageDialogStyle.Dark;
                message_work.Icon = MessageDialogIcon.Question;
                message_work.Buttons = MessageDialogButtons.YesNo;
                DialogResult check;

                if (com_items_moz.Text == "المعادن")
                {

                    if (com_types_moz.SelectedIndex == 0)
                    {
                        if (T_weight_Gold.Text == "" || T_Price_gold.Text == "")
                        {
                            meseage_style_error();
                            message_work.Show("أدخل البيانات لحاسب زكاة الذهب", "خطأ");

                        }
                        else
                        {
                            check = message_work.Show("هل تريد اضافة قيمة الزكاة ؟", "إضافة");
                            if (check == DialogResult.Yes)
                            {
                                Data_Zaka.Value_Monye_Gold = Value_Monye.ToString();
                                Data_Zaka.Value_Zakah_Gold = Value_zaka.ToString();
                                message();
                            }
                        }

                    }
                    else if (com_types_moz.SelectedIndex == 1)
                    {
                        if (Nisba_Silver.Text == "" || price_dol_S.Text == "")
                        {
                            meseage_style_error();
                            message_work.Show("أدخل البيانات لحساب زكاة الفضة ", "خطأ");
                        }
                        else
                        {
                            check = message_work.Show("هل تريد اضافة قيمة الزكاة ؟", "إضافة");
                            if (check == DialogResult.Yes)
                            {
                                Data_Zaka.Value_Monye_Silver = Silver_M.ToString();
                                Data_Zaka.Value_Zakah_Silver = Silver_Z;
                                message();
                            }

                        }

                    }
                }
                else if (com_items_moz.Text == "الأموال التجارية")
                {
                    if (Como_Type_spotter.SelectedIndex == 0)
                    {
                        if (Comp_Gold_spo.Text == "" || TX_price_Gold.Text == "" || T_amuont.Text == "")
                        {
                            meseage_style_error();
                            message_work.Show("أدخل البيانات لحساب زكاة الأموال", "خطأ");


                        }
                        else
                        {
                            check = message_work.Show("هل تريد اضافة قيمة الزكاة ؟", "إضافة");
                            if (check == DialogResult.Yes)
                            {
                                Data_Zaka.Value_Monye_Money = Val_M_Money;
                                message();
                            }
                        }

                    }
                    else if (Como_Type_spotter.SelectedIndex == 1)
                    {
                        if (Comp_Silver_spo.Text == "" || T_price_Silver.Text == "" || T_amuont.Text == "")
                        {
                            meseage_style_error();
                            message_work.Show("أدخل البيانات لحساب زكاة الأموال", "خطأ");


                        }
                        else
                        {
                            check = message_work.Show("هل تريد اضافة قيمة الزكاة ؟", "إضافة");
                            if (check == DialogResult.Yes)
                            {
                                Data_Zaka.Value_Monye_Money = Val_M_Money;
                                message();
                            }
                        }
                    }
                    else
                    {
                        if (Comp_Silver_spo.Text == "" || T_price_Silver.Text == "" ||
                            Comp_Gold_spo.Text == "" || TX_price_Gold.Text == "" || T_amuont.Text == "")
                        {
                            meseage_style_error();
                            message_work.Show("أدخل البيانات لحساب زكاة الأموال", "خطأ");


                        }
                        else
                        {
                            check = message_work.Show("هل تريد اضافة قيمة الزكاة ؟", "إضافة");
                            if (check == DialogResult.Yes)
                            {
                                Data_Zaka.Value_Monye_Money = Val_M_Money;
                                message();
                            }
                        }
                    }

                }
                else if (com_items_moz.Text == "المحاصيل المروية")
                {

                    Data_Zaka.Value_Monye_Crops = Val_M_Crops;
                    Data_Zaka.Value_Zakah_Crops = Val_Z_Crops;


                }
                else if (com_items_moz.Text == "المحاصيل غير المروية")
                {
                    Data_Zaka.Value_Monye_Crops_n = Val_M_Crops_n;
                    Data_Zaka.Value_Zakah_Crops_n = Val_Z_Crops_n;
                }
                else if (com_items_moz.Text == "المواشي")
                {

                    if (com_types_moz.Text == "الغنم السائمة")
                    {
                        if (Num_livestock.Text == "" || Price_Sheep_Dol.Text == "")
                        {
                            meseage_style_error();
                            message_work.Show("أدخل البيانات لحساب زكاة الأعنام ", "خطأ");

                        }
                        else

                        {
                            check = message_work.Show("هل تريد اضافة قيمة الزكاة ؟", "إضافة");
                            if (check == DialogResult.Yes)
                            {
                                Data_Zaka.Value_Zakah_Livestock = Val_LiveS_Z;
                                Data_Zaka.Value_Monye_Livestock = Val_LiveS_M;
                                message();
                            }
                        }

                    }
                    else if (com_types_moz.Text == "البقر السائمة")
                    {
                        if (R_Tab.Visible == true && R_mos.Visible == true)
                        {
                            if (R_mos.Checked != true && R_Tab.Checked != true)
                            {
                                message_work.Icon = MessageDialogIcon.Error;
                                message_work.Show("يرجى اختيار نوع التخزين", "خطأ");
                            }

                            else
                            {
                                if (R_mos.Checked == true)
                                {

                                    Data_Zaka.Value_Monye_Livestock_b = Val_LiveS_M_B;
                                    R_mos.Checked = false;
                                    Num_livestock.Clear();
                                    Price_Sheep_Dol.Clear();
                                    Price_Sheep_Dol_mos.Clear();

                                }
                                else if (R_Tab.Checked == true)
                                {

                                    Data_Zaka.Value_Monye_Livestock_b = Val_LiveS_M_B_t;
                                    R_Tab.Checked = false;
                                    Num_livestock.Clear();
                                    Price_Sheep_Dol.Clear();
                                    Price_Sheep_Dol_mos.Clear();
                                }
                            }
                        }
                        if (sum != -1)
                        {
                            Data_Zaka.Value_Monye_Livestock_b = sum.ToString();
                            sum = -1;
                            Num_livestock.Clear();
                            Price_Sheep_Dol.Clear();
                            Price_Sheep_Dol_mos.Clear();
                        }
                        else if (Val_B_end != "")
                        {


                            Data_Zaka.Value_Monye_Livestock_b = Val_B_end;
                            Val_B_end = "";
                            Num_livestock.Clear();
                            Price_Sheep_Dol.Clear();
                            Price_Sheep_Dol_mos.Clear();


                        }

                        Data_Zaka.Value_Zakah_Livestock_b = Val_LiveS_Z_B;



                    }
                    else if (com_types_moz.Text == "الإبل السائمة")
                    {

                        if (R_A_Mos.Visible == true && R_A_Haq.Visible == true)
                        {
                            if (R_A_Mos.Checked != true && R_A_Haq.Checked != true)
                            {
                                message_work.Icon = MessageDialogIcon.Error;
                                message_work.Show("يرجى اختيار نوع التخزين", "خطأ");
                            }

                            else
                            {
                                if (R_A_Haq.Checked == true)
                                {


                                    Data_Zaka.Value_Monye_Livestock_A = Val_Haq_M_A;
                                    R_A_Haq.Checked = false;
                                    Num_livestock.Clear();
                                    Price_Sheep_Dol.Clear();
                                    Price_Sheep_Dol_mos.Clear();

                                }
                                else if (R_A_Mos.Checked == true)
                                {

                                    Data_Zaka.Value_Monye_Livestock_A = Val_MOS_M_A;
                                    R_A_Mos.Checked = false;
                                    Num_livestock.Clear();
                                    Price_Sheep_Dol.Clear();
                                    Price_Sheep_Dol_mos.Clear();
                                }
                            }
                        }
                        else
                        {
                            if (Sum_Abel != -1)
                            {
                                Data_Zaka.Value_Monye_Livestock_A = Sum_Abel.ToString();
                                Sum_Abel = -1;
                                Num_livestock.Clear();
                                Price_Sheep_Dol.Clear();
                                Price_Sheep_Dol_mos.Clear();
                            }
                            else if (Val_Abel_end_M != "")
                            {


                                Data_Zaka.Value_Monye_Livestock_A = Val_Abel_end_M;
                                Val_Abel_end_M = "";
                                Num_livestock.Clear();
                                Price_Sheep_Dol.Clear();
                                Price_Sheep_Dol_mos.Clear();
                            }
                        }
                        Data_Zaka.Value_Zakah_Livestock_A = Val_LiveS_Z_A;
                    }
                }

                else
                {

                }
            }
            catch
            { meseage_style_error();
                message_work.Show("أدخل جميع البيانات أو قم بحساب الزكاة  ", "");
            }
        }
        private void Price_Sheep_Dol_mos_TextChanged(object sender, EventArgs e)
        {
            Text_Change_livestock();
        }

    }
    }


