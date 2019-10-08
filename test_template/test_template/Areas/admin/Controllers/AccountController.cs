using test_template.Models.function;
using test_template.Models.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace test_template.Areas.admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: admin/Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Account accont)
        {
            if (ModelState.IsValid)
            {
                var dao = new AccountDao();
                int id = dao.insert(accont);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm không thành công");
                }
            }
                
            return View(accont);
        }
    }
}