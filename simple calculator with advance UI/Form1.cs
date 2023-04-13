using System.Windows.Forms;

namespace simple_calculator_with_advance_UI
{
    public partial class Form1 : Form
    {
        double a1;
        double a2;
        double result;
        string op_view;
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lb_result.Text == "")
            {
                lb_result.Text = btn.Text;
                lb_calculator.Text =lb_calculator.Text + lb_result.Text;
                a1 = Convert.ToDouble(btn.Text);

            }
            else
            {
                //lb_calculator.Text = lb_calculator.Text + lb_result.Text;
                a1 = Convert.ToDouble(lb_result.Text);
                lb_calculator.Text = lb_calculator.Text + lb_result.Text;
                lb_result.Text = "";
                lb_result.Text = btn.Text;
                a2 = Convert.ToDouble(btn.Text);

            }
        }
        private void pro_click(object sender, EventArgs e)
        {
            Button btnOp = (Button)sender;
            op_view = btnOp.Text;
            //label1.Text = label1.Text + label2.Text;
            lb_calculator.Text = lb_calculator.Text + " " + op_view + " ";
            //lb_result.Text = "";
        }


        private void equ_click(object sender, EventArgs e)
        {
            //Button button = (Button)sender;

            switch (op_view)
            {
                case "+":
                    result = a1 + a2;
                    break;
                case "-":
                    result = a1 - a2;
                    break;
                case "/":
                    result = a2 / a2;
                    break;

                case "%":
                    result = a1 % a2;
                    break;

                default:
                    result = a1 * a2;
                    break;
            }

            if (a1 >= 0 && a2 >= 0)
            {
                lb_result.Text = "";
                lb_result.Text = Convert.ToString(result);
                lb_calculator.Text = lb_calculator.Text + " = " + lb_result.Text + " ...--> ";
            }
            else
                lb_result.Text = "first value or the second is empty!!! ";
        }

        private void delete_click(object sender, EventArgs e)
        {
            lb_result.Text = "";
        }
    }
}