using System;

namespace Design_Principles_2_Liskov_Substitution
{
    /// <summary>
    /// 长方形类
    /// </summary>
    public class Rectangle
    {
        private double length;
        private double width;

        public double GetLength()
        {
            return length;
        }
        
        public virtual void SetLength(double length)
        {
            this.length = length;
        }
        
        public double Getwidth()
        {
            return width;
        }
        
        public virtual void SetWidth(double width)
        {
            this.width = width;
        }
    }
}