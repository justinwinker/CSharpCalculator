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
        private double? output;
        private bool decimalOn = false;
        private bool MinusOn = false;
        private Operation currentOperation = Operation.NoneSelected;
        #endregion

        public enum Operation
        {
            NoneSelected = 0,
            SquareRoot = 1,
            Square = 2,
            Power = 3,
            Reciprocal = 4,
            Division = 5,
            Multiplication = 6,
            Subtraction = 7,
            Addition = 8
        }
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void BtnEqual_Click(object sender, EventArgs e)

        {
            switch (currentOperation)
            {
                case 0:
                    textBox1.Text = "No Operation Selected";
                        break;
                case 1:


            }
            //richTextBox1.Text += "\nAppended text";
            richTextBox1.ScrollToCaret();
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(".");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void BtnSquareRoot_Click(object sender, EventArgs e)
        {
            if ((operand1 != null) && (operand1 >= 0))
            {
                richTextBox1.AppendText("/n" + "Sqrt(" + operand1 + ") = " + Math.Sqrt(Convert.ToDouble(operand1)));
                //run this
            }
            else
            {
                textBox1.Text = "Invalid Input.";
            }
                //Cannot square null

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnOne_Click(object sender, EventArgs e)
        {

        }

        private void BtnZero_Click(object sender, EventArgs e)
        {

        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {

        }

        private void BtnThree_Click(object sender, EventArgs e)
        {

        }

        private void BtnFour_Click(object sender, EventArgs e)
        {

        }

        private void BtnFive_Click(object sender, EventArgs e)
        {

        }

        private void BtnSix_Click(object sender, EventArgs e)
        {

        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {

        }

        private void BtnEight_Click(object sender, EventArgs e)
        {

        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");

                
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            operand1 = null;
            operand2 = null;
            currentOperation = Operation.NoneSelected;
            richTextBox1.Text = null;
            textBox1.Text = "Inputs cleared.";
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnSquare_Click(object sender, EventArgs e)
        {

        }

        private void BtnPower_Click(object sender, EventArgs e)
        {

        }

        private void BtnInverse_Click(object sender, EventArgs e)
        {

        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {

        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {

        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {

        }

        private void BtnChangeSign_Click(object sender, EventArgs e)
        {

        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}