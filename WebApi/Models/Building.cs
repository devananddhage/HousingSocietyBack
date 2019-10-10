using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Building
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }

        public Society Society { get; set; }

        public ConstructionStatusType ConstructionStatus { get; set; }

        public DocumentFile DocumentFile { get; set; }

        public HouseType HouseType { get; set; }
    }
}
