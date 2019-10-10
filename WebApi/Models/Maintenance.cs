using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Maintenance
    {
        public int Id { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime PaidOn { get; set; }

        public MaintenancePaidStatusType Status { get; set; }

        public Flat Flat { get; set; }
    }
}
