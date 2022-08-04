// ------------------------------------ 里氏代换原则 ------------------------------------
// 任何基类可以出现的地方，子类一定可以出现
// 通俗理解：子类应该扩展父类的功能，但不应该改变父类原有的功能，如果每个子类都修改了父类原有的功能，会导致可复用性较差

using System;

//------------------------------- 正方形继承自矩形的一个例子 --------------------------
namespace Design_Principles_2_Liskov_Substitution
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 创建一个矩形，长20、宽10，经过Resize后正常得到一个长20、宽21的矩形
            Rectangle r = new Rectangle();
            r.SetLength(20);
            r.SetWidth(10);
            Resize(r);

            // 创建一个继承自矩形的正方形，长宽相等，但Resize不能正常执行
            // 基类出现的位置，子类却不能正常工作，违反了里氏代换原则
            Square s = new Square();
            s.SetLength(10);
            Resize(s);
        }

        // 一个简单的方法，传入一个矩形，如果矩形的宽<=长，就进行扩宽的操作，一直到最后宽要更长一些
        public static void Resize(Rectangle rectangle)
        {
            while (rectangle.Getwidth() <= rectangle.GetLength())
            {
                rectangle.SetWidth(rectangle.Getwidth() + 1);
                PrintLengthAndWidth(rectangle);
            }
        }
        
        public static void PrintLengthAndWidth(Rectangle r)
        {
            Console.Write("width:" + r.Getwidth() + "  ");
            Console.WriteLine("length:" + r.GetLength());
        }
    }
}