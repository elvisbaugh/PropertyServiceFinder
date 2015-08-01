using MVCPropertyService.BusinessLayer;
using MVCPropertyService.Models;
using MVCPropertyService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPropertyService.Controllers
{
  public class PropertyLocationController : Controller
  {


    public ActionResult Portland()
    {
      return View();
    }


    public ActionResult StJames()
    {
      return View();
    }


    public ActionResult StAnn()
    {
      return View();
    }


    public ActionResult Manchester()
    {
      return View();
    }


    public ActionResult StMary()
    {
      return View();
    }


    public ActionResult Westmoreland()
    {
      return View();
    }


    public ActionResult Andrew()
    {
      return View();
    }

    public ActionResult StThomas()
    {
      return View();
    }
    public ActionResult Trelawny()
    {
      return View();
    }

    public ActionResult Clarendon()
    {
      return View();
    }

    public ActionResult StCatherine()
    {
      return View();
    }

    public ActionResult StElizabeth()
    {
      return View();
    }



    public ActionResult GetView(string parish, string propertyType)
    {
      Object model = null;

      if (propertyType == "House")
      {
        GalleryBusinessLayer galleryHouseBusinessLayer = new GalleryBusinessLayer();
        IEnumerable<House> house = galleryHouseBusinessLayer.HouseProperties(parish, propertyType);
        model = house;
      }

      if (propertyType == "Land")
      {
        GalleryBusinessLayer galleryLandBusinessLayer = new GalleryBusinessLayer();
        IEnumerable<Land> land = galleryLandBusinessLayer.LandProperties(parish, propertyType);
        model = land;
      }

      return PartialView(propertyType, model);
    }


    public ActionResult HouseGalleryDisplay(int id)
    {
      GalleryDetails galleryDetails = new GalleryDetails();

      GalleryBusinessLayer galleryBusinessLayer = new GalleryBusinessLayer();
      galleryDetails.DisplayHouseGallery = galleryBusinessLayer.HouseGalleries(id);
      galleryDetails.DisplayHouseDetails = galleryBusinessLayer.HouseGalleryDetails(id);

      return View(galleryDetails);
    }

    public ActionResult LandGalleryDisplay(int id)
    {
      GalleryDetails galleryDetails = new GalleryDetails();

      GalleryBusinessLayer galleryBusinessLayer = new GalleryBusinessLayer();
      galleryDetails.DisplayLandGallery = galleryBusinessLayer.LandGalleries(id);
      galleryDetails.DisplayLandDetails = galleryBusinessLayer.LandGalleryDetails(id);
      return View(galleryDetails);
    }



  }
}
