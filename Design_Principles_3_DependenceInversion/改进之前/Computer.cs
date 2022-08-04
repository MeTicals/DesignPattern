using System;

namespace Design_Principles_3_DependenceInversion_After
{
    /// <summary>
    /// 计算机类
    /// </summary>
    public class Computer
    {
        private XiJieHardDisk hardDisk;
        private IntelCpu cpu;
        private KingstonMemory memory;

        public XiJieHardDisk HardDisk
        {
            get => hardDisk;
            set => hardDisk = value;
        }
        
        public IntelCpu Cpu
        {
            get => cpu;
            set => cpu = value;
        }

        public KingstonMemory Memory
        {
            get => memory;
            set => memory = value;
        }

        public void Run()
        {
            Console.WriteLine("运行计算机");
            Console.WriteLine("从硬盘上获取的数据是：" + hardDisk.Get());
            cpu.Run();
            memory.Save();
        }
    }
}