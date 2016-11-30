using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UBS.FundManager
{
    public partial class PortfolioEditor : Form
    {
        IManager manager;
        public PortfolioEditor()
        {
            InitializeComponent();
            manager = new FundManager();
        }

        private void addBondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddFund fund = new AddFund())
            {
                if (fund.ShowDialog() == DialogResult.OK)
                    manager.AddFund(StockType.Bond, fund.Quantity, fund.Price);
            }
            LoadMyFunds();
        }

        private void LoadMyFunds()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;

            dataGridView1.DataSource = manager.GetAllMyFunds();
            dataGridView2.DataSource = manager.GetFundSummary();
        }

        private void addEquityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddFund fund = new AddFund())
            {
                if (fund.ShowDialog() == DialogResult.OK)
                    manager.AddFund(StockType.Equity, fund.Quantity, fund.Price);
            }
            LoadMyFunds();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var tolerance = double.Parse(row.Cells["colTolerance"].Value.ToString());
                var marketvalue = double.Parse(row.Cells["colMarketValue"].Value.ToString());
                var transactionCost = double.Parse(row.Cells["colTransactionCost"].Value.ToString());

                if (marketvalue <= 0 || transactionCost > tolerance)
                { row.Cells["colName"].Style.ForeColor = Color.Red; }

            }
        }
    }
}
