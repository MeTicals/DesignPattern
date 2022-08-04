using System;

namespace Factory_Cofe_SimpleFactory
{
    public abstract class Coffee
    {
        public abstract string GetName();
        
        public void AddSugar()
        {
            Console.WriteLine("加糖");
        }

        public void AddMilk()
        {
            Console.WriteLine("加奶");
        }
    }
}