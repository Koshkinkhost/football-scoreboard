using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace заказ_демо
{
    
    public partial class Form1 : Form
    {
        
        public  int points = 0;
        public int points2 = 0;
        public  int count = 0;
        public Form1()
        {
            InitializeComponent();
            


    }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        Main m = new Main();
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            m.Show();
            m.label1.Text=points.ToString();
            
        }
  
        private void button1_Click_1(object sender, EventArgs e)
        {
            points++;
            m.label1.Text = points.ToString();
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result=new DialogResult();
            string caption = "Подтверждение";
            string message = "Вы уверены,что хотите закончить?";
            MessageBox.Show(message,caption, MessageBoxButtons.OKCancel);
            if(result==DialogResult.OK)
            {
                this.Close();
                m.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            points2++;
            m.label2.Text = points2.ToString();
        }
        DateTime date;
        
        private void button4_Click(object sender, EventArgs e)
        {
            
            //Stopwatch sw = new Stopwatch();
            //TimeSpan ts = new TimeSpan();
            //sw.Start();

            //m.label4.Text = String.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

            if (m.timer1.Enabled == true)
                m.timer1.Enabled = false;
            else
                m.timer1.Enabled = true;
            button1.Enabled = true;
            button3.Enabled = true;
            m.timer1.Interval = 1000;
            //m.WindowState = FormWindowState.Maximized;
            //m.Height=MaximumSize.Height;
            //m.Width=MaximumSize.Width;

            //m.label4.Text = m.sw.Elapsed.ToString("mm\\:ss");
            // m.timer1.Interval = 100;

            // m.timer1.Tick += new EventHandler(m.ticktimer);
            //m.timer1.Start();
            //m.timer.Start();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            m.timer1.Stop();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       
        private void button5_Click_1(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(new Regex("\\D").Replace(textBox1.Text, ""));
            
            m.count= i;
            m.timer2.Start();
             
            MessageBox.Show($"{i}");




        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
