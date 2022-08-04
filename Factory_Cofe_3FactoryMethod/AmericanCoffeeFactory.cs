namespace Factory_Cofe_FactoryMethod
{
    // 美式咖啡工厂类，生产美式咖啡
    public class AmericanCoffeeFactory : ICoffeeFactory
    {
        public Coffee CreateCoffee()
        {
            return new AmericanCoffee();
        }
    }
}