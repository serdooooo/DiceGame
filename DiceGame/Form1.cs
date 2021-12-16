using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        
        int dice1, dice2, dice3;
        public Form1()
        {
            
            InitializeComponent();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            Random rnd = new Random();
            dice1 = rnd.Next(0, 6);
            dice2 = rnd.Next(0, 6);
            dice3 = rnd.Next(0, 6);
            pictureBox1.Image = ımageList1.Images[dice1];
            pictureBox2.Image = ımageList1.Images[dice2];
            pictureBox3.Image = ımageList1.Images[dice3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Enabled = false;
        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            dice1 = rnd.Next(0, 6);
            dice2 = rnd.Next(0, 6);
            dice3 = rnd.Next(0, 6);
            if (checkBox1.Checked == true)
            {
                pictureBox1.Enabled = true;
            }
            else
            {
                pictureBox1.Enabled = false;
                pictureBox1.Image = ımageList1.Images[dice1];
            }


            if (checkBox2.Checked == true)
            {
                pictureBox2.Enabled = true;
            }
            else
            {
                pictureBox2.Enabled = false;
                pictureBox2.Image = ımageList1.Images[dice2];
            }


            if (checkBox3.Checked == true)
            {
                pictureBox3.Enabled = true;
            }
            else
            {
                pictureBox3.Enabled = false;
                pictureBox3.Image = ımageList1.Images[dice3];
            }
            sayac++;
            if (sayac == 10)
            {
                timer1.Stop();
                sayac = 0;
                button1.Enabled = true;
            }
        }

    }
}