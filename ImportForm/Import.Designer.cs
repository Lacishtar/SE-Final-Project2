namespace ImportForm
{
    partial class Import
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnImport = new System.Windows.Forms.Button();
			this.cbProduct = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtQuantity = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtQuan = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.btnImport);
			this.groupBox1.Controls.Add(this.cbProduct);
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.txtQuantity);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(269, 105);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(1123, 582);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Import Section";
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(934, 65);
			this.btnImport.Margin = new System.Windows.Forms.Padding(4);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(120, 35);
			this.btnImport.TabIndex = 2;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// cbProduct
			// 
			this.cbProduct.FormattingEnabled = true;
			this.cbProduct.Location = new System.Drawing.Point(724, 70);
			this.cbProduct.Margin = new System.Windows.Forms.Padding(4);
			this.cbProduct.Name = "cbProduct";
			this.cbProduct.Size = new System.Drawing.Size(160, 24);
			this.cbProduct.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(43, 248);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(1011, 326);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
			// 
			// txtQuantity
			// 
			this.txtQuantity.Location = new System.Drawing.Point(724, 127);
			this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
			this.txtQuantity.Name = "txtQuantity";
			this.txtQuantity.Size = new System.Drawing.Size(160, 22);
			this.txtQuantity.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.txtQuan);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtPrice);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnCreate);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtName);
			this.groupBox2.Location = new System.Drawing.Point(43, 22);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(469, 219);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Create New Product";
			// 
			// txtQuan
			// 
			this.txtQuan.Location = new System.Drawing.Point(139, 163);
			this.txtQuan.Name = "txtQuan";
			this.txtQuan.Size = new System.Drawing.Size(160, 22);
			this.txtQuan.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(54, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Quantity";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(139, 105);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(160, 22);
			this.txtPrice.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 109);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "Price";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(343, 178);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(120, 35);
			this.btnCreate.TabIndex = 9;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(48, 50);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Name";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(139, 49);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(160, 22);
			this.txtName.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(620, 74);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Product";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(620, 135);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Quantity";
			// 
			// Import
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(1713, 815);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Import";
			this.Text = "Import";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Import_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtQuan;
		private System.Windows.Forms.Label label5;
	}
}