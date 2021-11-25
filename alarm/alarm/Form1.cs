using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;//button 2 disabled 
            textBox1.Text = DateTime.Now.ToShortDateString();
            textBox2.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int x, y, z;
            if (textBox1.Text == DateTime.Now.ToShortDateString() && textBox2.Text == DateTime.Now.ToLongTimeString())
            {
                Random rnd = new Random();
                x = rnd.Next(255);
                y = rnd.Next(255);
                z = rnd.Next(255);
                

                groupBox1.BackColor = Color.FromArgb(x, y, z);
                this.BackColor = Color.FromArgb(x, y, z);



                label3.Text = "alarm çalıyor";
                timer2.Enabled = true;
                //isteğe bağlı şarkı eklenebilir
                //SoundPlayer palyer = new SoundPlayer();
                //string sarkiy = Application.StartupPath + "/alarm.mp3";
                //palyer.SoundLocation =  sarkiy;
                //palyer.Play();
                button2.Enabled = true;
            }
            else
            {
                label3.Text = " ";
                groupBox1.BackColor = Color.White;
                this.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            ;
        }
    }
}
