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
    public partial class Update : UserControl
    {
        Backbone bac = new Backbone();
        int updated = 0;
        public Update()
        {
            InitializeComponent();
            bac.Retriveshet();

        }





        private void button5_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                // error
                return;
            }
            else
            {
                if (updated == 1)
                {
                    bac.Updatename(textBox1.Text);

                }
                else if (updated == 2)
                {

                    bac.UpdateAge(textBox1.Text);
                }
                else if (updated == 3)
                {
                    bac.UpdateGender(textBox1.Text);
                }
                else if (updated == 4)
                {
                    bac.UpdateContact(textBox1.Text);
                }
                else
                {
                    
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = $"{SharedVariable.MembernameD}";
            updated = 1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Text = $"{SharedVariable.AgenameD}";
            updated = 2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Text = $"{SharedVariable.GenderD}";
            updated = 3;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label1.Text = $"{SharedVariable.contactinfo}";
            updated = 4;
        }
    }
}
