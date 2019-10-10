using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Floor
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        public FloorVerboseDetail FloorVerboseDetail { get; set; }
        public FloorPlan FloorPlan { get; set; }
        public Building Building { get; set; }
        public Society Society { get; set; }
        
    }
}
