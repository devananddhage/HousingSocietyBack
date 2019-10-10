using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class City
    {
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }

        public State State { get; set; }
    }
}
