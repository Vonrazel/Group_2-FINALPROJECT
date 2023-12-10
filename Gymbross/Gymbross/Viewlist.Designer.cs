namespace Gymbross
{
    partial class Viewlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewlist));
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            display = new Button();
            delete = new Button();
            refresh = new Button();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(74, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(955, 280);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(319, 11);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(582, 43);
            textBox1.TabIndex = 1;
            // 
            // display
            // 
            display.BackgroundImage = (Image)resources.GetObject("display.BackgroundImage");
            display.BackgroundImageLayout = ImageLayout.Stretch;
            display.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            display.Location = new Point(1002, 6);
            display.Name = "display";
            display.Size = new Size(123, 53);
            display.TabIndex = 3;
            display.Text = "DISPLAY";
            display.UseVisualStyleBackColor = true;
            display.Click += display_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Transparent;
            delete.BackgroundImage = (Image)resources.GetObject("delete.BackgroundImage");
            delete.BackgroundImageLayout = ImageLayout.Stretch;
            delete.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete.ForeColor = SystemColors.ActiveCaptionText;
            delete.Location = new Point(907, 15);
            delete.Name = "delete";
            delete.Size = new Size(89, 38);
            delete.TabIndex = 4;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // refresh
            // 
            refresh.BackColor = Color.Transparent;
            refresh.BackgroundImage = (Image)resources.GetObject("refresh.BackgroundImage");
            refresh.BackgroundImageLayout = ImageLayout.Stretch;
            refresh.Location = new Point(156, 6);
            refresh.Name = "refresh";
            refresh.Size = new Size(58, 50);
            refresh.TabIndex = 5;
            refresh.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            search.BackColor = Color.Transparent;
            search.BackgroundImage = (Image)resources.GetObject("search.BackgroundImage");
            search.BackgroundImageLayout = ImageLayout.Zoom;
            search.Location = new Point(256, 10);
            search.Name = "search";
            search.Size = new Size(57, 43);
            search.TabIndex = 6;
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // Viewlist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(search);
            Controls.Add(refresh);
            Controls.Add(delete);
            Controls.Add(display);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "Viewlist";
            Size = new Size(1145, 541);
            Load += Viewlist_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button display;
        private Button delete;
        private Button refresh;
        private Button search;
    }
}
