using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEP_CALC
{
    public partial class calculator : Form
    {
        Double value = 0;
        string operation = "";
        bool operator_pressed;
        string result;
        public calculator()
        {
            InitializeComponent();
            button1.Text = Convert.ToString("\u0967");
            button2.Text = Convert.ToString("\u0968");
            button3.Text = Convert.ToString("\u0969");
            button4.Text = Convert.ToString("\u096A");
            button5.Text = Convert.ToString("\u096B");
            button6.Text = Convert.ToString("\u096C");
            button7.Text = Convert.ToString("\u096D");
            button8.Text = Convert.ToString("\u096E");
            button9.Text = Convert.ToString("\u096F");
            button10.Text = Convert.ToString("\u0966");
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void btn_click(object sender, EventArgs e)
        {
            if ((Output.Text == "0") || (operator_pressed))
                Output.Clear();
            operator_pressed = false;

            Button b = (Button)sender;
            Output.Text = Output.Text + b.Text;

        }

        private void allclear_Click(object sender, EventArgs e)
        {
            Output.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Output.Clear();
            value = 0;
        }

        private string conv_eng(string str)
        {
            string res = "";
            for (int i = 0; i < str.Length; i++)
            {
                string ip;
                switch (str[i])
                {
                    case '\u0967':
                        ip="1";
                        break;

                    case '\u0968':
                        ip="2";
                        break;

                    case '\u0969':
                        ip= "3";
                        break;

                    case '\u096A':
                        ip="4";
                        break;

                    case '\u096B':
                        ip="5";
                        break;
                    case '\u096C':
                        ip="6";
                        break;
                    case '\u096D':
                        ip="7";
                        break;
                    case '\u096E':
                        ip="8";
                        break;
                    case '\u096F':
                        ip="9";
                        break;
                    case '\u0966':
                        ip="0";
                        break;
                    case '.':
                        ip = ".";
                        break;
                    case '-':
                        ip = "-";
                        break;
                    default:
                        ip="0";
                        break;

                }
                res = res + ip;
            }
            return (res);
        }
        private string res_conv(string str)
        {
            string res = "";
            for(int i= 0; i < str.Length; i++)
            {
                string op;
                switch (str[i])
                {
                    case '1':
                        op ="\u0967";
                        break;

                    case '2':
                        op="\u0968";
                        break;

                    case '3':
                        op="\u0969";
                        break;

                    case '4':
                        op="\u096A";
                        break;

                    case '5':
                        op="\u096B";
                        break;

                    case '6':
                        op="\u096C";
                        break;
                    case '7':
                        op="\u096D";
                        break;
                    case '8':
                        op="\u096E";
                        break;
                    case '9':
                        op="\u096F";
                        break;
                    case '0':
                        op="\u0966";
                        break;
                    case '.':
                        op = ".";
                        break;
                    case '-':
                        op = "-";
                        break;
                    default:
                        op="\u0966";
                        break;
                }
                res = res + op;
                

            }
            return (res);


        }
        private void equalto_Click(object sender, EventArgs e)
        {
            string str = conv_eng(Output.Text);
            display.Text = "";
            switch (operation)
            {
                case "+":
                    result = (value + Double.Parse(str)).ToString();
                    break;
                case "-":
                    result = (value - Double.Parse(str)).ToString();
                    break;
                case "*":
                    result = (value * Double.Parse(str)).ToString();
                    break;
                case "/":
                    result = (value / Double.Parse(str)).ToString();
                    break;
                default:
                    break;
            }
            Output.Text= res_conv(result);

            operator_pressed = true;
        }

        private void operators_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            string str=conv_eng(Output.Text);
            value = Double.Parse(str);
            operator_pressed = true;
            display.Text = Output.Text + "" + operation;
        }
     
    }
}
