namespace Factory_Cofe_AbstractFacttory
{
    public interface IAbstractFactory
    {
        Coffee CreateCoffee();
        Dessert CreateDessert();
    }
}