using System;

namespace Design_Principles_3_DependenceInversion.Before
{
    public class IntelCpu :ICpu
    {
        public void Run()
        {
            Console.WriteLine("使用Intel处理器");
        }
    }
}