using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        float value = 0, value2 = 0;
        string previousoper = "+";
        bool re = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text.Length < 8)
            {
                if(lblDisplay.Text == "0")
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + ((Button)sender).Text;
                }
            }
        }
        double first, second, result;

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            previousoper = "+";
            value = 0;
            value2 = 0;
            re = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text != "")
            {
                lblDisplay.Text = lblDisplay.Text.Substring(0, lblDisplay.Text.Length - 1);
            }
            if (lblDisplay.Text == "")
            {
                lblDisplay.Text = "0";
            }
        }

        private void PlMinus(object sender, EventArgs e)
        {
            value = float.Parse(lblDisplay.Text);
            value *= -1;
            lblDisplay.Text = value.ToString();
        }
        int foo;
        private void Percent_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text == " ")
            {
                result = first * first / 100;
                lblDisplay.Text = Convert.ToString(result);
            }
            else
            {
                second = Convert.ToDouble(lblDisplay.Text);
                result = first * second / 100;
                lblDisplay.Text = Convert.ToString(result);
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + ".";
        }

        string collect;
        private void btnOperator_Click(object sender, EventArgs e)
        {
            collect = ((Button)sender).Text;
            first = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = " ";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            second = Convert.ToDouble(lblDisplay.Text);
            if (collect == "+")
            {
                result = first + second;
                lblDisplay.Text = Convert.ToString(result);
            }
            else if (collect == "-")
            {
                result = first - second;
                lblDisplay.Text = Convert.ToString(result);
            }
            else if (collect == "X")
            {
                result = first * second;
                lblDisplay.Text = Convert.ToString(result);
            }
            else if (collect == "÷")
            {
                result = first / second;
                lblDisplay.Text = Convert.ToString(result);
            }

            else if(btn0.Text == "=")
            {
                if(!re)
                {
                    lblDisplay.Text = value.ToString();
                    if(lblDisplay.Text.Length > 9)
                    {
                        lblDisplay.Text = "Error";
                    }
                }
            }
            else
            {
                lblDisplay.Text = value.ToString();
                previousoper = btn0.Text;
            }
            re = true;
            string res;
            res = Convert.ToString(result);
            if(res.Length > 8 && result > 99999999)
            {
                lblDisplay.Text = "Error";
            }
            else
            {
                result = Math.Round(result, 6);
                lblDisplay.Text = Convert.ToString(result);
            }
        }
    }
}
