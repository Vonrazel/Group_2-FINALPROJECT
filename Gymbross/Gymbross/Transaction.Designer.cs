namespace Gymbross
{
    partial class Transaction
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 12F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(569, 83);
            label1.Name = "label1";
            label1.Size = new Size(113, 27);
            label1.TabIndex = 0;
            label1.Text = "Member Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 12F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(874, 88);
            label2.Name = "label2";
            label2.Size = new Size(88, 27);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 12F);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(755, 252);
            label3.Name = "label3";
            label3.Size = new Size(163, 43);
            label3.TabIndex = 2;
            label3.Text = "Total Amount";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 13.8F);
            textBox1.Location = new Point(543, 120);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 38);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 13.8F);
            textBox2.Location = new Point(841, 120);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 40);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(742, 284);
            label4.Name = "label4";
            label4.Size = new Size(125, 38);
            label4.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Palatino Linotype", 12F);
            button1.Location = new Point(707, 444);
            button1.Name = "button1";
            button1.Size = new Size(160, 65);
            button1.TabIndex = 6;
            button1.Text = "PAY NOW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Transaction";
            Size = new Size(1145, 541);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
    }
}
