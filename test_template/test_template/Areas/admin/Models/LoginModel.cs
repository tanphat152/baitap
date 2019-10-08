using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_template.Areas.admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời bạn tên đăng nhập")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Mời bạn nhập mật khẩu")]
        public string Passwork { set; get; }
        public bool RememberMe { set; get; }
    }
}