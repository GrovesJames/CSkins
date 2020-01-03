using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSkins.Models;
using CSkins.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CSkins.Controllers
{
    public class SkinsController : Controller
    {
        IRepository<Skin> skinRepo;
        public SkinsController(IRepository<Skin> skinsRepo)
        {
            this.skinRepo = skinsRepo;
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
            return RedirectToAction("Index", "Skins");
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
            return RedirectToAction("Index", "Skins");
        }
    }
}