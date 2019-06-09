using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Entities
{  
    [Table("Room")]
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Price")]
        public float Price { get; set; }

        [StringLength(255)]
        [Display(Name = "Desc")]
        public string Desc { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "People_count")]
        public int PeopleCount { get; set; }

        //Foreign key for RoomType
        [Required]
        [Display(Name = "Room_type_id")]
        public int RoomTypeId { get; set; }

        public RoomType RoomType { get; set; }
    }
}
