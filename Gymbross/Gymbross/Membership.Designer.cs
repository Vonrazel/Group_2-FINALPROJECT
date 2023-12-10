namespace Gymbross
{
    partial class Membership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membership));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 12F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(484, 112);
            label1.Name = "label1";
            label1.Size = new Size(117, 27);
            label1.TabIndex = 0;
            label1.Text = "Member ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(471, 239);
            label2.Name = "label2";
            label2.Size = new Size(166, 30);
            label2.TabIndex = 1;
            label2.Text = "Membership type";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Red;
            textBox1.Font = new Font("Microsoft Sans Serif", 13.8F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(457, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(144, 34);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Red;
            textBox2.Font = new Font("Microsoft Sans Serif", 13.8F);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(457, 286);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 34);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Palatino Linotype", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(768, 21);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(144, 34);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Palatino Linotype", 12F);
            button1.Location = new Point(471, 471);
            button1.Name = "button1";
            button1.Size = new Size(128, 55);
            button1.TabIndex = 5;
            button1.Text = "DONE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Location = new Point(20, 19);
            button2.Name = "button2";
            button2.Size = new Size(57, 48);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(1024, 15);
            button3.Name = "button3";
            button3.Size = new Size(94, 48);
            button3.TabIndex = 7;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Membership
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Membership";
            Size = new Size(1145, 541);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
