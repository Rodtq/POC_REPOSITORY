using POC_REPOSITORY.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POC_REPOSITORY.Bussiness;
using POC_REPOSITORY.Data.Repository.Contracts;

namespace POC_REPOSITORY.Controllers
{
    public class RegisterController : Controller
    {
        private IRegisterManager _rm;
        public RegisterController(IRegisterManager rm)
        {
            _rm = rm;
        }

        // GET: Register
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RegisterUser(FormCollection formData)
        {
            UserRegisterViewModel model = new UserRegisterViewModel
            {
                Name = formData.Get("Name")
            };
            _rm.AddUser(model);
            return PartialView("Partials/RegisterUser", model);
        }

        [HttpPost]
        public ActionResult RegisterProfile(FormCollection formData)
        {
            ProfileRegisterViewModel model = new ProfileRegisterViewModel
            {
                Name = formData.Get("Name")
            };
            _rm.AddProfile(model);
            return PartialView("Partials/RegisterProfile", model);
        }

        [HttpPost]
        public ActionResult RegisterRole(FormCollection formData)
        {
            RoleRegisterViewModel model = new RoleRegisterViewModel
            {
                Name = formData.Get("Name")
            };
            _rm.AddRole(model);
            return PartialView("Partials/RegisterRole", model);
        }

    }
}