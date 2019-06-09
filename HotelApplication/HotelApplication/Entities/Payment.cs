using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Entities
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        [StringLength(38)]
        public string Id { get; set; }

        [Required]
        public float Price { get; set; }

        //Foreign key for Relief
        [Required]
        [Display(Name = "Relief_Id")]
        public int ReliefId { get; set; }

        public Relief Relief { get; set; }
    }
}
