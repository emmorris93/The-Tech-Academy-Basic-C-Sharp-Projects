using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            var adminVm = new List<AdminViewModel>();
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var insurees = db.Insurees.Where(x => x.Quote > 0).ToList();
                
                foreach(var insuree in insurees)
                {
                    var thisAdminVm = new AdminViewModel
                    {
                        Quote = insuree.Quote,
                        FirstName = insuree.FirstName,
                        Lastname = insuree.LastName,
                        EmailAddress = insuree.EmailAddress
                    };
                    adminVm.Add(thisAdminVm);
                }
            }
            return View(adminVm);
        }
    }
}