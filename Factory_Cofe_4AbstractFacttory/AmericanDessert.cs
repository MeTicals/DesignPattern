using System;

namespace Factory_Cofe_AbstractFacttory
{
    public class AmericanDessert:Dessert
    {
        public override void Show()
        {
            Console.WriteLine("美式甜点");
        }
    }
}