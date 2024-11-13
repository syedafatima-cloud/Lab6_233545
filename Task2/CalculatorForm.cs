using System;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class CalculatorForm : Form
    {
        private double _currentValue = 0;
        private string _currentOperation = string.Empty;

        public CalculatorForm()
        {
            InitializeComponent();
            WireUpEventHandlers();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            _currentValue = double.Parse(txtDisplay.Text);
            _currentOperation = button.Text;
            txtDisplay.Clear();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondValue = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (_currentOperation)
            {
                case "+":
                    result = _currentValue + secondValue;
                    break;
                case "-":
                    result = _currentValue - secondValue;
                    break;
                case "*":
                    result = _currentValue * secondValue;
                    break;
                case "/":
                    if (secondValue != 0)
                        result = _currentValue / secondValue;
                    else
                        MessageBox.Show("Cannot divide by zero");
                    break;
            }

            txtDisplay.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            _currentValue = 0;
            _currentOperation = string.Empty;
        }
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm());
        }
    }
    
}
