using System;

namespace Design_Principles_4_InterfaceSegregation
{
    public class BDoor : IFanghuoDoor
    {
        public void Fanghuo()
        {
            Console.WriteLine("此门只防火");
        }
    }
}