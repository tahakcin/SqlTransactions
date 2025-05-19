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

	public partial class Form1 : Form
	{
		string CONNECTION_STRING = "Data Source=localhost;Initial Catalog=exam_practices;Integrated Security=True; TrustServerCertificate=True";
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGet_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(CONNECTION_STRING)) {
				conn.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM TblCharacter;", conn);
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable table = new DataTable();
				adapter.Fill(table);
				dataGridView1.DataSource = table;
				conn.Close();
			}
		}

		private void btnGetByCity_Click(object sender, EventArgs e)
		{
			Form form = new Form2();
			form.ShowDialog();
		}

		private void btnDetails_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
			{
				conn.Open();
				SqlCommand cmd = new SqlCommand("GetCharacterDetails", conn);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				DataTable Table = new DataTable();
				adapter.Fill(Table);
				dataGridView1.DataSource = Table;
				conn.Close();
			}
		}

		private void btnOutlaws_Click(object sender, EventArgs e)
		{
			List<Character> characters = new List<Character>();
			using (SqlConnection conn = new SqlConnection(CONNECTION_STRING)) {
				conn.Open();
				SqlCommand cmd = new SqlCommand("GetOutlaws", conn);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read()) {
					characters.Add(new Character
					{
						CharacterID = reader.GetGuid(0),
						CharacterName = reader.GetString(1),
						CityName = reader.GetString(2),
						TypeName = reader.GetString(3),
						CrimeBounty = reader.GetInt32(4)
					});
				}
				reader.Close();
				dataGridView1.DataSource = characters;
				conn.Close();
			}
		}
	}
	public class Character
	{
		public Guid CharacterID { get; set; }
		public string CharacterName { get; set; }
		public string CityName { get; set; }
		public string TypeName { get; set; }
		public int CrimeBounty { get; set; }
	}
}
