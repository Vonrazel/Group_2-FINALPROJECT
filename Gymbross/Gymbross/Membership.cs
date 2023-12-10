using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gymbross
{
    public partial class Membership : UserControl
    {
        Backbone bac = new Backbone();
        public Membership()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberShipView memberShipview = new MemberShipView();

            memberShipview.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SharedVariable.MemId = int.Parse(textBox1.Text);
            SharedVariable.Membershiptye = textBox2.Text;

            // Assuming Value is a DateTimePicker control
            SharedVariable.Enddate = dateTimePicker1.Value;



            bac.Membership(SharedVariable.MemId, SharedVariable.Membershiptye, SharedVariable.Enddate);
            bac.refreshmemberships();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
