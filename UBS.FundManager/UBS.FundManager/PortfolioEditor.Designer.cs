namespace UBS.FundManager
{
    partial class PortfolioEditor
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEquityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalStockWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalMarketValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarketValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTolerance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fundToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1477, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fundToolStripMenuItem
            // 
            this.fundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBondToolStripMenuItem,
            this.addEquityToolStripMenuItem});
            this.fundToolStripMenuItem.Name = "fundToolStripMenuItem";
            this.fundToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.fundToolStripMenuItem.Text = "Fund";
            // 
            // addBondToolStripMenuItem
            // 
            this.addBondToolStripMenuItem.Name = "addBondToolStripMenuItem";
            this.addBondToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.addBondToolStripMenuItem.Text = "Add Bond";
            this.addBondToolStripMenuItem.Click += new System.EventHandler(this.addBondToolStripMenuItem_Click);
            // 
            // addEquityToolStripMenuItem
            // 
            this.addEquityToolStripMenuItem.Name = "addEquityToolStripMenuItem";
            this.addEquityToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.addEquityToolStripMenuItem.Text = "Add Equity";
            this.addEquityToolStripMenuItem.Click += new System.EventHandler(this.addEquityToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colName,
            this.colPrice,
            this.colQuantity,
            this.colMarketValue,
            this.colTransactionPercent,
            this.colTransactionCost,
            this.colStockWeight,
            this.colTolerance});
            this.dataGridView1.DataMember = "MyFund";
            this.dataGridView1.DataSource = this.fundManagerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(987, 368);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.TotalNumber,
            this.TotalStockWeight,
            this.TotalMarketValue});
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(1005, 120);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(448, 199);
            this.dataGridView2.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // TotalNumber
            // 
            this.TotalNumber.DataPropertyName = "TotalNumber";
            this.TotalNumber.HeaderText = "Total Number";
            this.TotalNumber.Name = "TotalNumber";
            this.TotalNumber.ReadOnly = true;
            // 
            // TotalStockWeight
            // 
            this.TotalStockWeight.DataPropertyName = "TotalStockWeight";
            this.TotalStockWeight.HeaderText = "Total Stock Weight";
            this.TotalStockWeight.Name = "TotalStockWeight";
            this.TotalStockWeight.ReadOnly = true;
            // 
            // TotalMarketValue
            // 
            this.TotalMarketValue.DataPropertyName = "TotalMarketValue";
            this.TotalMarketValue.HeaderText = "Total Market Value";
            this.TotalMarketValue.Name = "TotalMarketValue";
            this.TotalMarketValue.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "Type";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colMarketValue
            // 
            this.colMarketValue.DataPropertyName = "MarketValue";
            this.colMarketValue.HeaderText = "MarketValue";
            this.colMarketValue.Name = "colMarketValue";
            this.colMarketValue.ReadOnly = true;
            // 
            // colTransactionPercent
            // 
            this.colTransactionPercent.DataPropertyName = "TransactionPercent";
            this.colTransactionPercent.HeaderText = "TransactionPercent";
            this.colTransactionPercent.Name = "colTransactionPercent";
            this.colTransactionPercent.ReadOnly = true;
            this.colTransactionPercent.Visible = false;
            // 
            // colTransactionCost
            // 
            this.colTransactionCost.DataPropertyName = "TransactionCost";
            this.colTransactionCost.HeaderText = "TransactionCost";
            this.colTransactionCost.Name = "colTransactionCost";
            this.colTransactionCost.ReadOnly = true;
            // 
            // colStockWeight
            // 
            this.colStockWeight.DataPropertyName = "StockWeight";
            this.colStockWeight.HeaderText = "StockWeight";
            this.colStockWeight.Name = "colStockWeight";
            this.colStockWeight.ReadOnly = true;
            // 
            // colTolerance
            // 
            this.colTolerance.DataPropertyName = "Tolerance";
            this.colTolerance.HeaderText = "Tolerance";
            this.colTolerance.Name = "colTolerance";
            this.colTolerance.ReadOnly = true;
            this.colTolerance.Visible = false;
            // 
            // fundManagerBindingSource
            // 
            this.fundManagerBindingSource.DataSource = typeof(UBS.FundManager.FundManager);
            // 
            // PortfolioEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 510);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PortfolioEditor";
            this.Text = "PortfolioEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEquityToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fundManagerBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalStockWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalMarketValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarketValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTolerance;
    }
}