using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ImportForm
{
	public partial class Export : Form
	{
		SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
		String indexOrder;
		String indexAgent;

		public Export()
		{
			InitializeComponent();
			loadDataGridView();
		}

		private void loadDataGridView()
		{
			String query = "select * from agent";
			SqlDataAdapter da = new SqlDataAdapter(query, conn);
			conn.Open();
			DataSet ds = new DataSet();
			da.Fill(ds);
			dataGridViewAgent.DataSource = ds.Tables[0];
			conn.Close();
		}

		private void dataGridViewAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1) return;
			txtAgent.Text = dataGridViewAgent.Rows[e.RowIndex].Cells["agent_name"].Value.ToString();
			txtAddress.Text = dataGridViewAgent.Rows[e.RowIndex].Cells["address"].Value.ToString();
			txtPhone.Text = dataGridViewAgent.Rows[e.RowIndex].Cells["phone"].Value.ToString();
			if (e.RowIndex < dataGridViewAgent.RowCount - 1)
			{
				dataGridViewOrderLoad(dataGridViewAgent.Rows[e.RowIndex].Cells["id"].Value.ToString());
			}

		}

		private void dataGridViewOrderLoad(String idAgent)
		{
			indexAgent = idAgent;
			String query = "select * from order_product where agentId=" + idAgent;
			SqlDataAdapter da = new SqlDataAdapter(query, conn);
			conn.Open();
			DataSet ds = new DataSet();
			if (ds != null)
			{
				da.Fill(ds);
				dataGridViewOrders.DataSource = ds.Tables[0];

			}
			conn.Close();
		}

		private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1 || e.RowIndex == dataGridViewOrders.Rows.Count - 1) return;
			indexOrder = dataGridViewOrders.Rows[e.RowIndex].Cells["id"].Value.ToString();
			if (e.RowIndex == -1) return;
			DateTime dt = (DateTime)dataGridViewOrders.Rows[e.RowIndex].Cells["orderDate"].Value;
			txtOrderDate.Text = dt.ToShortDateString();
			txtMethod.Text = dataGridViewOrders.Rows[e.RowIndex].Cells["methodPay"].Value.ToString();
			bool check = (bool)dataGridViewOrders.Rows[e.RowIndex].Cells["statusPay"].Value;
			if (check)
			{
				txtPayment.Text = "Pay Successful";
			}
			else
			{
				txtPayment.Text = "Not Pay";
			}
			check = (bool)dataGridViewOrders.Rows[e.RowIndex].Cells["statusOrder"].Value;
			if (check)
			{
				txtOrderStatus.Text = "Delivered";
			}
			else
			{
				txtOrderStatus.Text = "Processing";
			}
			if (e.RowIndex < dataGridViewOrders.RowCount - 1)
			{
				dataGridViewOrderDetails(dataGridViewOrders.Rows[e.RowIndex].Cells["id"].Value.ToString());
			}
		}

		private void dataGridViewOrderDetails(String idOrder)
		{
			String query = "select  p.id, p.name,p.price,od.quantity,(p.price * od.quantity) as 'price of product' from order_detail od, order_product op,products p where op.id = od.orderId and p.id = od.productId and op.id =" + idOrder;
			SqlDataAdapter da = new SqlDataAdapter(query, conn);
			conn.Open();
			DataSet ds = new DataSet();
			if (ds != null)
			{
				da.Fill(ds);
				dataGridViewOrderDetail.DataSource = ds.Tables[0];
			}
			query = "select sum(s) as total from (select  (p.price * od.quantity) as s from order_detail od, order_product op,products p where op.id = od.orderId and p.id = od.productId and op.id =" + idOrder + ") as tableSum ";
			SqlCommand cmd = new SqlCommand(query, conn);
			txtTotal.Text = cmd.ExecuteScalar().ToString();
			conn.Close();
		}

		private void btnExport_Click(object sender, EventArgs e)
		{
			if (txtAgent.Text == "" || txtOrderDate.Text == "")
			{
				MessageBox.Show("Make sure that you fill all information");
			}
			else if (txtOrderStatus.Text == "Delivered" && txtPayment.Text == "Pay Successful")
			{
				MessageBox.Show("This order already done");
			}
			else
			{
				conn.Open();
				bool enoughQuantity = true;
				for (int i = 0; i < dataGridViewOrderDetail.Rows.Count - 1; i++)
				{
					String productName = dataGridViewOrderDetail.Rows[i].Cells["name"].Value.ToString();
					int quantity = (int)dataGridViewOrderDetail.Rows[i].Cells["quantity"].Value;

					String checkQuantityQuery = "select quantity from products where name=@productName";
					SqlCommand checkQuantityCmd = new SqlCommand(checkQuantityQuery, conn);
					checkQuantityCmd.Parameters.AddWithValue("@productName", productName);
					int currentQuantity = (int)checkQuantityCmd.ExecuteScalar();

					if (currentQuantity - quantity < 0)
					{
						enoughQuantity = false;
						break;
					}

					String updateQuantityQuery = "update products set quantity=quantity-@quantity where name=@productName";
					SqlCommand updateQuantityCmd = new SqlCommand(updateQuantityQuery, conn);
					updateQuantityCmd.Parameters.AddWithValue("@quantity", quantity);
					updateQuantityCmd.Parameters.AddWithValue("@productName", productName);
					updateQuantityCmd.ExecuteNonQuery();
				}

				if (!enoughQuantity)
				{
					MessageBox.Show("Not enough quantity");
					conn.Close();
					return;
				}

				String orderQuery = "update order_product set statusOrder=1, statusPay=1 where id=@indexOrder";
				SqlCommand orderCmd = new SqlCommand(orderQuery, conn);
				orderCmd.Parameters.AddWithValue("@indexOrder", indexOrder);
				orderCmd.ExecuteNonQuery();

				for (int i = 0; i < dataGridViewOrderDetail.Rows.Count - 1; i++)
				{
					String soldQuery = "insert into sold (productId, quantity) values (@productId, @quantity)";
					SqlCommand soldCmd = new SqlCommand(soldQuery, conn);
					soldCmd.Parameters.AddWithValue("@productId", dataGridViewOrderDetail.Rows[i].Cells["id"].Value);
					soldCmd.Parameters.AddWithValue("@quantity", dataGridViewOrderDetail.Rows[i].Cells["quantity"].Value);
					soldCmd.ExecuteNonQuery();
				}
				conn.Close();

				Exporting exporting = new Exporting(txtAgent.Text, txtPhone.Text, txtAddress.Text, txtOrderDate.Text, txtOrderStatus.Text, txtPayment.Text, txtTotal.Text, txtMethod.Text, dataGridViewOrderDetail);
				exporting.Show();
				dataGridViewOrderLoad(indexAgent);
			}
		}

		private void Export_Load(object sender, EventArgs e)
		{

		}
	}
}
