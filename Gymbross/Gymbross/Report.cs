using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gymbross
{
    public partial class Report : UserControl
    {
        Backbone bac = new Backbone();
        public Report()
        {
            InitializeComponent();
            bac.CombinedReport(dataGridView1);

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Check if the clicked area is a row header
            string? Ridstring = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (int.TryParse(Ridstring, out var rid))
            {
                SharedVariable.Rid = rid;
            }
            else
            {

                SharedVariable.Rid = 0;


            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bac.DeleteRecord();
            SharedVariable.Rid = 0;
            bac.CombinedReport(dataGridView1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
