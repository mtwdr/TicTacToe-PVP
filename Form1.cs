using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{

    public partial class Form1 : Form
    {
        Boolean flag = false; //false = X, true = O

        int[] row0 = new int[] {-1, -1, -1}; //-1 is empty value for arrays aka when new game started
        int[] row1 = new int[] { -1, -1, -1 };
        int[] row2 = new int[] { -1, -1, -1 };

        int counter0_0 = 0; //counts how many times a button was clicked
        int counter0_1 = 0;
        int counter0_2 = 0;

        int counter1_0 = 0;
        int counter1_1 = 0;
        int counter1_2 = 0;

        int counter2_0 = 0;
        int counter2_1 = 0;
        int counter2_2 = 0;

        private Boolean checkXWin()
        {
            if (row0[0] == 0 && row0[1] == 0 && row0[2] == 0 || //horizontal wins 
                row1[0] == 0 && row1[1] == 0 && row1[2] == 0 ||
                row2[0] == 0 && row2[1] == 0 && row2[2] == 0 ||

                row0[0] == 0 && row1[0] == 0 && row2[0] == 0 || //vertical wins
                row0[1] == 0 && row1[1] == 0 && row2[1] == 0 ||
                row0[2] == 0 && row1[2] == 0 && row2[2] == 0 ||

                row0[0] == 0 && row1[1] == 0 && row2[2] == 0 || //diagonal wins
                row0[2] == 0 && row1[1] == 0 && row2[0] == 0)
                return true;

            return false;
        }

        private Boolean checkOWin()
        {
            if (row0[0] == 1 && row0[1] == 1 && row0[2] == 1 || //horizontal wins 
                row1[0] == 1 && row1[1] == 1 && row1[2] == 1 ||
                row2[0] == 1 && row2[1] == 1 && row2[2] == 1 ||

                row0[0] == 1 && row1[0] == 1 && row2[0] == 1 || //vertical wins
                row0[1] == 1 && row1[1] == 1 && row2[1] == 1 ||
                row0[2] == 1 && row1[2] == 1 && row2[2] == 1 ||

                row0[0] == 1 && row1[1] == 1 && row2[2] == 1 || //diagonal wins
                row0[2] == 1 && row1[1] == 1 && row2[0] == 1)
                return true;

            return false;
        }

        private Boolean checkDraw()
        {
            if (counter0_0 == 1 &&
                counter0_1 == 1 &&
                counter0_2 == 1 &&

                counter1_0 == 1 &&
                counter1_1 == 1 &&
                counter1_2 == 1 &&

                counter2_0 == 1 &&
                counter2_1 == 1 &&
                counter2_2 == 1)
                return true;

            return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void space0_0_Click(object sender, EventArgs e)
        {
            if (counter0_0 == 0)
            {
                if (flag == false)
                {
                    space0_0.Text = "X";
                    row0[0] = 0;
                }
                else if (flag == true)
                {
                    space0_0.Text = "O";
                    row0[0] = 1;
                }
                flag = !flag;

                if (checkXWin() == true)
                {
                    outcomeLabel.Text = "X wins";
                }

                if (checkOWin() == true)
                {
                    outcomeLabel.Text = "O wins";
                }

                if (checkDraw() == true)
                {
                    outcomeLabel.Text = "Draw";
                }
            }
            counter0_0++;
        }

        private void space0_1_Click(object sender, EventArgs e)
        {
            if (counter0_1 == 0)
            {
                if (flag == false)
                {
                    space0_1.Text = "X";
                    row0[1] = 0;
                }
                else if (flag == true)
                {
                    space0_1.Text = "O";
                    row0[1] = 1;
                }
                flag = !flag;

                if (checkXWin() == true)
                {
                    outcomeLabel.Text = "X wins";
                }

                if (checkOWin() == true)
                {
                    outcomeLabel.Text = "O wins";
                }

                if (checkDraw() == true)
                {
                    outcomeLabel.Text = "Draw";
                }
            }
            counter0_1++;
        }

        private void space0_2_Click(object sender, EventArgs e)
        {
            if (counter0_2 == 0)
            {
                if (flag == false)
                {
                    space0_2.Text = "X";
                    row0[2] = 0;
                }
                else if (flag == true)
                {
                    space0_2.Text = "O";
                    row0[2] = 1;
                }
                flag = !flag;

                if (checkXWin() == true)
                {
                    outcomeLabel.Text = "X wins";
                }

                if (checkOWin() == true)
                {
                    outcomeLabel.Text = "O wins";
                }

                if (checkDraw() == true)
                {
                    outcomeLabel.Text = "Draw";
                }
            }
            counter0_2++;
        }

        private void space1_0_Click(object sender, EventArgs e)
        {
            if (counter1_0 == 0)
            {
                if (flag == false)
                {
                    space1_0.Text = "X";
                    row1[0] = 0;
                }
                else if (flag == true)
                {
                    space1_0.Text = "O";
                    row1[0] = 1;
                }
                flag = !flag;

                if (checkXWin() == true)
                {
                    outcomeLabel.Text = "X wins";
                }

                if (checkOWin() == true)
                {
                    outcomeLabel.Text = "O wins";
                }

                if (checkDraw() == true)
                {
                    outcomeLabel.Text = "Draw";
                }
            }
            counter1_0++;
        }

        private void space1_1_Click(object sender, EventArgs e)
        {
            if (counter1_1 == 0)
            {
                if (flag == false)
                {
                    space1_1.Text = "X";
                    row1[1] = 0;
                }
                else if (flag == true)
                {
                    space1_1.Text = "O";
                    row1[1] = 1;
                }
                flag = !flag;

                if (checkXWin() == true)
                {
                    outcomeLabel.Text = "X wins";
                }

                if (checkOWin() == true)
                {
                    outcomeLabel.Text = "O wins";
                }

                if (checkDraw() == true)
                {
                    outcomeLabel.Text = "Draw";
                }
            }
            counter1_1++;
        }

        private void space1_2_Click(object sender, EventArgs e)
        {
            if (counter1_2 == 0)
            {
                if (flag == false)
                {
                    space1_2.Text = "X";
                    row1[2] = 0;
                }
                else if (flag == true)
                {
                    space1_2.Text = "O";
                    row1[2] = 1;
                }
                flag = !flag;

                if (checkXWin() == true)
                {
                    outcomeLabel.Text = "X wins";
                }

                if (checkOWin() == true)
                {
                    outcomeLabel.Text = "O wins";
                }

                if (checkDraw() == true)
                {
                    outcomeLabel.Text = "Draw";
                }
            }
            counter1_2++;
        }

        private void space2_0_Click(object sender, EventArgs e)
        {
            if (counter2_0 == 0)
            {
                if (flag == false)
                {
                    space2_0.Text = "X";
                    row2[0] = 0;
                }
                else if (flag == true)
                {
                    space2_0.Text = "O";
                    row2[0] = 1;
                }
                flag = !flag;

                if (checkXWin() == true)
                {
                    outcomeLabel.Text = "X wins";
                }

                if (checkOWin() == true)
                {
                    outcomeLabel.Text = "O wins";
                }

                if (checkDraw() == true)
                {
                    outcomeLabel.Text = "Draw";
                }
            }
            counter2_0++;
        }

        private void space2_1_Click(object sender, EventArgs e)
        {
            if (counter2_1 == 0)
            {
                if (flag == false)
                {
                    space2_1.Text = "X";
                    row2[1] = 0;
                }
                else if (flag == true)
                {
                    space2_1.Text = "O";
                    row2[1] = 1;
                }
                flag = !flag;

                if (checkXWin() == true)
                {
                    outcomeLabel.Text = "X wins";
                }

                if (checkOWin() == true)
                {
                    outcomeLabel.Text = "O wins";
                }

                if (checkDraw() == true)
                {
                    outcomeLabel.Text = "Draw";
                }
            }
            counter2_1++;
        }

        private void space2_2_Click(object sender, EventArgs e)
        {
            if (counter2_2 == 0)
            {
                if (flag == false)
                {
                    space2_2.Text = "X";
                    row2[2] = 0;
                }
                else if (flag == true)
                {
                    space2_2.Text = "O";
                    row2[2] = 1;
                }
                flag = !flag;

                if (checkXWin() == true)
                {
                    outcomeLabel.Text = "X wins";
                }

                if (checkOWin() == true)
                {
                    outcomeLabel.Text = "O wins";
                }

                if (checkDraw() == true)
                {
                    outcomeLabel.Text = "Draw";
                }
            }
            counter2_2++;
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            counter0_0 = 0;
            counter0_1 = 0;
            counter0_2 = 0;

            counter1_0 = 0;
            counter1_1 = 0;
            counter1_2 = 0;

            counter2_0 = 0;
            counter2_1 = 0;
            counter2_2 = 0;

            space0_0.Text = "";
            space0_1.Text = "";
            space0_2.Text = "";

            space1_0.Text = "";
            space1_1.Text = "";
            space1_2.Text = "";

            space2_0.Text = "";
            space2_1.Text = "";
            space2_2.Text = "";

            row0[0] = -1;
            row0[1] = -1;
            row0[2] = -1;

            row1[0] = -1;
            row1[1] = -1;
            row1[2] = -1;

            row2[0] = -1;
            row2[1] = -1;
            row2[2] = -1;

            outcomeLabel.Text = "";

            flag = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
