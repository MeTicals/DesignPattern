using System;
using System.Collections.Generic;

namespace Design_Principles_5_LawOfDemeter_After
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
        
        // 实际问题出在经理的位置，经历应该提供打印名字的方法，因为它跟员工之间有直接的朋友关系
        public void PrintEmployee()
        {
            List<Employee> employees = this.GetEmployees();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetName() + ";");
            }
        }
    }
}