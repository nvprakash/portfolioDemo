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
    public partial class AddFund : Form
    {
        public double Quantity;
        public double Price;

        public AddFund()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPrice.Text, out Price) && double.TryParse(txtQuantity.Text, out Quantity))
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Invalid input");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
