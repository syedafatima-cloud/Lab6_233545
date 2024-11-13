using System;
using System.Windows.Forms;

namespace SquareCalculatorApp
{
    public partial class SquareCalculatorForm : Form
    {
        public SquareCalculatorForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.listBoxSquares = new ListBox();
            this.btnCalculate = new Button();
            this.SuspendLayout();

            // 
            // listBoxSquares
            // 
            this.listBoxSquares.FormattingEnabled = true;
            this.listBoxSquares.ItemHeight = 20;
            this.listBoxSquares.Location = new System.Drawing.Point(12, 12);
            this.listBoxSquares.Name = "listBoxSquares";
            this.listBoxSquares.Size = new System.Drawing.Size(260, 224);
            this.listBoxSquares.TabIndex = 0;

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(90, 250);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new EventHandler(this.BtnCalculate_Click);

            // 
            // SquareCalculatorForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 300);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.listBoxSquares);
            this.Name = "SquareCalculatorForm";
            this.Text = "Square Calculator";
            this.ResumeLayout(false);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalculateSquares();
        }

        private void CalculateSquares()
        {
            listBoxSquares.Items.Clear(); // Clear any previous results
            for (int i = 1; i <= 10; i++)
            {
                int square = i * i;
                listBoxSquares.Items.Add($"{i}\t{square}");
            }
        }

        private ListBox listBoxSquares;
        private Button btnCalculate;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SquareCalculatorForm());
        }
    }
}
