using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPServer.ServiceReference;

namespace ASPServer.Controllers
{
    public class SellerController : Controller
    {
        static IService iService = new ServiceClient();
        // GET: Seller
        public ActionResult Index()
        {
            // Get all sellers from DB
            List<Seller> sellers = iService.GetAllSellers();

            return View(sellers);
        }

        // GET: Seller/Details/5
        public ActionResult Details(int id)
        {
            //Get single seller from database
            Seller seller = iService. GetSellerById(id);

            //Make single seller available to view
            return View(seller);
        }

        // GET: Seller/Edit/5
        public ActionResult Edit(int id)
        {
            //NOTE: This is for HTTP GET
            //Get seller by id from database
            Seller seller = iService.GetSellerById(id);
            //Return that seller to the view
            return View(seller);
        }

        // POST: Seller/Edit/5
        [HttpPost]
        public ActionResult Edit(Seller seller)
        {
            //NOTE: This is for HTTP post
            //Get the correct seller from db
            Seller dbSeller = iService.GetSellerById(seller.Id);
            //Assign only relevant values since rest are null
            dbSeller.Name = seller.Name;
            dbSeller.Address = seller.Address;
            dbSeller.ZipCode = seller.ZipCode;
            dbSeller.Phone = seller.Phone;
            dbSeller.Mobile = seller.Mobile;
            dbSeller.Email = seller.Email;
            //Update seller via service
            
            iService.UpdateSellerSingle(dbSeller);
            
            return View(seller);
        }
    }
}