using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Addr1 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Addr2 { get; set; }

        [Column(TypeName = "nvarchar(6)")]
        public string Pincode { get; set; }

        [Required]
        public City City { get; set; }
    }
}
