namespace Associatons.Aggregation
{
    public class Manager
    {

        public string _department;
        public Employee Employee { get; set; }
        public Manager(string Department)
        {
            _department = Department;
        }
    }
}

