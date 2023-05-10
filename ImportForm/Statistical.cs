using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ImportForm
{
	public partial class Statistical : Form
	{
		SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
		public Statistical()
		{
			InitializeComponent();
		}

		private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
		{
			String query = "";
			if (cbChoice.SelectedIndex == 0)
			{
				chart1.Visible = false;
				query = "select p.id, p.name,p.quantity, sum(id.quantity) as 'number of product import' from import_detail id, products p where id.idProduct = p.id group by  p.id, p.name,p.quantity";
			}
			else if (cbChoice.SelectedIndex == 1)
			{
				chart1.Visible = false;
				query = "select p.id, p.name,p.quantity, sum(s.quantity) as 'number of selling products' from sold s,products p where p.id = s.productId group by p.id, p.name,p.quantity";
			}
			else if (cbChoice.SelectedIndex == 2)
			{
				chart1.Visible = false;
				query = "select p.id, p.name,p.quantity, sum(s.quantity) as 'number of selling products' from sold s,products p where p.id = s.productId group by p.id, p.name,p.quantity having sum(s.quantity) = (select  max(max_sell.sum_quantity) as 'sellest_product' from (select p.id, p.name,p.quantity, sum(s.quantity) as sum_quantity from sold s,products p where p.id = s.productId group by  p.id, p.name,p.quantity) as max_sell)";
			}
			else if(cbChoice.SelectedIndex == 3)
			{
				chart1.Visible = false;
				query = "select p.id, p.name,p.quantity, sum(s.quantity) as 'number of selling products' from sold s,products p where p.id = s.productId group by p.id, p.name,p.quantity having sum(s.quantity) = (select  max(max_sell.sum_quantity) as 'sellest_product' from (select p.id, p.name,p.quantity, sum(s.quantity) as sum_quantity from sold s,products p where p.id = s.productId group by  p.id, p.name,p.quantity) as max_sell)";
			}
			else
			{
				chart1.Visible = true;
				query = "select month(o.orderDate) as 'month', sum(od.quantity * p.price) as 'profit' from order_detail od, order_product o, products p where p.id = od.productId and o.id = od.orderId and o.statusOrder = 1 and o.statusPay = 1 group by p.id, p.name, p.quantity, month(o.orderDate), year(o.orderDate)";
				SqlDataAdapter chart = new SqlDataAdapter(query,conn);
				conn.Open();
				DataSet ds2 = new DataSet();
				chart.Fill(ds2);
				chart1.DataSource = ds2;
				conn.Close();
				chart1.Series["Profit"].XValueMember = "month";
				chart1.Series["Profit"].YValueMembers = "profit";
				chart1.Titles.Add("Monthly Profit");
				return;
			}
			SqlDataAdapter da = new SqlDataAdapter(query, conn);
			conn.Open();
			DataSet ds = new DataSet();
			da.Fill(ds);
			dataGridView1.DataSource = ds.Tables[0];
			conn.Close();
		}

		private void Statistical_Load(object sender, EventArgs e)
		{
			chart1.Visible = false;
		}

	}
}
