
namespace HR
{
    public class EmployeeRepositor : IEmployeeRepository
    {
        private readonly List<Employee> _employees;
        public void AddEmploye(Employee employee)
        {
            _employees.Add(employee);
        }

        public void DeleteEmploye(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmploye()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}