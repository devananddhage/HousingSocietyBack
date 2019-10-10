using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    /// <summary>
    /// define unit plan under society e.g. every unique type of flat in society plan
    /// </summary>
    public class UnitPlan
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; } // flat facing, etc. any oral description related to flat goes here]

        public Society Society { get; set; }

        public DocumentFile Document { get; set; }

        public FloorPlan FloorPlan { get; set; }

        public int MaintenanceArea { get; set; }

        public int CarpetArea { get; set; }

        public UnitType UnitType { get; set; }
    }
}
