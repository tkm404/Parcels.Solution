using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{

  public class PackageController : Controller
  {
    [HttpGet("/packages")]
    public ActionResult PackageIndex()
    {
      List<Package> allPackages = Package.GetAll();
      return View(allPackages);
    }
    [HttpGet("/packages/new")]
    public ActionResult NewPackagesForm()
    {
      return View();
    }
    [HttpPost("/packages")]
    public ActionResult Create(string packageName)
    {
      Package myPackage = new Package(packageName);
      return RedirectToAction("packageindex");
    }
  }
}