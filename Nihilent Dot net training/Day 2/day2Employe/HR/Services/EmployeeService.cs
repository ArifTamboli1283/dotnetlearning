
namespace HR
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public void AddEmploye(Employee employee)
        {
            _employeeRepository.AddEmploye(employee);
        }

        public void DeleteEmploye(int id)
        {
            _employeeRepository.DeleteEmploye(id);
        }

        public IEnumerable<Employee> GetAllEmploye()
        {
            return _employeeRepository.GetAllEmploye();
        }

        public Employee GetEmployee(int id)
        {
            return _employeeRepository.GetEmployee(id);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }
    }
}