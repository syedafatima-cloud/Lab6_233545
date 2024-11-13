namespace CountdownApp
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
            components = new System.ComponentModel.Container();
            lblSetTime = new Label();
            numericUpDown = new NumericUpDown();
            btnStart = new Button();
            lblTimeLeft = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // lblSetTime
            // 
            lblSetTime.AutoSize = true;
            lblSetTime.Location = new Point(59, 64);
            lblSetTime.Name = "lblSetTime";
            lblSetTime.Size = new Size(67, 20);
            lblSetTime.TabIndex = 0;
            lblSetTime.Text = "Set Time";
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(186, 64);
            numericUpDown.Maximum = new decimal(new int[] { 3600, 0, 0, 0 });
            numericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(150, 27);
            numericUpDown.TabIndex = 1;
            numericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(242, 144);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.Location = new Point(59, 228);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(71, 20);
            lblTimeLeft.TabIndex = 3;
            lblTimeLeft.Text = "Time Left";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTimeLeft);
            Controls.Add(btnStart);
            Controls.Add(numericUpDown);
            Controls.Add(lblSetTime);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSetTime;
        private NumericUpDown numericUpDown;
        private Button btnStart;
        private Label lblTimeLeft;
        private System.Windows.Forms.Timer timer1;
    }
}
