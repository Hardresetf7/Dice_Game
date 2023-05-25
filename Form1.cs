using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int amountUser = 0;
        int amountComputer = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            Random randomer = new Random();
            int a = randomer.Next(1, 7);
            int b = randomer.Next(1, 7);

            amountUser = amountUser + a + b;
            label16.Text = amountUser.ToString();

            if (a ==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice1.PNG";
            }

            if (a ==2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice2.PNG";
            }

            if (a ==3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice3.PNG";
            }

            if (a==4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice4.PNG";
            }

            if (a ==5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice5.PNG";
            }

            if (a==6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice6.PNG";
            }

            if (b== 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice1.PNG";
            }

            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice2.PNG";
            }

            if (b == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice3.PNG";
            }

            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice4.PNG";
            }

            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice5.PNG";
            }

            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice6.PNG";
            }


            label3.Text = a.ToString();
            label4.Text = b.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            Random randomer = new Random();

            int c = randomer.Next(1, 7);
            int d = randomer.Next(1, 7);

            label10.Text = c.ToString();
            label9.Text = d.ToString();

            amountComputer = amountComputer + c + d;
            label15.Text = amountComputer.ToString();


            
            label10.Text = c.ToString();
            label9.Text = d.ToString();

            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice1.PNG";
            }

            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice2.PNG";
            }

            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice3.PNG";
            }

            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice4.PNG";
            }

            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice5.PNG";
            }

            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice6.PNG";
            }

            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice1.PNG";
            }

            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice2.PNG";
            }

            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice3.PNG";
            }

            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice4.PNG";
            }

            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice5.PNG";
            }

            if (d == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\FurkanOviççç\\Documents\\C# Projects\\Dökümanlar\\dice6.PNG";
            }

            if (amountUser > 100 && amountUser > amountComputer)
            {
                label13.Text = " Player has won the game! ♥ ";
            }

            if ( amountComputer > 100 && amountComputer > amountUser)
            {
                label13.Text = "Computer has won the game! ☻ ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
 }
