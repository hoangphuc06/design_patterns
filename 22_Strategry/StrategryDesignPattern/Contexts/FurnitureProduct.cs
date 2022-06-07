using StrategryDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategryDesignPattern.Contexts
{
    public class FurnitureProduct : IProduct
    {
        private IDiscountStrategy _discountStrategy;
        private float _price;
        private int _quantity;
        public FurnitureProduct(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public float Price { get => _price; set => _price = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }

        public float CalculatePrice()
        {
            return _discountStrategy.DoDiscount(_price, _quantity);
        }

        public void SetDisCountStrategy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }
    }
}
