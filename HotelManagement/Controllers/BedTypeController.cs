using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelManagement.Data;
using HotelManagement.Helpers;
using HotelManagement.Models;

namespace HotelManagement.Controllers
{
    public class BedTypeController : Controller
    {
        private readonly HotelContext _context;

        public BedTypeController()
        {

            _context = new HotelContext();
        }

        // GET: Room
        public ActionResult Index()
        {
            var list = _context.bedTypes.OrderByDescending(p => p.Id).ToList();
            return View(list);

        }

        public ActionResult Create()
        {
            ViewBag.BedTypes = _context.bedTypes.ToList();


            return View();
        }

        [HttpPost]
        public ActionResult Create(BedType bedType)
        {
            

            if (ModelState.IsValid)
            {

                


                _context.bedTypes.Add(bedType);
                _context.SaveChanges();

                return RedirectToAction("index");
            }

            return View(bedType);
        }

        public ActionResult Edit(int Id)
        {
            BedType bedtype = _context.bedTypes.Find(Id);

            if (bedtype == null)
            {

                return HttpNotFound();
            }

            ViewBag.BedTypes = _context.bedTypes.ToList();

            return View(bedtype);
        }

        [HttpPost]
        public ActionResult Edit(BedType bedType)
        {
            

            if (ModelState.IsValid)
            {

               


                _context.Entry(bedType).State = System.Data.Entity.EntityState.Modified;

                _context.SaveChanges();

                return RedirectToAction("index");
            }


            ViewBag.BedTypes = _context.bedTypes.ToList();


            return View(bedType);
        }

        public ActionResult Delete(int Id)
        {
            BedType bedType = _context.bedTypes.Find(Id);

            if (bedType == null)
            {

                return HttpNotFound();
            }

            
            _context.bedTypes.Remove(bedType);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}