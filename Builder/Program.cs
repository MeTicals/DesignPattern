// 3.Builder生成器
// 存在一个abstractBuilder文件，一个RomanHouseBuilder文件，和一个GameManager文件
// AbstractBuilder 实际上是提供了创建房子需要的所有方法，并最终返回一个房子
// 而GameManager中提供了一个静态方法用来创建房屋，并利用这些创建房子的方法，我们认为创建房屋的框架是几乎不变的，这个是相对稳定的
// 而这其中传入的Build风格可能经常修改
// 最终效果是如果需要另一种风格的房子，只需要传入new otherHouseBuilder()即可
//---------------------------------Builder生成器模式-------------------------------------
using System;
namespace Creational_Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            House house = GameManager.CreateHouse(new RomanHouseBuilder());
            Console.WriteLine(house.houseString);
        }
    }
}