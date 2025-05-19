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
	public partial class FormDelete : Form
	{
		public void Delete()
		{
			string customerId = txtCustomerID.Text;
			string connectionString = "Data Source=.;Initial Catalog=Northwind;TrustServerCertificate=True;Integrated Security=True";
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();
			SqlCommand cmd = new SqlCommand("DELETE FROM Musteriler WHERE MusteriID=@MusteriID", connection);
			cmd.Parameters.AddWithValue("@MusteriID", customerId);
			cmd.ExecuteNonQuery();
			connection.Close();
		}
		
		public FormDelete()
		{
			InitializeComponent();
		}

		private void btnDelCustomer_Click(object sender, EventArgs e)
		{
			Delete();
			DialogResult result = MessageBox.Show("Müşteri Silindi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
