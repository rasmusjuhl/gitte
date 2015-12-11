using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPServer.ServiceReference;

namespace ASPServer.Controllers
{
    public class BuyerController : Controller
    {
        static IService iService = new ServiceClient();
        // GET: Buyer
        public ActionResult Index()
        {
            //Get all buyers from database
            List<Buyer> buyers = iService.GetAllBuyers();

            //Make buyers available to view
            return View(buyers);
        }

        // GET: Buyer/Details/5
        public ActionResult Details(int id)
        {
            //Get single buyer from database
            Buyer buyer = iService.GetBuyerById(id);

            //Make single buyer available to view
            return View(buyer);
        }

        // GET: Buyer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buyer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Buyer/Edit/5
        public ActionResult Edit(int id)
        {
            //NOTE: This is for HTTP GET
            //Get buyer by id from database
            Buyer buyer = iService.GetBuyerById(id);
            //Return that buyer to the view
            return View(buyer);
        }

        // POST: Buyer/Edit/5
        [HttpPost]
        public ActionResult Edit(Buyer buyer)
        {
            //NOTE: This is for HTTP post
            //Get the correct buyer from db
            Buyer dbBuyer = iService.GetBuyerById(buyer.Id);
            //Assign only relevant values since rest are null
            dbBuyer.Name = buyer.Name;
            dbBuyer.Address = buyer.Address;
            dbBuyer.ZipCode = buyer.ZipCode;
            dbBuyer.Phone = buyer.Phone;
            dbBuyer.Mobile = buyer.Mobile;
            dbBuyer.Email = buyer.Email;
            //Update buyer via service
            iService.UpdateBuyerSingle(dbBuyer);
            return View(buyer);
        }

        // GET: Buyer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buyer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
