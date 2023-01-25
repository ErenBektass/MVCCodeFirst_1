using MVCCodeFirst_1.DesignPatterns.SingletonPattern;
using MVCCodeFirst_1.Models.Context;
using MVCCodeFirst_1.Models.Entities;
using MVCCodeFirst_1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirst_1.Controllers
{
    public class DirectorController : Controller
    {
        MyContext _db;


        public DirectorController()
        {
            _db = DBTool.DBInstance;
        }
        // GET: Director
        public ActionResult ListDirectors()
        {
            DirectorVM dvm = new DirectorVM
            {
                Directors = _db.Directors.ToList()
            };
            return View(dvm);
        }

        public ActionResult AddDirector()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDirector(Director director)
        {
            _db.Directors.Add(director);
            _db.SaveChanges();
            return RedirectToAction("ListDirectors");
        }

        public ActionResult UpdateDirector(int id)
        {
            DirectorVM dvm = new DirectorVM
            {
                Director = _db.Directors.Find(id)
            };
            return View(dvm);
        }

        [HttpPost]
        public ActionResult UpdateDirector(Director director)
        {
            Director guncellenecek = _db.Directors.Find(director.ID);
            guncellenecek.FirstName = director.FirstName;
            guncellenecek.LastName = director.LastName;
            _db.SaveChanges();
            return RedirectToAction("ListDirectors");
        }

        public ActionResult DeleteDirector(int id)
        {
            _db.Directors.Remove(_db.Directors.Find(id));
            _db.SaveChanges();
            return RedirectToAction("ListDirectors");
        }
    }
}