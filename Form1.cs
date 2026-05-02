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
        clsPizzaOrder _order;
        int _orderNumber;
        enum Mode { eAddNew, eEdit };
        Mode _Mode;

        public Form1()
        {
            InitializeComponent();

            _Mode = Mode.eAddNew;

        }
        public Form1( int orderId )
        {
            InitializeComponent();
            _orderNumber = orderId;    
            _Mode = Mode.eEdit;
            
        }

        public void UpdatePizzaSize()
        {
            if (rbtnSmall.Checked)
            {
                _order.Size = clsPizzaOrder.smallSize;
            }
            else if (rbtnMedium.Checked)
            {
                _order.Size = clsPizzaOrder.mediumSize;                
            }
            else if (rbtnLarge.Checked)
            {
                _order.Size = clsPizzaOrder.largeSize;
            }

            lblSize.Text = _order.Size;
            UpdateTotalPrice();
        }

        public void UpdateToppings()
        {
            List<string> toppings = new List<string>();

            if (chbExtraCheese.Checked)
                toppings.Add(clsPizzaOrder.ExtraCheese);

            if (chbMashrooms.Checked)
                toppings.Add(clsPizzaOrder.Mushrooms);

            if (chbTomatoes.Checked)
                toppings.Add(clsPizzaOrder.Tomatoes);

            if (chbOlives.Checked)
                toppings.Add(clsPizzaOrder.Olives);

            if (chbOnion.Checked)
                toppings.Add(clsPizzaOrder.Onion);

            if (chbGreenPepper.Checked)
                toppings.Add(clsPizzaOrder.GreenPepper);

            if (toppings.Count == 0)
                _order.Toppings = clsPizzaOrder.NoToppings;
            else
                _order.Toppings = string.Join(", ", toppings);
            
            
            lblToppings.Text = _order.Toppings;
            UpdateTotalPrice();
            
        }

        public void UpdateCrustType()
        {
            if (rbtnThin.Checked)
            {
                _order.CrustType = clsPizzaOrder.thinCrust;
            }
            else if (rbtnThick.Checked)
            {
                _order.CrustType = clsPizzaOrder.thickCrust;
            }
            lblCrustType.Text = _order.CrustType;
            UpdateTotalPrice();
        }

        public void UpdateWhereToEat()
        {
            if (rbtnEatIn.Checked)
                _order.WhereToEat = clsPizzaOrder.toEatIn;

            if (rbtnTakeAway.Checked)
                _order.WhereToEat = clsPizzaOrder.toTakeAway;

            lblWhereToEat.Text = _order.WhereToEat;
        }

        public float GetSelectedCrustPrice()
        {
            return _order.UpdateSelectedCrustPrice();
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
            return _order.UpdateSelectedSizePrice();
        }

        public float CalculateTotalPrice()
        {
            _order.TotalPrice = GetSelectedSizePrice() + CalculateSelectedToppingsPrice()
                    + GetSelectedCrustPrice();

            return _order.TotalPrice;
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
        private void ExistingOrder_PizzaSizeLoad()
        {
            if (_order.Size == clsPizzaOrder.smallSize)
                rbtnSmall.Checked = true;
            else if (_order.Size == clsPizzaOrder.mediumSize)
                rbtnMedium.Checked = true;
            else
                rbtnLarge.Checked = true;
        }
        private void ExistingOrder_CrustTypeLoad()
        {
            if (_order.CrustType == clsPizzaOrder.thinCrust)
                rbtnThin.Checked = true;
            else
                rbtnThick.Checked = true;
        }
        private void ExistingOrder_WhereToEatLoad()
        {
            if (_order.WhereToEat == clsPizzaOrder.toEatIn)
                rbtnEatIn.Checked = true;
            else
                rbtnTakeAway.Checked = true;
        }
        private void ExistingOrder_ToppingsLoad()
        {
            if (_order.Toppings == clsPizzaOrder.NoToppings)
                return;

            string[] toppingsFromDB = _order.Toppings.Split(',').Select(t => t.Trim()).ToArray();
            
            Dictionary<string, CheckBox> checkedToppinsMap = new Dictionary<string, CheckBox>()
            {
                { clsPizzaOrder.ExtraCheese, chbExtraCheese },
                { clsPizzaOrder.Mushrooms, chbMashrooms},
                { clsPizzaOrder.Tomatoes, chbTomatoes },
                { clsPizzaOrder.Onion, chbOnion },
                { clsPizzaOrder.Olives, chbOlives },
                { clsPizzaOrder.GreenPepper, chbGreenPepper }
            };

            foreach(string topp in toppingsFromDB)
            {
                checkedToppinsMap[topp].Checked = true;
            }
        }
        private void ExistingOrder_FormLoad()
        {
            ExistingOrder_PizzaSizeLoad();
            ExistingOrder_CrustTypeLoad();
            ExistingOrder_WhereToEatLoad();
            ExistingOrder_ToppingsLoad();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (_Mode == Mode.eAddNew)
            {
                lblAddEditOrderTitle.Text = "Make a New Order";
                btnEditOrder.Enabled = false;
                _order = new clsPizzaOrder();
                
            }                

            else if (_Mode == Mode.eEdit)
            {
                // Here I linked my current order with the existing one in the database
                 
                _order = clsPizzaOrder.FindPizzaOrder(_orderNumber);
                btnEditOrder.Enabled = true;
                btnOrderPizza.Enabled = false;

                if (_order == null)
                {
                    MessageBox.Show("No Order with Number " + _orderNumber + ", Form will be closed!");
                    this.Close();
                    return;
                }
                lblAddEditOrderTitle.Text = $"Edit Order No {_order.OrderId}";
                _order.OrderId = _orderNumber;
                lblOrderNum.Text = _order.OrderId.ToString();
                ExistingOrder_FormLoad();
            }

            UpdateOrderSummary();
        }
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (_Mode != Mode.eAddNew)
            {
                Console.WriteLine("Non coherency: New Order button must be enabled in Add mode only");
                btnOrderPizza.Enabled = false;
                return;
            }

            lblOrderNum.Tag = Convert.ToSingle(_order.AddNewOrder());
            lblOrderNum.Text = lblOrderNum.Tag.ToString();
            MessageBox.Show("Order placed successfully:-)");

            gbSize.Enabled = false;
            gbCrustType.Enabled = false;
            gbWhereToEat.Enabled = false;
            gbToppings.Enabled = false;
            btnOrderPizza.Enabled = false;

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

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (_Mode != Mode.eEdit)
            {
                Console.WriteLine("Non conherency: Edit button must be enabled in edit mode only");
                btnEditOrder.Enabled = false;
                return;
            }

            if (!_order.UpdateExistingOrder())
            {
                MessageBox.Show("Order Not Found");
                this.Close();
                return;
            }

            MessageBox.Show("Order No " + _order.OrderId + " has been successfully modified !");
            this.Close();
        }
    }
}
