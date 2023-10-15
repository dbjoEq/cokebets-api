using CokeBets.Models;

namespace CokeBets.Interfaces;

public interface ICustomerService
{
    Task<Customer> GetCustomer(long customerId);
    Task<IEnumerable<Customer>> GetAllCustomers();
}