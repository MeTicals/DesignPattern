using System;

namespace Design_Principles_1_OpenClose
{
    public class DefaultSkin : AbstractSkin
    {
        public override void Display()
        {
            Console.WriteLine("默认皮肤");
        }
    }
}