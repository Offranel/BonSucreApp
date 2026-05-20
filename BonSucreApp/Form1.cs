using BonSucreApp.DB;
using BonSucreApp.Models;

namespace BonSucreApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadCustomers();
            LoadDesserts();
        }
        private void LoadCustomers()
        {
            List<Customer> customers = CustomerDB.GetAllCustomers();

            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "Name";

        }
        private void LoadDesserts()
        {
            List<Desert> desserts = DessertDB.GetAllDesserts();
            cboDessert.DataSource = desserts;
            cboDessert.DisplayMember = "Name";
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            Review review = new Review();
            review.CustomerId = ((Customer)cmbCustomer.SelectedItem).CustomerId;
            review.DessertId = ((Desert)cboDessert.SelectedItem).DessertId;
            review.Score = Convert.ToInt32(txtReviewScore.Text);
            ReviewDB.AddReview(review);
            MessageBox.Show("Review Added!");
            txtReviewScore.Text = "";

        }
    }
}
