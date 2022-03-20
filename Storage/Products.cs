using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Storage
{
    enum Quantity
    {
        db,
        csomag,
        liter,
        kg,
        karton,
        doboz,
        zsugor,
    }
    enum VAT
    {
        [Description("27%")]
        twentySeven,
        [Description("18%")]
        eighteen,
        [Description("5%")]
        five,

    }
    class Products
    {
        int? id;
        int? orderId;
        string productName;
        string productNumber;
        Quantity quantity;
        VAT vat;
        double nettoBuyPrice;
        double bruttoBuyPrice;
        double nettoSellPrice;
        double bruttoSellPrice;
        int stock;
        int minStock;
        int orderDiscount;

        public Products(string productName, string productNumber, Quantity quantity, VAT vat, double nettoBuyPrice, double bruttoBuyPrice, double nettoSellPrice, double bruttoSellPrice, int stock, int minStock)
        {
            ProductName = productName;
            ProductNumber = productNumber;
            Quantity = quantity;
            Vat = vat;
            NettoBuyPrice = nettoBuyPrice;
            BruttoBuyPrice = bruttoBuyPrice;
            NettoSellPrice = nettoSellPrice;
            BruttoSellPrice = bruttoSellPrice;
            Stock = stock;
            MinStock = minStock;
        }

        public Products(int? id, string productName, string productNumber, Quantity quantity, VAT vat, double nettoBuyPrice, double bruttoBuyPrice, double nettoSellPrice, double bruttoSellPrice, int stock, int minStock)
        {
            Id = id;
            ProductName = productName;
            ProductNumber = productNumber;
            Quantity = quantity;
            Vat = vat;
            NettoBuyPrice = nettoBuyPrice;
            BruttoBuyPrice = bruttoBuyPrice;
            NettoSellPrice = nettoSellPrice;
            BruttoSellPrice = bruttoSellPrice;
            Stock = stock;
            MinStock = minStock;
        }
        public Products(int? id, string productName, int? orderId, int orderDiscount, string productNumber, Quantity quantity, VAT vat, double nettoBuyPrice, double bruttoBuyPrice, double nettoSellPrice, double bruttoSellPrice, int stock)
        {
            Id = id;
            OrderId = orderId;
            OrderDiscount = orderDiscount;
            ProductName = productName;
            ProductNumber = productNumber;
            Quantity = quantity;
            Vat = vat;
            NettoBuyPrice = nettoBuyPrice;
            BruttoBuyPrice = bruttoBuyPrice;
            NettoSellPrice = nettoSellPrice;
            BruttoSellPrice = bruttoSellPrice;
            Stock = stock;

        }
        public int? Id
        {
            get => id;
            set
            {
                if (id == null)
                {
                    id = value;
                }
                else
                {
                    throw new InvalidOperationException("Az azonosító beállítható, de nem módosítható!");
                }
            }
        }
        public int? OrderId
        {
            get => orderId;
            set
            {
                if (orderId == null)
                {
                    orderId = value;
                }
                else
                {
                    throw new InvalidOperationException("Az azonosító beállítható, de nem módosítható!");
                }
            }
        }
        public string ProductName
        {
            get => productName;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    productName = value;
                }
                else
                {
                    throw new ArgumentException("A név mező kitöltése kötelező!");
                }
            }
        }
        public string ProductNumber
        {
            get => productNumber;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    productNumber = value;
                }
                else
                {
                    throw new ArgumentException("A név mező kitöltése kötelező!");
                }
            }
        }
        public double NettoBuyPrice
        {
            get => nettoBuyPrice;
            set
            {
                if (value >= 0 && value <= 10000000)
                {
                    nettoBuyPrice = value;
                }
                else
                {
                    throw new ArgumentException("A nettó beszerzési ár nem lehet kisebb mint 0 Ft!");
                }
            }
        }
        public double BruttoBuyPrice
        {
            get => bruttoBuyPrice;
            set
            {
                if (value >= 0 && value <= 10000000)
                {
                    bruttoBuyPrice = value;
                }
                else
                {
                    throw new ArgumentException("A bruttó beszerzési ár nem lehet kisebb mint 0 Ft!");
                }
            }
        }
        public double NettoSellPrice
        {
            get => nettoSellPrice;
            set
            {
                if (value >= 0 && value <= 10000000)
                {
                    nettoSellPrice = value;
                }
                else
                {
                    throw new ArgumentException("A nettó eladási ár nem lehet kisebb mint 0 Ft!");
                }
            }
        }
        public double BruttoSellPrice
        {
            get => bruttoSellPrice;
            set
            {
                if (value >= 0 && value <= 10000000)
                {
                    bruttoSellPrice = value;
                }
                else
                {
                    throw new ArgumentException("A brutto eladási ár nem lehet kisebb mint 0 Ft!");
                }
            }
        }
        public int Stock
        {
            get => stock;
            set
            {
                if (value >= 0 && value <= 10000)
                {
                    stock = value;
                }
                else
                {
                    throw new ArgumentException("A készlet nem lehet negatív!");
                }
            }
        }
        public int MinStock
        {
            get => minStock;
            set
            {
                if (value >= 0 && value <= 10000)
                {
                    minStock = value;
                }
                else
                {
                    throw new ArgumentException("A minimum készlet nem lehet negatív!");
                }
            }
        }
        public int OrderDiscount
        {
            get => orderDiscount;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    orderDiscount = value;
                }
                else
                {
                    throw new ArgumentException("A kedvezmény mértéke nem lehet nagyobb 100%-nál!");
                }
            }
        }


        internal Quantity Quantity { get => quantity; set => quantity = value; }
        internal VAT Vat { get => vat; set => vat = value; }
    }
}
