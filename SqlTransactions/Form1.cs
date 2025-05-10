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
		string CONNECTION_STRİNG = "Data Source=.;Initial Catalog=Northwind;TrustServerCertificate=True;Integrated Security=True";
		DataTable table;
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
			//string CONNECTION_STRİNG = "Data Source=localhost;Initial Catalog=Northwind;TrustServerCertificate=True;Integrated Security=True";
			//SqlConnection connection = new SqlConnection(CONNECTION_STRİNG);
			//connection.Open();
			//SqlDataAdapter da = new SqlDataAdapter("SELECT * from Musteriler", connection);
			//DataTable table = new DataTable();
			//da.Fill(table);
			//dataGridView1.DataSource = table;
			//connection.Close();

			// --- with DataReader (Bağlantılı Mimari)---
			SqlConnection conn = new SqlConnection(CONNECTION_STRİNG);
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT * from Musteriler", conn);
			SqlDataReader reader = cmd.ExecuteReader();
			table = new DataTable();
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

		
		private void btnFilter_Click(object sender, EventArgs e)
		{
			// with Language Integrated Query (LINQ)
			var filteredText = txtFilter.Text.Trim();
			if (!string.IsNullOrEmpty(filteredText) && table != null) {

				var filteredRows = table.AsEnumerable()
					.Where(row => table.Columns.Cast<DataColumn>().
					Any(col => row[col].ToString().ToLower().Contains(filteredText.ToLower())))
					.ToList();
				if (filteredRows.Count() > 0)
				{
					var filteredTable = filteredRows.CopyToDataTable();
					dataGridView1.DataSource = filteredTable;
				}
				else { 
					DialogResult result = MessageBox.Show("Aradığınız kriterlere uygun veri bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					dataGridView1.DataSource = table;
					txtFilter.Clear();
				}
			} else {
				DialogResult result = MessageBox.Show("Lütfen filtreleme kriteri giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			

			/*
			var filteredText = txtFilter.Text.Trim();
			if (!string.IsNullOrEmpty(filteredText) && table != null) {
				string filterExpression = "";
				foreach (DataColumn column in table.Columns) {
					if (column.DataType == typeof(string)) {
						if (!string.IsNullOrEmpty(filterExpression)) {
							filterExpression += " OR ";
						}
						filterExpression += $"{column.ColumnName} LIKE '%{filteredText}%'";
					}
				}
				table.DefaultView.RowFilter = filterExpression;
			}
			else {
				table.DefaultView.RowFilter = "";
			}
			*/
		}
	}
}
