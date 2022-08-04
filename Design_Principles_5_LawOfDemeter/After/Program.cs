namespace Design_Principles_5_LawOfDemeter_After
{
    // 目标，创建一个公司，就可以直接打印所有的员工。
    internal class Program
    {
        public static void Main(string[] args)
        {
            Company c = new Company();
            c.PrintEmployee();
        }
    }
}