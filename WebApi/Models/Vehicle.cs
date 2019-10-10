using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(15)")]
        public string VehicleNumber { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }

        public Parking Parking { get; set; }

        public VehicleType VehicleType { get; set; }

        public VehicleStickerType StickerType { get; set; }
    }
}
