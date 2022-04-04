using CWM_VidlyGyak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity; //!!!!!!
using CWM_VidlyGyak.ViewModels;
using System.Runtime.Caching;

namespace CWM_VidlyGyak.Controllers
{
    public class CustumersController : Controller
    {
        private ApplicationDbContext _context;

        public CustumersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();
            var viewModel = new CustumerFormViewModel()
            {
                MembershipTypes = membershipType
            };
            return View("CustumerForm", viewModel);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Save(Custumer custumer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustumerFormViewModel(custumer)
                {
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("CustumerForm", viewModel);
            };


            if (custumer.Id == 0)
                _context.Custumers.Add(custumer);
            else
            {
                var custumerInDb = _context.Custumers.Single(c => c.Id == custumer.Id);
                //Direkt csak Single. Ha nincs ilyen, dobjon hibát!

                custumerInDb.Name = custumer.Name;
                custumerInDb.Birthdate = custumer.Birthdate;
                custumerInDb.MembershipTypeId = custumer.MembershipTypeId;
                custumerInDb.IsSubscribedToNewsletter = custumer.IsSubscribedToNewsletter;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Custumers");
        }

        //[Route("Custumers/Edit/{id}")]

        public ActionResult Edit(int id)
        {
            var customer = _context.Custumers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustumerFormViewModel(customer)
            {
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("CustumerForm", viewModel);
        }

        // GET: Custumers
        public ActionResult Index()
        {
            return View();
        }

    }
}
