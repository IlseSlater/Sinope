using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sinope.Controllers
{
    public class ManageIncidentController : Controller
    {
        // GET: ManageIncident
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create_Incident()
        {
            return View();
        }    
    }
}