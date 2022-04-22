namespace WebApiTest.Services.DataSource;

using Models;

public static class CustomerDataSource
{

    private static List<Customer> _customers = new List<Customer>
    {
        new Customer
        {
            Id = 1,
            Name = "John Doe",
            DateOfBirth = new DateTime(2000,1,1)
        },
        new Customer
        {
            Id = 2,
            Name = "Susan Doe",
            DateOfBirth = new DateTime(1999,12,1)
        },
        new Customer
        {
            Id = 3,
            Name = "David Doe",
            DateOfBirth = new DateTime(1986,1,12)
        }
    };

    public static Customer GetCustomer(int id)
    {
        return _customers.First(x => x.Id == id);
    }

    public static List<Customer> GetCustomers()
    {
        return _customers;
    }

    public static int DeleteCustomer(int id)
    {
        int count = _customers.RemoveAll(x => x.Id == id);

        return count;
    }

    public static void CreateCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public static void UpdateCustomer(Customer customer)
    {
        var existingCustomer = _customers.First(x => x.Id == customer.Id);

        existingCustomer.Name = customer.Name;
        existingCustomer.DateOfBirth = customer.DateOfBirth;
    }
}