namespace TemperatureConverter
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
            labelFahrenheit = new Label();
            labelCelcius = new Label();
            textBoxFahrenhiet = new TextBox();
            textBoxCelcius = new TextBox();
            buttonCalculate = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelFahrenheit
            // 
            labelFahrenheit.AutoSize = true;
            labelFahrenheit.Location = new Point(107, 113);
            labelFahrenheit.Name = "labelFahrenheit";
            labelFahrenheit.Size = new Size(77, 20);
            labelFahrenheit.TabIndex = 0;
            labelFahrenheit.Text = "Fahrenheit";
            // 
            // labelCelcius
            // 
            labelCelcius.AutoSize = true;
            labelCelcius.Location = new Point(107, 179);
            labelCelcius.Name = "labelCelcius";
            labelCelcius.Size = new Size(55, 20);
            labelCelcius.TabIndex = 1;
            labelCelcius.Text = "Celcius";
            // 
            // textBoxFahrenhiet
            // 
            textBoxFahrenhiet.Location = new Point(250, 110);
            textBoxFahrenhiet.Name = "textBoxFahrenhiet";
            textBoxFahrenhiet.Size = new Size(125, 27);
            textBoxFahrenhiet.TabIndex = 2;
            // 
            // textBoxCelcius
            // 
            textBoxCelcius.Location = new Point(250, 179);
            textBoxCelcius.Name = "textBoxCelcius";
            textBoxCelcius.Size = new Size(125, 27);
            textBoxCelcius.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            buttonCalculate.FlatStyle = FlatStyle.Popup;
            buttonCalculate.Location = new Point(155, 278);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(281, 278);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxCelcius);
            Controls.Add(textBoxFahrenhiet);
            Controls.Add(labelCelcius);
            Controls.Add(labelFahrenheit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFahrenheit;
        private Label labelCelcius;
        private TextBox textBoxFahrenhiet;
        private TextBox textBoxCelcius;
        private Button buttonCalculate;
        private Button buttonExit;
    }
}
