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
    public partial class Paymenthmethod : Form
    {
        Backbone bac = new Backbone();
        public Paymenthmethod()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gcash gcash = new Gcash();
            this.Close();
            gcash.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SharedVariable.Paymenthod = "Cash";

            bac.RefreshOther();
            bac.transaction();
        }
    }
}
