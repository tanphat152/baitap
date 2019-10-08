namespace test_template.Models.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int AccountID { get; set; }

        [Required]
        public string Fullname { get; set; }

        [Required]
        public string Phonenumber { get; set; }

        [Required]
        public string Address { get; set; }

        public string Email { get; set; }

        [Required]
        public string TotalPrice { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
