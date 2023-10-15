using CokeBets.Data;
using CokeBets.Interfaces;
using CokeBets.Models;
namespace CokeBets.Services;
using Microsoft.EntityFrameworkCore;

public class CustomerService : ICustomerService
{
    private readonly SalesDbContext _dbContext;
    private readonly List<Customer> _customers = new List<Customer>
    {
        new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe", CompanyName = "ABC Inc" },
        new Customer { CustomerId = 2, FirstName = "Jane", LastName = "Smith", CompanyName = "XYZ Corp" },
        new Customer { CustomerId = 3, FirstName = "Alice", LastName = "Johnson", CompanyName = "LMN Ltd" },
        new Customer { CustomerId = 4, FirstName = "Bob", LastName = "Williams", CompanyName = "PQR Co" },
        new Customer { CustomerId = 5, FirstName = "Ella", LastName = "Brown", CompanyName = "JKL Enterprises" },
        new Customer { CustomerId = 6, FirstName = "David", LastName = "Lee", CompanyName = "UVW Systems" },
        new Customer { CustomerId = 7, FirstName = "Emily", LastName = "Davis", CompanyName = "RST Solutions" },
        new Customer { CustomerId = 8, FirstName = "Michael", LastName = "Wilson", CompanyName = "GHI Group" },
        new Customer { CustomerId = 9, FirstName = "Olivia", LastName = "Martinez", CompanyName = "DEF Corporation" },
        new Customer { CustomerId = 10, FirstName = "William", LastName = "Jones", CompanyName = "STU Ltd" }
    };


    public CustomerService(SalesDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Customer> GetCustomer(long customerId)
    {
        var customer = _customers.Find(c => c.CustomerId == customerId);
            return customer;
    }

    public async Task<IEnumerable<Customer>> GetAllCustomers()
    {
       List<Customer> customers = _dbContext.Customer
            .Take(10) // Retrieve the first 10 customers
            .ToList();
        
        return customers;
    }
}