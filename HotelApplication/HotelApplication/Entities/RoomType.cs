using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Entities
{
    [Table("Room_type")]
    public class RoomType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }
    }
}
