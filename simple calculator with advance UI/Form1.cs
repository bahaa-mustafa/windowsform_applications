using System.Windows.Forms;

namespace simple_calculator_with_advance_UI
{
    public partial class Form1 : Form
    {
        double a1;
        double a2;
        double result;
        string op_view = "";
        public Form1()
        {
            InitializeComponent();
        }



        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // not accept code

            /*  if (lb_result.Text == "")
              {
                 // lb_result.Text = btn.Text;
                 // lb_calculator.Text =lb_calculator.Text + lb_result.Text;
                  a1 = Convert.ToDouble(btn.Text);

              }
              else
              {
                 // lb_calculator.Text = lb_calculator.Text + lb_result.Text;
                  a1 = Convert.ToDouble(lb_result.Text);
                  lb_result.Text = "";
                 // lb_result.Text = btn.Text;
                  a2 = Convert.ToDouble(btn.Text);
                 // lb_calculator.Text = lb_calculator.Text + lb_result.Text;
              }
            */

            // anthor trying
            
            lb_result.Text = lb_result.Text + btn.Text;
            if(op_view=="")
            {
                a1 = Convert.ToDouble(lb_result.Text);

            }
            else
            {
                
                a2 = Convert.ToDouble(lb_result.Text);
               // lb_calculator.Text = lb_calculator.Text + lb_result.Text;
            }


        }
        private void pro_click(object sender, EventArgs e)
        {
            Button btnOp = (Button)sender;
            op_view = btnOp.Text;

            //label1.Text = label1.Text + label2.Text;
           // a1 = Convert.ToDouble(lb_result.Text);
            
            lb_calculator.Text = lb_result.Text + " " + op_view + " ";
            lb_result.Text = "";
        }


        private void equ_click(object sender, EventArgs e)
        {
            //Button button = (Button)sender;

            switch (op_view)
            {
                case "+":
                    result = a1 + a2;
                    op_view = "";
                    break;
                case "-":
                    result = a1 - a2;
                    op_view = "";
                    break;
                case "/":
                    result = a1 / a2;
                    op_view = "";
                    break;

                case "%":
                    result = a1 % a2;
                    op_view = "";
                    break;

                default:
                    result = a1 * a2;
                    op_view = "";
                    break;
            }

            lb_calculator.Text = lb_calculator.Text + lb_result.Text;

            lb_result.Text = "";
            lb_result.Text = Convert.ToString(result);
            lb_calculator.Text = lb_calculator.Text + " = " + lb_result.Text ;
        }

        private void delete_click(object sender, EventArgs e)
        {
            lb_result.Text = "";
            lb_calculator.Text = "";
        }
    }
}