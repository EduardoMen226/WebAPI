using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Entities
{
    public class AppDbContext
    {
        [Key]
        public int AddressID { get; set; }

        [Required]
        [StringLength(60)]
        public string AddressLine1 { get; set; }

        [StringLength(60)]
        public string? AddressLine2 { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        [Required]
        public int StateProvinceID { get; set; }

        [Required]
        [StringLength(15)]
        public string PostalCode { get; set; }

        public string? SpatialLocation { get; set; } 

        [Required]
        public Guid rowguid { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}
