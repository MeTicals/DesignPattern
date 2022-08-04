using System;
using System.Collections.Generic;

namespace Design_Principles_5_LawOfDemeter_Before
{
    /// <summary>
    /// 部门经理类（他是员工类的朋友，因为他们有直接引用关系）
    /// </summary>
    public class Manager
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                Employee employee = new Employee();
                // 雇员姓名
                employee.SetName("员工" + i);
                employees.Add(employee);
            }

            return employees;
        }
    }
}