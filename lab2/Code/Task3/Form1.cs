namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int RecursiveFibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtFibonacciInput.Text);
            int result = RecursiveFibonacci(number);
            lblFibonacciResult.Text = $"Fibonacci({number}): {result}";
        }

        // ? Recursive Power Calculation (x^n)
        public int RecursivePower(int x, int n)
        {
            if (n == 0) return 1; // Base case: x^0 = 1
            return x * RecursivePower(x, n - 1);
        }

        private void btnCalculatePower_Click(object sender, EventArgs e)
        {
            int baseNumber = int.Parse(txtBase.Text);
            int exponent = int.Parse(txtExponent.Text);
            int result = RecursivePower(baseNumber, exponent);
            lblPowerResult.Text = $"{baseNumber}^{exponent} = {result}";
        }

    }
}
