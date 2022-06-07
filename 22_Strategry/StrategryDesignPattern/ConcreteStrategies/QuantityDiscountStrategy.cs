using StrategryDesignPattern.Interfaces;

namespace StrategryDesignPattern.ConcreteStrategies
{
    public class QuantityDiscountStrategy : IDiscountStrategy
    {
        public float DoDiscount(float price, int quantity)
        {
            if (quantity > 10)
            {
                return (float)(price * 0.9) * quantity;
            }
            else
            {
                return price * quantity;
            }
        }
    }
}
