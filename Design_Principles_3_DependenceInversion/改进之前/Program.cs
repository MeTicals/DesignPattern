// ------------------------------------ 依赖倒置原则 ------------------------------------
// 高层模块不应该依赖低层模块，两者都应该依赖其抽象；抽象不应该依赖细节，细节应该依赖抽象。

// 通俗理解：要对抽象进行编程，不要对实现进行编程，从而降低耦合性

// 依赖：泛指A类需要使用B类的功能，则A类依赖于B类，例如A类调用了B类的静态字段、A类实例化了一个B类。
//      A类是高层模块，B类是低层模块

// 举例：组装电脑时，如果所有的程序都按照特定的模块进行编程，而不依赖抽象，就导致如果想把cpu更换品牌，就需要修改Computer类
// 应该抽象出 CPU、内存等的方法，它们具体是做什么用的，进行抽取。
// namespace Design_Principles_3_DependenceInversion_After
// {
//     internal class Program
//     {
//         public static void Main(string[] args)
//         {
//             // 创建组件
//             XiJieHardDisk hardDisk = new XiJieHardDisk();
//             IntelCpu cpu = new IntelCpu();
//             KingstonMemory memory = new KingstonMemory();
//             
//             // 创建计算机
//             Computer c = new Computer();
//             
//             // 组装计算机
//             c.Cpu = cpu;
//             c.Memory = memory;
//             c.HardDisk = hardDisk;
//             
//             // 运行计算机
//             c.Run();
//         }
//     }
// }