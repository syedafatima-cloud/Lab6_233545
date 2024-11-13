using System;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public class ConverterForm : Form
    {
        private Label labelFahrenheit;
        private TextBox textBoxFahrenheit;
        private Label labelCelsius;
        private TextBox textBoxCelsius;
        private Button buttonCalculate;
        private Button buttonExit;

        public ConverterForm()
        {
            // Initialize components
            labelFahrenheit = new Label();
            textBoxFahrenheit = new TextBox();
            labelCelsius = new Label();
            textBoxCelsius = new TextBox();
            buttonCalculate = new Button();
            buttonExit = new Button();

            // Form settings
            this.Text = "Calculate Celsius";
            this.Size = new System.Drawing.Size(300, 200);

            // Fahrenheit Label
            labelFahrenheit.Text = "Fahrenheit:";
            labelFahrenheit.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(labelFahrenheit);

            // Fahrenheit TextBox
            textBoxFahrenheit.Location = new System.Drawing.Point(120, 20);
            this.Controls.Add(textBoxFahrenheit);

            // Celsius Label
            labelCelsius.Text = "Celsius:";
            labelCelsius.Location = new System.Drawing.Point(20, 60);
            this.Controls.Add(labelCelsius);

            // Celsius TextBox (read-only)
            textBoxCelsius.Location = new System.Drawing.Point(120, 60);
            textBoxCelsius.ReadOnly = true;
            this.Controls.Add(textBoxCelsius);

            // Calculate Button
            buttonCalculate.Text = "Calculate";
            buttonCalculate.Location = new System.Drawing.Point(20, 100);
            buttonCalculate.Click += new EventHandler(ButtonCalculate_Click);
            this.Controls.Add(buttonCalculate);

            // Exit Button
            buttonExit.Text = "Exit";
            buttonExit.Location = new System.Drawing.Point(120, 100);
            buttonExit.Click += new EventHandler(ButtonExit_Click);
            this.Controls.Add(buttonExit);
        }

        // Event handler for Calculate button
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = double.Parse(textBoxFahrenheit.Text);
                double celsius = (fahrenheit - 32) * 5 / 9;
                textBoxCelsius.Text = celsius.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Fahrenheit.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
