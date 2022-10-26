namespace Associatons.Aggregation
{
    public class Employee
    {
        Manager _manager;
        string name;
        public Manager Manager { get; set; }
        public Employee(Manager manager, string Name)
        {
            name = Name;
            _manager = manager;
            _manager.Employee = this;
        }
        public void RemoveManager()
        {
            _manager.Employee = null;
        }
        public void UpdateManager(Manager Manager)
        {
            RemoveManager();
            _manager = Manager;
        }


    }
}

