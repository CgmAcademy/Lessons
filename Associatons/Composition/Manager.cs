namespace Associatons.Composition
{
    public class Manager
    {
        public Project project;
        public decimal salary;
        public Manager()
        {
            project = new Project();
        } 
        public void IsAGoodManager(bool good)
        {
            if (good)
            {
                salary += 1000M;
            }
        }

    }
}

