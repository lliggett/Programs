using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool teamX = false;
        bool teamO = false;
        string winner = "";
        bool botsTurn;


        public Form1()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button_click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            List<Button> buttons = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8, button9 };

            if (winner == "")
            {
                if (teamX == true)
                {

                    if (botsTurn == false)
                    {
                        button.Text += "x";
                        buttons.RemoveAt(buttons.IndexOf(button));
                        button.Enabled = false;
                    }
                    if (button == (Button)sender)
                    {
                        botsTurn = true;
                    }
                    while (botsTurn == true)
                    {
                        //stops loop if all bottons are used    
                        if (buttons.All(x => !x.Enabled)) botsTurn = false;
                        //bot determines its next move
                        Random random = new Random();
                        int botMove = random.Next(0, buttons.Count);
                        Button botMoveBut = buttons.ElementAt(botMove);
                        if (botMoveBut.Text == "")
                        {
                            buttons.ElementAt(botMove).Text += "o";
                            buttons.ElementAt(botMove).Enabled = false;
                            buttons.Remove(botMoveBut);
                            botsTurn = false;
                        }
                    }

                }
                if (teamO == true)
                {
                    
                    if (botsTurn == false)
                    {
                        button.Text += "o";
                        buttons.RemoveAt(buttons.IndexOf(button));
                        button.Enabled = false;

                    }
                    if (button == (Button)sender) botsTurn = true;

                    while (botsTurn == true)
                    {
                        if (buttons.All(x => !x.Enabled)) botsTurn = false;
                        Random random = new Random();
                        int botMove = random.Next(0, buttons.Count);
                        Button botMoveBut = buttons.ElementAt(botMove);
                        if (botMoveBut.Text == "")
                        {
                            buttons.ElementAt(botMove).Text += "x";
                            buttons.ElementAt(botMove).Enabled = false;
                            botsTurn = false;
                        }
                    }
                }
            }
            //determine if x is winner
            List<Button> lColumn = new List<Button> { button1, button4, button7 };
            List<Button> mColumn = new List<Button> { button2, button5, button8 };
            List<Button> rColumn = new List<Button> { button3, button6, button9 };
            List<Button> topRow = new List<Button> { button1, button2, button3 };
            List<Button> midRow = new List<Button> { button4, button5, button6 };
            List<Button> bottomRow = new List<Button> { button7, button8, button9 };
            List<Button> leftDiag = new List<Button> { button1, button5, button9 };
            List<Button> rightDiag = new List<Button> { button3, button5, button7 };

            if (lColumn.All(x => x.Text == "x") || mColumn.All(x => x.Text == "x") || rColumn.All(x => x.Text == "x") || topRow.All(x => x.Text == "x") || midRow.All(x => x.Text == "x")
                || bottomRow.All(x => x.Text == "x") || leftDiag.All(x => x.Text == "x") || rightDiag.All(x => x.Text == "x"))
            {
                winner = "X is the winner";
                lbl_winner.Text = winner;
                panel1.Enabled = false;

            }

            //determine if o is winner
            if (lColumn.All(x => x.Text == "o") || mColumn.All(x => x.Text == "o") || rColumn.All(x => x.Text == "o") || topRow.All(x => x.Text == "o") || midRow.All(x => x.Text == "o")
                || bottomRow.All(x => x.Text == "o") || leftDiag.All(x => x.Text == "o") || rightDiag.All(x => x.Text == "o"))
            {
                winner = "O is the winner";
                lbl_winner.Text = winner;
                panel1.Enabled = false;

            }

        }
            

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void xo_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button == btn_x)
            {
                teamX = true;
                panel1.Enabled = true;
                panel2.Enabled = false;
            }
            if (button == btn_o)
            {
                teamO = true;
                panel1.Enabled = true;
                panel2.Enabled = false;
                botsTurn = true;
            }
        }

        private void l_column(object sender, EventArgs e)
        {

        }
    }
}
