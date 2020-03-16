using System;
using System.Data;
namespace StoreApplication
{
    public partial class DeleteProducts : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GroceryStroreDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        public DeleteProducts()
        {
            InitializeComponent();
            BindDate();
        }
        private void BindDate()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].DisplayIndex = 0;
                dataGridView1.Columns["productName"].DisplayIndex = 1;
                dataGridView1.Columns["productCategory"].DisplayIndex = 2;
                dataGridView1.Columns["productCompany"].DisplayIndex = 3;
                dataGridView1.Columns["productPrice"].DisplayIndex = 4;
                dataGridView1.Columns["productQuantity"].DisplayIndex = 5;
                con.Close();
            }
        }
        private void Del_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE from Products WHERE productName= '" + proname.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully!!");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Products", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["id"].DisplayIndex = 0;
                dataGridView1.Columns["productName"].DisplayIndex = 1;
                dataGridView1.Columns["productCategory"].DisplayIndex = 2;
                dataGridView1.Columns["productCompany"].DisplayIndex = 3;
                dataGridView1.Columns["productPrice"].DisplayIndex = 4;
                dataGridView1.Columns["productQuantity"].DisplayIndex = 5;
                con.Close();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            proname.Text = "";
            pprice.Text = "";
            pquantity.Text = "";
            pcompany.Text = "";
            procategory.Text = "";
            BindDate();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products p = new Products();
            p.ShowDialog();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders o = new Orders();
            o.ShowDialog();
        }
    }
}