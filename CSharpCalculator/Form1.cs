using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCalculator
{
    public partial class FrmCalculator : Form
    {
        #region Variables
        private double? operand1;
        private double? operand2;
        private int Operation;
        private bool Decimal = false;
        #endregion

        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void BtnEqual_Click(object sender, EventArgs e)

        {
            switch (Operation)
            {
                case 1: //Square Root
                    richTextBox1.AppendText("\nSqrt(" + operand1.ToString() + ") = " + Math.Sqrt(Convert.ToDouble(operand1)).ToString());
                    break;
                case 2: //Square
                    richTextBox1.AppendText("\nSquare of " + operand1.ToString() + " = " + Math.Pow(Convert.ToDouble(operand1), 2).ToString());
                    break;
                case 3: //Power
                    if (operand2 is null)
                    {
                        MessageBox.Show("\nSecond value is missing. Please re-enter values.");
                        break;
                    }
                    else
                    {
                        richTextBox1.AppendText("\n" + operand1.ToString() + " ^ " + operand2.ToString() + " = " + Math.Pow(Convert.ToDouble(operand1), Convert.ToDouble(operand2)).ToString());
                    }
                    break;
                case 4: //Reciprocal
                    richTextBox1.AppendText("\n1 / " + operand1 + " = " + (1 / operand1));
                    break;
                case 5: //Division
                    if (operand2 is null)
                    {
                        MessageBox.Show("\nSecond value is missing. Please re-enter values.");
                    }
                    else
                    {
                        richTextBox1.AppendText("\n" + operand1 + " / " + operand2 + " = " + (operand1 / operand2));
                    }
                    break;
                case 6: //Multiplication
                    if (operand2 is null)
                    {
                        MessageBox.Show("\nSecond value is missing. Please re-enter values.");
                    }
                    else
                    {
                        richTextBox1.AppendText("\n" + operand1 + " * " + operand2 + " = " + (operand1 * operand2));
                    }
                    break;
                case 7: //Subtraction
                    if (operand2 is null)
                    {
                        MessageBox.Show("\nSecond value is missing. Please re-enter values.");
                    }
                    else
                    {
                        richTextBox1.AppendText("\n" + operand1 + " - " + operand2 + " = " + (operand1 - operand2));
                    }
                    break;
                case 8: //Addition
                    if (operand2 is null)
                    {
                        MessageBox.Show("\nSecond value is missing. Please re-enter values.");
                    }
                    else
                    {
                        richTextBox1.AppendText("\n" + operand1 + " + " + operand2 + " = " + (operand1 + operand2));
                    }
                    break;
                default:
                    MessageBox.Show("\nNo Operation Selected. Please re-enter values & select operation.");
                    break;
            }
            operand1 = null;
            operand2 = null;
            textBox1.Text = null;
            Operation = 0;
            //richTextBox1.Text += "\nAppended text";
            richTextBox1.ScrollToCaret();

        }

        private void BtnDecimal_Click(object sender, EventArgs e) //Incomplete
        {
            if(operand1 == null && operand2 == null)
            {
                //operand1 = (double)"0.";
                textBox1.AppendText("0.");
            }
            else if (operand1 != null && Operation != 0)
            {

            }
            
            //textBox1.AppendText(".");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
/*        void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
                {
                    switch ((int)e.KeyChar)
                        {
                            case '0':
                                BtnZero_Click(sender, e);
                                    break;
                            case '1':
                                 BtnOne_Click(sender, e);
                                     break;
                             case '2':
                                 BtnTwo_Click(sender, e);
                                     break;
                             case '3':
                                 BtnThree_Click(sender, e);
                                     break;
                             case '4':
                                 BtnFour_Click(sender, e);
                                     break;
                             case '5':
                                 BtnFive_Click(sender, e);
                                     break;
                             case '6':
                                 BtnSix_Click(sender, e);
                                     break;
                             case '7':
                                 BtnSeven_Click(sender, e);
                                     break;
                             case '8':
                                 BtnEight_Click(sender, e);
                                     break;
                             case '9':
                                 BtnNine_Click(sender, e);
                                     break;
                             case '.':
                                 BtnDecimal_Click(sender, e);
                                     break;
                             case '+':
                                 BtnPlus_Click(sender, e);
                                     break;
                             case '=':
                                 BtnEqual_Click(sender, e);
                                 break;
                             case '-':
                                 BtnSubtract_Click(sender, e);
                                 break;
                             case '*':
                                 BtnMultiply_Click(sender, e);
                                 break;
                             case '\\':
                                 BtnDivide_Click(sender, e);
                                 break;
                             case '/':
                                 BtnDivide_Click(sender, e);
                                 break;

                         }  
                }*/

        #region Numbers
        private void BtnOne_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
            if (operand1 == null && Operation == 0)
            {
                operand1 = 1;
            }
            else if (operand1 != null && Operation == 0)
            {
                operand1 = int.Parse(operand1.ToString() + "1");
            }
            else if (operand2 == null && Operation != 0)
            {
                operand2 = 1;
            }
            else if (operand2 != null && Operation != 0)
            {
                operand2 = int.Parse(operand2.ToString() + "1");
            }
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
            if (operand1 == null && Operation == 0)
            {
                operand1 = 0;
            }
            else if (operand1 != null && Operation == 0)
            {
                operand1 = int.Parse(operand1.ToString() + "0");
            }
            else if (operand2 == null && Operation != 0)
            {
                operand2 = 0;
            }
            else if (operand2 != null && Operation != 0)
            {
                operand2 = int.Parse(operand2.ToString() + "0");
            }
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
            if (operand1 == null && Operation == 0)
            {
                operand1 = 2;
            }
            else if (operand1 != null && Operation == 0)
            {
                operand1 = int.Parse(operand1.ToString() + "2");
            }
            else if (operand2 == null && Operation != 0)
            {
                operand2 = 2;
            }
            else if (operand2 != null && Operation != 0)
            {
                operand2 = int.Parse(operand2.ToString() + "2");
            }
        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
            if (operand1 == null && Operation == 0)
            {
                operand1 = 3;
            }
            else if (operand1 != null && Operation == 0)
            {
                operand1 = int.Parse(operand1.ToString() + "3");
            }
            else if (operand2 == null && Operation != 0)
            {
                operand2 = 3;
            }
            else if (operand2 != null && Operation != 0)
            {
                operand2 = int.Parse(operand2.ToString() + "3");
            }
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
            if (operand1 == null && Operation == 0)
            {
                operand1 = 4;
            }
            else if (operand1 != null && Operation == 0)
            {
                operand1 = int.Parse(operand1.ToString() + "4");
            }
            else if (operand2 == null && Operation != 0)
            {
                operand2 = 4;
            }
            else if (operand2 != null && Operation != 0)
            {
                operand2 = int.Parse(operand2.ToString() + "4");
            }
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
            if (operand1 == null && Operation == 0)
            {
                operand1 = 5;
            }
            else if (operand1 != null && Operation == 0)
            {
                operand1 = int.Parse(operand1.ToString() + "5");
            }
            else if (operand2 == null && Operation != 0)
            {
                operand2 = 5;
            }
            else if (operand2 != null && Operation != 0)
            {
                operand2 = int.Parse(operand2.ToString() + "5");
            }
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
            if (operand1 == null && Operation == 0)
            {
                operand1 = 6;
            }
            else if (operand1 != null && Operation == 0)
            {
                operand1 = int.Parse(operand1.ToString() + "6");
            }
            else if (operand2 == null && Operation != 0)
            {
                operand2 = 6;
            }
            else if (operand2 != null && Operation != 0)
            {
                operand2 = int.Parse(operand2.ToString() + "6");
            }
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
            if (operand1 == null && Operation == 0)
            {
                operand1 = 7;
            }
            else if (operand1 != null && Operation == 0)
            {
                operand1 = int.Parse(operand1.ToString() + "7");
            }
            else if (operand2 == null && Operation != 0)
            {
                operand2 = 7;
            }
            else if (operand2 != null && Operation != 0)
            {
                operand2 = int.Parse(operand2.ToString() + "7");
            }
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
            if (operand1 == null && Operation == 0)
            {
                operand1 = 8;
            }
            else if (operand1 != null && Operation == 0)
            {
                operand1 = int.Parse(operand1.ToString() + "8");
            }
            else if (operand2 == null && Operation != 0)
            {
                operand2 = 8;
            }
            else if (operand2 != null && Operation != 0)
            {
                operand2 = int.Parse(operand2.ToString() + "8");
            }
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
            if (operand1 == null && Operation == 0)
            {
                operand1 = 9;
            }
            else if (operand1 != null && Operation == 0)
            {
                operand1 = int.Parse(operand1.ToString() + "9");
            }
            else if (operand2 == null && Operation != 0)
            {
                operand2 = 9;
            }
            else if (operand2 != null && Operation != 0)
            {
                operand2 = int.Parse(operand2.ToString() + "9");
            }
                
                
        }
        #endregion COMPLETE

        #region ClearButtons INCOMPLETE
        private void BtnClear_Click(object sender, EventArgs e)
        {
            operand1 = null;
            operand2 = null;
            Operation = 0;
            richTextBox1.Text = "Inputs cleared";
            textBox1.Text = null;
        }

        private void BtnClearEntry_Click(object sender, EventArgs e) //Clears all entriees, and resets all necessary values to null. 
        {
            if(operand2 != null)
            {
                operand2 = null;
                textBox1.Text = null;
            }
            else if(operand1 != null && operand2 == null)
            {
                operand1 = null;
                textBox1.Text = null;
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e) // Check length of most recently-entered operand, and remove the right-most character of that operand.
        {
            if(operand1 == null)
            {
                MessageBox.Show("No values input to delete.");
            }
            else if(operand1 != null && operand2 == null && Operation == 0)
            {
                operand1 = Convert.ToDouble(operand1.ToString().Remove(operand1.ToString().Length - 1, 1));
                textBox1.Text = operand1.ToString();
            }
            else if(operand1 != null && operand2 != null && Operation != 0)
            {
                operand2 = Convert.ToDouble(operand2.ToString().Remove(operand2.ToString().Length - 1, 1)); 
                textBox1.Text = operand2.ToString();
            }
        }
        #endregion

        #region Operations
        private void BtnSquare_Click(object sender, EventArgs e)
        {
            if(operand1 != null)
            {
                Operation = 2;
                BtnEqual_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No value entered.");
            }
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            if(operand1 != null)
            {
                Operation = 3;
                textBox1.AppendText(" ^ ");
            }
            else
            {
                MessageBox.Show("Missing base value for Power operation.");
            }
        }

        private void BtnInverse_Click(object sender, EventArgs e)
        {
            if(operand1 != null)
            {
                Operation = 4;
                BtnEqual_Click(sender, e);
            }
            else if(operand1 == 0)
            {
                MessageBox.Show("Cannot divide by zero.");
            }
            else
            {
                MessageBox.Show("No value entered.");
            }
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if(operand1 != null)
            {
                Operation = 5;
                textBox1.AppendText(" / ");
            }
            else
            {
                MessageBox.Show("No value entered.");
            }
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            if (operand1 != null)
            {
                Operation = 6;
                textBox1.AppendText(" * ");

            }
            else
            {
                MessageBox.Show("No value entered.");
            }
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            if (operand1 != null)
            {
                Operation = 7;
                textBox1.AppendText(" - ");

            }
            else
            {
                MessageBox.Show("No value entered.");
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (operand1 != null)
            {
                Operation = 8;
                textBox1.AppendText(" + ");

            }
            else
            {
                MessageBox.Show("No value entered.");
            }
        }

        private void BtnChangeSign_Click(object sender, EventArgs e)
        {
            if (operand2 == null && operand1 == null)
            {
                MessageBox.Show("No value entered.");
            }
            else if (operand2 == null && operand1 != null)
            {
                operand1 *= -1;
                textBox1.Text = operand1.ToString();
            }
            else
            {
                operand2 *= -1;
                textBox1.Text = operand2.ToString();
            }
        }
        private void BtnSquareRoot_Click(object sender, EventArgs e)
        {
            if ((operand1 != null) && (operand1 >= 0))
            {
                Operation = 1;
                BtnEqual_Click(sender, e);
                //run this
            }
            else
            {
                MessageBox.Show("Invalid Input. Must be a value >= zero.");
            }
            //Cannot take the square root of null or negative number.

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}