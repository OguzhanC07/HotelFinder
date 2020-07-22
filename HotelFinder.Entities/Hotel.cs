using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelFinder.Entities
{
    public class Hotel
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }


        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string City { get; set; }

    }
}
