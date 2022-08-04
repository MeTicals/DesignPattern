namespace Factory_Cofe_AbstractFacttory
{
    public class CoffeeStore
    {
        private IAbstractFactory factory;

        public void SetFactory(IAbstractFactory coffeeFactory)
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

        public Dessert OrderDessert()
        {
            Dessert dessert = factory.CreateDessert();
            
            dessert.Show();

            return dessert;
        }
    }
}