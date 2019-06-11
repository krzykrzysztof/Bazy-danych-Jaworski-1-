using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApplication.Entities;

namespace HotelApplication.Models
{
    public class HomeViewModel
    {
        public List<Reservation> Reservations { get; set; }
    }
}
