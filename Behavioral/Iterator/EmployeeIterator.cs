namespace Iterator
{
    public class EmployeeIterator
    {
        private readonly List<string> _employees;
        private int _currentIndex = 0;

        public EmployeeIterator(List<string> employees)
        {
            _employees = employees;
        }

        public bool HasNext()
        {
            return _currentIndex < _employees.Count;
        }

        public string Next()
        {
            return _employees[_currentIndex++];
        }
    }
}