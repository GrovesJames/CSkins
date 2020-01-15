using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSkins.Models;
using CSkins.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CSkins.Controllers
{
    public class SkinController : Controller
    {
        IRepository<Skin> skinRepo;
        public SkinController(IRepository<Skin> skinRepo)
        {
            this.skinRepo = skinRepo;
        }
        public ViewResult Index()
        {
            var model = skinRepo.GetAll();

            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = skinRepo.GetById(id);
            return View(model);
        }
        [HttpGet]
        public ViewResult AddASkin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Skin skin)
        {
            skinRepo.Create(skin);
            return RedirectToAction("Index", "Skin");
        }
        [HttpGet]
        public ViewResult Delete()
        {
            var model = skinRepo.GetAll();
            return View(model);
        }
        [HttpPost]
        public ActionResult DeleteById(int id)
        {
            var coffee = skinRepo.GetById(id);
            skinRepo.Delete(coffee);
            return RedirectToAction("Index", "Skin");
        }
    }
}