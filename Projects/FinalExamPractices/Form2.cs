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

namespace FinalExamPractices
{
	public partial class Form2 : Form
	{
		string CONNECTION_STRING = "Data Source=localhost;Initial Catalog=exam_practices;Integrated Security=True; TrustServerCertificate=True";
		public Form2()
		{
			InitializeComponent();
		}

		private void btnGetByCity_Click(object sender, EventArgs e)
		{

			using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
			{
				string city = txtCity.Text;
				conn.Open();
				SqlCommand cmd = new SqlCommand("GetCharacterByCity", conn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@CityName",city);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable table = new DataTable();
				adapter.Fill(table);
				dataGridView1.DataSource = table;
				conn.Close();
			}
		}
	}
}
