namespace Design_Principles_5_LawOfDemeter_Before
{
    /// <summary>
    /// 员工类
    /// </summary>
    public class Employee
    {
        private string name;

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}