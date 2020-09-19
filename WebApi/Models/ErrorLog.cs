using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ErrorLog
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string Message { get; set; }

        [Required]
        [Column(TypeName = "text")]
        public string StackTrace { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime CreatedOn { get; set; }

    }
}
