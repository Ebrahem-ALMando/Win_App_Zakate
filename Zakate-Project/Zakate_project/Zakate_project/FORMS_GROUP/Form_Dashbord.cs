using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zakate_project.FORMS_GROUP
{
    public partial class Form_Dashbord : Form
    {
        private Reports.dashBord_Reports model = new Reports.dashBord_Reports();

        public Form_Dashbord()
        {
            InitializeComponent();
          

            dtpEndDate.Value = DateTime.Today.AddDays(-7);
            dtpStartDate.Value = DateTime.Now;
            btnLast7Days.Select();
            LoadData();
           


        }
        //Convert.ToDateTime(dtpStartDate.Value.ToString("yyyy-MM-dd"))
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
          

            if (refreshData == true)
            {
                lblNummoz.Text = model.Num_mozke.ToString();
                lblTotalmony.Text =model.sum_Monye.ToString()+ " \t$ ";
                //double tipo_de_cambio = 17;//سعر التصريف الحالي 
                //double Value_Money_Dol =(double) model.sum_Monye / tipo_de_cambio;
                //double value_Round = Math.Round(Value_Money_Dol,2);
                //lblTotalmonyDolr.Text = value_Round.ToString()+ "\tTRY";
                lblTotalPro.Text = model.Num_Process.ToString();
                lblNumItem.Text = model.Num_Item.ToString();
                lblNumtype.Text = model.Num_Type.ToString();
                //Num_Process_in_date
                lb_lNum_Process_in_date.Text = model.Num_Process_in_date.ToString();
                //Num_mozke_in_date


                lblNummozindata.Text = model.Num_mozke_in_date.ToString();


               
                chart1.DataSource = model.TotalProsgerList;
                chart1.Series[0].XValueMember = "data";
                chart1.Series[0].YValueMembers = "TotleAmount";
                chart1.DataBind();
                chart2.DataSource = model.TopItemList;
                chart2.Series[0].XValueMember = "Key";
                chart2.Series[0].YValueMembers = "Value";
                chart2.DataBind();
         /*       
                dgvUnderstock.DataSource = model.TopItemList;
                dgvUnderstock.Columns[0].HeaderText = "Item";
                dgvUnderstock.Columns[1].HeaderText = "Units";*/
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {

            LoadData();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {

        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            btnLast7Days.BackColor = Color.Red;
           
           
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {

        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {

        }

        private void btnLast7Days_MouseHover(object sender, EventArgs e)
        {
           btnLast7Days.BackColor= Color.Red;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}

