namespace Iterator
{
    public class EmployeeCollection
    {
        private readonly List<string> _employees = new();

        public void AddEmployee(string employee)
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(string employee)
        {
            _employees.Remove(employee);
        }


        public EmployeeIterator CreateIterator()
        {
            return new EmployeeIterator(_employees);
        }

    }
}
