using System;
using System.Windows.Forms;
namespace CalculatorForm
{
    partial class CalculatorForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btn0 = new Button();
            btnC = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnResult = new Button();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(24, 114);
            btn1.Name = "btn1";
            btn1.Size = new Size(69, 45);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(118, 114);
            btn2.Name = "btn2";
            btn2.Size = new Size(69, 45);
            btn2.TabIndex = 1;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(213, 114);
            btn3.Name = "btn3";
            btn3.Size = new Size(69, 45);
            btn3.TabIndex = 2;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(24, 178);
            btn4.Name = "btn4";
            btn4.Size = new Size(69, 45);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(118, 178);
            btn5.Name = "btn5";
            btn5.Size = new Size(69, 45);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(213, 178);
            btn6.Name = "btn6";
            btn6.Size = new Size(69, 45);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(24, 243);
            btn7.Name = "btn7";
            btn7.Size = new Size(69, 45);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(118, 243);
            btn8.Name = "btn8";
            btn8.Size = new Size(69, 45);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(213, 243);
            btn9.Name = "btn9";
            btn9.Size = new Size(69, 45);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            btn10.Location = new Point(24, 315);
            btn10.Name = "btn10";
            btn10.Size = new Size(69, 45);
            btn10.TabIndex = 9;
            btn10.Text = ".";
            btn10.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(118, 315);
            btn0.Name = "btn0";
            btn0.Size = new Size(69, 45);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(213, 315);
            btnC.Name = "btnC";
            btnC.Size = new Size(69, 45);
            btnC.TabIndex = 11;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(328, 114);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(69, 45);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(430, 114);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(69, 45);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(328, 178);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(69, 45);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(430, 178);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(69, 45);
            btnDivide.TabIndex = 15;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnResult
            // 
            btnResult.Location = new Point(328, 273);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(171, 87);
            btnResult.TabIndex = 16;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(24, 63);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(475, 27);
            txtDisplay.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDisplay);
            Controls.Add(btnResult);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btnC);
            Controls.Add(btn0);
            Controls.Add(btn10);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "CalculatorForm";
            Text = "CalculatorForm";
            ResumeLayout(false);
            PerformLayout();
        }
        private void WireUpEventHandlers()
        {
            // Wire up number buttons (0-9)
            btn0.Click += NumberButton_Click;
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;

            // Wire up operation buttons (+, -, *, /)
            btnAdd.Click += OperationButton_Click;
            btnSubtract.Click += OperationButton_Click;
            btnMultiply.Click += OperationButton_Click;
            btnDivide.Click += OperationButton_Click;

            // Wire up the equals button (=)
            btnResult.Click += btnEquals_Click;

            // Wire up the clear button (C)
            btnC.Click += btnClear_Click;
        }
        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btn0;
        private Button btnC;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnResult;
        private TextBox txtDisplay;
    }
}
