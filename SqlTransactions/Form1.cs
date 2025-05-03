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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGetList_Click(object sender, EventArgs e)
		{
			ListCustomers();
		}

		public void ListCustomers()
		{
			//// --- with DataAdapter (Bağlantısız Mimari)---
			//string connectionString = "Data Source=localhost;Initial Catalog=Northwind;TrustServerCertificate=True;Integrated Security=True";
			//SqlConnection connection = new SqlConnection(connectionString);
			//connection.Open();
			//SqlDataAdapter da = new SqlDataAdapter("SELECT * from Musteriler", connection);
			//DataTable table = new DataTable();
			//da.Fill(table);
			//dataGridView1.DataSource = table;
			//connection.Close();

			// --- with DataReader (Bağlantılı Mimari)---
			string connectionString = "Data Source=.;Initial Catalog=Northwind;TrustServerCertificate=True;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT * from Musteriler", conn);
			SqlDataReader reader = cmd.ExecuteReader();
			DataTable table = new DataTable();
			table.Load(reader);
			dataGridView1.DataSource = table;
			conn.Close();



		}
		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			Form form = new FormAdd();
			form.ShowDialog();

		}

		private void btnDelCustomer_Click(object sender, EventArgs e)
		{
			Form form = new FormDelete();
			form.ShowDialog();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Form form = new FormEdit();
			form.ShowDialog();
		}
	}
}
