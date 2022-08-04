using System;

namespace Design_Principles_3_DependenceInversion.Before
{
    public class XiJieHardDisk : IHardDisk
    {
        public void Save(string data)
        {
            Console.WriteLine("使用希捷硬盘存储 " + data + "数据");
        }

        public string Get()
        {
            Console.WriteLine("使用希捷数据读取数据");
            return "细节硬盘数据";
        }

    }
}