namespace simple_calculater
{
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(text1.Text);
            n2 = Convert.ToDouble(text2.Text);
            result = n1 + n2;
            resultBox.Text = Convert.ToString(result);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            n1 = Convert.ToDouble(text1.Text);
            n2 = Convert.ToDouble(text2.Text);
            result = n1 - n2;
            resultBox.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            n1 = Convert.ToDouble(text1.Text);
            n2 = Convert.ToDouble(text2.Text);
            result = n1 * n2;
            resultBox.Text = Convert.ToString(result);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            n1 = Convert.ToDouble(text1.Text);
            n2 = Convert.ToDouble(text2.Text);
            result = n1 / n2;
            resultBox.Text = Convert.ToString(result);
        }
    }
}