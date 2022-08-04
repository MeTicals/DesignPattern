using System;

namespace Design_Principles_3_DependenceInversion.Before
{
    public class KingstonMemory : IMemory
    {
        public void Save()
        {
            Console.WriteLine("使用Kingston内存条保存");
        }
    }
}