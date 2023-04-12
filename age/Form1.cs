namespace age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox1.Text);
            age = 2023 - age;
            label1.Text = age.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}