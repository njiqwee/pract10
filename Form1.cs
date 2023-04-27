using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml;
using System.Data.OleDb;
using System.Xml.Linq;

namespace pract10
{
	public partial class Form1 : Form
	{
		private SQLiteConnection sqlConn;
		private SQLiteCommand sqlCmd;
		private DataTable sqlDT = new DataTable();
		private DataSet DS = new DataSet();
		private SQLiteDataAdapter DB;
		public int selectedRow; 
		public Form1()
		{
			InitializeComponent();
			upLoadData();
		}

		private void SetConnectDB()
		{
			sqlConn= new SQLiteConnection("Data source = C:\\Users\\Mortimer\\Desktop\\оопсасат\\pract10\\bin\\Debug\\details.db");
		}
		private void ExecuteQuery(string QueryData)
		{
			SetConnectDB();
			sqlConn.Open();
			sqlCmd = sqlConn.CreateCommand();
			sqlCmd.CommandText = QueryData;
			sqlCmd.ExecuteNonQuery();
			sqlCmd.Dispose();
			sqlConn.Close();
		}
		private void upLoadData()
		{
			SetConnectDB();
			sqlConn.Open();
			sqlCmd = sqlConn.CreateCommand();
			string CommandText = "select * from details";
			DB = new SQLiteDataAdapter(CommandText, sqlConn);
			DS.Reset();
			DB.Fill(DS);
			sqlDT = DS.Tables[0];
			dataGridView1.DataSource= sqlDT;
			sqlConn.Close();
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			string QueryData = "insert into details(Firstname, Lastname) values ('"+
				textBoxFN.Text + "','" + textBoxLN.Text + "')";
			ExecuteQuery(QueryData);
			upLoadData();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			ExecuteQuery("DELETE FROM details WHERE ID = '" + textBoxIDDelete.Text + "'");
			upLoadData();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			if(sqlConn.State == ConnectionState.Closed)
			{
				sqlConn.Open();
			}
			using (SQLiteDataAdapter DB = new SQLiteDataAdapter("Select * from details", sqlConn))
			{
				DataTable sqlDT = new DataTable("Firstname");
				DB.Fill(sqlDT);
				dataGridView1.DataSource= sqlDT;
			}
		}

		private void textBoxS_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == (Char)13)
			{
				DataView dv = sqlDT.DefaultView;
				dv.RowFilter = string.Format("Firstname like '%{0}%'", textBoxS.Text);
				dataGridView1.DataSource= dv.ToTable();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				textBoxFN.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				textBoxLN.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Data entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}

	public class Person
	{
		public static int ID;
		public string Firstname;
		public string Lastname;
		public int getID()
		{
			return ID;
		}
	}
}
