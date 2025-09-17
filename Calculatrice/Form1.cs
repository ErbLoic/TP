namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CalTotal;
        int num1 = 0;
        int num2 = 0;
        string option;
        int result;

        private void btn1_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "9";

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Total.Text = Total.Text + "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = Convert.ToInt32(Total.Text);

            Total.Clear();
        }

        private void moins_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = Convert.ToInt32(Total.Text);

            Total.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = Convert.ToInt32(Total.Text);

            Total.Clear();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = Convert.ToInt32(Total.Text);

            Total.Clear();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Total.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void egal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(Total.Text);
            if (option == "+")
            {
                result = num1 + num2;
            }
            else if (option == "-")
            {
                result = num1 - num2;
            }
            else if (option == "/")
            {
                result = num1 / num2;
            }
            else
            {
                result = num1 * num2;
            }
            CalTotal = Convert.ToString(result);
            Total.Text = CalTotal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
