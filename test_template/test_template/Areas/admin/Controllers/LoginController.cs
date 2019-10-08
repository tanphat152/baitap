using test_template.Models.function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_template.Areas.admin.Models;
using test_template.common;

namespace test_template.Areas.admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new AccountDao();
                int result = dao.login(model.UserName, model.Passwork);
                if (result == 1)
                {
                    var userSession = new AccountLogin();
                    var user = dao.GetbyId(model.UserName);
                    userSession.AccountName = user.Username;
                    userSession.AccountId = user.ID;
                    Session.Add(CommonConstanr.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Account");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại!");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản bị khóa");
                }
                else
                    ModelState.AddModelError("", "Mật khẩu không đúng");
            }
            return View("Index");

        }
    }
}