using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Models
{
    public class DetailsViewModel
    {
        public string PaymentId { get; set; }

        public float Price { get; set; }

        public string Customer { get; set; }

        public int Discount { get; set; }
    }
}
