using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace BasicCalculator
{
    public partial class Main : Form
    {
        private double Num;
        private double Result = 0;
        private bool Status;
        private string Last;
        private bool FirstEqu = true;
        private bool IsFirst = true;

        public Main()
        {
            InitializeComponent();


            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(BtnNumber_KeyPress);
            this.KeyPress += new KeyPressEventHandler(ClearPress_Key);
            this.KeyPress += new KeyPressEventHandler(RemoveKey_Press);
            this.KeyPress += new KeyPressEventHandler(ResultKey_Press);

        }

        private void BtnNumber_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (LabelShow.Text == "0")
                LabelShow.Text = btn.Text;

            else
            {
                if (Status)
                {
                    LabelShow.Text = btn.Text;
                    Status = false;
                }

                else
                    LabelShow.Text += btn.Text;
            }
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Status = true;

            if (!IsFirst)
            {
                BtnResult_Click(sender, e);
                Last = btn.Text;
            }

            else
            {
                switch (btn.Text)
                {
                    case "+":

                        Result += Convert.ToDouble(LabelShow.Text);
                        LabelShow.Text = Result.ToString();
                        Last = "+";
                        FirstEqu = true;
                        break;

                    case "-":
                        if (Result == 0)
                            Result = Convert.ToDouble(LabelShow.Text);

                        else
                        {
                            Result -= Convert.ToDouble(LabelShow.Text);
                            LabelShow.Text = Result.ToString();
                        }

                        Last = "-";
                        FirstEqu = true;
                        break;

                    case "X":

                        if (Result == 0)
                            Result = Convert.ToDouble(LabelShow.Text);

                        else
                        {
                            Result *= Convert.ToDouble(LabelShow.Text);
                            LabelShow.Text = Result.ToString();
                        }

                        Last = "X";
                        FirstEqu = true;
                        break;

                    case "/":

                        if (Result == 0)
                            Result = Convert.ToDouble(LabelShow.Text);

                        else
                        {
                            if (LabelShow.Text == "0")
                                LabelShow.Text = "You cannot divide by zero.";

                            else
                            {
                                Result /= Convert.ToDouble(LabelShow.Text);
                                LabelShow.Text = Result.ToString();
                            }

                        }

                        Last = "/";
                        FirstEqu = true;
                        break;

                }

                IsFirst = false;
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            if (LabelShow.Text != "0")
            {
                LabelShow.Text = "0";
                Result = 0;
                Status = false;
                FirstEqu = false;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (LabelShow.Text != "0" && LabelShow.Text.Length != 0)
                LabelShow.Text = LabelShow.Text.Remove(LabelShow.Text.Length - 1);

            if (LabelShow.Text.Length == 0)
                LabelShow.Text = "0";

        }

        private void BtnDot_Click(object sender, EventArgs e)
        {
            if (!LabelShow.Text.Contains("."))
                LabelShow.Text += ".";
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (FirstEqu == true)
            {
                Num = Convert.ToDouble(LabelShow.Text);
                FirstEqu = false;
            }

            switch (Last)
            {
                case "+":

                    Result += Num;

                    break;

                case "-":
                    Result -= Num;
                    break;

                case "X":
                    Result *= Num;
                    break;

                case "/":

                    if (LabelShow.Text == "0")
                        LabelShow.Text = "You cannot divide by zero.";

                    else
                        Result /= Num;

                    break;

                case "=":

                    if (Last == "+")
                        goto case "+";
                    if (Last == "-")
                        goto case "-";
                    if (Last == "X")
                        goto case "X";
                    if (Last == "/")
                        goto case "/";
                    break;

            }

            LabelShow.Text = Result.ToString();

        }

        private void BtnNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                if (LabelShow.Text == "0")
                    LabelShow.Text = e.KeyChar.ToString();
                else
                {
                    if (Status)
                    {
                        LabelShow.Text = e.KeyChar.ToString();
                        Status = false;
                    }
                    else
                        LabelShow.Text += e.KeyChar.ToString();
                }


        }

        private void BtnSignChanger_Click_Click(object sender, EventArgs e)
        {

            if (!LabelShow.Text.Contains("-"))
            {
                if (LabelShow.Text == "0")
                    LabelShow.Text = "-";

                else
                    LabelShow.Text = "-" + LabelShow.Text;
            }

            else
            {
                if (LabelShow.Text == "-")
                    LabelShow.Text = "0";

                else
                    LabelShow.Text = LabelShow.Text.Remove(0, 1);
            }

        }

        private void ClearPress_Key(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'C' || e.KeyChar == 'c')
                if (LabelShow.Text != "0")
                {
                    LabelShow.Text = "0";
                    Result = 0;
                    Status = false;
                    FirstEqu = false;
                }
        }

        private void RemoveKey_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                if (LabelShow.Text != "0" && LabelShow.Text.Length != 0)
                    LabelShow.Text = LabelShow.Text.Remove(LabelShow.Text.Length - 1);

                if (LabelShow.Text.Length == 0)
                    LabelShow.Text = "0";
            }
        }

        private void OperationKey_Down(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Add || (e.Shift && e.KeyCode == Keys.Oemplus))
            {
                Last = "+";
                BtnOperation_Click(BtnPlus, e);
            }
                

            if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                Last = "-";
                BtnOperation_Click(BtnMinus, e);
            }
                

            if (e.Shift && e.KeyCode == Keys.D8)
            {
                Last = "X";
                BtnOperation_Click(BtnMultiply, e);
            }
               

            if (e.KeyCode == Keys.Oem2)
            {
                Last = "/";
                BtnOperation_Click(BtnDivide, e);
            }
               

        }

        private void ResultKey_Press(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='=')
                BtnResult_Click(BtnResult, e);
        }
    }
}
