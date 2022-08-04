// 2.抽象工厂模式
// new的问题：实现依赖，不能应对“具体实例化类型”的变化
// 解决思路：封装变化点，哪里变化才需要封装哪里
// 适用于对象的数量（结构）不变，但对象本身在扩展，它适用于“多系列对象构建”，一定要寻找变化点
//----------------------------------抽象工厂------------------------------------
namespace Creational_AbstractFactory
{
    class Program
    {
        public static void Main()
        {
            GameManager g = new GameManager(new ModernFacilityFactory());
            g.BuildGameFacilities();
            g.Play();

            GameManager g2 = new GameManager(new OldFacilityFactory());
            g2.BuildGameFacilities();
            g2.Play();
        }
    }
}