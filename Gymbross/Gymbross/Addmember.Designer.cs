namespace Gymbross
{
    partial class Addmember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addmember));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt5 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            txt6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(236, 64);
            label1.Name = "label1";
            label1.Size = new Size(177, 43);
            label1.TabIndex = 0;
            label1.Text = "Member Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(533, 70);
            label2.Name = "label2";
            label2.Size = new Size(138, 29);
            label2.TabIndex = 1;
            label2.Text = "Contact No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(899, 71);
            label3.Name = "label3";
            label3.Size = new Size(62, 29);
            label3.TabIndex = 2;
            label3.Text = "Age:";
            label3.Click += label3_Click;
            // 
            // txt5
            // 
            txt5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt5.FormattingEnabled = true;
            txt5.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txt5.Location = new Point(345, 261);
            txt5.Name = "txt5";
            txt5.Size = new Size(149, 33);
            txt5.TabIndex = 3;
            txt5.SelectedIndexChanged += txt5_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(371, 220);
            label4.Name = "label4";
            label4.Size = new Size(100, 29);
            label4.TabIndex = 4;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F);
            label5.ForeColor = Color.DarkRed;
            label5.Location = new Point(716, 226);
            label5.Name = "label5";
            label5.Size = new Size(88, 29);
            label5.TabIndex = 5;
            label5.Text = "Coach:";
            // 
            // txt1
            // 
            txt1.Font = new Font("Microsoft Sans Serif", 13.8F);
            txt1.Location = new Point(206, 109);
            txt1.Multiline = true;
            txt1.Name = "txt1";
            txt1.Size = new Size(152, 39);
            txt1.TabIndex = 6;
            txt1.TextChanged += txt1_TextChanged;
            // 
            // txt2
            // 
            txt2.Font = new Font("Microsoft Sans Serif", 13.8F);
            txt2.Location = new Point(525, 114);
            txt2.Multiline = true;
            txt2.Name = "txt2";
            txt2.Size = new Size(146, 34);
            txt2.TabIndex = 7;
            // 
            // txt3
            // 
            txt3.Font = new Font("Microsoft Sans Serif", 13.8F);
            txt3.Location = new Point(844, 110);
            txt3.Multiline = true;
            txt3.Name = "txt3";
            txt3.Size = new Size(152, 38);
            txt3.TabIndex = 8;
            txt3.TextChanged += txt3_TextChanged;
            // 
            // txt6
            // 
            txt6.Font = new Font("Microsoft Sans Serif", 13.8F);
            txt6.Location = new Point(675, 265);
            txt6.Name = "txt6";
            txt6.Size = new Size(158, 34);
            txt6.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F);
            button1.ForeColor = Color.DarkRed;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(533, 396);
            button1.Name = "button1";
            button1.Size = new Size(138, 77);
            button1.TabIndex = 10;
            button1.Text = "DONE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Addmember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(button1);
            Controls.Add(txt6);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Addmember";
            Size = new Size(1145, 541);
            Load += Addmember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox txt5;
        private Label label4;
        private Label label5;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private TextBox txt6;
        private Button button1;
    }
}
