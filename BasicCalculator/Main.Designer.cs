namespace BasicCalculator
{
    partial class Main
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
            BtnZero = new Button();
            BtnOne = new Button();
            BtnTwo = new Button();
            BtnThree = new Button();
            BtnMinus = new Button();
            BtnDot = new Button();
            BtnResult = new Button();
            BtnDivide = new Button();
            BtnSix = new Button();
            BtnMultiply = new Button();
            BtnNine = new Button();
            BtnEight = new Button();
            BtnFive = new Button();
            BtnSeven = new Button();
            BtnFour = new Button();
            BtnPlus = new Button();
            BtnRemove = new Button();
            BtnClear = new Button();
            LabelShow = new Label();
            BtnSignChange_Click = new Button();
            SuspendLayout();
            // 
            // BtnZero
            // 
            BtnZero.Location = new Point(12, 386);
            BtnZero.Name = "BtnZero";
            BtnZero.Size = new Size(192, 68);
            BtnZero.TabIndex = 0;
            BtnZero.Text = "0";
            BtnZero.UseVisualStyleBackColor = true;
            BtnZero.Click += BtnNumber_Click;
            // 
            // BtnOne
            // 
            BtnOne.Location = new Point(12, 294);
            BtnOne.Name = "BtnOne";
            BtnOne.Size = new Size(79, 68);
            BtnOne.TabIndex = 1;
            BtnOne.Text = "1";
            BtnOne.UseVisualStyleBackColor = true;
            BtnOne.Click += BtnNumber_Click;
            // 
            // BtnTwo
            // 
            BtnTwo.Location = new Point(125, 294);
            BtnTwo.Name = "BtnTwo";
            BtnTwo.Size = new Size(79, 68);
            BtnTwo.TabIndex = 1;
            BtnTwo.Text = "2";
            BtnTwo.UseVisualStyleBackColor = true;
            BtnTwo.Click += BtnNumber_Click;
            // 
            // BtnThree
            // 
            BtnThree.Location = new Point(230, 294);
            BtnThree.Name = "BtnThree";
            BtnThree.Size = new Size(79, 68);
            BtnThree.TabIndex = 1;
            BtnThree.Text = "3";
            BtnThree.UseVisualStyleBackColor = true;
            BtnThree.Click += BtnNumber_Click;
            // 
            // BtnMinus
            // 
            BtnMinus.Location = new Point(343, 294);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(79, 68);
            BtnMinus.TabIndex = 1;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = true;
            BtnMinus.Click += BtnOperation_Click;
            BtnMinus.KeyDown += OperationKey_Down;
            // 
            // BtnDot
            // 
            BtnDot.Location = new Point(230, 386);
            BtnDot.Name = "BtnDot";
            BtnDot.Size = new Size(79, 68);
            BtnDot.TabIndex = 1;
            BtnDot.Text = ".";
            BtnDot.UseVisualStyleBackColor = true;
            BtnDot.Click += BtnDot_Click;
            BtnDot.KeyPress += DotKey_Press;
            // 
            // BtnResult
            // 
            BtnResult.Location = new Point(343, 386);
            BtnResult.Name = "BtnResult";
            BtnResult.Size = new Size(79, 68);
            BtnResult.TabIndex = 1;
            BtnResult.Text = "=";
            BtnResult.UseVisualStyleBackColor = true;
            BtnResult.Click += BtnResult_Click;
            BtnResult.KeyPress += ResultKey_Press;
            // 
            // BtnDivide
            // 
            BtnDivide.Location = new Point(343, 109);
            BtnDivide.Name = "BtnDivide";
            BtnDivide.Size = new Size(79, 68);
            BtnDivide.TabIndex = 1;
            BtnDivide.Text = "/";
            BtnDivide.UseVisualStyleBackColor = true;
            BtnDivide.Click += BtnOperation_Click;
            BtnDivide.KeyDown += OperationKey_Down;
            // 
            // BtnSix
            // 
            BtnSix.Location = new Point(230, 200);
            BtnSix.Name = "BtnSix";
            BtnSix.Size = new Size(79, 68);
            BtnSix.TabIndex = 1;
            BtnSix.Text = "6";
            BtnSix.UseVisualStyleBackColor = true;
            BtnSix.Click += BtnNumber_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.Location = new Point(343, 200);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(79, 68);
            BtnMultiply.TabIndex = 1;
            BtnMultiply.Text = "X";
            BtnMultiply.UseVisualStyleBackColor = true;
            BtnMultiply.Click += BtnOperation_Click;
            BtnMultiply.KeyDown += OperationKey_Down;
            // 
            // BtnNine
            // 
            BtnNine.Location = new Point(230, 109);
            BtnNine.Name = "BtnNine";
            BtnNine.Size = new Size(79, 68);
            BtnNine.TabIndex = 1;
            BtnNine.Text = "9";
            BtnNine.UseVisualStyleBackColor = true;
            BtnNine.Click += BtnNumber_Click;
            // 
            // BtnEight
            // 
            BtnEight.Location = new Point(125, 109);
            BtnEight.Name = "BtnEight";
            BtnEight.Size = new Size(79, 68);
            BtnEight.TabIndex = 1;
            BtnEight.Text = "8";
            BtnEight.UseVisualStyleBackColor = true;
            BtnEight.Click += BtnNumber_Click;
            BtnEight.KeyPress += BtnNumber_KeyPress;
            // 
            // BtnFive
            // 
            BtnFive.Location = new Point(125, 200);
            BtnFive.Name = "BtnFive";
            BtnFive.Size = new Size(79, 68);
            BtnFive.TabIndex = 1;
            BtnFive.Text = "5";
            BtnFive.UseVisualStyleBackColor = true;
            BtnFive.Click += BtnNumber_Click;
            // 
            // BtnSeven
            // 
            BtnSeven.Location = new Point(12, 109);
            BtnSeven.Name = "BtnSeven";
            BtnSeven.Size = new Size(79, 68);
            BtnSeven.TabIndex = 1;
            BtnSeven.Text = "7";
            BtnSeven.UseVisualStyleBackColor = true;
            BtnSeven.Click += BtnNumber_Click;
            // 
            // BtnFour
            // 
            BtnFour.Location = new Point(12, 200);
            BtnFour.Name = "BtnFour";
            BtnFour.Size = new Size(79, 68);
            BtnFour.TabIndex = 1;
            BtnFour.Text = "4";
            BtnFour.UseVisualStyleBackColor = true;
            BtnFour.Click += BtnNumber_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.Location = new Point(448, 294);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(79, 68);
            BtnPlus.TabIndex = 1;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = true;
            BtnPlus.Click += BtnOperation_Click;
            BtnPlus.KeyDown += OperationKey_Down;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(448, 109);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(79, 68);
            BtnRemove.TabIndex = 1;
            BtnRemove.Text = "<-";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            BtnRemove.KeyPress += RemoveKey_Press;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(448, 200);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(79, 68);
            BtnClear.TabIndex = 1;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            BtnClear.KeyPress += ClearPress_Key;
            // 
            // LabelShow
            // 
            LabelShow.BackColor = SystemColors.Window;
            LabelShow.Location = new Point(12, 26);
            LabelShow.Name = "LabelShow";
            LabelShow.Size = new Size(515, 62);
            LabelShow.TabIndex = 2;
            LabelShow.Text = "0";
            LabelShow.TextAlign = ContentAlignment.MiddleRight;
            LabelShow.Click += BtnNumber_Click;
            // 
            // BtnSignChange_Click
            // 
            BtnSignChange_Click.Location = new Point(448, 386);
            BtnSignChange_Click.Name = "BtnSignChange_Click";
            BtnSignChange_Click.Size = new Size(79, 68);
            BtnSignChange_Click.TabIndex = 1;
            BtnSignChange_Click.Text = "+/-";
            BtnSignChange_Click.UseVisualStyleBackColor = true;
            BtnSignChange_Click.Click += BtnSignChange_Click_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(557, 481);
            Controls.Add(LabelShow);
            Controls.Add(BtnClear);
            Controls.Add(BtnMultiply);
            Controls.Add(BtnFour);
            Controls.Add(BtnFive);
            Controls.Add(BtnSix);
            Controls.Add(BtnPlus);
            Controls.Add(BtnSignChange_Click);
            Controls.Add(BtnResult);
            Controls.Add(BtnSeven);
            Controls.Add(BtnEight);
            Controls.Add(BtnNine);
            Controls.Add(BtnRemove);
            Controls.Add(BtnDivide);
            Controls.Add(BtnDot);
            Controls.Add(BtnMinus);
            Controls.Add(BtnThree);
            Controls.Add(BtnTwo);
            Controls.Add(BtnOne);
            Controls.Add(BtnZero);
            MaximizeBox = false;
            Name = "Main";
            Text = "Main";
            KeyDown += OperationKey_Down;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnZero;
        private Button BtnOne;
        private Button BtnTwo;
        private Button BtnThree;
        private Button BtnMinus;
        private Button BtnDot;
        private Button BtnResult;
        private Button BtnDivide;
        private Button BtnSix;
        private Button BtnMultiply;
        private Button BtnNine;
        private Button BtnEight;
        private Button BtnFive;
        private Button BtnSeven;
        private Button BtnFour;
        private Button BtnPlus;
        private Button BtnRemove;
        private Button BtnClear;
        private Label LabelShow;
        private Button BtnSignChanger_Click;
        private Button BtnSignChange_Click;
    }
}