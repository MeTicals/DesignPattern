namespace Factory_Cofe_FactoryMethod
{
    // 拿铁咖啡工厂
    public class LatterCoffeeFactory :ICoffeeFactory
    {
        public Coffee CreateCoffee()
        {
            return new LatterCoffee();
        }
    }
}