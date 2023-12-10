using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gymbross
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();

            Dashboard form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addmember form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Viewlist form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            Membership form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Transaction form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Dashboard form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PorgramPpl form = new();
            panel1.Controls.Clear();
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.BringToFront();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
