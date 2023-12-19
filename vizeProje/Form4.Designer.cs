namespace vizeProje
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            button4 = new Button();
            listBox2 = new ListBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            button6 = new Button();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(565, 325);
            button5.Name = "button5";
            button5.Size = new Size(95, 40);
            button5.TabIndex = 13;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Location = new Point(545, 261);
            button4.Name = "button4";
            button4.Size = new Size(135, 55);
            button4.TabIndex = 12;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(450, 31);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(315, 404);
            listBox2.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(62, 305);
            button3.Name = "button3";
            button3.Size = new Size(156, 68);
            button3.TabIndex = 10;
            button3.Text = "Tatlı";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(62, 178);
            button2.Name = "button2";
            button2.Size = new Size(156, 68);
            button2.TabIndex = 9;
            button2.Text = "İçecek";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(62, 52);
            button1.Name = "button1";
            button1.Size = new Size(156, 73);
            button1.TabIndex = 8;
            button1.Text = "Ana Yemek";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(36, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(206, 444);
            listBox1.TabIndex = 7;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonFace;
            button6.Location = new Point(266, 178);
            button6.Name = "button6";
            button6.Size = new Size(156, 68);
            button6.TabIndex = 14;
            button6.Text = "Toplam";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(listBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
        }

        #endregion

        public Button button5;
        public Button button4;
        public ListBox listBox2;
        public Button button3;
        public Button button2;
        public Button button1;
        public ListBox listBox1;
        public Button button6;
    }
}