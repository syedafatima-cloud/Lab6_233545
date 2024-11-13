using System;
using System.Windows.Forms;
namespace CalculatorApp
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
        private void InitializeComponent()
        {
            lblResult = new Label();
            txtNumber1 = new TextBox();
            txtNumber2 = new TextBox();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            SuspendLayout();

            // lblResult
            lblResult.AutoSize = true;
            lblResult.Location = new Point(398, 277);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(49, 20);
            lblResult.TabIndex = 0;
            lblResult.Text = "Result";

            // txtNumber1
            txtNumber1.Location = new Point(362, 158);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new Size(125, 27);
            txtNumber1.TabIndex = 1;

            // txtNumber2
            txtNumber2.Location = new Point(362, 223);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new Size(125, 27);
            txtNumber2.TabIndex = 2;

            // btnAdd
            btnAdd.Location = new Point(95, 315);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new EventHandler(btnAdd_Click); // Wire the event handler

            // btnSubtract
            btnSubtract.Location = new Point(300, 315);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(94, 29);
            btnSubtract.TabIndex = 4;
            btnSubtract.Text = "Subtract";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += new EventHandler(btnSubtract_Click); // Wire the event handler

            // btnMultiply
            btnMultiply.Location = new Point(482, 315);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(94, 29);
            btnMultiply.TabIndex = 5;
            btnMultiply.Text = "Multiply";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += new EventHandler(btnMultiply_Click); // Wire the event handler

            // btnDivide
            btnDivide.Location = new Point(663, 315);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(94, 29);
            btnDivide.TabIndex = 6;
            btnDivide.Text = "Divide";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += new EventHandler(btnDivide_Click); // Wire the event handler

            // CalculatorForm
            ClientSize = new Size(922, 509);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lblResult);
            Name = "CalculatorForm"; // Ensure this matches the class name
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblResult;
        private TextBox txtNumber1;
        private TextBox txtNumber2;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
    }
}
