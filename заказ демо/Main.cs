using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace заказ_демо
{
    public partial class Main : Form
    {
       
        public DateTime date=new DateTime(0,0);
        public DateTime date2 = new DateTime(0, 0);
        private Point mouseOffset;
        private bool isMouseDown = false;
        
        public static int points = 0;
        public Main()
        {
              
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            if (label5.Text == "45")
                label10.Visible = true;


        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            points++;
            
        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            label5.Text = time.ToString();
            label10.Visible = false;
            label9.Visible =false;
            label8.Visible = false;
            label11.Visible = false;

        }
      
        //DateTime stop = new DateTime(0,0);
        public void ticktimer(object sendet,EventArgs e)
        {
            
            //long tick = DateTime.Now.Ticks - date.Ticks;
            //stop =stop.AddTicks(tick);
            //label4.Text=stop.ToString("mm\\:ss");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            this.Location = new Point(Cursor.Position.X - ClientSize.Width / 8, Cursor.Position.Y - ClientSize.Height / 8);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //stop.AddMinutes(4);
        }
        public int time = 85;
        public int time0 = 00;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            
            date = date.AddSeconds(60);
            label4.Text = date.ToString("ss");

            if (time < 9)
            {


                if (label4.Text == "00")
                    time += 1;
                label7.Text = time.ToString();
            }
            else
            {
                label7.Visible = false;
                if (label4.Text == "00")
                    time++;
                label5.Text = time.ToString();
            }
            
            
            
            if ((time == 45)||(time==90))
            {
                timer1.Stop();
                
            }
                
           



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
    
            
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
        public int doptime = 0;
        public int count = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            
            if ((label5.Text == "45") || (label5.Text == "90"))
            {


                timer2.Interval = 1000;
                if ((label9.Text != count.ToString()) & (label10.Text != count.ToString()))
                    date2 = date2.AddSeconds(1);
                if (count < 10)
                {
                    if (label9.Text == count.ToString())
                        timer2.Stop();
                }
                else
                {
                    if (label10.Text == count.ToString())
                        timer2.Stop();
                }




                label8.Text = date2.ToString("ss");
                if (doptime < 9)
                {


                    if ((label8.Text == "00") & ((label9.Text != count.ToString()) & (label10.Text != count.ToString())))
                    {
                        doptime++;
                        label9.Text = doptime.ToString();
                    }
                }
                else
                {
                    label9.Visible = false;
                    if ((label8.Text == "00") & ((label9.Text != count.ToString()) & (label10.Text != count.ToString())))
                        doptime++;
                    label10.Text = doptime.ToString();
                }
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            if ((label5.Text == "45")||(label5.Text=="90"))
            {
                label10.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label11.Visible = true;
            }
                

        }
    }
}
