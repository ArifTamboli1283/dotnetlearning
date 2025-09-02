namespace HR
{
    public interface IEmployeeService
    {
        Employee GetEmployee(int id);
        public void AddEmploye(Employee employee);

        IEnumerable<Employee> GetAllEmploye();

        public void DeleteEmploye(int id);

        public void UpdateEmployee(Employee employee); 
        
    }
}