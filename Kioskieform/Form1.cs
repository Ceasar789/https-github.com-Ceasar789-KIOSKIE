namespace Kioskieform
{
    public partial class KIOSKIEFORM : Form
    {
        public KIOSKIEFORM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void welcomelabel2_Click(object sender, EventArgs e)
        {

        }

        private void welcomebutton1_Click(object sender, EventArgs e)
        {
            KIOSKIEFORM2.KIOSKIEFORM2 form2 = new KIOSKIEFORM2.KIOSKIEFORM2();
            form2.Show();
            this.Hide();
        }

    }
}
