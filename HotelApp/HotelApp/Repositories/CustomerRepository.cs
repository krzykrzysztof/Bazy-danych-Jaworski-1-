using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApp.Models;

namespace HotelApp.Repositories
{
    public class CustomerRepository
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>();
        }
    }
}
