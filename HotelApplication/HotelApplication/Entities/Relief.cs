using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApplication.Entities
{
    [Table("Relief")]
    public class Relief
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Discount")]
        public int Discount { get; set; }

        [StringLength(50)]
        [Display(Name = "Code")]
        public string Code { get; set; }
    }
}
