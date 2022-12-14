// 咖啡商店类：可以根据咖啡名点咖啡
// 咖啡类：有加糖和加奶的方法和抽象方法获取名字
// 美式咖啡、拿铁咖啡类重写了自己的名字
// 存在的问题：如果需要加一种新的咖啡，就必须修改咖啡商店的代码，违背开闭原则。如果咖啡店开了1000家，意味着需要在1000个不同的地方修改代码

// 简单工厂的修改方案：其实这部分代码在所有的咖啡店内都需要增加相同的判断
// 那干脆把这部分抽出来变成一个工厂类，让其他所有的咖啡店去调用这个工厂类，具体逻辑也在工厂类中实现
// 简单工厂存在的问题，违背开闭原则

// 工厂方法的修改方案：由于简单工厂在增加新咖啡品种时，还是需要修改原先类中的代码，违背了开闭原则，对这部分进行提取
// 新增抽象工厂接口，并实现美式咖啡工厂和拿铁咖啡工厂，实现咖啡的实例化（对用户隐藏了咖啡实例化具体的方法）
// 商店类中需要传入具体的咖啡工厂类，并通过这个工厂类创建的咖啡交付给用户（SetFactory和OrderCoffee）
// 这样以后如果需要新的摩卡咖啡类，只需要新建一个具体的摩卡咖啡工厂类，之后在咖啡商店类设置工厂即可，原先类的代码都不需要进行修改
// 工厂方法的问题：如果有100种咖啡，然后又有100种蛋糕，100种盘子....意味着有300个具体的工厂，可能会导致类的爆炸

namespace Factory_Cofe_FactoryMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CoffeeStore store = new CoffeeStore();

            ICoffeeFactory factory = new AmericanCoffeeFactory();

            store.SetFactory(factory);
            
            store.OrderCoffee();
        }
    }
}