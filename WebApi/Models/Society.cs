using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Society
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string ShortName { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string RegistrationNumber { get; set; }

        public Address Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime EstablishedOn { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Developer { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ImagePath { get; set; }
    }
}
