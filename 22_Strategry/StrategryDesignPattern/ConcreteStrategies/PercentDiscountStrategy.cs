using StrategryDesignPattern.Interfaces;

namespace StrategryDesignPattern.ConcreteStrategies
{
    public class PercentDiscountStrategy : IDiscountStrategy
    {
        public float DoDiscount(float price, int quantity)
        {
            return (float)(price * 0.8) * quantity;
        }
    }
}
