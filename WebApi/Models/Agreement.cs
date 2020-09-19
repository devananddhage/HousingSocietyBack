using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Agreement
    {
        public int Id { get; set; }


        [Required]

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        public DateTime AgreementDate {get;set;}
        public DateTime StartDate { get; set; }
        public int NumberOfMonths { get; set; }
        public int NoticePeriod { get; set; }
        public Flat Flat { get; set; }
        //public Tenant Tenant { get; set; }
        

    }
}
