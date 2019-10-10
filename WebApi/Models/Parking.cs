using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Parking
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string LotNumber { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }

        public Flat Flat { get; set; }

    }
}
