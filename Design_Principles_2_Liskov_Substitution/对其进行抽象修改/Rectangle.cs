using System;

namespace Design_Principles_2_Liskov_Substitution.对其进行抽象修改
{
    /// <summary>
    /// 矩形
    /// </summary>
    public class Rectangle : Quadrilateral
    {
        private double length;
        private double width;

        public void SetLength(double length)
        {
            this.length = length;
        }

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public double GetLength()
        {
            return length;
        }

        public double GetWidth()
        {
            return width;
        }
    }
}