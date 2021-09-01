
namespace CSharpCalculator
{
    partial class FrmCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnEquals = new System.Windows.Forms.Button();
            this.BtnDecimal = new System.Windows.Forms.Button();
            this.BtnZero = new System.Windows.Forms.Button();
            this.BtnChangeSign = new System.Windows.Forms.Button();
            this.BtnOne = new System.Windows.Forms.Button();
            this.BtnTwo = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnFour = new System.Windows.Forms.Button();
            this.BtnFive = new System.Windows.Forms.Button();
            this.BtnSix = new System.Windows.Forms.Button();
            this.BtnSubtract = new System.Windows.Forms.Button();
            this.BtnSeven = new System.Windows.Forms.Button();
            this.BtnEight = new System.Windows.Forms.Button();
            this.BtnNine = new System.Windows.Forms.Button();
            this.BtnMultiply = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnClearEntry = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnSquareRoot = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.BtnPower = new System.Windows.Forms.Button();
            this.BtnInverse = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.OutputHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEquals
            // 
            this.BtnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquals.Location = new System.Drawing.Point(264, 494);
            this.BtnEquals.Name = "BtnEquals";
            this.BtnEquals.Size = new System.Drawing.Size(76, 61);
            this.BtnEquals.TabIndex = 0;
            this.BtnEquals.Text = "=";
            this.BtnEquals.UseVisualStyleBackColor = true;
            this.BtnEquals.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnDecimal
            // 
            this.BtnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDecimal.Location = new System.Drawing.Point(182, 494);
            this.BtnDecimal.Name = "BtnDecimal";
            this.BtnDecimal.Size = new System.Drawing.Size(76, 61);
            this.BtnDecimal.TabIndex = 2;
            this.BtnDecimal.Text = ".";
            this.BtnDecimal.UseVisualStyleBackColor = true;
            this.BtnDecimal.Click += new System.EventHandler(this.BtnDecimal_Click);
            // 
            // BtnZero
            // 
            this.BtnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZero.Location = new System.Drawing.Point(100, 494);
            this.BtnZero.Name = "BtnZero";
            this.BtnZero.Size = new System.Drawing.Size(76, 61);
            this.BtnZero.TabIndex = 3;
            this.BtnZero.Text = "0";
            this.BtnZero.UseVisualStyleBackColor = true;
            this.BtnZero.Click += new System.EventHandler(this.BtnZero_Click);
            // 
            // BtnChangeSign
            // 
            this.BtnChangeSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeSign.Location = new System.Drawing.Point(18, 494);
            this.BtnChangeSign.Name = "BtnChangeSign";
            this.BtnChangeSign.Size = new System.Drawing.Size(76, 61);
            this.BtnChangeSign.TabIndex = 4;
            this.BtnChangeSign.Text = "+ / -";
            this.BtnChangeSign.UseVisualStyleBackColor = true;
            this.BtnChangeSign.Click += new System.EventHandler(this.BtnChangeSign_Click);
            // 
            // BtnOne
            // 
            this.BtnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOne.Location = new System.Drawing.Point(18, 427);
            this.BtnOne.Name = "BtnOne";
            this.BtnOne.Size = new System.Drawing.Size(76, 61);
            this.BtnOne.TabIndex = 8;
            this.BtnOne.Text = "1";
            this.BtnOne.UseVisualStyleBackColor = true;
            this.BtnOne.Click += new System.EventHandler(this.BtnOne_Click);
            // 
            // BtnTwo
            // 
            this.BtnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTwo.Location = new System.Drawing.Point(100, 427);
            this.BtnTwo.Name = "BtnTwo";
            this.BtnTwo.Size = new System.Drawing.Size(76, 61);
            this.BtnTwo.TabIndex = 7;
            this.BtnTwo.Text = "2";
            this.BtnTwo.UseVisualStyleBackColor = true;
            this.BtnTwo.Click += new System.EventHandler(this.BtnTwo_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThree.Location = new System.Drawing.Point(182, 427);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(76, 61);
            this.BtnThree.TabIndex = 6;
            this.BtnThree.Text = "3";
            this.BtnThree.UseVisualStyleBackColor = true;
            this.BtnThree.Click += new System.EventHandler(this.BtnThree_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlus.Location = new System.Drawing.Point(264, 427);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(76, 61);
            this.BtnPlus.TabIndex = 5;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = true;
            this.BtnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // BtnFour
            // 
            this.BtnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFour.Location = new System.Drawing.Point(18, 360);
            this.BtnFour.Name = "BtnFour";
            this.BtnFour.Size = new System.Drawing.Size(76, 61);
            this.BtnFour.TabIndex = 12;
            this.BtnFour.Text = "4";
            this.BtnFour.UseVisualStyleBackColor = true;
            this.BtnFour.Click += new System.EventHandler(this.BtnFour_Click);
            // 
            // BtnFive
            // 
            this.BtnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFive.Location = new System.Drawing.Point(100, 360);
            this.BtnFive.Name = "BtnFive";
            this.BtnFive.Size = new System.Drawing.Size(76, 61);
            this.BtnFive.TabIndex = 11;
            this.BtnFive.Text = "5";
            this.BtnFive.UseVisualStyleBackColor = true;
            this.BtnFive.Click += new System.EventHandler(this.BtnFive_Click);
            // 
            // BtnSix
            // 
            this.BtnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSix.Location = new System.Drawing.Point(182, 360);
            this.BtnSix.Name = "BtnSix";
            this.BtnSix.Size = new System.Drawing.Size(76, 61);
            this.BtnSix.TabIndex = 10;
            this.BtnSix.Text = "6";
            this.BtnSix.UseVisualStyleBackColor = true;
            this.BtnSix.Click += new System.EventHandler(this.BtnSix_Click);
            // 
            // BtnSubtract
            // 
            this.BtnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubtract.Location = new System.Drawing.Point(264, 360);
            this.BtnSubtract.Name = "BtnSubtract";
            this.BtnSubtract.Size = new System.Drawing.Size(76, 61);
            this.BtnSubtract.TabIndex = 9;
            this.BtnSubtract.Text = "-";
            this.BtnSubtract.UseVisualStyleBackColor = true;
            this.BtnSubtract.Click += new System.EventHandler(this.BtnSubtract_Click);
            // 
            // BtnSeven
            // 
            this.BtnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeven.Location = new System.Drawing.Point(18, 294);
            this.BtnSeven.Name = "BtnSeven";
            this.BtnSeven.Size = new System.Drawing.Size(76, 61);
            this.BtnSeven.TabIndex = 16;
            this.BtnSeven.Text = "7";
            this.BtnSeven.UseVisualStyleBackColor = true;
            this.BtnSeven.Click += new System.EventHandler(this.BtnSeven_Click);
            // 
            // BtnEight
            // 
            this.BtnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEight.Location = new System.Drawing.Point(100, 294);
            this.BtnEight.Name = "BtnEight";
            this.BtnEight.Size = new System.Drawing.Size(76, 61);
            this.BtnEight.TabIndex = 15;
            this.BtnEight.Text = "8";
            this.BtnEight.UseVisualStyleBackColor = true;
            this.BtnEight.Click += new System.EventHandler(this.BtnEight_Click);
            // 
            // BtnNine
            // 
            this.BtnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNine.Location = new System.Drawing.Point(182, 294);
            this.BtnNine.Name = "BtnNine";
            this.BtnNine.Size = new System.Drawing.Size(76, 61);
            this.BtnNine.TabIndex = 14;
            this.BtnNine.Text = "9";
            this.BtnNine.UseVisualStyleBackColor = true;
            this.BtnNine.Click += new System.EventHandler(this.BtnNine_Click);
            // 
            // BtnMultiply
            // 
            this.BtnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMultiply.Location = new System.Drawing.Point(264, 294);
            this.BtnMultiply.Name = "BtnMultiply";
            this.BtnMultiply.Size = new System.Drawing.Size(76, 61);
            this.BtnMultiply.TabIndex = 13;
            this.BtnMultiply.Text = "x";
            this.BtnMultiply.UseVisualStyleBackColor = true;
            this.BtnMultiply.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(18, 228);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(76, 61);
            this.BtnClear.TabIndex = 20;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnClearEntry
            // 
            this.BtnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearEntry.Location = new System.Drawing.Point(100, 228);
            this.BtnClearEntry.Name = "BtnClearEntry";
            this.BtnClearEntry.Size = new System.Drawing.Size(76, 61);
            this.BtnClearEntry.TabIndex = 19;
            this.BtnClearEntry.Text = "CE";
            this.BtnClearEntry.UseVisualStyleBackColor = true;
            this.BtnClearEntry.Click += new System.EventHandler(this.BtnClearEntry_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(182, 228);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(76, 61);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Del";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDivide.Location = new System.Drawing.Point(264, 228);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(76, 61);
            this.BtnDivide.TabIndex = 17;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnSquareRoot
            // 
            this.BtnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquareRoot.Location = new System.Drawing.Point(18, 162);
            this.BtnSquareRoot.Name = "BtnSquareRoot";
            this.BtnSquareRoot.Size = new System.Drawing.Size(76, 61);
            this.BtnSquareRoot.TabIndex = 24;
            this.BtnSquareRoot.Text = "Sqrt";
            this.BtnSquareRoot.UseVisualStyleBackColor = true;
            this.BtnSquareRoot.Click += new System.EventHandler(this.BtnSquareRoot_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSquare.Location = new System.Drawing.Point(100, 162);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(76, 61);
            this.BtnSquare.TabIndex = 23;
            this.BtnSquare.Text = "x^2";
            this.BtnSquare.UseVisualStyleBackColor = true;
            this.BtnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // BtnPower
            // 
            this.BtnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPower.Location = new System.Drawing.Point(182, 162);
            this.BtnPower.Name = "BtnPower";
            this.BtnPower.Size = new System.Drawing.Size(76, 61);
            this.BtnPower.TabIndex = 22;
            this.BtnPower.Text = "x^y";
            this.BtnPower.UseVisualStyleBackColor = true;
            this.BtnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // BtnInverse
            // 
            this.BtnInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInverse.Location = new System.Drawing.Point(264, 162);
            this.BtnInverse.Name = "BtnInverse";
            this.BtnInverse.Size = new System.Drawing.Size(76, 61);
            this.BtnInverse.TabIndex = 21;
            this.BtnInverse.Text = "1/x";
            this.BtnInverse.UseVisualStyleBackColor = true;
            this.BtnInverse.Click += new System.EventHandler(this.BtnInverse_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(18, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(322, 78);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(15, 118);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(31, 13);
            this.InputLabel.TabIndex = 27;
            this.InputLabel.Text = "Input";
            // 
            // OutputHistory
            // 
            this.OutputHistory.AutoSize = true;
            this.OutputHistory.Location = new System.Drawing.Point(15, 16);
            this.OutputHistory.Name = "OutputHistory";
            this.OutputHistory.Size = new System.Drawing.Size(83, 13);
            this.OutputHistory.TabIndex = 28;
            this.OutputHistory.Text = "Output && History";
            this.OutputHistory.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 569);
            this.Controls.Add(this.OutputHistory);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnSquareRoot);
            this.Controls.Add(this.BtnSquare);
            this.Controls.Add(this.BtnPower);
            this.Controls.Add(this.BtnInverse);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnClearEntry);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnSeven);
            this.Controls.Add(this.BtnEight);
            this.Controls.Add(this.BtnNine);
            this.Controls.Add(this.BtnMultiply);
            this.Controls.Add(this.BtnFour);
            this.Controls.Add(this.BtnFive);
            this.Controls.Add(this.BtnSix);
            this.Controls.Add(this.BtnSubtract);
            this.Controls.Add(this.BtnOne);
            this.Controls.Add(this.BtnTwo);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnChangeSign);
            this.Controls.Add(this.BtnZero);
            this.Controls.Add(this.BtnDecimal);
            this.Controls.Add(this.BtnEquals);
            this.Name = "FrmCalculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEquals;
        private System.Windows.Forms.Button BtnDecimal;
        private System.Windows.Forms.Button BtnZero;
        private System.Windows.Forms.Button BtnChangeSign;
        private System.Windows.Forms.Button BtnOne;
        private System.Windows.Forms.Button BtnTwo;
        private System.Windows.Forms.Button BtnThree;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnFour;
        private System.Windows.Forms.Button BtnFive;
        private System.Windows.Forms.Button BtnSix;
        private System.Windows.Forms.Button BtnSubtract;
        private System.Windows.Forms.Button BtnSeven;
        private System.Windows.Forms.Button BtnEight;
        private System.Windows.Forms.Button BtnNine;
        private System.Windows.Forms.Button BtnMultiply;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnClearEntry;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnSquareRoot;
        private System.Windows.Forms.Button BtnSquare;
        private System.Windows.Forms.Button BtnPower;
        private System.Windows.Forms.Button BtnInverse;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label OutputHistory;
    }
}

