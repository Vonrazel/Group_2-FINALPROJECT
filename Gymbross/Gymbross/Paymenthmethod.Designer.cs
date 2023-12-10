namespace Gymbross
{
    partial class Paymenthmethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paymenthmethod));
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(30, 94);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(250, 140);
            button1.TabIndex = 0;
            button1.Text = "Cash";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(336, 94);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(245, 140);
            button2.TabIndex = 1;
            button2.Text = "Gcash";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Paymenthmethod
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 350);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Paymenthmethod";
            Text = "Paymenthmethod";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}