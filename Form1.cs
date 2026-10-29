namespace software
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtnumberofbackage.Clear();
            listBox1.Items.Clear();
            txtpriceperpackage.Focus();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int packages;

            if (!int.TryParse(txtnumberofbackage.Text, out packages)
                || packages <= 0)
            {
                MessageBox.Show("Please enter a valid number!");
                return;
            }

            decimal price = 99.00m;
            decimal discountRate = 0m;

            if (packages >= 100) 
                discountRate = 0.50m;
            else if (packages >= 50)
                discountRate = 0.40m;
            else if (packages >= 20)
                discountRate = 0.30m;
            else if (packages >= 10)
                discountRate = 0.20m;

            decimal subtotal = packages * price;
            decimal discount = subtotal * discountRate;
            decimal total = subtotal + discount;
            listBox1.Items.Clear();

            listBox1.Items.Add("Software Sales Results");
            listBox1.Items.Add("Number of Packages: " + packages);
            listBox1.Items.Add("Price per package: $" + price.ToString("n2"));
            listBox1.Items.Add("Subtotal Before Discount: $" + subtotal.ToString("n2"));
            listBox1.Items.Add("Discount Amount: $" + discount.ToString());
            listBox1.Items.Add("Total Amount (After Discount): $" + total.ToString("n2"));
        }
    }
}
