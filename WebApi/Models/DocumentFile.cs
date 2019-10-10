using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    /// <summary>
    /// Files details
    /// </summary>
    public class DocumentFile
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        
        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Extension { get; set; }

        public GeneralGroup GeneralGroup { get; set; }
    }
}
