using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ImportForm
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtUser.Text == "")
			{
				MessageBox.Show("Please provide UserName");
			}
			else if (txtPass.Text == "")
			{
				MessageBox.Show("Please provide Password");
			}
			else
			{
				//Create SqlConnection
				string cs = "initial catalog = LogManage; data source = LAPTOP-SRBQGE9I\\SQLEXPRESS07; integrated security = true";
				SqlConnection con = new SqlConnection(cs);
				SqlCommand cmd = new SqlCommand("Select * from Log where UserName=@username and Password=@password", con);
				cmd.Parameters.AddWithValue("@username", txtUser.Text);
				cmd.Parameters.AddWithValue("@password", txtPass.Text);
				con.Open();
				SqlDataAdapter adapt = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				adapt.Fill(ds);
				con.Close();
				int count = ds.Tables[0].Rows.Count;
				//If count is equal to 1, than show frmMain form
				if (count == 1)
				{
					MessageBox.Show("Login Successful!");
					this.Hide();
					Main fm = new Main();
					fm.Show();
				}
				else
				{
					MessageBox.Show("Login Failed!");
				}
			}
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
