using Iterator;

var employees = new EmployeeCollection();
employees.AddEmployee("Dev Sharma");
employees.AddEmployee("John Doe");
employees.AddEmployee("Jane Smith");

var iterator = employees.CreateIterator();

while(iterator.HasNext())
{
    var employee = iterator.Next();
    Console.WriteLine(employee);
}