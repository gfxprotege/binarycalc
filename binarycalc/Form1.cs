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
        //global var's
        long temp, sum;
        bool state;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            txt.Text += "1";
        }

        private void clr_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            sum = 0;
            temp = 0;
            
        }

        private void plus_Click(object sender, EventArgs e)
        {
            String s = txt.Text;
            temp = Convert.ToInt64(s, 2);
            sum += temp;
            txt.Text = "";
            state = true;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            txt.Text += "0";
        }

        

        private void equals_Click(object sender, EventArgs e)
        {
            String s = txt.Text;
            temp = Convert.ToInt64(s, 2);
            if (state)
            {
                sum += temp;
            }
            else sum *= temp;


            txt.Text = toBin(sum);
        }
        private String toBin(long x) {

            
            Int64 BinaryHolder;
            char[] BinaryArray;
            String BinaryResult = "";

            while (x > 0) {
                BinaryHolder = x % 2;
                BinaryResult += BinaryHolder;
                x = x / 2;
            
            }
            BinaryArray = BinaryResult.ToCharArray();
            Array.Reverse(BinaryArray);
            BinaryResult = new string(BinaryArray);
            return BinaryResult;
            

        }

        private void mult_Click(object sender, EventArgs e)
        {
            String s = txt.Text;
            temp = Convert.ToInt64(s, 2);
            sum *= temp;
            txt.Text = "";
            state = false;

        }        
    }
}
