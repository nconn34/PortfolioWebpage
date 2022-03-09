using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Controllers
{
  public class PortfolioController : Controller
  {
    private readonly PortfolioContext _db;

    public PortfolioController(PortfolioContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Skills> model = _db.portfolio.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Skills skill)
    {
      _db.portfolio.Add(skill);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      Skills thisPortfolio = _db.portfolio.FirstOrDefault(portfolio => portfolio.SkillsId == id);
      return View(thisPortfolio);
    }

    public ActionResult Edit(int id)
    {
      var thisPortfolio = _db.portfolio.FirstOrDefault(portfolio => portfolio.SkillsId == id);
      return View(thisPortfolio);
    }
     public ActionResult Delete(int id)
    {
      var thisItem = _db.portfolio.FirstOrDefault(item => item.SkillsId == id);
      return View(thisItem);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisSkill = _db.portfolio.FirstOrDefault(item => item.SkillsId == id);
      _db.portfolio.Remove(thisSkill);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Projects()
    {
      return View();
    }
        public ActionResult Work()
    {
      return View();
    }
    
        public ActionResult AboutMe()
    {
      return View();
    }
  }
}