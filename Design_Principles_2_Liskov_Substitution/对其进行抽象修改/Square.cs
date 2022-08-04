using System;

namespace Design_Principles_2_Liskov_Substitution.对其进行抽象修改
{
    /// <summary>
    /// 正方形
    /// </summary>
    public class Square : Quadrilateral
    {
        private double side;

        public double GetSide()
        {
            return side;
        }

        public void SetSide(double side)
        {
            this.side = side;
        }

        public double GetLength()
        {
            return side;
        }

        public double GetWidth()
        {
            return side;
        }
    }
}