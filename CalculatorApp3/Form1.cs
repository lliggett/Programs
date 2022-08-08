using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp3
{
    public partial class Form1 : Form
    {


        double result;
        int operandNum = 0;
        bool operandEntered = false;
        double firstEntry;
        double secondEntry;
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botton_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

                if (operandEntered != true)
                {
                    txt_display.Text += button.Text;
                    lbl_operation.Text += button.Text;

                    if (button.Text == ".")
                        {
                            Convert.ToDecimal(firstEntry);
                        }
                    if (button.Text == "-")
                        {
                            firstEntry *= -1;
                        }
                    if (button.Text != "-" && button.Text != ".")
                        {
                            firstEntry = double.Parse(txt_display.Text);
                        }

                }

                if (operandEntered == true)
                {
                    txt_display.Text += button.Text;
                    lbl_operation.Text += button.Text;

                    if (button.Text == ".")
                        {
                            Convert.ToDecimal(secondEntry);
                        }
                    if (button.Text == "-")
                        {
                            secondEntry *= -1;
                        }
                    if (button.Text != "-" && button.Text != ".")
                        {
                            secondEntry = double.Parse(txt_display.Text);
                        }
                }


        }

        private void operand_click(object sender, EventArgs e)
        {
            Button operand = (Button)sender;
            operandEntered = true;
            txt_display.Clear();

            if (operand.Text == "+")
            {
                operandNum = 1;
            }
            if (operand.Text == "-")
            {
                operandNum = 2;
            }
            if (operand.Text == "*")
            {
                operandNum = 3;
            }
            if (operand.Text == "/")
            {
                operandNum = 4;
            }

            lbl_operation.Text += operand.Text;

        }

        private void enter_click(object sender, EventArgs e)
        {
            txt_display.Clear();


            pnl_numbers.Enabled = false;
            pnl_operands.Enabled = false;
            pnl_enter.Enabled = false;



                switch (operandNum)
                {
                    case 1:
                        result = firstEntry + secondEntry;
                        break;
                    case 2:
                        result = firstEntry - secondEntry;
                        break;
                    case 3:
                        result = firstEntry * secondEntry;
                        break;
                    case 4:
                        result = firstEntry / secondEntry;
                        break;
                }
            

            txt_display.Text += result;

            firstEntry = 0;
            secondEntry = 0;
            operandNum = 0;
            
        }

        private void clear_click(object sender, EventArgs e)
        {
            txt_display.Clear();
            lbl_operation.Text = "";

            firstEntry = 0;
            secondEntry = 0;
            operandNum = 0;

            txt_display.Text += "";
            operandEntered = false;


            pnl_numbers.Enabled = true;
            pnl_operands.Enabled = true;
            pnl_enter.Enabled = true;

        }

        private void txt_display_TextChanged(object sender, EventArgs e)
        {

        }





        private void pnl_numbers_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void all_buttons(object sender, EventArgs e)
        {

        }
    }
}
