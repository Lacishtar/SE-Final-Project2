using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ImportForm
{
	public partial class Import : Form
	{
		SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
		public Import()
		{
			InitializeComponent();
			loadComboBoxProduct();
			loadDataGridView();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			int result;

			if (txtName.Text == "")
			{
				MessageBox.Show("Please insert product name");
			}
			else if (txtPrice.Text == "")
			{
				MessageBox.Show("Please insert product price");
			}
			else if (!int.TryParse(txtQuan.Text, out result))
			{
				MessageBox.Show("Please insert the number, not string!");
			}
			else
			{
				//Checked existed
				for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
				{
					String productName = dataGridView1.Rows[i].Cells["name"].Value.ToString();
					if (productName == txtName.Text)
					{
						MessageBox.Show("You have entered existed product! Please try again");
						return;
					}
				}

				//Create new product
				conn.Open();
				string query = "insert into products(name,quantity,price) values ('" + txtName.Text + "', '" + txtQuan.Text + "', '" + txtPrice.Text + "')";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.ExecuteNonQuery();
				conn.Close();
				loadComboBoxProduct();
				loadDataGridView();
			}
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			int result;
			int quan = -1;
			if(txtQuantity.Text != "" && int.TryParse(txtQuantity.Text, out result))
			{
				quan = int.Parse(txtQuantity.Text);
			}
			if (txtQuantity.Text == "")
			{
				MessageBox.Show("Plese insert the quantity!");
				return;
			}
			else if (!int.TryParse(txtQuantity.Text, out result))
			{
				MessageBox.Show("Please insert the number, not string!");
			}
			else if (quan <= 0)
			{
				MessageBox.Show("Please insert number larger than 0");
			}
			else
			{
				conn.Open();
				//Add to import
				String query = "insert into import(created_date) values ('" + DateTime.Today.ToShortDateString() + "')";
				SqlCommand cmd = new SqlCommand(query, conn);
				cmd.ExecuteNonQuery();

				//Get import id just inserted
				query = "select max(id) from import";
				cmd = new SqlCommand(query, conn);
				int idImport = (int)cmd.ExecuteScalar();

				//Get product id
				query = "select id from products where name = '" + cbProduct.Text + "'";
				cmd = new SqlCommand(query, conn);
				int idProduct = (int)cmd.ExecuteScalar();

				//Update Quantity
				query = "select quantity from products where id=" + idProduct.ToString();
				cmd = new SqlCommand(query, conn);
				int Quantity = (int)cmd.ExecuteScalar();

				Quantity += Int32.Parse(txtQuantity.Text);

				query = "update products set quantity=" + Quantity.ToString() + "where id=" + idProduct.ToString();
				cmd = new SqlCommand(query, conn);
				cmd.ExecuteNonQuery();

				//Add to import_detail
				query = "insert into import_detail(idImport, idProduct, quantity) values (" + idImport.ToString() + ", " + idProduct.ToString() + ", " + txtQuantity.Text + ")";
				cmd = new SqlCommand(query, conn);
				cmd.ExecuteNonQuery();

				MessageBox.Show("Added successfully");
				conn.Close();
				loadDataGridView();
			}
		}

		private void loadComboBoxProduct()
		{
			String query = "select * from products";
			SqlDataAdapter da = new SqlDataAdapter(query, conn);
			conn.Open();
			DataSet ds = new DataSet();
			da.Fill(ds);
			cbProduct.DataSource = ds.Tables[0];
			cbProduct.DisplayMember = "name";
			cbProduct.ValueMember = "id";
			conn.Close();
		}

		private void loadDataGridView()
		{
			String query = "select * from products";
			SqlDataAdapter da = new SqlDataAdapter(query, conn);
			conn.Open();
			DataSet ds = new DataSet();
			da.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			conn.Close();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || e.RowIndex == dataGridView1.Rows.Count - 1) return;
			cbProduct.SelectedIndex = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value - 1;
		}

		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			/*            if (e.RowIndex >= 0)
						{
							DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
							txtName.Text = row.Cells[1].Value.ToString();
						}*/
		}

		private void Import_Load(object sender, EventArgs e)
		{

		}
	}
}
