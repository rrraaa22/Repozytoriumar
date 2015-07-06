using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Form0 Form0;

        public Form1(Form0 zestaw)
        {
            InitializeComponent();
            Form0 = zestaw;
        }

        string[,] array66 = Form0.Atrybuty.array;
        string[] numbers66 = Form0.Atrybuty.numbers;
        string[] colors66 = Form0.Atrybuty.colors;


        public void Karty()
        {

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    array66[i + j * 2 * 6, 0] = numbers66[i];
                    array66[i + (j * 2 + 1) * 6, 0] = numbers66[i];
                    array66[i + j * 2 * 6, 1] = colors66[j];
                    array66[i + (j * 2 + 1) * 6, 1] = colors66[j];
                };
            };
               Random rand = new Random();
               for (int i = 0; i < 36; i++)
               {
                   string str0 = array66[i, 0];
                   string str1 = array66[i, 1];
                   int r = rand.Next(i, 35);
                   array66[i, 0] = array66[r, 0];
                   array66[i, 1] = array66[r, 1];
                   array66[r, 0] = str0;
                   array66[r, 1] = str1;
               };
        }


        public int ruch = 0;
        public Color[] c = { Color.Transparent, Color.Silver, Color.Green };
        public String[] t = { "a", "b", "c" };
        public int[] a = { 0, 0, 0 };
        public int sukces;
        public int[] antibug = { 0, 0, 0 };
/**/    public int lruchow = 0;


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
                    if (sukces == 18) Sukces();
                }
                else if (antibug[1] == antibug[2])
                {
                    Pudlo(a[1]);
                    ruch = 1;
                }
                else
                {
                    ruch = 3;
/**/                lruchow++;
/**/                label3.Text = lruchow.ToString();
                }
            }
        }

        public void Trafienie(int s)
        {
            switch (s)
            {
                case 1:
                    label6_1.Enabled = false;
                    break;
                case 2:
                    label6_2.Enabled = false;
                    break;
                case 3:
                    label6_3.Enabled = false;
                    break;
                case 4:
                    label6_4.Enabled = false;
                    break;
                case 5:
                    label6_5.Enabled = false;
                    break;
                case 6:
                    label6_6.Enabled = false;
                    break;
                case 7:
                    label6_7.Enabled = false;
                    break;
                case 8:
                    label6_8.Enabled = false;
                    break;
                case 9:
                    label6_9.Enabled = false;
                    break;
                case 10:
                    label6_10.Enabled = false;
                    break;
                case 11:
                    label6_11.Enabled = false;
                    break;
                case 12:
                    label6_12.Enabled = false;
                    break;
                case 13:
                    label6_13.Enabled = false;
                    break;
                case 14:
                    label6_14.Enabled = false;
                    break;
                case 15:
                    label6_15.Enabled = false;
                    break;
                case 16:
                    label6_16.Enabled = false;
                    break;
                case 17:
                    label6_17.Enabled = false;
                    break;
                case 18:
                    label6_18.Enabled = false;
                    break;
                case 19:
                    label6_19.Enabled = false;
                    break;
                case 20:
                    label6_20.Enabled = false;
                    break;
                case 21:
                    label6_21.Enabled = false;
                    break;
                case 22:
                    label6_22.Enabled = false;
                    break;
                case 23:
                    label6_23.Enabled = false;
                    break;
                case 24:
                    label6_24.Enabled = false;
                    break;
                case 25:
                    label6_25.Enabled = false;
                    break;
                case 26:
                    label6_26.Enabled = false;
                    break;
                case 27:
                    label6_27.Enabled = false;
                    break;
                case 28:
                    label6_28.Enabled = false;
                    break;
                case 29:
                    label6_29.Enabled = false;
                    break;
                case 30:
                    label6_30.Enabled = false;
                    break;
                case 31:
                    label6_31.Enabled = false;
                    break;
                case 32:
                    label6_32.Enabled = false;
                    break;
                case 33:
                    label6_33.Enabled = false;
                    break;
                case 34:
                    label6_34.Enabled = false;
                    break;
                case 35:
                    label6_35.Enabled = false;
                    break;
                case 36:
                    label6_36.Enabled = false;
                    break;
            }
        }

        public void Pudlo(int s)
        {
            switch (s)
            {
                case 1:
                    label6_1.BorderStyle = BorderStyle.FixedSingle;
                    label6_1.BackColor = Color.LavenderBlush;
                    label6_1.Text = "";
                    break;
                case 2:
                    label6_2.BorderStyle = BorderStyle.FixedSingle;
                    label6_2.BackColor = Color.LavenderBlush;
                    label6_2.Text = "";
                    break;
                case 3:
                    label6_3.BorderStyle = BorderStyle.FixedSingle;
                    label6_3.BackColor = Color.LavenderBlush;
                    label6_3.Text = "";
                    break;
                case 4:
                    label6_4.BorderStyle = BorderStyle.FixedSingle;
                    label6_4.BackColor = Color.LavenderBlush;
                    label6_4.Text = "";
                    break;
                case 5:
                    label6_5.BorderStyle = BorderStyle.FixedSingle;
                    label6_5.BackColor = Color.LavenderBlush;
                    label6_5.Text = "";
                    break;
                case 6:
                    label6_6.BorderStyle = BorderStyle.FixedSingle;
                    label6_6.BackColor = Color.LavenderBlush;
                    label6_6.Text = "";
                    break;
                case 7:
                    label6_7.BorderStyle = BorderStyle.FixedSingle;
                    label6_7.BackColor = Color.LavenderBlush;
                    label6_7.Text = "";
                    break;
                case 8:
                    label6_8.BorderStyle = BorderStyle.FixedSingle;
                    label6_8.BackColor = Color.LavenderBlush;
                    label6_8.Text = "";
                    break;
                case 9:
                    label6_9.BorderStyle = BorderStyle.FixedSingle;
                    label6_9.BackColor = Color.LavenderBlush;
                    label6_9.Text = "";
                    break;
                case 10:
                    label6_10.BorderStyle = BorderStyle.FixedSingle;
                    label6_10.BackColor = Color.LavenderBlush;
                    label6_10.Text = "";
                    break;
                case 11:
                    label6_11.BorderStyle = BorderStyle.FixedSingle;
                    label6_11.BackColor = Color.LavenderBlush;
                    label6_11.Text = "";
                    break;
                case 12:
                    label6_12.BorderStyle = BorderStyle.FixedSingle;
                    label6_12.BackColor = Color.LavenderBlush;
                    label6_12.Text = "";
                    break;
                case 13:
                    label6_13.BorderStyle = BorderStyle.FixedSingle;
                    label6_13.BackColor = Color.LavenderBlush;
                    label6_13.Text = "";
                    break;
                case 14:
                    label6_14.BorderStyle = BorderStyle.FixedSingle;
                    label6_14.BackColor = Color.LavenderBlush;
                    label6_14.Text = "";
                    break;
                case 15:
                    label6_15.BorderStyle = BorderStyle.FixedSingle;
                    label6_15.BackColor = Color.LavenderBlush;
                    label6_15.Text = "";
                    break;
                case 16:
                    label6_16.BorderStyle = BorderStyle.FixedSingle;
                    label6_16.BackColor = Color.LavenderBlush;
                    label6_16.Text = "";
                    break;
                case 17:
                    label6_17.BorderStyle = BorderStyle.FixedSingle;
                    label6_17.BackColor = Color.LavenderBlush;
                    label6_17.Text = "";
                    break;
                case 18:
                    label6_18.BorderStyle = BorderStyle.FixedSingle;
                    label6_18.BackColor = Color.LavenderBlush;
                    label6_18.Text = "";
                    break;
                case 19:
                    label6_19.BorderStyle = BorderStyle.FixedSingle;
                    label6_19.BackColor = Color.LavenderBlush;
                    label6_19.Text = "";
                    break;
                case 20:
                    label6_20.BorderStyle = BorderStyle.FixedSingle;
                    label6_20.BackColor = Color.LavenderBlush;
                    label6_20.Text = "";
                    break;
                case 21:
                    label6_21.BorderStyle = BorderStyle.FixedSingle;
                    label6_21.BackColor = Color.LavenderBlush;
                    label6_21.Text = "";
                    break;
                case 22:
                    label6_22.BorderStyle = BorderStyle.FixedSingle;
                    label6_22.BackColor = Color.LavenderBlush;
                    label6_22.Text = "";
                    break;
                case 23:
                    label6_23.BorderStyle = BorderStyle.FixedSingle;
                    label6_23.BackColor = Color.LavenderBlush;
                    label6_23.Text = "";
                    break;
                case 24:
                    label6_24.BorderStyle = BorderStyle.FixedSingle;
                    label6_24.BackColor = Color.LavenderBlush;
                    label6_24.Text = "";
                    break;
                case 25:
                    label6_25.BorderStyle = BorderStyle.FixedSingle;
                    label6_25.BackColor = Color.LavenderBlush;
                    label6_25.Text = "";
                    break;
                case 26:
                    label6_26.BorderStyle = BorderStyle.FixedSingle;
                    label6_26.BackColor = Color.LavenderBlush;
                    label6_26.Text = "";
                    break;
                case 27:
                    label6_27.BorderStyle = BorderStyle.FixedSingle;
                    label6_27.BackColor = Color.LavenderBlush;
                    label6_27.Text = "";
                    break;
                case 28:
                    label6_28.BorderStyle = BorderStyle.FixedSingle;
                    label6_28.BackColor = Color.LavenderBlush;
                    label6_28.Text = "";
                    break;
                case 29:
                    label6_29.BorderStyle = BorderStyle.FixedSingle;
                    label6_29.BackColor = Color.LavenderBlush;
                    label6_29.Text = "";
                    break;
                case 30:
                    label6_30.BorderStyle = BorderStyle.FixedSingle;
                    label6_30.BackColor = Color.LavenderBlush;
                    label6_30.Text = "";
                    break;
                case 31:
                    label6_31.BorderStyle = BorderStyle.FixedSingle;
                    label6_31.BackColor = Color.LavenderBlush;
                    label6_31.Text = "";
                    break;
                case 32:
                    label6_32.BorderStyle = BorderStyle.FixedSingle;
                    label6_32.BackColor = Color.LavenderBlush;
                    label6_32.Text = "";
                    break;
                case 33:
                    label6_33.BorderStyle = BorderStyle.FixedSingle;
                    label6_33.BackColor = Color.LavenderBlush;
                    label6_33.Text = "";
                    break;
                case 34:
                    label6_34.BorderStyle = BorderStyle.FixedSingle;
                    label6_34.BackColor = Color.LavenderBlush;
                    label6_34.Text = "";
                    break;
                case 35:
                    label6_35.BorderStyle = BorderStyle.FixedSingle;
                    label6_35.BackColor = Color.LavenderBlush;
                    label6_35.Text = "";
                    break;
                case 36:
                    label6_36.BorderStyle = BorderStyle.FixedSingle;
                    label6_36.BackColor = Color.LavenderBlush;
                    label6_36.Text = "";
                    break;
            }
        }

        public void Wlacz(int s)
        {
            switch (s)
            {
                case 1:
                    label6_1.Visible = true;
                    label6_1.Enabled = true;
                    break;
                case 2:
                    label6_2.Visible = true;
                    label6_2.Enabled = true;
                    break;
                case 3:
                    label6_3.Visible = true;
                    label6_3.Enabled = true;
                    break;
                case 4:
                    label6_4.Visible = true;
                    label6_4.Enabled = true;
                    break;
                case 5:
                    label6_5.Visible = true;
                    label6_5.Enabled = true;
                    break;
                case 6:
                    label6_6.Visible = true;
                    label6_6.Enabled = true;
                    break;
                case 7:
                    label6_7.Visible = true;
                    label6_7.Enabled = true;
                    break;
                case 8:
                    label6_8.Visible = true;
                    label6_8.Enabled = true;
                    break;
                case 9:
                    label6_9.Visible = true;
                    label6_9.Enabled = true;
                    break;
                case 10:
                    label6_10.Visible = true;
                    label6_10.Enabled = true;
                    break;
                case 11:
                    label6_11.Visible = true;
                    label6_11.Enabled = true;
                    break;
                case 12:
                    label6_12.Visible = true;
                    label6_12.Enabled = true;
                    break;
                case 13:
                    label6_13.Visible = true;
                    label6_13.Enabled = true;
                    break;
                case 14:
                    label6_14.Visible = true;
                    label6_14.Enabled = true;
                    break;
                case 15:
                    label6_15.Visible = true;
                    label6_15.Enabled = true;
                    break;
                case 16:
                    label6_16.Visible = true;
                    label6_16.Enabled = true;
                    break;
                case 17:
                    label6_17.Visible = true;
                    label6_17.Enabled = true;
                    break;
                case 18:
                    label6_18.Visible = true;
                    label6_18.Enabled = true;
                    break;
                case 19:
                    label6_19.Visible = true;
                    label6_19.Enabled = true;
                    break;
                case 20:
                    label6_20.Visible = true;
                    label6_20.Enabled = true;
                    break;
                case 21:
                    label6_21.Visible = true;
                    label6_21.Enabled = true;
                    break;
                case 22:
                    label6_22.Visible = true;
                    label6_22.Enabled = true;
                    break;
                case 23:
                    label6_23.Visible = true;
                    label6_23.Enabled = true;
                    break;
                case 24:
                    label6_24.Visible = true;
                    label6_24.Enabled = true;
                    break;
                case 25:
                    label6_25.Visible = true;
                    label6_25.Enabled = true;
                    break;
                case 26:
                    label6_26.Visible = true;
                    label6_26.Enabled = true;
                    break;
                case 27:
                    label6_27.Visible = true;
                    label6_27.Enabled = true;
                    break;
                case 28:
                    label6_28.Visible = true;
                    label6_28.Enabled = true;
                    break;
                case 29:
                    label6_29.Visible = true;
                    label6_29.Enabled = true;
                    break;
                case 30:
                    label6_30.Visible = true;
                    label6_30.Enabled = true;
                    break;
                case 31:
                    label6_31.Visible = true;
                    label6_31.Enabled = true;
                    break;
                case 32:
                    label6_32.Visible = true;
                    label6_32.Enabled = true;
                    break;
                case 33:
                    label6_33.Visible = true;
                    label6_33.Enabled = true;
                    break;
                case 34:
                    label6_34.Visible = true;
                    label6_34.Enabled = true;
                    break;
                case 35:
                    label6_35.Visible = true;
                    label6_35.Enabled = true;
                    break;
                case 36:
                    label6_36.Visible = true;
                    label6_36.Enabled = true;
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
                    label6_1.BorderStyle = BorderStyle.Fixed3D;
                    label6_1.BackColor = c[ruch];
                    label6_1.Text = t[ruch];
                    YF();
                    break;
                case 2:
                    label6_2.BorderStyle = BorderStyle.Fixed3D;
                    label6_2.BackColor = c[ruch];
                    label6_2.Text = t[ruch];
                    YF();
                    break;
                case 3:
                    label6_3.BorderStyle = BorderStyle.Fixed3D;
                    label6_3.BackColor = c[ruch];
                    label6_3.Text = t[ruch];
                    YF();
                    break;
                case 4:
                    label6_4.BorderStyle = BorderStyle.Fixed3D;
                    label6_4.BackColor = c[ruch];
                    label6_4.Text = t[ruch];
                    YF();
                    break;
                case 5:
                    label6_5.BorderStyle = BorderStyle.Fixed3D;
                    label6_5.BackColor = c[ruch];
                    label6_5.Text = t[ruch];
                    YF();
                    break;
                case 6:
                    label6_6.BorderStyle = BorderStyle.Fixed3D;
                    label6_6.BackColor = c[ruch];
                    label6_6.Text = t[ruch];
                    YF();
                    break;
                case 7:
                    label6_7.BorderStyle = BorderStyle.Fixed3D;
                    label6_7.BackColor = c[ruch];
                    label6_7.Text = t[ruch];
                    YF();
                    break;
                case 8:
                    label6_8.BorderStyle = BorderStyle.Fixed3D;
                    label6_8.BackColor = c[ruch];
                    label6_8.Text = t[ruch];
                    YF();
                    break;
                case 9:
                    label6_9.BorderStyle = BorderStyle.Fixed3D;
                    label6_9.BackColor = c[ruch];
                    label6_9.Text = t[ruch];
                    YF();
                    break;
                case 10:
                    label6_10.BorderStyle = BorderStyle.Fixed3D;
                    label6_10.BackColor = c[ruch];
                    label6_10.Text = t[ruch];
                    YF();
                    break;
                case 11:
                    label6_11.BorderStyle = BorderStyle.Fixed3D;
                    label6_11.BackColor = c[ruch];
                    label6_11.Text = t[ruch];
                    YF();
                    break;
                case 12:
                    label6_12.BorderStyle = BorderStyle.Fixed3D;
                    label6_12.BackColor = c[ruch];
                    label6_12.Text = t[ruch];
                    YF();
                    break;
                case 13:
                    label6_13.BorderStyle = BorderStyle.Fixed3D;
                    label6_13.BackColor = c[ruch];
                    label6_13.Text = t[ruch];
                    YF();
                    break;
                case 14:
                    label6_14.BorderStyle = BorderStyle.Fixed3D;
                    label6_14.BackColor = c[ruch];
                    label6_14.Text = t[ruch];
                    YF();
                    break;
                case 15:
                    label6_15.BorderStyle = BorderStyle.Fixed3D;
                    label6_15.BackColor = c[ruch];
                    label6_15.Text = t[ruch];
                    YF();
                    break;
                case 16:
                    label6_16.BorderStyle = BorderStyle.Fixed3D;
                    label6_16.BackColor = c[ruch];
                    label6_16.Text = t[ruch];
                    YF();
                    break;
                case 17:
                    label6_17.BorderStyle = BorderStyle.Fixed3D;
                    label6_17.BackColor = c[ruch];
                    label6_17.Text = t[ruch];
                    YF();
                    break;
                case 18:
                    label6_18.BorderStyle = BorderStyle.Fixed3D;
                    label6_18.BackColor = c[ruch];
                    label6_18.Text = t[ruch];
                    YF();
                    break;
                case 19:
                    label6_19.BorderStyle = BorderStyle.Fixed3D;
                    label6_19.BackColor = c[ruch];
                    label6_19.Text = t[ruch];
                    YF();
                    break;
                case 20:
                    label6_20.BorderStyle = BorderStyle.Fixed3D;
                    label6_20.BackColor = c[ruch];
                    label6_20.Text = t[ruch];
                    YF();
                    break;
                case 21:
                    label6_21.BorderStyle = BorderStyle.Fixed3D;
                    label6_21.BackColor = c[ruch];
                    label6_21.Text = t[ruch];
                    YF();
                    break;
                case 22:
                    label6_22.BorderStyle = BorderStyle.Fixed3D;
                    label6_22.BackColor = c[ruch];
                    label6_22.Text = t[ruch];
                    YF();
                    break;
                case 23:
                    label6_23.BorderStyle = BorderStyle.Fixed3D;
                    label6_23.BackColor = c[ruch];
                    label6_23.Text = t[ruch];
                    YF();
                    break;
                case 24:
                    label6_24.BorderStyle = BorderStyle.Fixed3D;
                    label6_24.BackColor = c[ruch];
                    label6_24.Text = t[ruch];
                    YF();
                    break;
                case 25:
                    label6_25.BorderStyle = BorderStyle.Fixed3D;
                    label6_25.BackColor = c[ruch];
                    label6_25.Text = t[ruch];
                    YF();
                    break;
                case 26:
                    label6_26.BorderStyle = BorderStyle.Fixed3D;
                    label6_26.BackColor = c[ruch];
                    label6_26.Text = t[ruch];
                    YF();
                    break;
                case 27:
                    label6_27.BorderStyle = BorderStyle.Fixed3D;
                    label6_27.BackColor = c[ruch];
                    label6_27.Text = t[ruch];
                    YF();
                    break;
                case 28:
                    label6_28.BorderStyle = BorderStyle.Fixed3D;
                    label6_28.BackColor = c[ruch];
                    label6_28.Text = t[ruch];
                    YF();
                    break;
                case 29:
                    label6_29.BorderStyle = BorderStyle.Fixed3D;
                    label6_29.BackColor = c[ruch];
                    label6_29.Text = t[ruch];
                    YF();
                    break;
                case 30:
                    label6_30.BorderStyle = BorderStyle.Fixed3D;
                    label6_30.BackColor = c[ruch];
                    label6_30.Text = t[ruch];
                    YF();
                    break;
                case 31:
                    label6_31.BorderStyle = BorderStyle.Fixed3D;
                    label6_31.BackColor = c[ruch];
                    label6_31.Text = t[ruch];
                    YF();
                    break;
                case 32:
                    label6_32.BorderStyle = BorderStyle.Fixed3D;
                    label6_32.BackColor = c[ruch];
                    label6_32.Text = t[ruch];
                    YF();
                    break;
                case 33:
                    label6_33.BorderStyle = BorderStyle.Fixed3D;
                    label6_33.BackColor = c[ruch];
                    label6_33.Text = t[ruch];
                    YF();
                    break;
                case 34:
                    label6_34.BorderStyle = BorderStyle.Fixed3D;
                    label6_34.BackColor = c[ruch];
                    label6_34.Text = t[ruch];
                    YF();
                    break;
                case 35:
                    label6_35.BorderStyle = BorderStyle.Fixed3D;
                    label6_35.BackColor = c[ruch];
                    label6_35.Text = t[ruch];
                    YF();
                    break;
                case 36:
                    label6_36.BorderStyle = BorderStyle.Fixed3D;
                    label6_36.BackColor = c[ruch];
                    label6_36.Text = t[ruch];
                    YF();
                    break;
            }
        }

        public static string[] karta = new string[2];

        public void Karta(int a)
        {
            karta[0] = array66[a, 0];
            karta[1] = array66[a, 1];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ruch == 0)
            {
                button1.Location = new Point(290, 129);
                button2.Text = "Powrót";
                button2.Location = new Point(290, 160);
                button1.Width = 80;
/**/            label2.Visible = true;
/**/            label3.Visible = true;
/**/            label3.Text = "0";
            }
            for (int i = 1; i < 37; i++)
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
            label1.Text = "Trwa gra . . .";
            button1.Text = "Od nowa?";
            ruch = 1;
        }

        private void label6_1_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(1);       
        }

        private void label6_2_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(2);       
        }

        private void label6_3_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(3);
        }

        private void label6_4_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(4);
        }

        private void label6_5_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(5);
        }

        private void label6_6_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(6);
        
        }

        private void label6_7_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(7);
        }

        private void label6_8_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(8);
        }

        private void label6_9_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(9);
        }

        private void label6_10_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(10);
        }

        private void label6_11_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(11);        
        }

        private void label6_12_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(12);
        }

        private void label6_13_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(13);
        }

        private void label6_14_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(14);
        }

        private void label6_15_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(15);
        }

        private void label6_16_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(16);
        }

        private void label6_17_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(17);
        }

        private void label6_18_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(18);
        }

        private void label6_19_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(19);
        }

        private void label6_20_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(20);
        }

        private void label6_21_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(21);
        }

        private void label6_22_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(22);
        }

        private void label6_23_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(23);
        }

        private void label6_24_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(24);
        }

        private void label6_25_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(25);
        }

        private void label6_26_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(26);
        }

        private void label6_27_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(27);
        }

        private void label6_28_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(28);
        }

        private void label6_29_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(29);
        }

        private void label6_30_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(30);
        }

        private void label6_31_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(31);
        }

        private void label6_32_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(32);
        }

        private void label6_33_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(33);
        }

        private void label6_34_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(34);
        }

        private void label6_35_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(35);
        }

        private void label6_36_Click(object sender, EventArgs e)
        {
            if (ruch > 0) Ruch(36);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form0.Visible = true;
        }    
    }
}
