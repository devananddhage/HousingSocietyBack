using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Notice
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }

        [Column(TypeName = "date")]
        public DateTime NoticeStartDate { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime NoticeEndDate { get; set; }

        public DbStatusType Status { get; set; }
    }
}
