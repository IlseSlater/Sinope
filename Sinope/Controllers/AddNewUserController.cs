using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sinope.Models;

namespace Sinope.Controllers
{
    public class AddNewUserController : Controller
    {
        // GET: AddNewUser
        public ActionResult Details(string name)
        {

            AddNewUserContext newUser = new AddNewUserContext();
            AddNewUser newU = newUser.IMS_Login.Single(usr => usr.Name == name);
            return View(newU);
        }
    }
}