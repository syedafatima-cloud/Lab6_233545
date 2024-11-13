using System;
using System.Windows.Forms;

namespace CountdownApp
{
    public class CountdownForm : Form
    {
        private Label lblSetTime;
        private NumericUpDown numericUpDownTime;
        private Button btnStart;
        private Label lblTimeLeft;
        private System.Windows.Forms.Timer countdownTimer;
        private int timeLeft;

        public CountdownForm()
        {
            // Initialize components
            lblSetTime = new Label();
            numericUpDownTime = new NumericUpDown();
            btnStart = new Button();
            lblTimeLeft = new Label();
            countdownTimer = new System.Windows.Forms.Timer();

            // Form settings
            this.Text = "Time Span";
            this.Size = new System.Drawing.Size(400, 200);

            // Set Time Label
            lblSetTime.Text = "Set Time (seconds):";
            lblSetTime.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(lblSetTime);

            // NumericUpDown for time input
            numericUpDownTime.Location = new System.Drawing.Point(100, 20);
            numericUpDownTime.Minimum = 1;
            numericUpDownTime.Maximum = 3600; // Set maximum to 3600 seconds (1 hour)
            numericUpDownTime.Value = 1;      // Default value
            this.Controls.Add(numericUpDownTime);

            // Start Button
            btnStart.Text = "Quiz Start";
            btnStart.Location = new System.Drawing.Point(250, 20);
            btnStart.Click += new EventHandler(BtnStart_Click);
            this.Controls.Add(btnStart);

            // Time Left Label
            lblTimeLeft.Text = "Time Left: 0 Seconds.";
            lblTimeLeft.Font = new System.Drawing.Font("Arial", 14);
            lblTimeLeft.Location = new System.Drawing.Point(20, 80);
            lblTimeLeft.AutoSize = true;
            this.Controls.Add(lblTimeLeft);

            // Timer settings
            countdownTimer.Interval = 1000; // 1 second interval
            countdownTimer.Tick += new EventHandler(CountdownTimer_Tick);
        }

        // Event handler for Start button click
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // Set timeLeft to the value from numericUpDownTime
            timeLeft = (int)numericUpDownTime.Value;
            lblTimeLeft.Text = $"Time Left: {timeLeft} Seconds.";
            countdownTimer.Start();
        }

        // Event handler for Timer tick
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimeLeft.Text = $"Time Left: {timeLeft} Seconds.";
            }
            else
            {
                countdownTimer.Stop();
                MessageBox.Show("Time Over!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CountdownForm());
        }
    }
}
