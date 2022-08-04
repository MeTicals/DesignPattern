namespace Factory_Cofe_AbstractFacttory
{
    // 拿铁咖啡和拿铁甜品工厂
    public class LatterFactory : IAbstractFactory
    {
        public Coffee CreateCoffee()
        {
            return new LatterCoffee();
        }

        public Dessert CreateDessert()
        {
            return new LatterDessert();
        }
    }
}