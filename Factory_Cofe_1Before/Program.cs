using System;
using System.Diagnostics;

// 咖啡商店类：可以根据咖啡名点咖啡
// 咖啡类：有加糖和加奶的方法和抽象方法获取名字
// 美式咖啡、拿铁咖啡类重写了自己的名字
// 存在的问题：如果需要加一种新的咖啡，就必须修改咖啡商店的代码，违背开闭原则。如果咖啡店开了1000家，意味着需要在1000个不同的地方修改代码
namespace Factory_Cofe_Before
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeStore store = new CoffeeStore();
            store.OrderCoffee("American");
        }
    }
}