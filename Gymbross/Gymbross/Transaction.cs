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
    public partial class Transaction : UserControl
    {
        public Transaction()
        {
            InitializeComponent();
            label4.Text = SharedVariable.total.ToString("N2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Error Pls Try again");
                return;
            }
            if (double.TryParse(textBox2.Text, out double amounth) && amounth > 0)
            {

                if (amounth >= SharedVariable.total)
                {

                    SharedVariable.amounth = amounth;
                    SharedVariable.Change = SharedVariable.amounth - SharedVariable.total;

                    Paymenthmethod payment = new Paymenthmethod();
                    this.Hide();
                    payment.Show();
                }
                else
                {
                    MessageBox.Show("Your payment is insufficient; please pay the exact amount.\" ");

                }



            }
            if (int.TryParse(textBox1.Text, out int id))
            {
                SharedVariable.memberidT = id;
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
