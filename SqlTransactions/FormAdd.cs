using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlTransactions
{
	public partial class FormAdd : Form
	{

		public FormAdd()
		{
			InitializeComponent();
			
		}

		public void AddCustomer()
		{
			string customerId = txtCustomerID.Text;
			string companyName = txtCompanyName.Text;
			string customerName = txtCustomerName.Text;
			string customerTitle = txtCustomerTitle.Text;
			string address = txtAddress.Text;
			string city = txtCity.Text;
			string zone = txtZone.Text;
			string postalCode = txtPostalCode.Text;
			string country = txtCountry.Text;
			string phone = txtPhone.Text;
			string fax = txtFax.Text;


			string connectionString = "Data Source=localhost;Initial Catalog=Northwind;TrustServerCertificate=True;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			SqlCommand cmd = new SqlCommand("INSERT INTO Musteriler (MusteriID, SirketAdi, MusteriAdi, MusteriUnvani, Adres, Sehir, Bolge, PostaKodu, Ulke, Telefon, Faks) VALUES (@MusteriID, @SirketAdi, @MusteriAdi, @MusteriUnvani, @Adres, @Sehir, @Bolge, @PostaKodu, @Ulke, @Telefon, @Faks) ", connection);
			cmd.Parameters.AddWithValue("@MusteriID", customerId);
			cmd.Parameters.AddWithValue("@SirketAdi", companyName);
			cmd.Parameters.AddWithValue("@MusteriAdi", customerName);
			cmd.Parameters.AddWithValue("@MusteriUnvani", customerTitle);
			cmd.Parameters.AddWithValue("@Adres", address);
			cmd.Parameters.AddWithValue("@Sehir", city);
			cmd.Parameters.AddWithValue("@Bolge", zone);
			cmd.Parameters.AddWithValue("@PostaKodu", postalCode);
			cmd.Parameters.AddWithValue("@Ulke", country);
			cmd.Parameters.AddWithValue("@Telefon", phone);
			cmd.Parameters.AddWithValue("@Faks", fax);



			cmd.ExecuteNonQuery();
			connection.Close();
		}

		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			AddCustomer();
			DialogResult result = MessageBox.Show("Müşteri Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
