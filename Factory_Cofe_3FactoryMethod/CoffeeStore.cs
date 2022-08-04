namespace Factory_Cofe_FactoryMethod
{
    public class CoffeeStore
    {
        private ICoffeeFactory factory;

        public void SetFactory(ICoffeeFactory coffeeFactory)
        {
            this.factory = coffeeFactory;
        }
        
        public Coffee OrderCoffee()
        {
            Coffee coffee = factory.CreateCoffee();
            
            coffee.AddMilk();
            coffee.AddMilk();
            
            return coffee;
        }
    }
}