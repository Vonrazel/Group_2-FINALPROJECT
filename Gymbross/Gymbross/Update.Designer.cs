namespace Gymbross
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Palatino Linotype", 12F);
            button1.Location = new Point(329, 272);
            button1.Name = "button1";
            button1.Size = new Size(120, 46);
            button1.TabIndex = 0;
            button1.Text = "Name";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.Font = new Font("Palatino Linotype", 12F);
            button2.Location = new Point(466, 272);
            button2.Name = "button2";
            button2.Size = new Size(115, 46);
            button2.TabIndex = 1;
            button2.Text = "Age";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.Font = new Font("Palatino Linotype", 12F);
            button3.Location = new Point(599, 272);
            button3.Name = "button3";
            button3.Size = new Size(111, 46);
            button3.TabIndex = 2;
            button3.Text = "Gender";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.Font = new Font("Palatino Linotype", 12F);
            button4.Location = new Point(737, 272);
            button4.Name = "button4";
            button4.Size = new Size(106, 46);
            button4.TabIndex = 3;
            button4.Text = "Contact";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(661, 102);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(329, 100);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 37);
            textBox1.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Palatino Linotype", 12F);
            button5.Location = new Point(545, 388);
            button5.Name = "button5";
            button5.Size = new Size(113, 50);
            button5.TabIndex = 6;
            button5.Text = "Update";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 12F);
            label2.Location = new Point(708, 67);
            label2.Name = "label2";
            label2.Size = new Size(106, 27);
            label2.TabIndex = 7;
            label2.Text = "Old Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(367, 67);
            label3.Name = "label3";
            label3.Size = new Size(114, 27);
            label3.TabIndex = 8;
            label3.Text = "New Name";
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "Update";
            Size = new Size(1145, 541);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private TextBox textBox1;
        private Button button5;
        private Label label2;
        private Label label3;
    }
}
