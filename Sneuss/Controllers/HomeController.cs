using Microsoft.AspNetCore.Mvc;
using Sneuss.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sneuss.Controllers
{
  public class HomeController : Controller
  {
    private readonly SneussContext _db;

    public HomeController(SneussContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      ViewBag.Engineers = _db.Engineers.ToList();
      ViewBag.Machines = _db.Machines.ToList();
      return View();
    }
  }
}