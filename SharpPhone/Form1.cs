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
            SmartPhone newPhone = new SmartPhone(1, "Google", "Pixel 4", 256000, 499.99m);
            
            List<SmartPhone> phones = new List<SmartPhone>();
            phones.Add(new SmartPhone(2, "Apple", "iPhone 12", 128000, 799.99m));

            foreach (SmartPhone phone in phones)
                {
                    MessageBox.Show(phone.Brand);
            } 

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
