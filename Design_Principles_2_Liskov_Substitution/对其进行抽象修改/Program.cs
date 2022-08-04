using System;

// namespace Design_Principles_2_Liskov_Substitution.对其进行抽象修改
// {
//     class Program
//     {
//         public static void Main(string[] args)
//         {
//             // 创建一个矩形，长20、宽10，Resize方法只接收Rectangle类，最后得到一个长20、宽21的矩形
//             Rectangle r = new Rectangle();
//             r.SetLength(20);
//             r.SetWidth(10);
//             Resize(r);
//
//             // 创建一个正方形，因为他不是矩形类，不能被操作
//             // 但它和矩形都继承自四边形接口，所以以然可以通过PrintLengthAndWidth来输出自己的长和宽
//             Square s = new Square();
//             s.SetSide(10);
//             PrintLengthAndWidth(s);
//         }
//
//         // 一个简单的方法，传入一个矩形，如果矩形的宽<=长，就进行扩宽的操作，一直到最后宽要更长一些
//         public static void Resize(Rectangle rectangle)
//         {
//             while (rectangle.GetWidth() <= rectangle.GetLength())
//             {
//                 rectangle.SetWidth(rectangle.GetWidth() + 1);
//                 PrintLengthAndWidth(rectangle);
//             }
//         }
//
//         public static void PrintLengthAndWidth(Quadrilateral q)
//         {
//             Console.Write("width:" + q.GetWidth() + "  ");
//             Console.WriteLine("length:" + q.GetLength());
//         }
//     }
// }