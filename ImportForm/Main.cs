using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            import.MdiParent = this;
            import.Text = "Import";
            import.Dock = DockStyle.Fill;
            import.Show();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.MdiParent = this;
            export.Text = "Export";
            export.Dock = DockStyle.Fill;
            export.Show();
        }

        private void statisticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistical statistical = new Statistical();
            statistical.MdiParent = this;
            statistical.Text = "Statistical";
            statistical.Dock = DockStyle.Fill;
            statistical.Show();
        }

		private void Main_Load(object sender, EventArgs e)
		{

		}
	}
}
