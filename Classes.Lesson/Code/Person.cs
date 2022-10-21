namespace Classes.Lesson.Code
{
    public class Person
    {
        public string _name;
        public string _cf;

        public Person(string Name, string CF)
        {
            _name = Name;
            _cf = CF;
        }
    }
    public class Employee
    {
        public Manager _manager;  

        public Employee(string Name , Manager manager)
        {

        } 

        public void DettachManager(Employee employee)
        {
            _manager.DettachEmployee(this);
        }
    }
}
