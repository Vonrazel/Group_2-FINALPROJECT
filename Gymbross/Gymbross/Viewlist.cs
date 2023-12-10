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
    public partial class Viewlist : UserControl
    {
        Backbone bac = new Backbone();
        public Viewlist()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;

        }



        private void update_Click(object sender, EventArgs e)
        {
            if (SharedVariable.memid == 0)
            {
                 
            }
            else
            {
              Update update = new Update();

               update.Show();

            }
        }

        private void Viewlist_Load(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            SharedVariable.Search = textBox1.Text;

            bac.ViewList(SharedVariable.Search, dataGridView1);

        }

        private void display_Click(object sender, EventArgs e)
        {


            bac.DisplayMemberData(dataGridView1);
            bac.RefreshDataGridView(dataGridView1);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            bac.Delete();
            bac.RefreshForDisplay(dataGridView1);
            bac.DisplayMemberData(dataGridView1);
            SharedVariable.memid = 0;
        }
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Check if the clicked area is a row header
            if (e.RowIndex >= 0)
            {
                // Get the value in the first cell of the clicked row (assuming it's the membername)

                SharedVariable.MembernameD = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                // Call the delete method

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string? memidstring = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (int.TryParse(memidstring, out var memid))
            {
                SharedVariable.memid = memid;
            }
            else
            {

                SharedVariable.memid = 0;


            }
        }
    }
}
