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
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        public class Atrybuty
        {
            public static string[] numbers = new string[] { "1", "2", "3", "4", "5", "6" };
            public static string[] colors = new string[] { "SteelBlue", "Goldenrod", "Red" };
            public static string[,] array = new string[36, 2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Gra66;
            Gra66 = new Form1(this);
            Gra66.Show();
            Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form11 Gra44;
            Gra44 = new Form11(this);
            Gra44.Show();
            Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        } 
         
    }
}
