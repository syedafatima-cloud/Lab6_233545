using System;
using System.Windows.Forms;
namespace CalculatorApp
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }
        

        // Function for addition
        private double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Function for subtraction
        private double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Function for multiplication
        private double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Function for division
        private double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                MessageBox.Show("Division by zero is not allowed.");
                return 0;
            }
            return num1 / num2;
        }

        // Event handler for addition
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformCalculation(Add);
        }

        // Event handler for subtraction
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformCalculation(Subtract);
        }

        // Event handler for multiplication
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformCalculation(Multiply);
        }

        // Event handler for division
        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformCalculation(Divide);
        }

        // Method to perform the calculation
        private void PerformCalculation(Func<double, double, double> operation)
        {
            double num1, num2;
            bool isNum1Valid = double.TryParse(txtNumber1.Text, out num1);
            bool isNum2Valid = double.TryParse(txtNumber2.Text, out num2);

            if (!isNum1Valid || !isNum2Valid)
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            double result = operation(num1, num2);
            lblResult.Text = "Result: " + result.ToString();
        }
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CalculatorForm());
        }

    }
}
