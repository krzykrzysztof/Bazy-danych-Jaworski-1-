using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApplication.Data;
using HotelApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApplication.Repositories
{
    public class PaymentRepository
    {
        private ApplicationDbContext _applicationDbContext;
        
        public PaymentRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Payment GetPayment(string id)
        {
            try
            {
                var payment = _applicationDbContext.Payments.Include(x => x.Customer).Include(x => x.Relief).FirstOrDefault(x => x.Id == id);
                return payment;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during conntection to database. Table: Reservation. Details: {ex.Message}");
            }
        
        }
    }
}
