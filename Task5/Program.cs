using System;
using System.Windows.Forms;

namespace FactorialApp
{
    public class ConverterForm : Form
    {
        private Label lblNumber;
        private TextBox textBoxNumber;
        private Label lblFactorial;
        private TextBox textBoxFactorial;
        private Button btnCalculate;
        private Button btnExit;

        public ConverterForm()
        {
            // Initialize components
            lblNumber = new Label();
            textBoxNumber = new TextBox();
            lblFactorial = new Label();
            textBoxFactorial = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();

            // Form settings
            this.Text = "Calculate Factorial";
            this.Size = new System.Drawing.Size(300, 200);

            // Number Label
            lblNumber.Text = "Number:";
            lblNumber.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(lblNumber);

            // Number TextBox
            textBoxNumber.Location = new System.Drawing.Point(120, 20);
            this.Controls.Add(textBoxNumber);

            // Factorial Label
            lblFactorial.Text = "Factorial:";
            lblFactorial.Location = new System.Drawing.Point(20, 60);
            this.Controls.Add(lblFactorial);

            // Factorial TextBox (read-only)
            textBoxFactorial.Location = new System.Drawing.Point(120, 60);
            textBoxFactorial.ReadOnly = true;
            this.Controls.Add(textBoxFactorial);

            // Calculate Button
            btnCalculate.Text = "Calculate";
            btnCalculate.Location = new System.Drawing.Point(20, 100);
            btnCalculate.Click += new EventHandler(ButtonCalculateFactorial_Click);
            this.Controls.Add(btnCalculate);

            // Exit Button
            btnExit.Text = "Exit";
            btnExit.Location = new System.Drawing.Point(120, 100);
            btnExit.Click += new EventHandler(ButtonExit_Click);
            this.Controls.Add(btnExit);
        }

        // Event handler for Calculate button
        private void ButtonCalculateFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(textBoxNumber.Text);
                if (number < 0)
                {
                    MessageBox.Show("Please enter a non-negative integer for factorial calculation.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                long factorial = CalculateFactorial(number);
                textBoxFactorial.Text = factorial.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer for factorial calculation.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is too large to calculate factorial.", "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Factorial calculation function
        private long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Event handler for Exit button
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ConverterForm());
        }
    }
}
