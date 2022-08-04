namespace Factory_Cofe_AbstractFacttory
{
    // 美式咖啡和甜点工厂
    public class AmericanFactory : IAbstractFactory
    {
        public Coffee CreateCoffee()
        {
            return new AmericanCoffee();
        }

        public Dessert CreateDessert()
        {
            return new AmericanDessert();
        }
    }
}