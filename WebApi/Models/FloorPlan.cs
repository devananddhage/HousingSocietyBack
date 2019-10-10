using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    /// <summary>
    /// define floor plan under society e.g. Odd, Even, Refuse floor
    /// </summary>
    public class FloorPlan
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        public Society Society { get; set; }

        public DocumentFile Document { get; set; }
    }
}
