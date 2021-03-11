using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

      

        bool a = false;
        double x1;
        int xs1;
        int vz = 0;


        private void button1_Click(object sender, EventArgs e)
        {

            if (inputvalue.Text != "0")
            {
                inputvalue.Text = inputvalue.Text + button1.Text;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (inputvalue.Text != "0")
            {
                inputvalue.Text = inputvalue.Text + button2.Text;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (inputvalue.Text != "0")
            {
                inputvalue.Text = inputvalue.Text + button3.Text;
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (inputvalue.Text != "0")
            {
                inputvalue.Text = inputvalue.Text + button5.Text;
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (inputvalue.Text != "0")
            {
                inputvalue.Text = inputvalue.Text + button6.Text;
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (inputvalue.Text != "0")
            {
                inputvalue.Text = inputvalue.Text + button7.Text;
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (inputvalue.Text != "0")
            {
                inputvalue.Text = inputvalue.Text + button9.Text;
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            if (inputvalue.Text != "0")
            {
                inputvalue.Text = inputvalue.Text + button10.Text;
            }
        }


        private void button11_Click(object sender, EventArgs e)
        {
            if (inputvalue.Text != "0")
            {
                inputvalue.Text = inputvalue.Text + button11.Text;
            }
        }


        private void button14_Click(object sender, EventArgs e)
        {
            if (inputvalue.Text != "0")
            {
                inputvalue.Text = inputvalue.Text + button14.Text;
            }
        }






        // calculate function

        public void calculate()
        {
            string cv;
            if (vz == 0) { inputvalue.Text = ""; }
            if (vz != 0)
            {
                if (inputvalue.Text.Length < 1) { inputvalue.Text = ""; }
                cv = inputvalue.Text.Remove(0, xs1 + 1);
                double d = Convert.ToDouble(cv);
                if (vz == 1)
                {
                    x1 = x1 - d;
                }
                else if (vz == 2)
                {
                    x1 = x1 + d;
                }
                else if (vz == 3)
                {
                    x1 = x1 / d;
                }
                else if (vz == 4)
                {
                    x1 = x1 * d;
                }
                vz = 0;


                inputvalue.Text = x1.ToString();
            }
        }




        private void button15_Click(object sender, EventArgs e)
        {
            calculate();
        }




     
        //check function
        public void check() {
            if (inputvalue.Text.Length > 0 && vz == 0)
            {
                xs1 = inputvalue.Text.Length;
                x1 = Convert.ToDouble(inputvalue.Text);
                a = true;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            check();
            if (a == true)
            {
                inputvalue.Text = inputvalue.Text + button4.Text;
                vz = 1;
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            check();
            if (a == true)
            {
                inputvalue.Text = inputvalue.Text + button8.Text;  
                vz = 2;
            }
          
        }



        private void button12_Click(object sender, EventArgs e)
        {
            check();
            if (a == true)
            {
                inputvalue.Text = inputvalue.Text + button12.Text;  
                vz = 3;
            }
          
        }

        private void button16_Click(object sender, EventArgs e)
        {
            check();
            if (a == true)
            {
                inputvalue.Text = inputvalue.Text + button16.Text;
                vz = 4;
            }
            
           
        }


        private void button18_Click(object sender, EventArgs e)
        {
            inputvalue.Text = "";
            vz = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int m;
            m = inputvalue.Text.Length;
            if (inputvalue.Text.Length > 0)
            {
                inputvalue.Text = inputvalue.Text.Remove(m - 1, 1);
                vz = 0;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            inputvalue.Text = inputvalue.Text + button13.Text;
        }

        private void inputvalue_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 45)
            {
                check();
                if (a == true)
                {
                    vz = 1;
                }
            }

            else if (e.KeyChar == 43)
            {
                check();
                if (a == true)
                {
                    vz = 2;
                }
                vz = 2;
            }

            else if (e.KeyChar == 47)
            {
                check();
                if (a == true)
                {
                    vz = 3;
                }
            }

            else if (e.KeyChar == 120)
            {
                check();
                if (a == true)
                {
                    vz = 4;
                }
            }

            else if (e.KeyChar == 13)
            {
                calculate();
            }
        }
    }
}
