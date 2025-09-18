using CRMEntities;
namespace CRMRepositories;

public interface ICustomerRepository
{
    Customer GetCustomer(string customerId);
    IEnumerable<Customer> GetCustomerList();

    public void AddCustomer(Customer customer);

    public void UpdateCustomer(Customer customer);

    public void DeleteCustomer(Customer customer);
}