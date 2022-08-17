using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zakate_project.login;

namespace Zakate_project.FORMS_GROUP
{
    public partial class Form_Reception : Form
    {
        string text;
        int len = 0;
        public Form_Reception()
        {
         

            InitializeComponent();
            Timer_text.Stop();
            pictureBox3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (this.Opacity< 1)
            {
                this.Opacity += 0.04;
                
            }

            CircleProgressBar1.Value += 1;
            CircleProgressBar1.Text = CircleProgressBar1.Value.ToString();
            Timer_text.Start();
          
                if (CircleProgressBar1.Value == 100)
                {
                    timer1.Stop();
                    timer2.Start();
                }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.02;
            if (this.Opacity == 0)
            {
                this.Close();
                timer2.Stop();
            
            }
        }

        private void Form_Reception_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Form_Login l = new Form_Login();
            CircleProgressBar1.Value = 0;
            CircleProgressBar1.Maximum= 100;
            CircleProgressBar1.Minimum = 0;
       
            text = Welcome_L.Text;
            Welcome_L.Text = "";

        }

        private void Timer_text_Tick(object sender, EventArgs e)
        {
            if (len < text.Length)
            {
                Welcome_L.Text = Welcome_L.Text + text.ElementAt(len);
                len++;
            }
           
            else
            {
                Timer_text.Stop();
                l_Username.Text = User_Name.Text_Name;
                pictureBox3.Visible = true ;

            }
        }
    }
}
