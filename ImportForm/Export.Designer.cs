namespace ImportForm
{
    partial class Export
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtMethod = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnExport = new System.Windows.Forms.Button();
			this.txtPayment = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtOrderStatus = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtOrderDate = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAgent = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewAgent = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dataGridViewOrderDetail = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgent)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.groupBox4);
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(1620, 1001);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Export Section";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtMethod);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.btnExport);
			this.groupBox3.Controls.Add(this.txtPayment);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.txtTotal);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.txtOrderStatus);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.txtOrderDate);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.dataGridViewOrders);
			this.groupBox3.Location = new System.Drawing.Point(820, 32);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox3.Size = new System.Drawing.Size(1223, 270);
			this.groupBox3.TabIndex = 18;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Order Information";
			// 
			// txtMethod
			// 
			this.txtMethod.Location = new System.Drawing.Point(85, 219);
			this.txtMethod.Margin = new System.Windows.Forms.Padding(4);
			this.txtMethod.Name = "txtMethod";
			this.txtMethod.ReadOnly = true;
			this.txtMethod.Size = new System.Drawing.Size(125, 22);
			this.txtMethod.TabIndex = 7;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(8, 223);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(52, 16);
			this.label12.TabIndex = 22;
			this.label12.Text = "Method";
			// 
			// btnExport
			// 
			this.btnExport.Location = new System.Drawing.Point(220, 219);
			this.btnExport.Margin = new System.Windows.Forms.Padding(4);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(73, 28);
			this.btnExport.TabIndex = 8;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
			// 
			// txtPayment
			// 
			this.txtPayment.Location = new System.Drawing.Point(85, 132);
			this.txtPayment.Margin = new System.Windows.Forms.Padding(4);
			this.txtPayment.Name = "txtPayment";
			this.txtPayment.ReadOnly = true;
			this.txtPayment.Size = new System.Drawing.Size(179, 22);
			this.txtPayment.TabIndex = 5;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(8, 135);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 16);
			this.label11.TabIndex = 20;
			this.label11.Text = "Payment";
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(85, 174);
			this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(179, 22);
			this.txtTotal.TabIndex = 6;
			this.txtTotal.Text = "0";
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(17, 177);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 16);
			this.label10.TabIndex = 18;
			this.label10.Text = "Total";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(19, 46);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 16);
			this.label9.TabIndex = 17;
			this.label9.Text = "Date";
			// 
			// txtOrderStatus
			// 
			this.txtOrderStatus.Location = new System.Drawing.Point(85, 89);
			this.txtOrderStatus.Margin = new System.Windows.Forms.Padding(4);
			this.txtOrderStatus.Name = "txtOrderStatus";
			this.txtOrderStatus.ReadOnly = true;
			this.txtOrderStatus.Size = new System.Drawing.Size(179, 22);
			this.txtOrderStatus.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 91);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 16);
			this.label7.TabIndex = 15;
			this.label7.Text = "Delivery";
			// 
			// txtOrderDate
			// 
			this.txtOrderDate.Location = new System.Drawing.Point(85, 42);
			this.txtOrderDate.Margin = new System.Windows.Forms.Padding(4);
			this.txtOrderDate.Name = "txtOrderDate";
			this.txtOrderDate.Size = new System.Drawing.Size(179, 22);
			this.txtOrderDate.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(303, 4);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "List of Orders";
			// 
			// dataGridViewOrders
			// 
			this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrders.Location = new System.Drawing.Point(307, 42);
			this.dataGridViewOrders.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewOrders.Name = "dataGridViewOrders";
			this.dataGridViewOrders.RowHeadersWidth = 51;
			this.dataGridViewOrders.Size = new System.Drawing.Size(908, 206);
			this.dataGridViewOrders.TabIndex = 9;
			this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtAddress);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtPhone);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.txtAgent);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dataGridViewAgent);
			this.groupBox2.Location = new System.Drawing.Point(20, 23);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(792, 279);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Agent Information";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(308, 0);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 16);
			this.label4.TabIndex = 10;
			this.label4.Text = "List of Agents";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(91, 119);
			this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(179, 22);
			this.txtAddress.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 123);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Address";
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(91, 73);
			this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(179, 22);
			this.txtPhone.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 76);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Phone";
			// 
			// txtAgent
			// 
			this.txtAgent.Location = new System.Drawing.Point(91, 26);
			this.txtAgent.Margin = new System.Windows.Forms.Padding(4);
			this.txtAgent.Name = "txtAgent";
			this.txtAgent.Size = new System.Drawing.Size(179, 22);
			this.txtAgent.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 30);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Agent";
			// 
			// dataGridViewAgent
			// 
			this.dataGridViewAgent.BackgroundColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridViewAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAgent.Location = new System.Drawing.Point(312, 30);
			this.dataGridViewAgent.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewAgent.Name = "dataGridViewAgent";
			this.dataGridViewAgent.RowHeadersWidth = 51;
			this.dataGridViewAgent.Size = new System.Drawing.Size(472, 241);
			this.dataGridViewAgent.TabIndex = 0;
			this.dataGridViewAgent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAgent_CellContentClick);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.dataGridViewOrderDetail);
			this.groupBox4.Location = new System.Drawing.Point(20, 309);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(1970, 587);
			this.groupBox4.TabIndex = 19;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "List of Products";
			// 
			// dataGridViewOrderDetail
			// 
			this.dataGridViewOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrderDetail.Location = new System.Drawing.Point(20, 22);
			this.dataGridViewOrderDetail.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridViewOrderDetail.Name = "dataGridViewOrderDetail";
			this.dataGridViewOrderDetail.RowHeadersWidth = 51;
			this.dataGridViewOrderDetail.Size = new System.Drawing.Size(1943, 558);
			this.dataGridViewOrderDetail.TabIndex = 2;
			// 
			// Export
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1620, 970);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Export";
			this.Text = "Export";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Export_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgent)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetail;
        private System.Windows.Forms.DataGridView dataGridViewAgent;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnExport;
		private System.Windows.Forms.GroupBox groupBox4;
	}
}