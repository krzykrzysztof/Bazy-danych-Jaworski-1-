using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApplication.Data;
using HotelApplication.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelApplication.Repositories
{
    public class ReservationRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ReservationRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public List<Reservation> GetReservations()
        {
            List<Reservation> reservations = new List<Reservation>();

            try
            {
                reservations = _applicationDbContext.Reservations.Include(x => x.Payment).Include(x => x.Room).Include(x => x.Room.RoomType).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during conntection to database. Table: Reservation. Details: {ex.Message}");
            }

            return reservations;
        }
    }
}
