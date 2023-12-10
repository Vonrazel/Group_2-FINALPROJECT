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
    public partial class MemberShipView : Form
    {
        Backbone bac = new Backbone();
        public MemberShipView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SharedVariable.SearchM = textBox1.Text;
            bac.RefreshMembership();
            bac.ViewlistMembership(SharedVariable.SearchM, dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bac.RefreshMembership();
            bac.DisplayMembershipData(dataGridView1);

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the value in the first cell of the clicked row (assuming it's the membername)

                SharedVariable.SearchM = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                // Call the delete method

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void MemberShipView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Membership membership = new Membership();
            this.Close();
            membership.Show();
        }
    }
}
