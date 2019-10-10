using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    /// <summary>
    /// Create a group for file documents, or any purpose
    /// e.g Floor Plan, Monthly Meeting October 2019 etc.
    /// Nested example is Festival { Diwali {2019}, Holi{2018, 2019} }
    /// e.g. vehicle docs, events docs, festival docs, billing docs, account docs
    /// society docs {society master plan, floor plan, parking plan, garden plan}
    /// </summary>
    public class GeneralGroup
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }

        public GeneralGroup ParentGeneralGroup { get; set; }
       
        public Society Society { get; set; }

    }
}
