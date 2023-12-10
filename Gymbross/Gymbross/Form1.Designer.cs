namespace Gymbross
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(489, 155);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Microsoft Sans Serif", 18F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(686, 308);
            button1.Name = "button1";
            button1.Size = new Size(134, 46);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 18F);
            textBox1.Location = new Point(650, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 41);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 18F);
            textBox2.Location = new Point(650, 233);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 41);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(489, 238);
            label2.Name = "label2";
            label2.Size = new Size(155, 36);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 508);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Location = new Point(716, 277);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(80, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ForgotPass";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(899, 500);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}
