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
    public partial class Addmember : UserControl
    {
        Backbone bac = new Backbone();

        public Addmember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SharedVariable.MemberName = txt1.Text;
            SharedVariable.PhoneNum = txt2.Text;
            SharedVariable.Age = txt3.Text;
            SharedVariable.Gender = txt5.Text;
            SharedVariable.coachid = int.Parse(txt6.Text);




            bac.AddMember(SharedVariable.MemberName, SharedVariable.PhoneNum, SharedVariable.Age, SharedVariable.Gender, SharedVariable.coachid);

            bac.refreshmem();

        }

        private void Addmember_Load(object sender, EventArgs e)
        {

        }

        private void txt5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
