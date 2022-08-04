using System;
using System.Collections.Generic;

namespace Design_Principles_5_LawOfDemeter_After
{
    /// <summary>
    /// 公司类，他的朋友理应只有经理类，但是它为了打印每个员工的名字，所以还引用了员工类
    /// </summary>
    public class Company
    {
        private Manager manager = new Manager();

        public void PrintEmployee()
        {
            manager.PrintEmployee();
        }
    }
}