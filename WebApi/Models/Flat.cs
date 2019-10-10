using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Flat
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public string Description { get; set; }

        public int FlatNumber { get; set; }

        public Floor Floor { get; set; }
        public UnitPlan UnitPlan { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string ExtensionNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime Possession { get; set; }

        public LivingStatusType LivingStatusType { get; set; }
    }
}
