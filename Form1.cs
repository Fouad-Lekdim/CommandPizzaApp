using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace CommandPizzaApp
{
    public partial class Form1 : Form
    {
        RadioButton _currentCheckedRBtnSize;
        clsPizzaOrder order = new clsPizzaOrder();


        public Form1()
        {
            InitializeComponent();
        }

        public void UpdatePizzaSize()
        {
            if (rbtnSmall.Checked)
            {
                order.Size = "Small";
            }
            else if (rbtnMedium.Checked)
            {
                order.Size = "Medium";                
            }
            else if (rbtnLarge.Checked)
            {
                order.Size = "Large";
            }

            lblSize.Text = order.Size;
            UpdateTotalPrice();
        }

        public void UpdateToppings()
        {
            List<string> toppings = new List<string>();

            if (chbExtraCheese.Checked)
                toppings.Add(clsPizzaOrder._toppings[0]);

            if (chbMashrooms.Checked)
                toppings.Add(clsPizzaOrder._toppings[1]);

            if (chbTomatoes.Checked)
                toppings.Add(clsPizzaOrder._toppings[2]);

            if (chbOlives.Checked)
                toppings.Add(clsPizzaOrder._toppings[3]);

            if (chbOnion.Checked)
                toppings.Add(clsPizzaOrder._toppings[4]);

            if (chbGreenPepper.Checked)
                toppings.Add(clsPizzaOrder._toppings[5]);

            if (toppings.Count == 0)
                order.Toppings = "No Toppings";
            else
                order.Toppings = string.Join(", ", toppings);
            
            
            lblToppings.Text = order.Toppings;
            UpdateTotalPrice();
            
        }

        public void UpdateCrustType()
        {
            if (rbtnThin.Checked)
            {
                order.CrustType = clsPizzaOrder.thinCrust;
            }
            else if (rbtnThick.Checked)
            {
                order.CrustType = clsPizzaOrder.thickCrust;
            }
            lblCrustType.Text = order.CrustType;
            UpdateTotalPrice();
        }

        public void UpdateWhereToEat()
        {
            if (rbtnEatIn.Checked)
                order.WhereToEat = clsPizzaOrder.toEatIn;

            if (rbtnTakeAway.Checked)
                order.WhereToEat = clsPizzaOrder.toTakeAway;

            lblWhereToEat.Text = order.WhereToEat;
        }

        public float GetSelectedCrustPrice()
        {
            return order.UpdateSelectedCrustPrice();
        }

        public float CalculateSelectedToppingsPrice()
        {
            float toppingsPrice = 0f;
            if (chbExtraCheese.Checked)
            {
                toppingsPrice += clsPizzaOrder._toppingUnitPrice;

            }
            if (chbMashrooms.Checked)
            {
                toppingsPrice += clsPizzaOrder._toppingUnitPrice;
            }
            if (chbTomatoes.Checked)
            {
                toppingsPrice += clsPizzaOrder._toppingUnitPrice;
            }
            if (chbOlives.Checked)
            {
                toppingsPrice += clsPizzaOrder._toppingUnitPrice;
            }
            if (chbOnion.Checked)
            {
                toppingsPrice += clsPizzaOrder._toppingUnitPrice;
            }
            if (chbGreenPepper.Checked)
            {
                toppingsPrice += clsPizzaOrder._toppingUnitPrice;
            }
            return toppingsPrice;
        }

        public float GetSelectedSizePrice()
        {
            return order.UpdateSelectedSizePrice();
        }

        public float CalculateTotalPrice()
        {
            order.TotalPrice = GetSelectedSizePrice() + CalculateSelectedToppingsPrice()
                    + GetSelectedCrustPrice();

            return order.TotalPrice;
        }

        public void UpdateTotalPrice()
        {
            lblTotalPrice.Text = CalculateTotalPrice().ToString() + " $";
        }

        public void UpdateOrderSummary()
        {
            UpdatePizzaSize();
            UpdateToppings();
            UpdateCrustType();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            lblOrderNum.Tag = Convert.ToSingle(order.AddNewOrder());
            lblOrderNum.Text = lblOrderNum.Tag.ToString();
            gbSize.Enabled = false;
            gbCrustType.Enabled = false;
            gbWhereToEat.Enabled = false;
            gbToppings.Enabled = false;
            btnOrderPizza.Enabled = false;

            MessageBox.Show("Order placed successfully:-)");

        }

        private void ResetForm()
        {
            // Reset groups
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;

            // Reset Pizza Size
            rbtnSmall.Checked = true;
            rbtnMedium.Checked = false;
            rbtnLarge.Checked = false;

            // Reset Crust type
            rbtnThick.Checked = false;
            rbtnThin.Checked = true;

            // Reset Toppings
            chbExtraCheese.Checked = false;
            chbGreenPepper.Checked = false;
            chbMashrooms.Checked = false;
            chbTomatoes.Checked = false;
            chbOlives.Checked = false;
            chbOnion.Checked = false;

            // Reset Order button
            btnOrderPizza.Enabled = true;

            if (lblOrderNum.Tag != null)
                lblOrderNum.Text = (Convert.ToSingle(lblOrderNum.Tag)+1).ToString();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
            UpdateOrderSummary();
        }

        private void rbSize_checkedChanged(object sender, MouseEventArgs e)
        {
            UpdatePizzaSize();
        }

        private void rbCrustType_checkedChanged(object sender, MouseEventArgs e)
        {
            UpdateCrustType();
        }

        private void chkToppings_ClickChanged(object sender, MouseEventArgs e)
        {
            UpdateToppings();
        }

        private void rbWhereToEat_checkedChanged(object sender, MouseEventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnPersonalSpace_Click(object sender, EventArgs e)
        {
            FrmPersonalSpace personalSpace = new FrmPersonalSpace();
            personalSpace.Show();
        }
    }
}
