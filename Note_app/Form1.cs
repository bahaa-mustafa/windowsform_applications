using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Note_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void save_click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Text File|*.txt";
            dialog.FileName = Path.GetFileName(dialog.FileName);
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, richTextBox1.Text);
            }
        }

        private void open_click(object sender, EventArgs e)
        {
            var dial = new OpenFileDialog();
            // dial.Filter = "File Text|*.txt";
            dial.FileName = Path.GetFileName(dial.FileName);

            // dial.FileName = "Txt" + ".txt";
            var result = dial.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(dial.FileName);
            }
        }

        private void copy_click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void past_click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + Clipboard.GetText();

        }

        private void print_click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog(this);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, new PointF(100, 100));
        }

        private void delet_cut_click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.SelectedText = "";
        }

        private void font_click(object sender, EventArgs e)
        {
            var fontdialog = new FontDialog();

            var result = fontdialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                richTextBox1.Font = fontdialog.Font;
            }
        }

        private void bold_click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void underLine_click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font,FontStyle.Underline);
        }
    }
}