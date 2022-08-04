using System;
using System.Diagnostics;

// 咖啡商店类：可以根据咖啡名点咖啡
// 咖啡类：有加糖和加奶的方法和抽象方法获取名字
// 美式咖啡、拿铁咖啡类重写了自己的名字
// 存在的问题：如果需要加一种新的咖啡，就必须修改咖啡商店的代码，违背开闭原则。如果咖啡店开了1000家，意味着需要在1000个不同的地方修改代码
// 简单工厂的修改方案：其实这部分代码在所有的咖啡店内都需要增加相同的判断
// 那干脆把这部分抽出来变成一个工厂类，让其他所有的咖啡店去调用这个工厂类，具体逻辑也在工厂类中实现
namespace Factory_Cofe_SimpleFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeStore store = new CoffeeStore();
            Coffee coffee = store.OrderCoffee("American");
            Console.WriteLine(coffee.GetName());
        }
    }
}