namespace _2836373ClassExample1
{
    public partial class ClassEg1 : Form
    {
        public ClassEg1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            lblMessage1.Text = "Welcome to So Yum!" + txtName.Text;
            lblMessage2.Text = "You are assigned Table" + txtTableNo.Text;
        }

        private void ClassEg1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtTableNo.Text = "";
            lblMessage1.Text = "XXXXX";
            lblMessage2.Text = "XXXXX";
            txtName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}