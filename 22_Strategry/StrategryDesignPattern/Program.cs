using StrategryDesignPattern.ConcreteStrategies;
using StrategryDesignPattern.Contexts;

var random = new Random();
int technologyProductPrice = random.Next(1, 1000000);
int technologyProductQuantity = random.Next(1, 10);
int furnitureProductPrice = random.Next(1, 500000);
int furnitureProductQuantity = random.Next(1, 20);
int housewareProductPrice = random.Next(1, 100000);
int housewareProductQuantity = random.Next(1, 20);

var oneThounsandStrategy = new OneThousandDiscountStrategy();
TechnologyProduct techonologyProduct = new (oneThounsandStrategy);
techonologyProduct.Price = technologyProductPrice;
techonologyProduct.Quantity = technologyProductQuantity;

var percentDiscountStrategy = new PercentDiscountStrategy();
FurnitureProduct furnitureProduct = new(percentDiscountStrategy);
furnitureProduct.Price = furnitureProductPrice;
furnitureProduct.Quantity = furnitureProductQuantity;

var quantityDiscountStrategy = new QuantityDiscountStrategy();
HousewareProduct housewareProduct = new(quantityDiscountStrategy);
housewareProduct.Price = housewareProductPrice;
housewareProduct.Quantity = housewareProductQuantity;

Console.WriteLine(technologyProductPrice);
Console.WriteLine(technologyProductQuantity);
Console.WriteLine(technologyProductPrice * technologyProductQuantity);
Console.WriteLine(techonologyProduct.CalculatePrice());

Console.WriteLine();

Console.WriteLine(furnitureProductPrice);
Console.WriteLine(furnitureProductQuantity);
Console.WriteLine(furnitureProductPrice * furnitureProductQuantity);
Console.WriteLine(furnitureProduct.CalculatePrice());

Console.WriteLine();

Console.WriteLine(housewareProductPrice);
Console.WriteLine(housewareProductQuantity);
Console.WriteLine(housewareProductPrice * housewareProductQuantity);
Console.WriteLine(housewareProduct.CalculatePrice());

housewareProduct.SetDisCountStrategy(percentDiscountStrategy);

Console.WriteLine();

Console.WriteLine("New price after change discount strategy: {0}", housewareProduct.CalculatePrice());
