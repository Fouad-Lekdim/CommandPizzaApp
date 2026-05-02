using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommandPizzaApp
{
    public partial class FrmPersonalSpace : Form
    {
        string _tbSearchOrderPlaceHolder = "Search order";
        BindingSource _bs = new BindingSource();
        public FrmPersonalSpace()
        {
            InitializeComponent();
        }

        public void _RefreshCompleteOrdersList()
        {
            dgvPizzaOrders.DataSource = clsPizzaOrder.GetAllPizzaOrders();
        }

        private void FrmPersonalSpace_Load(object sender, EventArgs e)
        {
            _RefreshCompleteOrdersList();
        }

        private void tbSearchOrder_Enter(object sender, EventArgs e)
        {
            if (tbSearchOrder.Text == _tbSearchOrderPlaceHolder)
            {
                tbSearchOrder.Text = "";
                tbSearchOrder.ForeColor = Color.Black;
            }
        }

        private void tbSearchOrder_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchOrder.Text))
            {
                tbSearchOrder.Text = _tbSearchOrderPlaceHolder;
                tbSearchOrder.ForeColor = Color.Gray;
                _RefreshCompleteOrdersList();
            }
        }

        private void tbSearchOrder_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchOrder.Text))
            {
                _RefreshCompleteOrdersList();
                return;
            }

            if (!int.TryParse(tbSearchOrder.Text, out int orderId)){
                dgvPizzaOrders.DataSource = null;
                return;
            }

            DataTable dtAllOrders = clsPizzaOrder.GetAllPizzaOrders();
            DataTable dtFilteredOrders = dtAllOrders.Clone();

            foreach (DataRow order in dtAllOrders.Rows)
            {
                if (order["OrderNumber"].ToString().StartsWith(tbSearchOrder.Text))
                {
                    dtFilteredOrders.ImportRow(order);
                }
            }

            dgvPizzaOrders.DataSource = dtFilteredOrders;
        }

        private void EditOrder_Click(object sender, EventArgs e)
        {
            Form1 editOrderForm = new Form1((int)dgvPizzaOrders.CurrentRow.Cells[0].Value);
            editOrderForm.ShowDialog();
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            int orderID = (int)dgvPizzaOrders.CurrentRow.Cells[0].Value;
            if (MessageBox.Show($"Are you sure you want to delete order No {dgvPizzaOrders.CurrentRow.Cells[0].Value}", "Delete Order", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsPizzaOrder.DeleteExistingOrder(orderID))
                {
                    MessageBox.Show("Order No " + orderID + " Successfully Deleted :-)");
                    return;
                }

                MessageBox.Show("Problem occured: Order couldn't be deleted :-(");
            }
        }

        private void dgvPizzaOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvPizzaOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
