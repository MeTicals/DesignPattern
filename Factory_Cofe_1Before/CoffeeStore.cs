﻿namespace Factory_Cofe_Before
{
    public class CoffeeStore
    {
        public Coffee OrderCoffee(string type)
        {
            Coffee coffee = null;
            if ("American".Equals(type))
            {
                coffee = new AmericanCoffee();
            }
            else if ("Latter".Equals(type))
            {
                coffee = new LatterCoffee();
            }
            if (coffee != null)
            {
                coffee.AddMilk();
                coffee.AddSugar();
            }
            return coffee;
        }
    }
}