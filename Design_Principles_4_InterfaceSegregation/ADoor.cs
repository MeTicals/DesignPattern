using System;

namespace Design_Principles_4_InterfaceSegregation
{
    public class ADoor : IFanghuoDoor,IFangshuiDoor
    {
        public void Fanghuo()
        {
            Console.WriteLine("此门可以防火");
        }

        public void Fangshui()
        {
            Console.WriteLine("此门可以防水");
        }
    }
}