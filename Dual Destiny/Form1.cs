using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Collections.Concurrent;

namespace Dual_Destiny
{
    public partial class Form1 : Form
    {
        bool[] One = { false, false };
        bool[] two = { false, false };
        bool[] three = { false, false };
        bool[] four = { false, false };
        bool[] five = { false, false };
        bool[] six = { false, false };
        bool[] seven = { false, false };
        bool[] eight = { false, false };
        bool[] nine = { false, false };

        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.Transparent;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void TurnOnOrangeLines()
        {
            Graphics g = panel1.CreateGraphics();
            //g.Clear(Color.White);
            Pen OrangePen = new Pen(Color.Orange);
            OrangePen.Width = 10;
            if (One[0])
            {
                g.DrawLine(OrangePen, 35, 0, 200, 135);
            }
            if (two[0])
            {
                g.DrawLine(OrangePen, 0, 65, 200, 135);
            }
            if (three[0])
            {
                g.DrawLine(OrangePen, 20, 145, 200, 135);
            }
            if (four[0])
            {
                g.DrawLine(OrangePen, 125, 200, 200, 135);
            }
            if (five[0])
            {
                g.DrawLine(OrangePen, 200, 300, 200, 135);
            }
            if (six[0])
            {
                g.DrawLine(OrangePen, 290, 220, 200, 135);
            }
            if (eight[0])
            {
                g.DrawLine(OrangePen, 365, 145, 200, 135);
            }
            if (eight[0])
            {
                g.DrawLine(OrangePen, 400, 65, 200, 135);
            }
            if (nine[0])
            {
                g.DrawLine(OrangePen, 385, 0, 200, 135);
            }
        }
        private void TurnOnGreenLines()
        {
            Graphics g = panel1.CreateGraphics();
            //g.Clear(Color.White);
            Pen GreenPen = new Pen(Color.White);
            GreenPen.Width = 10;
            if (One[1])
            {
                g.DrawLine(GreenPen, 35, 0, 200, 135);
            }
            if (two[1])
            {
                g.DrawLine(GreenPen, 0, 65, 200, 135);
            }
            if (three[1])
            {
                g.DrawLine(GreenPen, 20, 145, 200, 135);
            }
            if (four[1])
            {
                g.DrawLine(GreenPen, 125, 200, 200, 135);
            }
            if (five[1])
            {
                g.DrawLine(GreenPen, 200, 300, 200, 135);
            }
            if (six[1])
            {
                g.DrawLine(GreenPen, 290, 220, 200, 135);
            }
            if (seven[1])
            {
                g.DrawLine(GreenPen, 365, 145, 200, 135);
            }
            if (eight[1])
            {
                g.DrawLine(GreenPen, 400, 65, 200, 135);
            }
            if (nine[1])
            {
                g.DrawLine(GreenPen, 385, 0, 200, 135);
            }
        }
        private void TurnOffLines()
        {
            Graphics g = panel1.CreateGraphics();
            //g.Clear(Color.White);
            Pen WhitePen = new Pen(Color.Green);
            WhitePen.Width = 10;
            if (One[1])
            {
                g.DrawLine(WhitePen, 35, 0, 200, 135);
            }
            if (two[1])
            {
                g.DrawLine(WhitePen, 0, 65, 200, 135);
            }
            if (three[1])
            {
                g.DrawLine(WhitePen, 20, 145, 200, 135);
            }
            if (four[1])
            {
                g.DrawLine(WhitePen, 125, 200, 200, 135);
            }
            if (five[1])
            {
                g.DrawLine(WhitePen, 200, 300, 200, 135);
            }
            if (six[1])
            {
                g.DrawLine(WhitePen, 290, 220, 200, 135);
            }
            if (seven[1])
            {
                g.DrawLine(WhitePen, 365, 145, 200, 135);
            }
            if (eight[1])
            {
                g.DrawLine(WhitePen, 400, 65, 200, 135);
            }
            if (nine[1])
            {
                g.DrawLine(WhitePen, 385, 0, 200, 135);
            }
        }
        private void clearNumbers()
        {
            One[0] = false;
            two[0] = false;
            three[0] = false;
            four[0] = false;
            five[0] = false;
            six[0] = false;
            seven[0] = false;
            eight[0] = false;
            nine[0] = false;
            One[1] = false;
            two[1] = false;
            three[1] = false;
            four[1] = false;
            five[1] = false;
            six[1] = false;
            seven[1] = false;
            eight[1] = false;
            nine[1] = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool isOrange = One[0];
            bool isGreen = One[1];
            if(isGreen)
            {
                One[0] = false;
                One[1] = false;
            }
            else if (isOrange)
            {
                One[1] = true;
            }
            else
            {
                One[0] = true;
            }
            TurnOnOrangeLines();
            TurnOnGreenLines();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isOrange = two[0];
            bool isGreen = two[1];
            if (isGreen)
            {
                two[0] = false;
                two[1] = false;
            }
            else if (isOrange)
            {
                two[1] = true;
            }
            else
            {
                two[0] = true;
            }
            TurnOnOrangeLines();
            TurnOnGreenLines();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool isOrange = three[0];
            bool isGreen = three[1];
            if (isGreen)
            {
                three[0] = false;
                three[1] = false;
            }
            else if (isOrange)
            {
                three[1] = true;
            }
            else
            {
                three[0] = true;
            }
            TurnOnOrangeLines();
            TurnOnGreenLines();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool isOrange = four[0];
            bool isGreen = four[1];
            if (isGreen)
            {
                four[0] = false;
                four[1] = false;
            }
            else if (isOrange)
            {
                four[1] = true;
            }
            else
            {
                four[0] = true;
            }
            TurnOnOrangeLines();
            TurnOnGreenLines();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool isOrange = five[0];
            bool isGreen = five[1];
            if (isGreen)
            {
                five[0] = false;
                five[1] = false;
            }
            else if (isOrange)
            {
                five[1] = true;
            }
            else
            {
                five[0] = true;
            }
            TurnOnOrangeLines();
            TurnOnGreenLines();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool isOrange = six[0];
            bool isGreen = six[1];
            if (isGreen)
            {
                six[0] = false;
                six[1] = false;
            }
            else if (isOrange)
            {
                six[1] = true;
            }
            else
            {
                six[0] = true;
            }
            TurnOnOrangeLines();
            TurnOnGreenLines();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool isOrange = seven[0];
            bool isGreen = seven[1];
            if (isGreen)
            {
                seven[0] = false;
                seven[1] = false;
            }
            else if (isOrange)
            {
                seven[1] = true;
            }
            else
            {
                seven[0] = true;
            }
            TurnOnOrangeLines();
            TurnOnGreenLines();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool isOrange = eight[0];
            bool isGreen = eight[1];
            if (isGreen)
            {
                eight[0] = false;
                eight[1] = false;
            }
            else if (isOrange)
            {
                eight[1] = true;
            }
            else
            {
                eight[0] = true;
            }
            TurnOnOrangeLines();
            TurnOnGreenLines();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool isOrange = nine[0];
            bool isGreen = nine[1];
            if (isGreen)
            {
                nine[0] = false;
                nine[1] = false;
            }
            else if (isOrange)
            {
                nine[1] = true;
            }
            else
            {
                nine[0] = true;
            }
            TurnOnOrangeLines();
            TurnOnGreenLines();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            bool isParsed = int.TryParse(Text, out int result);
            if (Text.Length == 6 && isParsed)
            {
                int[] unmatchedNums = { Text[0], Text[1], Text[2], Text[3], Text[4], Text[5] };
                clearNumbers();

                ErrorLabel.Text = "";
                foreach (int n in unmatchedNums)
                {
                    //ErrorLabel.Text += n;
                    //n = n - 48;
                    switch (n)
                    {
                        case 49:
                            One[0] = true;
                            break;
                        case 50:
                            two[0] = true;
                            break;
                        case 51:
                            three[0] = true;
                            break;
                        case 52:
                            four[0] = true;
                            break;
                        case 53:
                            five[0] = true;
                            break;
                        case 54:
                            six[0] = true;
                            break;
                        case 55:
                            seven[0] = true;
                            break;
                        case 56: 
                            eight[0] = true; 
                            break;
                        case 57: 
                            nine[0] = true;
                            break;
                    }
                }
                if (!One[0]) 
                {
                    One[1] = true;
                }
                if (!two[0])
                {
                    two[1] = true;
                }
                if (!three[0])
                {
                    three[1] = true;
                }
                if (four[0])
                {
                    four[1] = true;
                }
                if (five[0])
                { 
                    five[1] = true;
                }
                if (six[0])
                {
                    six[1] = true;
                }
                if (seven[0])
                {
                    seven[1] = true;
                }
                if (eight[0])
                {
                    eight[1] = true;
                }
                if (nine[0])
                {
                    nine[1] = true;
                }

                TurnOnGreenLines();
            }
            else
            {
                clearNumbers();
                Graphics g = panel1.CreateGraphics();
                g.Clear(Color.White);
            }
        }
    }
}
