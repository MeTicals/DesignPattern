namespace Factory_Cofe_SimpleFactory
{
    public class CoffeeStore
    {
        public Coffee OrderCoffee(string type)
        {
            SimpleCoffeeFactory factory = new SimpleCoffeeFactory();

            Coffee coffee = factory.CreateCoffee(type);
            
            coffee.AddMilk();
            coffee.AddSugar();

            return coffee;
        }
    }
}