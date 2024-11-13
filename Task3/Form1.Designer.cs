namespace CalculatorSquareApp
{
    partial class Form1
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
            listBoxSquares = new ListBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // listBoxSquares
            // 
            listBoxSquares.FormattingEnabled = true;
            listBoxSquares.Location = new Point(328, 44);
            listBoxSquares.Name = "listBoxSquares";
            listBoxSquares.Size = new Size(150, 104);
            listBoxSquares.TabIndex = 0;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(354, 181);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculate);
            Controls.Add(listBoxSquares);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxSquares;
        private Button btnCalculate;
    }
}
