namespace WinFormsApp1
{

    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();

            new Form4().Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

            new Form2().Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

            new Form3().Show();

        }

    }

}
