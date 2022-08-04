namespace Design_Principles_2_Liskov_Substitution
{
    /// <summary>
    /// 正方形类
    /// </summary>
    public class Square : Rectangle
    {
        public override void SetLength(double length)
        {
            base.SetLength(length);
            base.SetWidth(length);
        }

        public override void SetWidth(double length)
        {
            base.SetLength(length);
            base.SetWidth(length);
        }
    }
}