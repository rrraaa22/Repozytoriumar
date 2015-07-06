using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form11 : Form
    {
        private Form0 Form0;
        public Form11(Form0 zestaw)
        {
            InitializeComponent();
            Form0 = zestaw;
           
            //public string array = Form0.
        }

        string[,] array44 = Form0.Atrybuty.array;
        string[] numbers44 = Form0.Atrybuty.numbers;
        string[] colors44 = Form0.Atrybuty.colors;


        public void Karty()
        {

            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    array44[i + j * 2 * 4, 0] = numbers44[i];
                    array44[i + (j * 2 + 1) * 4, 0] = numbers44[i];
                    array44[i + j * 2 * 4, 1] = colors44[j];
                    array44[i + (j * 2 + 1) * 4, 1] = colors44[j];
                };
            };
            Random rand = new Random();
            for (int i = 0; i < 16; i++)
            {
                string str0 = array44[i, 0];
                string str1 = array44[i, 1];
                int r = rand.Next(i, 15);
                array44[i, 0] = array44[r, 0];
                array44[i, 1] = array44[r, 1];
                array44[r, 0] = str0;
                array44[r, 1] = str1;
            };
            for (int i = 0; i < 16; i++)
            {
                string str0 = array44[i, 0];
                string str1 = array44[i, 1];
                int r = rand.Next(i, 15);
                array44[i, 0] = array44[r, 0];
                array44[i, 1] = array44[r, 1];
                array44[r, 0] = str0;
                array44[r, 1] = str1;
            };
        }


        public int ruch = 0;
        public Color[] c = {Color.Transparent, Color.Silver, Color.Green};
        public String[] t = {"a", "b", "c"};
        public int[] a = {0,0,0};
        public int sukces;
        public int[] antibug = {0,0,0};
/**/        public int lruchow = 0;

        public void Sukces()
        {
            Text = "Sukces!";
            label1.Text = "Koniec gry!";
            button1.Text = "NOWA GRA";
        }

        public void YF()
        {
            if (ruch == 1)
            {
                ruch = 2;
/**/            lruchow++;
/**/            label3.Text = lruchow.ToString();
            }
            else if (ruch == 2)
            {
                if (c[1] == c[2] && t[1] == t[2] && (antibug[1] > antibug[2] || antibug[1] < antibug[2]))
                {
                    sukces++;
                    Trafienie(a[1]);
                    Trafienie(a[2]);
                    ruch = 1;
/**/                lruchow++;
/**/                label3.Text = lruchow.ToString();
                    if (sukces == 8) Sukces();
                }
                else if (antibug[1] == antibug[2]) 
                {
                    Pudlo(a[1]);
                    ruch = 1;
                }
                else
                {
/**/                lruchow++;
/**/                label3.Text = lruchow.ToString(); 
                    ruch = 3;
                }
            }
        }

        public void Trafienie(int s)
        {
            switch(s)
            {
                case 1:
                    label4_1.Enabled = false;
                    break;
                case 2:
                    label4_2.Enabled = false;
                    break;
                case 3:
                    label4_3.Enabled = false;
                    break;
                case 4:
                    label4_4.Enabled = false;
                    break;
                case 5:
                    label4_5.Enabled = false;
                    break;
                case 6:
                    label4_6.Enabled = false;
                    break;
                case 7:
                    label4_7.Enabled = false;
                    break;
                case 8:
                    label4_8.Enabled = false;
                    break;
                case 9:
                    label4_9.Enabled = false;
                    break;
                case 10:
                    label4_10.Enabled = false;
                    break;
                case 11:
                    label4_11.Enabled = false;
                    break;
                case 12:
                    label4_12.Enabled = false;
                    break;
                case 13:
                    label4_13.Enabled = false;
                    break;
                case 14:
                    label4_14.Enabled = false;
                    break;
                case 15:
                    label4_15.Enabled = false;
                    break;
                case 16:
                    label4_16.Enabled = false;
                    break;
            }
        }

        public void Pudlo(int s)
        {
            switch(s)
            {
                case 1:
                    label4_1.BorderStyle = BorderStyle.FixedSingle;
                    label4_1.BackColor = Color.LavenderBlush;
                    label4_1.Text = "";
                    break;
                case 2:
                    label4_2.BorderStyle = BorderStyle.FixedSingle;
                    label4_2.BackColor = Color.LavenderBlush;
                    label4_2.Text = "";
                    break;
                case 3:
                    label4_3.BorderStyle = BorderStyle.FixedSingle;
                    label4_3.BackColor = Color.LavenderBlush;
                    label4_3.Text = "";
                    break;
                case 4:
                    label4_4.BorderStyle = BorderStyle.FixedSingle;
                    label4_4.BackColor = Color.LavenderBlush;
                    label4_4.Text = "";
                    break;
                case 5:
                    label4_5.BorderStyle = BorderStyle.FixedSingle;
                    label4_5.BackColor = Color.LavenderBlush;
                    label4_5.Text = "";
                    break;
                case 6:
                    label4_6.BorderStyle = BorderStyle.FixedSingle;
                    label4_6.BackColor = Color.LavenderBlush;
                    label4_6.Text = "";
                    break;
                case 7:
                    label4_7.BorderStyle = BorderStyle.FixedSingle;
                    label4_7.BackColor = Color.LavenderBlush;
                    label4_7.Text = "";
                    break;
                case 8:
                    label4_8.BorderStyle = BorderStyle.FixedSingle;
                    label4_8.BackColor = Color.LavenderBlush;
                    label4_8.Text = "";
                    break;
                case 9:
                    label4_9.BorderStyle = BorderStyle.FixedSingle;
                    label4_9.BackColor = Color.LavenderBlush;
                    label4_9.Text = "";
                    break;
                case 10:
                    label4_10.BorderStyle = BorderStyle.FixedSingle;
                    label4_10.BackColor = Color.LavenderBlush;
                    label4_10.Text = "";
                    break;
                  case 11:
                    label4_11.BorderStyle = BorderStyle.FixedSingle;
                    label4_11.BackColor = Color.LavenderBlush;
                    label4_11.Text = "";
                    break;
                case 12:
                    label4_12.BorderStyle = BorderStyle.FixedSingle;
                    label4_12.BackColor = Color.LavenderBlush;
                    label4_12.Text = "";
                    break;
                case 13:
                    label4_13.BorderStyle = BorderStyle.FixedSingle;
                    label4_13.BackColor = Color.LavenderBlush;
                    label4_13.Text = "";
                    break;
                case 14:
                    label4_14.BorderStyle = BorderStyle.FixedSingle;
                    label4_14.BackColor = Color.LavenderBlush;
                    label4_14.Text = "";
                    break;
                case 15:
                    label4_15.BorderStyle = BorderStyle.FixedSingle;
                    label4_15.BackColor = Color.LavenderBlush;
                    label4_15.Text = "";
                    break;
                case 16:
                    label4_16.BorderStyle = BorderStyle.FixedSingle;
                    label4_16.BackColor = Color.LavenderBlush;
                    label4_16.Text = "";
                    break;
            }
        }

        public void Wlacz(int s)
        {
            switch(s)
            {
                case 1:
                    label4_1.Visible = true;
                    label4_1.Enabled = true;
                    break;
                case 2:
                    label4_2.Visible = true;
                    label4_2.Enabled = true;
                    break;
                case 3:
                    label4_3.Visible = true;
                    label4_3.Enabled = true;
                    break;
                case 4:
                    label4_4.Visible = true;
                    label4_4.Enabled = true;
                    break;
                case 5:
                    label4_5.Visible = true;
                    label4_5.Enabled = true;
                    break;
                case 6:
                    label4_6.Visible = true;
                    label4_6.Enabled = true;
                    break;
                case 7:
                    label4_7.Visible = true;
                    label4_7.Enabled = true;
                    break;
                case 8:
                    label4_8.Visible = true;
                    label4_8.Enabled = true;
                    break;
                case 9:
                    label4_9.Visible = true;
                    label4_9.Enabled = true;
                    break;
                case 10:
                    label4_10.Visible = true;
                    label4_10.Enabled = true;
                    break;
                case 11:
                    label4_11.Visible = true;
                    label4_11.Enabled = true;
                    break;
                case 12:
                    label4_12.Visible = true;
                    label4_12.Enabled = true;
                    break;
                case 13:
                    label4_13.Visible = true;
                    label4_13.Enabled = true;
                    break;
                case 14:
                    label4_14.Visible = true;
                    label4_14.Enabled = true;
                    break;
                case 15:
                    label4_15.Visible = true;
                    label4_15.Enabled = true;
                    break;
                case 16:
                    label4_16.Visible = true;
                    label4_16.Enabled = true;
                    break;
            }
        }

        public void Ruch(int s)
        {
            if (ruch == 3)
            {
                Pudlo(a[1]);
                Pudlo(a[2]);
                ruch = 1;
            }
            Karta(s - 1);

            a[ruch] = s;
            c[ruch] = Color.FromName(karta[1]);
            t[ruch] = karta[0];
            antibug[ruch] = s;
            switch (s)
            {
                case 1:
                    label4_1.BorderStyle = BorderStyle.Fixed3D;
                    label4_1.BackColor = c[ruch];
                    label4_1.Text = t[ruch];
                    YF();
                    break;
                case 2:
                    label4_2.BorderStyle = BorderStyle.Fixed3D;
                    label4_2.BackColor = c[ruch];
                    label4_2.Text = t[ruch];
                    YF();
                    break;
                case 3:
                    label4_3.BorderStyle = BorderStyle.Fixed3D;
                    label4_3.BackColor = c[ruch];
                    label4_3.Text = t[ruch];
                    YF();
                    break;
                case 4:
                    label4_4.BorderStyle = BorderStyle.Fixed3D;
                    label4_4.BackColor = c[ruch];
                    label4_4.Text = t[ruch];
                    YF();
                    break;
                case 5:
                    label4_5.BorderStyle = BorderStyle.Fixed3D;
                    label4_5.BackColor = c[ruch];
                    label4_5.Text = t[ruch];
                    YF();
                    break;
                case 6:
                    label4_6.BorderStyle = BorderStyle.Fixed3D;
                    label4_6.BackColor = c[ruch];
                    label4_6.Text = t[ruch];
                    YF();
                    break;
                case 7:
                    label4_7.BorderStyle = BorderStyle.Fixed3D;
                    label4_7.BackColor = c[ruch];
                    label4_7.Text = t[ruch];
                    YF();
                    break;
                case 8:
                    label4_8.BorderStyle = BorderStyle.Fixed3D;
                    label4_8.BackColor = c[ruch];
                    label4_8.Text = t[ruch];
                    YF();
                    break;
                case 9:
                    label4_9.BorderStyle = BorderStyle.Fixed3D;
                    label4_9.BackColor = c[ruch];
                    label4_9.Text = t[ruch];
                    YF();
                    break;
                case 10:
                    label4_10.BorderStyle = BorderStyle.Fixed3D;
                    label4_10.BackColor = c[ruch];
                    label4_10.Text = t[ruch];
                    YF();
                    break;
                case 11:
                    label4_11.BorderStyle = BorderStyle.Fixed3D;
                    label4_11.BackColor = c[ruch];
                    label4_11.Text = t[ruch];
                    YF();
                    break;
                case 12:
                    label4_12.BorderStyle = BorderStyle.Fixed3D;
                    label4_12.BackColor = c[ruch];
                    label4_12.Text = t[ruch];
                    YF();
                    break;
                case 13:
                    label4_13.BorderStyle = BorderStyle.Fixed3D;
                    label4_13.BackColor = c[ruch];
                    label4_13.Text = t[ruch];
                    YF();
                    break;
                case 14:
                    label4_14.BorderStyle = BorderStyle.Fixed3D;
                    label4_14.BackColor = c[ruch];
                    label4_14.Text = t[ruch];
                    YF();
                    break;
                case 15:
                    label4_15.BorderStyle = BorderStyle.Fixed3D;
                    label4_15.BackColor = c[ruch];
                    label4_15.Text = t[ruch];
                    YF();
                    break;
                case 16:
                    label4_16.BorderStyle = BorderStyle.Fixed3D;
                    label4_16.BackColor = c[ruch];
                    label4_16.Text = t[ruch];
                    YF();
                    break;
            
            }
        }
      
        public static string[] karta = new string[2];
      
        public void Karta(int a) 
        {
            karta[0] = array44[a, 0];
            karta[1] = array44[a, 1];
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            if (ruch == 0)
            {
                button1.Location = new Point(199, 84);
                button2.Text = "Powrót";
                button2.Location = new Point(199, 114);
                button1.Width = 88;
/**/                label2.Visible = true;
/**/                label3.Visible = true;

            };
            for (int i = 1; i < 17; i++)
                {
                    Pudlo(i);
                    Wlacz(i);
                };
/**/        lruchow = 0;
/**/        label3.Text = "0";
            Text = "START!";
            sukces = 0;
            ruch = 0;
            Karty();
            label1.Text = "Trwa gra...";
            button1.Text = "Od nowa?";
            ruch = 1;
        }

        private void label4_1_Click(object sender, EventArgs e)
        {
            if (ruch>0)Ruch(1);
        }

        private void label4_2_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(2);
        }
        private void label4_3_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(3);
        }

        private void label4_4_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(4);
        }

        private void label4_5_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(5);
        }

        private void label4_6_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(6);
        }

        private void label4_7_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(7);
        }

        private void label4_8_Click(object sender, EventArgs e)
        {
            if (ruch > 0)
            Ruch(8);
        }
        private void label4_9_Click(object sender, EventArgs e)
        {
            if (ruch > 0)
            Ruch(9);
        }

        private void label4_10_Click(object sender, EventArgs e)
        {
            if (ruch > 0)
            Ruch(10);
        }

        private void label4_11_Click(object sender, EventArgs e)
        {
            if (ruch > 0)
            Ruch(11);
        }

        private void label4_12_Click(object sender, EventArgs e)
        {
            if (ruch > 0)
            Ruch(12);
        }

        private void label4_13_Click(object sender, EventArgs e)
        {
            if (ruch > 0)
            Ruch(13);
        }

        private void label4_14_Click(object sender, EventArgs e)
        {
            if (ruch > 0)
            Ruch(14);
        }

        private void label4_15_Click(object sender, EventArgs e)
        {
            if (ruch > 0)
            Ruch(15);
        }

        private void label4_16_Click(object sender, EventArgs e)
        {
            if (ruch > 0)
            Ruch(16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form0.Visible = true;
        }
    }
}
