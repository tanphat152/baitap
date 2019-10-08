namespace test_template.Models.entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Tên tài khoản ")]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Mật khẩu ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [Display(Name = "Họ tên ")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [Column(TypeName = "date")]
        [Display(Name = "Ngày sinh ")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Giới tính")]
        public string Sex { get; set; }

        [Display(Name = "SĐT")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email ")]
        public string Email { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        public string Permission { get; set; }

        public string Active { get; set; }
    }
}
