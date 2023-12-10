namespace Gymbross
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backbone bac = new Backbone();

            if (int.TryParse(textBox1.Text, out int Username))
            {
                SharedVariable.Username = Username;
                SharedVariable.PassName = textBox2.Text.ToUpper();
                bac.Admin(SharedVariable.Username, SharedVariable.PassName);


            }
            else
            {

                // Handle the case where the input is not a valid integer
                MessageBox.Show("Invalid input for Username. Please enter a valid integer.");
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Admin 123, Passvon");
        }
    }
}
