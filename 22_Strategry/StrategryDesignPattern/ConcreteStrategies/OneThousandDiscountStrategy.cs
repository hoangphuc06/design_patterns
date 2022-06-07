using StrategryDesignPattern.Interfaces;

namespace StrategryDesignPattern.ConcreteStrategies
{
    internal class OneThousandDiscountStrategy : IDiscountStrategy
    {
        public float DoDiscount(float price, int quantity)
        {
            if (price < 100000 && quantity <= 5)
            {
                return 1000 * quantity;
            }
            else
            {
                return (float)(price * quantity * 0.95);
            }
        }
    }
}
