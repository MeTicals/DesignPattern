// ------------------------接口隔离原则------------------------
// 客户端不应该被迫依赖于它不需要的方法；一个类对另一个类的依赖应该建立在最小的接口上
 
namespace Design_Principles_4_InterfaceSegregation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ADoor a = new ADoor();
            BDoor b = new BDoor();
            a.Fanghuo();
            a.Fangshui();
            b.Fanghuo();
        }
    }
}