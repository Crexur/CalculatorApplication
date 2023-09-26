namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        //jierelle was here
        private CalculatorClass cal;
        private double num1;
        private double num2;
        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBoxInput1.Text);
            num2 = Convert.ToDouble(textBoxInput2.Text);

            string ComboBoxSelector = cbOperator.SelectedItem.ToString();
            double result = 0;

            switch (ComboBoxSelector)
            {
                case "+":
                    result = cal.GetSum(num1, num2);
                    break;
                case "-":
                    result = cal.GetDifference(num1, num2);
                    break;
                case "*":
                    result = cal.GetProduct(num1, num2);
                    break;
                case "/":
                    result = cal.GetQuotient(num1, num2);
                    break;
                default:
                    MessageBox.Show("Invalid operator selected.");
                    return;
            }

            lbldisplay.Text = result.ToString();
        }
    }
}