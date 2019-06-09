using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Entities
{
    [Table("Reservation")]
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        //Foreign key for Room
        [Required]
        [Display(Name = "Room_id")]
        public int RoomId { get; set; }

        public Room Room { get; set; }

        //Foreign key for Payment
        [Required]
        [Display(Name = "Payment_id")]
        public string PaymentId { get; set; }

        public Payment Payment { get; set; }
    }
}
