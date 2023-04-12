namespace simple_calculater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            text1 = new TextBox();
            label2 = new Label();
            text2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            resultBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Wide Latin", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(46, 57);
            label1.Name = "label1";
            label1.Size = new Size(91, 18);
            label1.TabIndex = 0;
            label1.Text = "num: 1";
            // 
            // text1
            // 
            text1.Location = new Point(46, 94);
            text1.Name = "text1";
            text1.Size = new Size(91, 27);
            text1.TabIndex = 1;
            text1.TextAlign = HorizontalAlignment.Center;
            text1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Wide Latin", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(249, 57);
            label2.Name = "label2";
            label2.Size = new Size(95, 18);
            label2.TabIndex = 0;
            label2.Text = "num: 2";
            label2.Click += label2_Click;
            // 
            // text2
            // 
            text2.Location = new Point(249, 94);
            text2.Name = "text2";
            text2.Size = new Size(95, 27);
            text2.TabIndex = 1;
            text2.TextAlign = HorizontalAlignment.Center;
            text2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(79, 197);
            button1.Name = "button1";
            button1.Size = new Size(40, 35);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(145, 197);
            button2.Name = "button2";
            button2.Size = new Size(40, 35);
            button2.TabIndex = 2;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(211, 197);
            button3.Name = "button3";
            button3.Size = new Size(40, 35);
            button3.TabIndex = 2;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(277, 197);
            button4.Name = "button4";
            button4.Size = new Size(40, 35);
            button4.TabIndex = 2;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Wide Latin", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(95, 345);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 0;
            label3.Text = "result:";
            label3.Click += label2_Click;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(211, 340);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(95, 27);
            resultBox.TabIndex = 1;
            resultBox.TextAlign = HorizontalAlignment.Center;
            resultBox.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 534);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(resultBox);
            Controls.Add(label3);
            Controls.Add(text2);
            Controls.Add(label2);
            Controls.Add(text1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox text1;
        private Label label2;
        private TextBox text2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private TextBox resultBox;
    }
}