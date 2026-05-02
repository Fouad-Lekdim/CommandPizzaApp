using PizzaDataAccess___Data_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsPizzaOrder
    {
        public int OrderId { get; set; }
        public string Toppings { get; set; }
        public string Size { get; set; }
        public int SizeId { get; set; }
        public string CrustType { get; set; }
        public int CrustTypeId { get; set; }
        public string WhereToEat { get; set; }
        public float TotalPrice { get; set; }

        public const string smallSize = "Small";
        public const string mediumSize = "Medium";
        public const string largeSize = "Large";

        public const string ExtraCheese = "Extra Cheese";
        public const string Mushrooms = "Mashrooms";
        public const string Tomatoes = "Tomatoes";
        public const string Onion = "Onion";
        public const string Olives = "Olives";
        public const string GreenPepper = "Green Pepper";
        public const string NoToppings = "No Toppings";

        public const string thinCrust = "Thin";
        public const string thickCrust = "Thick";
        public const string toEatIn = "EatIn";
        public const string toTakeAway = "TakeAway";

        public const float _toppingUnitPrice = 2f;

        public static readonly Dictionary<int, string> pizzaSizesMap = new Dictionary<int, string>
        {
            { 1, smallSize},
            { 2, mediumSize },
            { 3, largeSize }
        };

        public static readonly Dictionary<int, string> crustTypesMap = new Dictionary<int, string>
        {
            {1, thinCrust },
            {2, thickCrust },
        };


        public clsPizzaOrder()
        {
            this.OrderId = -1;
            this.Toppings = "";
            this.Size = "";
            this.SizeId = -1;
            this.CrustType = "";
            this.CrustTypeId = -1;
            this.WhereToEat = "";
            this.TotalPrice = 0;
        }

        public clsPizzaOrder(int orderId, int sizeId, int crustId, string toppings, 
                string whereToEat, float totalPrice)
        {
            this.OrderId=orderId;
            this.SizeId=sizeId;
            this.CrustTypeId=crustId;
            this.Toppings=toppings;
            this.WhereToEat=whereToEat;
            this.TotalPrice = totalPrice;

            this.Size = pizzaSizesMap[sizeId];
            this.CrustType = crustTypesMap[crustId];
        }

        public float UpdateSelectedSizePrice()
        {
            float sizePrice = 0f;
            int sizeId = -1;
            if (clsPizzaDataAccess.GetPizzaSizePrice(this.Size, ref sizeId, ref sizePrice))
            {
                this.SizeId = sizeId;
                return sizePrice;
            }
            return 0;
        }

        public float UpdateSelectedCrustPrice()
        {
            float crustPrice = 0f;
            int crustId = -1;
            if (clsPizzaDataAccess.GetCrustTypePrice(this.CrustType, ref crustId, ref crustPrice))
            {
                this.CrustTypeId = crustId;
                return crustPrice;
            }
            return 0;
        }

        public int AddNewOrder()
        {
            return clsPizzaDataAccess.AddNewPizzaOrder(this.SizeId, this.CrustTypeId, this.Toppings,
                this.WhereToEat, this.TotalPrice);
        }

        public bool UpdateExistingOrder()
        {
            return clsPizzaDataAccess.UpdatePizzaOrder(this.OrderId, this.SizeId, this.CrustTypeId,
                this.Toppings, this.WhereToEat, this.TotalPrice);
        }

        public static bool DeleteExistingOrder(int OrderId)
        {
            return clsPizzaDataAccess.DeletePizzaOrder(OrderId);
        }

        public static DataTable GetAllPizzaOrders()
        {
            return clsPizzaDataAccess.GetAllPizzaOrders();
        }

        public static clsPizzaOrder FindPizzaOrder(int pizzaOrder)
        {
            int sizeId = -1, crustTypeId = -1;
            string toppings = "", whereToEat = "";
            float totalPrice = -1f;

            if (clsPizzaDataAccess.GetPizzaOrderById(pizzaOrder, ref sizeId, ref crustTypeId,
                    ref toppings, ref whereToEat, ref totalPrice))
            {
                return new clsPizzaOrder(pizzaOrder, sizeId, crustTypeId, toppings, whereToEat,
                        totalPrice);
            }
            else
            {
                return null;
            }
        }

    }
}
