
namespace Zakate_project.FORMS_GROUP
{
    partial class Form_Dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Dashbord));
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnThisMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast30Days = new Guna.UI2.WinForms.Guna2Button();
            this.btnLast7Days = new Guna.UI2.WinForms.Guna2Button();
            this.btnToday = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomDate = new Guna.UI2.WinForms.Guna2Button();
            this.btnOkCustomDate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNummozindata = new System.Windows.Forms.Label();
            this.lblNummoz = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalmony = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lb_lNum_Process_in_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.Tx2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.Tx = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvUnderstock = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNumtype = new System.Windows.Forms.Label();
            this.lblNumItem = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_Home_moz = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.CustomFormat = "MMM dd, yyyy";
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(889, 12);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(162, 36);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.Value = new System.DateTime(2022, 6, 1, 13, 58, 31, 711);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThisMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThisMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThisMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThisMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThisMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThisMonth.ForeColor = System.Drawing.Color.White;
            this.btnThisMonth.Location = new System.Drawing.Point(6, 12);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(124, 36);
            this.btnThisMonth.TabIndex = 1;
            this.btnThisMonth.Text = "الشهر الحالي";
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLast30Days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLast30Days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLast30Days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLast30Days.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLast30Days.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLast30Days.ForeColor = System.Drawing.Color.White;
            this.btnLast30Days.Location = new System.Drawing.Point(135, 12);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(124, 36);
            this.btnLast30Days.TabIndex = 1;
            this.btnLast30Days.Text = "منذ 30 يوم";
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLast7Days.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLast7Days.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLast7Days.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLast7Days.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLast7Days.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLast7Days.ForeColor = System.Drawing.Color.White;
            this.btnLast7Days.Location = new System.Drawing.Point(264, 12);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(124, 36);
            this.btnLast7Days.TabIndex = 1;
            this.btnLast7Days.Text = "اخر 7 ايام";
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            this.btnLast7Days.MouseHover += new System.EventHandler(this.btnLast7Days_MouseHover);
            // 
            // btnToday
            // 
            this.btnToday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(393, 12);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(124, 36);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "اليوم";
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCustomDate.ForeColor = System.Drawing.Color.White;
            this.btnCustomDate.Location = new System.Drawing.Point(522, 12);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(124, 36);
            this.btnCustomDate.TabIndex = 1;
            this.btnCustomDate.Text = "مخصص";
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOkCustomDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOkCustomDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOkCustomDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOkCustomDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOkCustomDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOkCustomDate.ForeColor = System.Drawing.Color.White;
            this.btnOkCustomDate.Location = new System.Drawing.Point(651, 12);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(72, 36);
            this.btnOkCustomDate.TabIndex = 2;
            this.btnOkCustomDate.Text = "موافق";
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.lblNummozindata);
            this.guna2Panel1.Controls.Add(this.lblNummoz);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(825, 66);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(376, 50);
            this.guna2Panel1.TabIndex = 3;
            // 
            // lblNummozindata
            // 
            this.lblNummozindata.AutoSize = true;
            this.lblNummozindata.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNummozindata.Location = new System.Drawing.Point(45, 31);
            this.lblNummozindata.Name = "lblNummozindata";
            this.lblNummozindata.Size = new System.Drawing.Size(53, 17);
            this.lblNummozindata.TabIndex = 1;
            this.lblNummozindata.Text = "10000";
            // 
            // lblNummoz
            // 
            this.lblNummoz.AutoSize = true;
            this.lblNummoz.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNummoz.Location = new System.Drawing.Point(279, 30);
            this.lblNummoz.Name = "lblNummoz";
            this.lblNummoz.Size = new System.Drawing.Size(53, 17);
            this.lblNummoz.TabIndex = 1;
            this.lblNummoz.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "عدد المزكيين لتاريخ مخصص";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد المزكيين الكلي";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.lblTotalmony);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Location = new System.Drawing.Point(507, 66);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(312, 50);
            this.guna2Panel2.TabIndex = 4;
            // 
            // lblTotalmony
            // 
            this.lblTotalmony.AutoSize = true;
            this.lblTotalmony.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalmony.Location = new System.Drawing.Point(226, 28);
            this.lblTotalmony.Name = "lblTotalmony";
            this.lblTotalmony.Size = new System.Drawing.Size(53, 17);
            this.lblTotalmony.TabIndex = 1;
            this.lblTotalmony.Text = "10000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "كمية الزكاة";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.lb_lNum_Process_in_date);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.lblTotalPro);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Location = new System.Drawing.Point(12, 68);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(475, 50);
            this.guna2Panel3.TabIndex = 4;
            // 
            // lb_lNum_Process_in_date
            // 
            this.lb_lNum_Process_in_date.AutoSize = true;
            this.lb_lNum_Process_in_date.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lNum_Process_in_date.Location = new System.Drawing.Point(87, 26);
            this.lb_lNum_Process_in_date.Name = "lb_lNum_Process_in_date";
            this.lb_lNum_Process_in_date.Size = new System.Drawing.Size(53, 17);
            this.lb_lNum_Process_in_date.TabIndex = 3;
            this.lb_lNum_Process_in_date.Text = "10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "عدد عمليات الزكاة لتاريخ مخصص";
            // 
            // lblTotalPro
            // 
            this.lblTotalPro.AutoSize = true;
            this.lblTotalPro.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPro.Location = new System.Drawing.Point(350, 26);
            this.lblTotalPro.Name = "lblTotalPro";
            this.lblTotalPro.Size = new System.Drawing.Size(53, 17);
            this.lblTotalPro.TabIndex = 1;
            this.lblTotalPro.Text = "10000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "عدد عمليات الزكاة الكلية";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 124);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(818, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopRight;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "الرسم البياني لكمية الزكاة";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(853, 124);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            series2.IsValueShownAsLabel = true;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(343, 484);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopRight;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "نسبة كل صنف";
            this.chart2.Titles.Add(title2);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.White;
            this.guna2Panel4.Controls.Add(this.Tx2);
            this.guna2Panel4.Controls.Add(this.Tx);
            this.guna2Panel4.Controls.Add(this.dgvUnderstock);
            this.guna2Panel4.Controls.Add(this.label8);
            this.guna2Panel4.Location = new System.Drawing.Point(179, 440);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(651, 168);
            this.guna2Panel4.TabIndex = 4;
            // 
            // Tx2
            // 
            this.Tx2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tx2.DefaultText = "";
            this.Tx2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Tx2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Tx2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tx2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tx2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tx2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tx2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tx2.Location = new System.Drawing.Point(364, 95);
            this.Tx2.Name = "Tx2";
            this.Tx2.PasswordChar = '\0';
            this.Tx2.PlaceholderText = "";
            this.Tx2.SelectedText = "";
            this.Tx2.Size = new System.Drawing.Size(200, 36);
            this.Tx2.TabIndex = 7;
            // 
            // Tx
            // 
            this.Tx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tx.DefaultText = "";
            this.Tx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Tx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Tx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Tx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tx.Location = new System.Drawing.Point(364, 51);
            this.Tx.Name = "Tx";
            this.Tx.PasswordChar = '\0';
            this.Tx.PlaceholderText = "";
            this.Tx.SelectedText = "";
            this.Tx.Size = new System.Drawing.Size(200, 36);
            this.Tx.TabIndex = 6;
            // 
            // dgvUnderstock
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUnderstock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnderstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnderstock.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvUnderstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnderstock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnderstock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnderstock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnderstock.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnderstock.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUnderstock.EnableHeadersVisualStyles = false;
            this.dgvUnderstock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUnderstock.Location = new System.Drawing.Point(19, 20);
            this.dgvUnderstock.Name = "dgvUnderstock";
            this.dgvUnderstock.RowHeadersVisible = false;
            this.dgvUnderstock.RowHeadersWidth = 51;
            this.dgvUnderstock.RowTemplate.Height = 26;
            this.dgvUnderstock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnderstock.Size = new System.Drawing.Size(610, 130);
            this.dgvUnderstock.TabIndex = 1;
            this.dgvUnderstock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnderstock.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUnderstock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUnderstock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUnderstock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUnderstock.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvUnderstock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUnderstock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUnderstock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUnderstock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUnderstock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUnderstock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUnderstock.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvUnderstock.ThemeStyle.ReadOnly = false;
            this.dgvUnderstock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUnderstock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnderstock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvUnderstock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUnderstock.ThemeStyle.RowsStyle.Height = 26;
            this.dgvUnderstock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUnderstock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(521, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "الاصناف";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.White;
            this.guna2Panel5.Controls.Add(this.label7);
            this.guna2Panel5.Controls.Add(this.label12);
            this.guna2Panel5.Controls.Add(this.lblNumtype);
            this.guna2Panel5.Controls.Add(this.lblNumItem);
            this.guna2Panel5.Controls.Add(this.label10);
            this.guna2Panel5.Controls.Add(this.label9);
            this.guna2Panel5.Location = new System.Drawing.Point(12, 440);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(161, 168);
            this.guna2Panel5.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "10000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(57, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "الانواع";
            // 
            // lblNumtype
            // 
            this.lblNumtype.AutoSize = true;
            this.lblNumtype.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumtype.Location = new System.Drawing.Point(59, 95);
            this.lblNumtype.Name = "lblNumtype";
            this.lblNumtype.Size = new System.Drawing.Size(44, 17);
            this.lblNumtype.TabIndex = 0;
            this.lblNumtype.Text = "1000";
            // 
            // lblNumItem
            // 
            this.lblNumItem.AutoSize = true;
            this.lblNumItem.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumItem.Location = new System.Drawing.Point(59, 39);
            this.lblNumItem.Name = "lblNumItem";
            this.lblNumItem.Size = new System.Drawing.Size(44, 17);
            this.lblNumItem.TabIndex = 0;
            this.lblNumItem.Text = "1000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "الاصناف";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(416, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "الاصناف";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.CustomFormat = "MMM dd, yyyy";
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(726, 12);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(157, 36);
            this.dtpEndDate.TabIndex = 0;
            this.dtpEndDate.Value = new System.DateTime(2022, 6, 1, 13, 58, 31, 711);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // btn_Home_moz
            // 
            this.btn_Home_moz.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Home_moz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Home_moz.FlatAppearance.BorderSize = 0;
            this.btn_Home_moz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home_moz.Font = new System.Drawing.Font("AGA Arabesque", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home_moz.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Home_moz.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home_moz.Image")));
            this.btn_Home_moz.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Home_moz.Location = new System.Drawing.Point(1057, 7);
            this.btn_Home_moz.Name = "btn_Home_moz";
            this.btn_Home_moz.Size = new System.Drawing.Size(144, 41);
            this.btn_Home_moz.TabIndex = 7;
            this.btn_Home_moz.Text = "الرئيسية    ";
            this.btn_Home_moz.UseVisualStyleBackColor = false;
            // 
            // Form_Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 610);
            this.Controls.Add(this.btn_Home_moz);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnOkCustomDate);
            this.Controls.Add(this.btnCustomDate);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnLast7Days);
            this.Controls.Add(this.btnLast30Days);
            this.Controls.Add(this.btnThisMonth);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Name = "Form_Dashbord";
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnderstock)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnThisMonth;
        private Guna.UI2.WinForms.Guna2Button btnLast30Days;
        private Guna.UI2.WinForms.Guna2Button btnLast7Days;
        private Guna.UI2.WinForms.Guna2Button btnToday;
        private Guna.UI2.WinForms.Guna2Button btnCustomDate;
        private Guna.UI2.WinForms.Guna2Button btnOkCustomDate;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblNummoz;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblTotalmony;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblTotalPro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUnderstock;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNumtype;
        private System.Windows.Forms.Label lblNumItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_lNum_Process_in_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNummozindata;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2TextBox Tx;
        private Guna.UI2.WinForms.Guna2TextBox Tx2;
        private System.Windows.Forms.Button btn_Home_moz;
    }
}