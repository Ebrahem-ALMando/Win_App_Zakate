
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zakate_project.models;
using Guna.UI2.WinForms;
using Zakate_project.FORMS_GROUP;

namespace Zakate_project.FORMS_GROUP
{
    public partial class Form_Dashbord : Form
    {
        //Fields
        private Dashboard model;
        private Button currentButton;


        //Constructor
        public Form_Dashbord()
        {
            InitializeComponent();
            this.Text = string.Empty;
  
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
       
            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            SetDateMenuButtonsUI(btnLast7Days);
            model = new Dashboard();
            LoadData();
        }

        //Private methods
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
   
                  /*Get Sum Money*/
                lblSumMonye_indate.Text = "$" + model.Sum_Money.ToString();
                lblSumMonye.Text = "$" + model.sum_Monye.ToString();
                /*Get number processs*/
                lblNumProcess_indate.Text = model.Num_Process_in_date.ToString();
                lblNumProcess.Text = model.Num_Process.ToString();
                /* Get Total Number of Donors*/
                lblNumMoz.Text = model.Num_mozke.ToString();
                lblNumMoz_indate.Text = model.Num_mozke_in_date.ToString();
                /*Get Total Number of Type*/
                lblNumType.Text = model.Num_Type.ToString();
                /*Get Total Number of Item*/
                lblNumItem.Text = model.Num_Item.ToString();
                /*
                =================>>Ebrahem AL Mando<<=================
                =================>>Programmer<<=======================
                =================>>7/9/2022<<=========================*/

                chartSumMoney.DataSource = model.GrossRevenueList;
                chartSumMoney.Series[0].XValueMember = "Date";
                chartSumMoney.Series[0].YValueMembers = "TotalAmount";
                chartSumMoney.DataBind();
                chartItem.DataSource = model.TopitemList;
                chartItem.Series[0].XValueMember = "Key";
                chartItem.Series[0].YValueMembers = "Value";
                chartItem.DataBind();
                dgvUnderstock.DataSource = model.LowtypeList;
                dgvUnderstock.Columns[0].HeaderText = "اسم النوع";
                dgvUnderstock.Columns[1].HeaderText = "الكمية";
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }
        private void SetDateMenuButtonsUI(object button)
        {
            var btn = (Button)button;
            /* heighlight Bouttn*/
            btn.BackColor = btnLast30Days.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            if (currentButton != null && currentButton != btn) 
            {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currentButton = btn;//Set currentButton 
            //Enable custem dates
            if (btn == btnCustomDate)
            {
                dtpStartDate.Enabled = true;
                dtpEndDate.Enabled = true;
                btnOkCustomDate.Visible = true;
                LblStardate.Cursor = Cursors.Hand;
                LblEnddate.Cursor = Cursors.Hand;

            }
            //Enable custem dates
            else
            {
                dtpStartDate.Enabled = false;
                dtpEndDate.Enabled = false;
                btnOkCustomDate.Visible = false;
                LblStardate.Cursor = Cursors.Default;
                LblEnddate.Cursor = Cursors.Default;
            }
 
        }

        //Event methods
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            SetDateMenuButtonsUI(sender);
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
         
            SetDateMenuButtonsUI(sender);
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LblStardate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpStartDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void LblEnddate_Click(object sender, EventArgs e)
        {
            if (currentButton == btnCustomDate)
            {
                dtpEndDate.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            LblEnddate.Text = dtpEndDate.Text;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            LblStardate.Text = dtpStartDate.Text;
        }

        private void Form_Dashbord_Load(object sender, EventArgs e)
        {
            LblEnddate.Text = dtpEndDate.Text;
            LblStardate.Text = dtpStartDate.Text;
            dgvUnderstock.Columns[1].Width=70;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetDateMenuButtonsUI(sender);
            Guna2MessageDialog message = new Guna2MessageDialog();
            message.Icon = MessageDialogIcon.Question;
            message.Style = MessageDialogStyle.Light;
            message.Buttons = MessageDialogButtons.YesNo;
            DialogResult check = message.Show("هل تريد العودة الى الواجهة الرئيسية","الرئيسية");
            if (check == DialogResult.Yes)
            {
                Form_Home home = new Form_Home();
                this.Close();
                home.ShowDialog();
            }

            
        }
    }
}
