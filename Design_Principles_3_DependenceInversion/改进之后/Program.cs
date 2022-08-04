namespace Design_Principles_3_DependenceInversion.Before
{
    public class Program
    {
        public static void Main()
        {
            IHardDisk hardDisk = new XiJieHardDisk();
            ICpu cpu = new IntelCpu();
            IMemory memory = new KingstonMemory();
            
            Computer c = new Computer();
            
            c.SetHardDisk(hardDisk);
            c.SetCpu(cpu);
            c.SetMemory(memory);
            
            c.Run();
        }
    }
}