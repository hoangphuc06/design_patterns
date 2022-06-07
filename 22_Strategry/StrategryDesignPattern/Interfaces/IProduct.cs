using StrategryDesignPattern.Interfaces;

namespace StrategryDesignPattern
{
    public interface IProduct
    {
        public void SetDisCountStrategy(IDiscountStrategy discountStrategy);
        public float CalculatePrice();
            
    }
}
