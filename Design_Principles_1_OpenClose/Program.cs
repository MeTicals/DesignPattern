// ------------------------------开闭原则------------------------------
// 对扩展开放，对修改关闭
// 程序需要扩展的时候，不能修改原有的代码，使程序扩展性好，易于维护和升级
// 要通过接口和抽象类实现，只要抽象的合理，就可以基本保持软件框架的稳定，对细节进行扩展
// --------------------------举例：程序更换皮肤----------------------------
namespace Design_Principles_1_OpenClose
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 实例化一个默认皮肤
            DefaultSkin skin = new DefaultSkin();
            // 向设置皮肤中传入一个默认皮肤
            SkinSetting.SetSkin(skin);
            // 显示皮肤
            SkinSetting.Display();
        }
    }
}