using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    /// <summary>
    /// Floor number verbosity
    /// e.g. First - 1
    /// </summary>
    public class FloorVerboseDetail
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        public string VerboseName { get; set; }

        public int FloorNumber{ get; set; }

    }
}
