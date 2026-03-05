namespace SharpPhone
{
    public partial class listPhones : Form
    {
        public listPhones()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmAddEdit = new frmAddEdit();
            frmAddEdit.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }
    }
}
