namespace StrategryDesignPattern.Interfaces
{
    public interface IDiscountStrategy
    {
        public float DoDiscount(float price, int quantity);
    }
}
