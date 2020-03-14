using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = CVendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}