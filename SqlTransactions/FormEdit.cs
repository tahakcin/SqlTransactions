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
	public partial class FormEdit : Form
	{
		public void Edit(string customerId, string updatedColumn, string newData)
		{
			string connectionString = "Data Source=.;Initial Catalog=Northwind;TrustServerCertificate=True;Integrated Security=True";
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();
			SqlCommand cmd = new SqlCommand("EditById__Musteriler", conn);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@ID",customerId);
			cmd.Parameters.AddWithValue("@COLUMN", updatedColumn);
			cmd.Parameters.AddWithValue("@NEW_DATA", newData);
			cmd.ExecuteNonQuery();
			conn.Close();
		}
		public FormEdit()
		{
			InitializeComponent();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string id = txtCustomerID.Text;
			string column = txtUpdateCol.Text;
			string data = txtNewData.Text;
			Edit(id, column, data);
			DialogResult result = MessageBox.Show("Veri Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}


		
	}
}
