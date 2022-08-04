using System;

namespace Design_Principles_3_DependenceInversion.Before
{
    public class Computer
    {
        private IHardDisk _hardDisk;
        private ICpu _cpu;
        private IMemory _memory;

        public void SetHardDisk(IHardDisk _hardDisk)
        {
            this._hardDisk = _hardDisk;
        }
        
        public void SetCpu(ICpu _cpu)
        {
            this._cpu = _cpu;
        }
        
        public void SetMemory(IMemory _memory)
        {
            this._memory = _memory;
        }

        public IHardDisk GetHardDisk()
        {
            return _hardDisk;
        }
        
        public ICpu GetCpu()
        {
            return _cpu;
        }
        
        public IMemory GetMemory()
        {
            return _memory;
        }

        public void Run()
        {
            Console.WriteLine("运行计算机");
            Console.WriteLine("从硬盘上获取的数据是：" + _hardDisk.Get());
            _cpu.Run();
            _memory.Save();
        }
    }
}