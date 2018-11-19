using Bootcamp20.Micro.Common.Interfaces;
using Bootcamp20.Micro.DataAccess.Models;
using Bootcamp20.Micro.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Bootcamp20.Micro.Controllers
{
    public class SuppliersController : Controller //manggil si SupplierService
    {
        private readonly ISupplierService _supplierService; //utk manggil function2 yg ada di ISuppServ

        //konstruktor non parameter less
        public SuppliersController() { }

        //KONSTRUKTOR (nama konstruktor sama dgn nama class)
        public SuppliersController(ISupplierService supplierService)
        {
            this._supplierService = supplierService;
        }

        // GET: Suppliers
        public ActionResult Index()
        {
            return View(_supplierService.Get());
        }

        //Get Supplier-Insert
        public ActionResult Insert()
        {
            return View();
        }

        //Post Supplier-Insert
        [HttpPost]
        public ActionResult Insert(SupplierParam supplierParam)
        {
            if (ModelState.IsValid)
            {
            _supplierService.Insert(supplierParam);
                return RedirectToAction("Index");
            }
            return View(supplierParam);
        }

        //Get Supplier-Update
        public ActionResult Update(int? id)
        {
            return View(new SupplierParam(_supplierService.Get(id)));
        }

        //Post Supplier-Update
        [HttpPost]
        public ActionResult Update(SupplierParam supplierParam)
        {
            if (ModelState.IsValid)
            {
                _supplierService.Update(supplierParam);
                return RedirectToAction("Index");
            }
            return View(supplierParam);
        }

        //Get Supplier-Delete
        //public ActionResult Delete(int? id)
        //{
        //    return View(new SupplierParam(_supplierService.Get(id)));
        //}

        //Post Supplier-Delete
        [HttpPost]
        //[ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult Delete(int? id)
        {
            _supplierService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}